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
        private string jmbg_lekara, active_patient_jmbg;
        private int smena_lekara;
        private string sql_search;
        public FormLekar(string jmbg_lekara)
        {
            InitializeComponent();
            this.jmbg_lekara = jmbg_lekara;
            this.Text = GetDoctorNameAndSurname(jmbg_lekara);
            metroDateTime1.MinDate = System.DateTime.Today;
            metroDateTime1.Value = System.DateTime.Now; // causes event that calls RefreshControls to initialize the controls
            metroTabGlobal.SelectedIndex = 0; // Show 'Raspored pregleda' first
            metroComboBoxIzborPretrage.SelectedIndex = 1; // LBO default way of search
            metroLabelActivePatient.Text = "Prelaz preko dugmeta za info o terminu";

            //metroButtonPretraziPacijente_Click += metroComboBoxIzborPretrage_SelectedIndexChanged; 
            foreach (Control c in pnlPopodne.Controls)
            {
                MetroButton mb = c as MetroButton;
                if (mb != null)
                {
                    mb.Click += metroButton_Click;
                    mb.MouseHover += metroButton_MouseHover;
                    mb.MouseLeave += metroButton_MouseLeave;
                    //mb.UseStyleColors = true;
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
                    //mb.UseStyleColors = true;
                }
            }
        }

        public void setController(IController controller)
        {
            this._controller = controller;
        }

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

                #region Reset all buttons
                foreach (Control c in pnlPopodne.Controls)
                {
                    MetroButton mb = c as MetroButton;
                    if (mb != null)
                    {
                        mb.Highlight = false;
                        //mb.BackColor = Color.LightCyan; // LightCyan = Free
                    }

                }
                foreach (Control c in pnlPopodne.Controls)
                {
                    MetroButton mb = c as MetroButton;
                    if (mb != null)
                    {
                        mb.Highlight = false;
                        //mb.BackColor = Color.LightCyan; // LightCyan = Free
                    }
                }
                #endregion

                while (rdr.Read())
                {
                    int time = rdr.GetInt32(0);
                    //MetroMessageBox.Show(this, "Enter while loop in rdr.Read() " + time.ToString(), "rdr.Read()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (time <= 1330)
                    {
                        MetroButton mb = this.pnlPrepodne.Controls["metroButton" + time.ToString()] as MetroButton;
                        if (mb != null)
                        {
                            mb.Highlight = true;
                            //mb.BackColor = Color.LightGoldenrodYellow; // NOT Free
                            //this.pnlPrepodne.Controls["metroButton" + time.ToString()].Enabled = false;
                        }
                    }
                    else
                    {
                        MetroButton mb = this.pnlPrepodne.Controls["metroButton" + time.ToString()] as MetroButton;
                        if (mb != null)
                        {
                            mb.Highlight = true;
                            //mb.BackColor = Color.LightGoldenrodYellow; // NOT Free
                            //this.pnlPopodne.Controls["metroButton" + time.ToString()].Enabled = false;
                        }
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

        private string GetDate() // Trebalo bi svuda se iskoristi funkcija GetDateFromControl jer univerzalno radi za svaki MetroDateTimePicker
        {
            return metroDateTime1.Value.Year.ToString() + "-" + metroDateTime1.Value.Month.ToString() + "-" +
                              metroDateTime1.Value.Day.ToString();
        }

        private string GetDateFromControl(MetroDateTime mdt)
        {
            return mdt.Value.Year.ToString() + "-" + mdt.Value.Month.ToString() + "-" +
                              mdt.Value.Day.ToString();
        }
        private string GetPatientJMBG(string vreme)
        {
            string to_return = string.Empty;
            MySqlConnection conn = new MySqlConnection(Hippocrates.Data.ConnectionInfo.connection_string_nikola);
            try
            {
                conn.Open();
                string comm = "select MATBRP from TERMIN where MATBRL = '" + jmbg_lekara + "'" +
                    "and DATUM = '" + GetDate() + "' and VREME = '" + vreme + "';";
                MySqlCommand cmd = new MySqlCommand(comm, conn);
                to_return = cmd.ExecuteScalar().ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error during connection (in GetPatientJMBG())" + ex.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
            return to_return;

        }

        private string GetPatientBasicInfo(string jmbg_pacijenta)
        {
            string to_return = string.Empty;
            MySqlConnection conn = new MySqlConnection(Hippocrates.Data.ConnectionInfo.connection_string_nikola);
            try
            {
                conn.Open();
                string sql = "select JMBG, IME, PREZIME, DATUM_ROĐENJA, LBO from PACIJENT where jmbg = '" + jmbg_pacijenta + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                    to_return = rdr[0].ToString() + " " + rdr[1].ToString() + " " + rdr[2].ToString() + " " + rdr[3].ToString() + " " + rdr[4].ToString();

                rdr.Close();

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Greška prilikom čitanja baze " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                to_return = "Error during patient database reading (in GetPatientBasicInfo(jmbg_pacijenta))";
            }
            finally
            {
                conn.Close();
                // Database is always closed
            }
            return to_return;
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

        private void RefreshTerapijeData(string jmbg_pacijenta)
        {
            MySqlDataAdapter data_adapter;
            DataSet data_set;
            //string connStr = "server=localhost;user=root;database=world;port=3306;password=******;";
            MySqlConnection conn = new MySqlConnection(Hippocrates.Data.ConnectionInfo.connection_string_nikola);
            try
            {
                //label2.Text = "Connecting to MySQL...";

                // Sve terapije nezavisno od izabranog lekara pacijenta
                string sql = "select * from TERAPIJA where MATBRP = '" + jmbg_pacijenta + "'";
                data_adapter = new MySqlDataAdapter(sql, conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(data_adapter);

                data_set = new DataSet();
                data_adapter.Fill(data_set, "Terapija");
                metroGridTerapije.DataSource = data_set;
                metroGridTerapije.DataMember = "Terapija";
                for (int i = 0; i < metroGridTerapije.ColumnCount; i++)
                    metroGridTerapije.Columns[i].Width = metroGridTerapije.Width / metroGridTerapije.ColumnCount;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during connection " + ex.Message.ToString());
            }
        }

        private void RefreshVakcineData(string jmbg_pacijenta)
        {
            MySqlDataAdapter data_adapter;
            DataSet data_set;
            //string connStr = "server=localhost;user=root;database=world;port=3306;password=******;";
            MySqlConnection conn = new MySqlConnection(Hippocrates.Data.ConnectionInfo.connection_string_nikola);
            try
            {
                //label2.Text = "Connecting to MySQL...";

                string sql = "select * from PRIMIO_VAKCINU where JMBGP = '" + jmbg_pacijenta + "'";
                data_adapter = new MySqlDataAdapter(sql, conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(data_adapter);

                data_set = new DataSet();
                data_adapter.Fill(data_set, "Vakcine");
                metroGridVakcine.DataSource = data_set;
                metroGridVakcine.DataMember = "Vakcine";
                for (int i = 0; i < metroGridVakcine.ColumnCount; i++)
                    metroGridVakcine.Columns[i].Width = metroGridVakcine.Width / metroGridVakcine.ColumnCount;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during connection " + ex.Message.ToString());
            }

        }

        private void RefreshDijagnozeData(string jmbg_pacijenta)
        {
            MySqlDataAdapter data_adapter;
            DataSet data_set;
            //string connStr = "server=localhost;user=root;database=world;port=3306;password=******;";
            MySqlConnection conn = new MySqlConnection(Hippocrates.Data.ConnectionInfo.connection_string_nikola);
            try
            {
                //label2.Text = "Connecting to MySQL...";

                string sql = "select * from DIJAGNOSTIFIKOVANO where MATBRP = '" + jmbg_pacijenta + "'";
                data_adapter = new MySqlDataAdapter(sql, conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(data_adapter);

                data_set = new DataSet();
                data_adapter.Fill(data_set, "Dijagnoze");
                metroGridDijagnoze.DataSource = data_set;
                metroGridDijagnoze.DataMember = "Dijagnoze";
                for (int i = 0; i < metroGridDijagnoze.ColumnCount; i++)
                    metroGridDijagnoze.Columns[i].Width = metroGridDijagnoze.Width / metroGridDijagnoze.ColumnCount;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during connection " + ex.Message.ToString());
            }

        }

        private bool ChangePatientRightForAppointment(string jmbg_pacijenta, bool pravo_da_zakaze) 
        {
            bool success = true;
            int pravo = 1;
            if (pravo_da_zakaze)
                pravo = 1;
            else
                pravo = 0;
            MySqlConnection conn = new MySqlConnection(Hippocrates.Data.ConnectionInfo.connection_string_nikola);
            try
            {
                conn.Open();
                string sql = "update PACIJENT set PRAVO_DA_ZAKAŽE = " + pravo + " where JMBG ='" + jmbg_pacijenta + "';";
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

        private void SearchPatients(string sql)
        {
            //Validation Needed
            //Empty current data grid
            EmptyMetroDataGrid(metroGridPretragaPacijenata);

            MySqlDataAdapter data_adapter;
            DataSet data_set;
            //string connStr = "server=localhost;user=root;database=world;port=3306;password=******;";
            MySqlConnection conn = new MySqlConnection(Hippocrates.Data.ConnectionInfo.connection_string_nikola);
            try
            {
                data_adapter = new MySqlDataAdapter(sql, conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(data_adapter);

                data_set = new DataSet();
                data_adapter.Fill(data_set, "Pretraga");
                metroGridPretragaPacijenata.DataSource = data_set;
                metroGridPretragaPacijenata.DataMember = "Pretraga";
                for (int i = 0; i < metroGridPretragaPacijenata.ColumnCount; i++)
                    metroGridPretragaPacijenata.Columns[i].Width = metroGridPretragaPacijenata.Width / metroGridPretragaPacijenata.ColumnCount;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during connection " + ex.Message.ToString());
            }

        }

        private void EmptyMetroDataGrid(MetroGrid mg)
        {
            mg.DataSource = null;
        }

        private void RefreshSQLString()
        {
            switch (metroComboBoxIzborPretrage.SelectedIndex)
            {
                case 0:
                    {
                        this.sql_search = "select JMBG, IME, SREDNJE_SLOVO, PREZIME, DATUM_ROĐENJA, OPŠTINA, LBO"
                            + " from PACIJENT where DATUM_ROĐENJA = '" + GetDateFromControl(metroDateTimeDatumParametar) + "'";

                        //MessageBox.Show("datum rodjenja je:" + GetDateFromControl(metroDateTimeDatumParametar));

                        metroDateTimeDatumParametar.Enabled = true;
                        metroTextBoxUnosParametra.Enabled = false;
                        break;
                    }

                case 1:
                    {
                        this.sql_search = "select JMBG, IME, SREDNJE_SLOVO, PREZIME, DATUM_ROĐENJA, OPŠTINA, LBO"
                            + " from PACIJENT where LBO = '" + metroTextBoxUnosParametra.Text + "'";
                        metroDateTimeDatumParametar.Enabled = false;
                        metroTextBoxUnosParametra.Enabled = true;
                        break;
                    }
                case 2:
                    {
                        this.sql_search = "select JMBG, IME, SREDNJE_SLOVO, PREZIME, DATUM_ROĐENJA, OPŠTINA, LBO"
                            + " from PACIJENT where OPŠTINA = '" + metroTextBoxUnosParametra.Text + "'";
                        metroDateTimeDatumParametar.Enabled = false;
                        metroTextBoxUnosParametra.Enabled = true;
                        break;
                    }
            }
        }

        /////////////

        private void metroTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTabControl mtc = sender as MetroFramework.Controls.MetroTabControl;

            //MessageBox.Show("Selected inex changed event" + mtc.SelectedIndex);
            switch (mtc.SelectedIndex)
            {
                case 0: { RefreshControls(jmbg_lekara); break; }
                case 1: { GetAllPatientBasicInfo(); break; }
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

        private void metroButton_MouseLeave(object sender, EventArgs e)
        {
            MetroButton metro_button = (MetroButton)sender; // Current patient to show
            metroLabelActivePatient.Text = "Prelaz preko dugmeta za kratak info";
            metroLabelActivePatient.BackColor = Color.Aqua;
            metroLabelActivePatient.UseCustomBackColor = true;
        }

        private void metroButton_MouseHover(object sender, EventArgs e)
        {
            MetroButton metro_button = (MetroButton)sender;
            if (metro_button.Highlight == false) // Slobodan termin
            {
                metroLabelActivePatient.Text = "Slobodan termin";
                metroLabelActivePatient.BackColor = Color.Green;
            }
            else
            {
                metroLabelActivePatient.Text = "Zakazan termin (klik na dugme za info o pacijentu)";
                metroLabelActivePatient.BackColor = Color.OrangeRed;
            }
            metroLabelActivePatient.UseCustomBackColor = true;

        }

        private void metroTabPacijentInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTabControl mtc = sender as MetroFramework.Controls.MetroTabControl;
            //MessageBox.Show("Selected inex changed event" + mtc.SelectedIndex);
            switch (mtc.SelectedIndex)
            {
                case 0: { RefreshDijagnozeData(active_patient_jmbg); break; }
                case 1: { RefreshVakcineData(active_patient_jmbg); break; }
                case 2: { RefreshTerapijeData(active_patient_jmbg); break; }
                case 3: { metroLabelOceniPacijentaInfo.Text = GetPatientBasicInfo(active_patient_jmbg); break; }
            }
        }

        private void metroButtonOceniPacijenta_Click(object sender, EventArgs e)
        {
            //MetroMessageBox.Show(this, "Da li ste sigurni da želite da ocenite dolazak pacijenta?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            DialogResult dr = MetroMessageBox.Show(this, "Da li ste sigurni da želite da ocenite dolazak pacijenta?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel)
                return;

            bool dolazak = metroCheckBoxDosaoUTerminu.Checked;
            if (ChangePatientRightForAppointment(active_patient_jmbg, dolazak))
                MetroMessageBox.Show(this, "Uspešno ocenjen dolazak pacijenta", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MetroMessageBox.Show(this, "Greška prilikom ocenjivanja pacijenta", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void metroButtonPretraziPacijente_Click(object sender, EventArgs e)
        {
            //string sql = string.Empty;
            //Validation needed
            RefreshSQLString();
            SearchPatients(this.sql_search);
        }

        private void metroComboBoxIzborPretrage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Validation Needed
            RefreshSQLString();
        }

        private void metroButton_Click(object sender, EventArgs e)
        {
            // Open 'Informacije o pacijentu tab'
            MetroButton metro_button = (MetroButton)sender;
            metroTabGlobal.SelectedIndex = 2; // Change tab
            metroTabPacijentInfo.SelectedIndex = 0; // Informacije o pacijentu -> Dijagnoze
            active_patient_jmbg = GetPatientJMBG(metro_button.Text.Replace(":", string.Empty));
            RefreshDijagnozeData(active_patient_jmbg);
        }

    }
}
