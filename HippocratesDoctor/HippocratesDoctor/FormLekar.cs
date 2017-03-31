using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hippocrates.Controller;
using Hippocrates.View;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using MetroFramework;
using MetroFramework.Controls;
using HippocratesPatient;

namespace HippocratesDoctor
{
    public partial class FormLekar : MetroForm, IView
    {
        private IController _controller;
        private string jmbg_lekara;
        private int smena_lekara;
        public FormLekar(string jmbg_lekara)
        {
            InitializeComponent();
            this.jmbg_lekara = jmbg_lekara;
            this.Text = GetDoctorNameAndSurname(jmbg_lekara);
            metroDateTime1.MinDate = System.DateTime.Today;
            metroDateTime1.Value = System.DateTime.Now; // causes event that calls RefreshControls to initialize the controls
            metroTabGlobal.SelectedIndex = 0; // Show 'Raspored pregleda' first

            foreach (Control c in pnlPopodne.Controls)
            {
                MetroButton mb = c as MetroButton;
                if (mb != null)
                {
                    mb.Click += metroButton_Click;
                    mb.MouseHover += metroButton_MouseHover;
                    mb.MouseLeave += metroButton_MouseLeave;
                    // For color change to be seen
                    //if (mb != null)
                    //    mb.UseVisualStyleBackColor = false;
                }
            }
            foreach (Control c in pnlPrepodne.Controls)
            {
                MetroButton mb = c as MetroButton;
                if (mb != null)
                {
                    mb.Click += metroButton_Click;
                    mb.MouseHover += metroButton_MouseHover;
                    mb.MouseLeave += metroButton_MouseLeave;
                    // For color change to be seen
                    //if (mb != null)
                    //    mb.UseVisualStyleBackColor = false;
                }
            }
        }

        private void metroButton_MouseLeave(object sender, EventArgs e)
        {
            MetroButton metro_button = (MetroButton)sender;
            metroLabelActivePatient.Text = GetPatientData(metro_button);
        }

        private void metroButton_MouseHover(object sender, EventArgs e)
        {
            MetroButton metro_button = (MetroButton)sender;
            metroLabelActivePatient.Text = "enter hover (not implemented)";
        }

        private void metroButton_Click(object sender, EventArgs e)
        {
            // Open 'Informacije o pacijentu tab'
            MetroButton metro_button = (MetroButton)sender;
            metroTabGlobal.SelectedIndex = 2; // Change tab
            
        }

        public void setController(IController controller)
        {
            this._controller = controller;
        }

        private string GetPatientData(MetroButton metro_button)
        {
            return "get patient data (not implemented)";
            //if (metro_button.Enabled) // Free (no patient info)
            //    return "No_data";
            //string to_return = string.Empty;
            //MySqlConnection conn = new MySqlConnection(Hippocrates.Data.ConnectionInfo.connection_string_nikola);
            //try
            //{
            //    MetroMessageBox.Show(this, "Za dugme " + metro_button.Text + " enable = " + metro_button.Enabled, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    conn.Open();
            //    string sql = "select IME, PREZIME, JMBG from PACIJENT where MATBRL = " +
            //        "(select MATBRP from TERMIN where MATBRL LIKE '" + jmbg_lekara + "' AND DATUM = '" + GetDate() + "'" +
            //        "and VREME = '" + metro_button.Text.Replace(":", string.Empty) + "');";

            //    MySqlCommand cmd = new MySqlCommand(sql, conn);
            //    MySqlDataReader rdr = cmd.ExecuteReader();

            //    // rdr[0] = IME, rdr[1] = PREZIME, rdr[2] = JMBG
            //    while (rdr.Read())
            //        to_return = rdr[0].ToString() + " " + rdr[1].ToString() + " " + rdr[2].ToString();

            //    rdr.Close();
            //}
            //catch (Exception ex)
            //{
            //    MetroMessageBox.Show(this, "Greška prilikom čitanja baze " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    to_return = "Greška prilikom čitanja baze";
            //}
            //finally
            //{
            //    conn.Close();
            //    // Database is always closed
            //}

            //return to_return;
        } // Not implemented

        private string GetDoctorNameAndSurname(string jmbg_lekara)
        {
            string to_return = string.Empty;
            MySqlConnection conn = new MySqlConnection(Hippocrates.Data.ConnectionInfo.connection_string_nikola);
            try
            {
                // Open connection
                conn.Open();
                // Copy to local 
                // Perform database operations
                string sql = "select ime, prezime from IZABRANI_LEKAR where jmbg = '" + jmbg_lekara + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                // rdr[0] = IME, rdr[1] = PREZIME
                while (rdr.Read())
                    to_return = rdr[0].ToString() + " " + rdr[1].ToString();

                rdr.Close();

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Greška prilikom čitanja baze " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                to_return = "Error during doctor database reading";
            }
            finally
            {
                conn.Close();
                // Database is always closed
            }
            return to_return;
        }

