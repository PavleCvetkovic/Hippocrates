using Hippocrates;
using Hippocrates.Data;
using Hippocrates.Data.Entiteti;
using MetroFramework;
using MySql.Data.MySqlClient;
using NHibernate;
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
        private string jmbg_pacijenta, jmbg_lekara;
        private string puno_ime;
        private Pacijent pacijent;
        private ISession session;
        //private int pravo_da_zakaze;
        private byte pravo_da_zakaze;
        private string connection = "server=139.59.132.29;user=paja;charset=utf8;database=Hippocrates;port=3306;password=pajapro1234;protocol=TCP";
        //private MySqlDataAdapter daCountry;
        //private DataSet dsCountry;
        public PacijentForm(string jmbg, string lbo)
        {
            InitializeComponent();
            LoadPatientData(jmbg); // using ORM
            metroTabGlobal.SelectedIndex = 0; // Show 'Izabrani Lekar' tab
            this.Text = pacijent.Ime + " " + pacijent.Prezime;
            metrolabInfoLekar.Text = pacijent.Lekar.Ime + " " + pacijent.Lekar.Prezime;
            pravo_da_zakaze = (byte)pacijent.Pravo_da_zakaze;
            metroLabelJMBGLBO.Text = pacijent.Jmbg + " " + pacijent.Lbo;

            //
            jmbg_pacijenta = pacijent.Jmbg;
            //
            UpdateAppointment(pravo_da_zakaze);
        }

        private void LoadPatientData(string jmbg_pacijenta)
        {
            try
            {
                session = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                pacijent = session.Load<Pacijent>(jmbg_pacijenta);

                //MessageBox.Show(p.Naziv);

                //s.Close();
            }
            catch (Exception ec)
            {
                MetroMessageBox.Show(this, "Greška prilikom učitavanja podataka o pacijentu iz baze " + ec.Message);
            }
        }

        private void UpdateAppointment(byte priviledge)
        {
            if (pravo_da_zakaze >= 1)
            {
                metroLabelPravoZaZakazivanje.Text = "Imate pravo da zakazete termin";
                metroLabelPravoZaZakazivanje.UseCustomForeColor = true;
                metroLabelPravoZaZakazivanje.ForeColor = System.Drawing.Color.Aqua;
                metroLabelPravoZaZakazivanje.BackColor = System.Drawing.Color.Aqua;
                metroButtonZakaziteTermin.Enabled = true;
            }
            else
            {
                metroLabelPravoZaZakazivanje.Text = "Nemate pravo da zakazete termin";
                metroLabelPravoZaZakazivanje.UseCustomForeColor = true;
                metroLabelPravoZaZakazivanje.ForeColor = System.Drawing.Color.Red;
                metroButtonZakaziteTermin.Enabled = false;
            }
        }
        private string GetNameAndSurname(string jmbg, string lbo)
        {
            string to_return = "Not found";
            // Fetch 'Ime' + 'Prezime' from PACIJENT
            //string connection = "server=139.59.132.29;user=paja;charset=utf8;database=Hippocrates;port=3306;password=pajapro1234;protocol=TCP";
            //bool success = true;

            MySqlConnection conn = new MySqlConnection(connection);
            try
            {
                // Open connection
                conn.Open();
                // Copy to local 
                // Perform database operations
                string sql = "select ime, prezime, matbrl, PRAVO_DA_ZAKAŽE from PACIJENT where jmbg = '" + jmbg + "' and lbo = '" + lbo + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                // rdr[0] = IME, rdr[1] = PREZIME
                while (rdr.Read())
                {
                    to_return = rdr[0].ToString() + " " + rdr[1].ToString();
                    jmbg_lekara = rdr[2].ToString();
                    pravo_da_zakaze = Byte.Parse(rdr[3].ToString());
                }
                rdr.Close();

            }
            catch (Exception ex)
            {
                to_return = pravo_da_zakaze.ToString() + "Error during database reading in GetNameAndSurname" + ex.Message.ToString();
            }
            finally
            {
                conn.Close();
                // Database is always closed
            }
            return to_return;
        } // Return patient name and surname from Database

        private string GetDoctorNameAndSurname(string jmbg_lekar)
        {
            string to_return = "Not found";
            // Fetch 'Ime' + 'Prezime' from PACIJENT
            //string connection = "server=139.59.132.29;user=paja;charset=utf8;database=Hippocrates;port=3306;password=pajapro1234;protocol=TCP";
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
        } // Return doctor name and surname from Database

        private void GetVakcineData()
        {
            MySqlDataAdapter data_adapter;
            DataSet data_set;
            //string connStr = "server=localhost;user=root;database=world;port=3306;password=******;";
            MySqlConnection conn = new MySqlConnection(connection);
            try
            {
                //label2.Text = "Connecting to MySQL...";

                string sql = "select * from PRIMIO_VAKCINU where JMBGP = '" + jmbg_pacijenta + "'";
                data_adapter = new MySqlDataAdapter(sql, conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(data_adapter);

                data_set = new DataSet();
                data_adapter.Fill(data_set, "Vakcine");
                metrogridVakcine.DataSource = data_set;
                metrogridVakcine.DataMember = "Vakcine";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during connection " +  ex.Message.ToString());
            }
        } // Fill metroDataGrid in Vakcine

        private void GetDijagnozeData()
        {
            MySqlDataAdapter data_adapter;
            DataSet data_set;
            //string connStr = "server=localhost;user=root;database=world;port=3306;password=******;";
            MySqlConnection conn = new MySqlConnection(connection);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during connection " + ex.Message.ToString());
            }
        } // Fill metroDataGrid in Dijagnoze

        private void tabGlobal_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTabControl mtc = sender as MetroFramework.Controls.MetroTabControl;

            //MessageBox.Show("Selected inex changed event" + mtc.SelectedIndex);
            switch(mtc.SelectedTab.Text)
            {
                case "Vakcine" : { GetVakcineData(); break; }
                case "Dijagnoze" : { GetDijagnozeData(); break; }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //MetroMessageBox.Show(this, "This is a message in MetroBox");
            FormRaspored raspored_form = new FormRaspored(jmbg_pacijenta, GetDoctorNameAndSurname(jmbg_lekara), jmbg_lekara);
            raspored_form.StartPosition = FormStartPosition.CenterScreen;
            raspored_form.ShowDialog();
        }

        private void PacijentForm_Load(object sender, EventArgs e)
        {
            //this.Text = GetNameAndSurname(jmbg_pacijenta, lbo);
            //UpdateAppointment(pravo_da_zakaze); // UpdateAppointment MORA ISPOD GetNameAndSurname jer se tu vrsi inicijalizacija za "pravo_da_zakaze"
            //metrolabInfoLekar.Text = GetDoctorNameAndSurname(jmbg_lekara);
            //metroTabGlobal.SelectedIndex = 0; // Show 'Izabrani Lekar' tab
        }

        private void PacijentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            session.Save(pacijent); // just in case
            session.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ZahtevZaIzborLekara zahtev_form = new ZahtevZaIzborLekara(pacijent);
            zahtev_form.StartPosition = FormStartPosition.CenterScreen;
            //zahtev_form.MdiParent = this; // To make it impossible to NOT focus
            zahtev_form.ShowDialog();
        }
    }
}
