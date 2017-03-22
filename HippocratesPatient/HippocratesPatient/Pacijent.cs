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

namespace HippocratesPatient
{
    public partial class PacijentForm : MetroFramework.Forms.MetroForm//, View.IView
    {
        private string jmbg, lbo, jmbg_lekara;
        private string puno_ime;

        public PacijentForm(string jmbg, string lbo)
        {
            InitializeComponent();
            this.jmbg = jmbg;
            this.lbo = lbo;
            // jmbg_lekara inicijalizovano u funkciji GetNameAndSurname
            metroLabel1.Text = jmbg + " " + lbo;
            //this.Text = GetNameAndSurname(jmbg, lbo);
            puno_ime = this.Text;
        }

        private string GetNameAndSurname(string jmbg, string lbo)
        {
            string to_return = "Not found";
            // Fetch 'Ime' + 'Prezime' from PACIJENT
            string connection = "server=139.59.132.29;user=paja;charset=utf8;database=Hippocrates;port=3306;password=pajapro1234;protocol=TCP";
            //bool success = true;

            MySqlConnection conn = new MySqlConnection(connection);
            try
            {
                // Open connection
                conn.Open();
                // Copy to local 
                // Perform database operations
                string sql = "select ime, prezime, matbrl from PACIJENT where jmbg = '" + jmbg + "' and lbo = '" + lbo + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                // rdr[0] = IME, rdr[1] = PREZIME
                while (rdr.Read())
                {
                    to_return = rdr[0].ToString() + " " + rdr[1].ToString();
                    jmbg_lekara = rdr[2].ToString();
                }
                rdr.Close();

            }
            catch (Exception ex)
            {
                to_return = "Error during database reading";
            }
            finally
            {
                conn.Close();
                // Database is always closed
            }
            return to_return;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ZahtevZaIzborLekara zahtev_form = new ZahtevZaIzborLekara(jmbg_lekara);
            zahtev_form.StartPosition = FormStartPosition.CenterScreen;
            zahtev_form.Show();
        }

        private string GetDoctorNameAndSurname(string jmbg_lekar)
        {
            string to_return = "Not found";
            // Fetch 'Ime' + 'Prezime' from PACIJENT
            string connection = "server=139.59.132.29;user=paja;charset=utf8;database=Hippocrates;port=3306;password=pajapro1234;protocol=TCP";
            //bool success = true;

            MySqlConnection conn = new MySqlConnection(connection);
            try
            {
                // Open connection
                conn.Open();
                // Copy to local 
                // Perform database operations
                string sql = "select ime, prezime from IZABRANI_LEKAR where jmbg = '" + jmbg_lekar + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                // rdr[0] = IME, rdr[1] = PREZIME
                while (rdr.Read())
                    to_return = rdr[0].ToString() + " " + rdr[1].ToString();

                rdr.Close();

            }
            catch (Exception ex)
            {
                to_return = "Error during doctor database reading";
            }
            finally
            {
                conn.Close();
                // Database is always closed
            }
            return to_return;
        }
        
        private void PacijentForm_Load(object sender, EventArgs e)
        {
            this.Text = GetNameAndSurname(jmbg, lbo);
            metrolabInfoLekar.Text = GetDoctorNameAndSurname(jmbg_lekara);
        }
    }
}
