using MetroFramework;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HippocratesDoctor
{
    public partial class SmenaLekara : MetroFramework.Forms.MetroForm
    {
        private string jmbg_lekara;
        private string datum_od, datum_do;
        private int smena;

        public SmenaLekara(string jmbg_lekara)
        {
            InitializeComponent();
            this.Text = "Smena lekara " + GetDoctorNameAndSurname(jmbg_lekara);
            this.jmbg_lekara = jmbg_lekara;
            metroLabelInfoLekara.Text = jmbg_lekara;
            GetDoctorShift(this.jmbg_lekara);
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

        private void GetDoctorShift(string doctor_id) // Vraca smenu za trenutno sistemsko vreme (u kojoj smeni lekar sada radi)
        {
            //int to_return = 0;
            //string to_return = string.Empty;
            MySqlDataAdapter data_adapter;
            DataSet data_set;
            //string date = System.DateTime.Now.Year + "-" + System.DateTime.Now.Month + "-" + System.DateTime.Now.Day;
            //MessageBox.Show(date);
            MySqlConnection conn = new MySqlConnection(Hippocrates.Data.ConnectionInfo.connection_string_nikola);
            try
            {
                conn.Open();
                string sql_command = "select DATUM_OD, DATUM_DO, SMENA from SMENA where MATBRL = '" + doctor_id + "';";

                data_adapter = new MySqlDataAdapter(sql_command, conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(data_adapter);

                data_set = new DataSet();
                data_adapter.Fill(data_set, "Lekari");
                metroGridSmenaLekara.DataSource = data_set;
                metroGridSmenaLekara.DataMember = "Lekari";
                for (int i = 0; i < metroGridSmenaLekara.ColumnCount; i++)
                    metroGridSmenaLekara.Columns[i].Width = metroGridSmenaLekara.Width / metroGridSmenaLekara.ColumnCount;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Greška prilikom čitanja iz baze " + ex.Message + " (Moguće je da lekaru (za koga se traži smena) nije dodeljena smena u bazi)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            //return to_return;
        }

        private void ReadControls()
        {
            if (metroRadioButtonSmenaPrepodne.Checked)
                this.smena = 1;
            else
                this.smena = 2;

            string temp = metroDateTimeDatumOd.Value.Date.ToString();

            datum_od = ParseYear(temp) + "-" + ParseMonth(temp) + "-" + ParseDay(temp);

            temp = metroDateTimeDatumDo.Value.Date.ToString();

            datum_do = ParseYear(temp) + "-" + ParseMonth(temp) + "-" + ParseDay(temp);
            MessageBox.Show(smena + " " + datum_od + " " + datum_do);

        }

        private bool UpdateDoctorShift(string jmbg_lekara)
        {
            bool success = true;
            MySqlConnection conn = new MySqlConnection(Hippocrates.Data.ConnectionInfo.connection_string_nikola);
            try
            {
                conn.Open();
                string sql = "insert into SMENA values ('" + jmbg_lekara +"', '" + datum_od + "', '" + datum_do + "', " + smena + ");";

                MessageBox.Show(sql);

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

        private string ParseYear(string date)
        {
            string year = string.Empty;
            int occurence = 0, i = 0;
            while (occurence != 2)
            {
                if (date[i] == '.')
                    occurence++;
                i++;
            }
            year += date[i];
            year += date[i + 1];
            year += date[i + 2];
            year += date[i + 3];
            return year;
        }

        private string ParseMonth(string date)
        {
            // dd.MM.yyyy or dd.M.yyyy or d.MM.yyyy or d.M.yyyy
            // 0123456789
            string month = string.Empty;
            int i = 0;
            while (date[i] != '.')
                i++;
            month += date[i + 1];

            if (date[i + 2] != '.')
                month += date[i + 2];

            return month;
        }

        private string ParseDay(string date)
        {
            // dd.MM.yyyy or d.MM.yyyy
            // 0123456789
            string day = string.Empty;
            day += date[0];
            if (date[1] != '.')
                day += date[1];

            return day;
        }

        private void metroButtonDodajSmenu_Click(object sender, EventArgs e)
        {
            ReadControls(); // to local copy 
            if (UpdateDoctorShift(jmbg_lekara))
                MetroMessageBox.Show(this, "Uspešno dodata smena", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MetroMessageBox.Show(this, "Error prilikom update funkcije za smenu", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            GetDoctorShift(jmbg_lekara);
        }


    }
}