        private void RefreshControls(string jmbglek)
        {
            //int to_return = 1; // prva smena inicijalno
            MySqlConnection conn = new MySqlConnection(Hippocrates.Data.ConnectionInfo.connection_string_nikola);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                string smena = "select SMENA from SMENA  where MATBRL = '" + jmbglek + "'" +
                    " and '" + GetDate() + "'between DATUM_OD and DATUM_DO; ";
                MySqlCommand cmdSmena = new MySqlCommand(smena, conn);

                //short smena_byte = (short)cmdSmena.ExecuteScalar();
                //smena_lekara = (int)smena_byte;
                smena_lekara = (int)cmdSmena.ExecuteScalar();
                UpdateForm(smena_lekara); // Panel showing

                string command =
                    "SELECT VREME FROM TERMIN WHERE MATBRL LIKE '" + jmbglek + "' AND DATUM = '" + GetDate() /*"2017-03-22"*/ + "' ;";

                MySqlCommand cmd = new MySqlCommand(command, conn);
                rdr = cmd.ExecuteReader();

                foreach (Control c in pnlPopodne.Controls)
                {
                    c.Enabled = true;
                    c.BackColor = Color.LightCyan; // LightCyan = Free

                }
                foreach (Control c in pnlPrepodne.Controls)
                {
                    c.Enabled = true;
                    c.BackColor = Color.LightCyan;  // LightCyan = Free
                }

                while (rdr.Read())
                {
                    int time = rdr.GetInt32(0);
                    //MetroMessageBox.Show(this, "Enter while loop in rdr.Read() " + time.ToString(), "rdr.Read()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (time <= 1330)
                    {
                        this.pnlPrepodne.Controls["metroButton" + time.ToString()].Enabled = false;
                        this.pnlPrepodne.Controls["metroButton" + time.ToString()].BackColor = Color.LightGoldenrodYellow; // NOT Free
                    }
                    else
                    {
                        this.pnlPopodne.Controls["metroButton" + time.ToString()].Enabled = false;
                        this.pnlPrepodne.Controls["metroButton" + time.ToString()].BackColor = Color.LightGoldenrodYellow; // NOT Free
                    }
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void UpdateForm(int smena_lek)
        {
            if (smena_lek == 1) // Promenjen Visible na Enable svojstvo 
            {
                metroLabelSmenaLekara.Text = "Prepodne";
                pnlPrepodne.Enabled = true;
                pnlPopodne.Enabled = false;
                //pnlPopodne.Enabled = false;
            }
            else
            {
                metroLabelSmenaLekara.Text = "Poslepodne";
                pnlPrepodne.Enabled = false;
                pnlPopodne.Enabled = true;
                //pnlPrepodne.Enabled = false;
            }
        }

        private string GetDate()
        {
            return metroDateTime1.Value.Year.ToString() + "-" + metroDateTime1.Value.Month.ToString() + "-" +
                              metroDateTime1.Value.Day.ToString();
        }

        private void metroTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTabControl mtc = sender as MetroFramework.Controls.MetroTabControl;

            //MessageBox.Show("Selected inex changed event" + mtc.SelectedIndex);
            switch (mtc.SelectedIndex)
            {
                case 0: { RefreshControls(jmbg_lekara); break; }
                case 1: { GetAllPatientBasicInfo(); break; }
                //case 2: { GetActivePatientInfo(); break; } // Open FullPatientInfo form
            }
        }

        private void GetAllPatientBasicInfo()
        {
            string sql = "select JMBG, LBO, IME, PREZIME, OPŠTINA from PACIJENT " +
                    "where OPŠTINA = (select OPŠTINA from DOM_ZDRAVLJA " +
                    "where MBR = (select MBRZU from IZABRANI_LEKAR where JMBG = '" + jmbg_lekara + "'))";

            MySqlDataAdapter data_adapter;
            DataSet data_set;
            //string connStr = "server=localhost;user=root;database=world;port=3306;password=******;";
            MySqlConnection conn = new MySqlConnection(Hippocrates.Data.ConnectionInfo.connection_string_nikola);
            try
            {
                data_adapter = new MySqlDataAdapter(sql, conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(data_adapter);

                data_set = new DataSet();
                data_adapter.Fill(data_set, "Pacijenti");
                metroGridPacijenti.DataSource = data_set;
                metroGridPacijenti.DataMember = "Pacijenti";
                for (int i = 0; i < metroGridPacijenti.ColumnCount; i++)
                    metroGridPacijenti.Columns[i].Width = metroGridPacijenti.Width / metroGridPacijenti.ColumnCount;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error during database connection " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void metroGridPacijenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MetroGrid mg = sender as MetroGrid;
            if (mg == null)
                throw new Exception("Error in MetroGrid conversion");
            MetroMessageBox.Show(this, "Za metro grid cell is " + mg.SelectedCells[0].Value.ToString() + " LBO " + mg.SelectedCells[1].Value.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            PacijentForm pf = new PacijentForm(mg.SelectedCells[0].Value.ToString(), mg.SelectedCells[1].Value.ToString()); // jmbg (from MetroGrid), lbo(not needed)
            pf.ShowDialog();
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            RefreshControls(jmbg_lekara);
        }
    }
}
