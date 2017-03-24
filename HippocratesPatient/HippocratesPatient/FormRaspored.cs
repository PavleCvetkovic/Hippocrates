using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using MetroFramework;
using MetroFramework.Controls;

namespace Hippocrates
{
    public partial class FormRaspored : MetroForm
    {
        private string conStr =
                "server=139.59.132.29;user=djeki;charset=utf8;database=Hippocrates;port=3306;password=volimdoroteju1;";
        private int smena_lekara; // Local copy
        private string jmbg_lekara; // Local copy
        private string jmbg_pacijenta;

        public FormRaspored(string jmbg_p, string puno_ime_lekara, string jmbglek)
        {
            InitializeComponent();
            this.jmbg_pacijenta = jmbg_p;
            this.jmbg_lekara = jmbglek; // Local copy
            this.WindowState = FormWindowState.Maximized;
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width,
                Screen.PrimaryScreen.WorkingArea.Height);
            this.MinimumSize = new System.Drawing.Size(698, 365);

            metroDateTime1.MinDate = System.DateTime.Today;
            metroDateTime1.Value = System.DateTime.Now; // causes event that calls RefreshControls to initialize the controls
            metroLabelLekarInfo.Text = "Izabrani lekar: " + puno_ime_lekara + " " + jmbglek ;

            // Binding handler to control
            foreach (Control c in pnlPopodne.Controls)
                c.Click += metroButton_Click;
            foreach (Control c in pnlPrepodne.Controls)
                c.Click += metroButton_Click;

        }

        private void RefreshControls(string jmbglek)
        {
            //int to_return = 1; // prva smena inicijalno
            MySqlConnection conn = new MySqlConnection(conStr);
            MySqlDataReader rdr;
            try
            {
                conn.Open();
                string smena = "SELECT SMENA FROM IZABRANI_LEKAR WHERE JMBG = " + jmbglek;
                MySqlCommand cmdSmena = new MySqlCommand(smena, conn);

                smena_lekara = (int)cmdSmena.ExecuteScalar();
                UpdateForm(smena_lekara); // Panel showing

                string command =
                    "SELECT VREME FROM TERMIN WHERE MATBRL LIKE '" + jmbglek + "' AND DATUM = '" + GetDate() /*"2017-03-22"*/ + "' ;";

                MySqlCommand cmd = new MySqlCommand(command, conn);
                rdr = cmd.ExecuteReader();

                foreach (Control c in pnlPopodne.Controls)
                    c.Enabled = true;
                foreach (Control c in pnlPrepodne.Controls)
                    c.Enabled = true;

                while (rdr.Read())
                {
                    int time = rdr.GetInt32(0);
                    //MetroMessageBox.Show(this, "Enter while loop in rdr.Read() " + time.ToString(), "rdr.Read()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (time <= 1330)
                        this.pnlPrepodne.Controls["metroButton" + time.ToString()].Enabled = false;
                    else
                        this.pnlPopodne.Controls["metroButton" + time.ToString()].Enabled = false;
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

        private bool MakeAnApointment(string time, string napomena) // time - metroButton name (730, 745, 800 ...)
        {
            bool success = true;

            MySqlConnection conn = new MySqlConnection(conStr);
            try
            {
                conn.Open();

                string sql = "INSERT INTO TERMIN VALUES ('" + jmbg_lekara + "','" + jmbg_pacijenta + "','" + GetDate() + "','" + Int32.Parse(time) + "','" + napomena + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = false;
            }

            conn.Close();
            return success;
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            //Each date change refreshes controls
            RefreshControls(jmbg_lekara);
        }
        
        private void metroButton_Click(object sender, EventArgs e)
        {
            MetroButton metro_button = (MetroButton)sender;
            MetroMessageBox.Show(this, "Info", "Button " + metro_button.Text + "is clicked", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string napomena = "Treba da dodam formu za upis napomene"; // Add form

            if (MakeAnApointment(metro_button.Text.Replace(":", string.Empty), napomena)) // Replace(string old_string, string new_string) 11:30 -> 1130
            {
                RefreshControls(jmbg_lekara); //Each appointment change refreshed controls
                MetroMessageBox.Show(this, "Info", "Uspešno zakazan termin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MetroMessageBox.Show(this, "Info", "Greška prilikom zakazivanja termina", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
