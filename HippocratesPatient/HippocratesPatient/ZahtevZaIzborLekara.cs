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
    public partial class ZahtevZaIzborLekara : MetroFramework.Forms.MetroForm
    {
        //private string puno_ime_lekara, jmbg_lekara, jmbg_pacijenta;
        private Pacijent pacijent_local;
        private ISession session;
        private IList<IzabraniLekar> lekari;

        public ZahtevZaIzborLekara(ISession s, Pacijent pacijent_parametar)
        {
            InitializeComponent();
            session = s;
            this.pacijent_local = pacijent_parametar;
            //this.puno_ime_lekara = pacijent_parametar.Lekar.Ime + " " + pacijent_parametar.Lekar.Prezime;
            //this.jmbg_lekara = pacijent_parametar.Lekar.Jmbg;
            //this.jmbg_pacijenta = pacijent_parametar.Jmbg;
            metroLabelIzabraniLekar.Text = pacijent_parametar.Lekar.Ime + " " + pacijent_parametar.Lekar.Prezime;
            GetAvailableDoctors(pacijent_parametar);
        }

        private bool GetAvailableDoctors(Pacijent pacijent)
        {
            bool success = true;
            //ISession session = null;
            try
            {
                //session = DataLayer.GetSession();
                //IList<IzabraniLekar> dostupni_lekari = session.
                //var customers = session.CreateQuery("select c from Customer c  where c.FirstName = 'Laverne'"); 
                var dostupni_lekari = session.CreateQuery("select l from IzabraniLekar l where l.RadiUDomuZdravlja.Opstina  = '" + pacijent.Opstina + "'");
                //var dostupni_lekari = session.QueryOver<IzabraniLekar>().Where(x => x.RadiUDomuZdravlja.Opstina == pacijent.Opstina).List();

                lekari = dostupni_lekari.List<IzabraniLekar>();
                //IList<IzabraniLekar> lekari = dostupni_lekari.ToList<IzabraniLekar>();


                int i = 0;
                for (i = 0; i < lekari.Count; i++)
                    if (lekari[i].Jmbg == pacijent.Lekar.Jmbg)
                        break;
                lekari.RemoveAt(i); // izbaci vec izabranog lekara iz liste (on se ne prikazuje)

                metroGridPonudjeniLekari.DataSource = lekari;
                for (i = 5; i < metroGridPonudjeniLekari.ColumnCount; i++)
                    metroGridPonudjeniLekari.Columns[i].Visible = false;
            }
            catch (Exception ec)
            {
                MetroMessageBox.Show(this, "Greška prilikom učitavanja podataka o dostpunim lekarima iz baze " + ec.Message);
                success = false;
            }
            #region SQL nacin
            //Hippocrates.Data.ConnectionInfo ci = new Hippocrates.Data.ConnectionInfo();

            //MySqlDataAdapter data_adapter;
            //DataSet data_set;
            //MySqlConnection conn = new MySqlConnection(ci.Get_Nikola_Connection_String);
            //try
            //{
            //    // smena se uzima iz tabele smena
            //    string sql = "select JMBG, IME, SREDNJE_SLOVO, PREZIME from IZABRANI_LEKAR" +
            //                    " where IZABRANI_LEKAR.MBRZU = (select MBR from DOM_ZDRAVLJA, PACIJENT" +
            //                                                    " where DOM_ZDRAVLJA.OPŠTINA = PACIJENT.OPŠTINA " +
            //                                                    " and PACIJENT.JMBG = '" + this.jmbg_pacijenta + "')" +
            //                    " and IZABRANI_LEKAR.JMBG != '" + this.jmbg_lekara +"';";

            //    data_adapter = new MySqlDataAdapter(sql, conn);
            //    MySqlCommandBuilder cb = new MySqlCommandBuilder(data_adapter);

            //    data_set = new DataSet();
            //    data_adapter.Fill(data_set, "Doktori");
            //    metroGridPonudjeniLekari.DataSource = data_set;
            //    metroGridPonudjeniLekari.DataMember = "Doktori";
            //    //  metroGridPonudjeniLekari.
            //}
            //catch (Exception ex)
            //{
            //    MetroMessageBox.Show(this, "Here " + ex.Message);
            //    MetroMessageBox.Show(this, "Error", "Greška prilikom preuzimanja dostupnih doktora " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    success = false;
            //}
        #endregion

            return success;
        }

        private void ZahtevZaIzborLekara_FormClosing(object sender, FormClosingEventArgs e)
        {
            session.Flush();
        }

        private bool ChangeDoctor(string jmbg_zeljeni_lekar)
        {
            bool success = true;
            try
            {
                IzabraniLekar zeljeni_lekar = session.Get<IzabraniLekar>(jmbg_zeljeni_lekar);
                //string za_lazy_load = zeljeni_lekar.Ime;
                ZahtevZaPromenu novi_zahtev = new ZahtevZaPromenu() // Id je auto_increment 
                {
                    ZahtevPacijenta = pacijent_local,
                    ZeljeniLekar = zeljeni_lekar
                };

                zeljeni_lekar.Zahtevi.Add(novi_zahtev);
                pacijent_local.Zahtevi.Add(novi_zahtev);

                session.Save(novi_zahtev);
                session.Save(zeljeni_lekar);
                session.Save(pacijent_local);
                session.Flush();
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, "Greška prilikom generisanja zahteva " + ex.Message);
                success = false;
            }

            #region SQL nacin
            /*
            Hippocrates.Data.ConnectionInfo ci = new Hippocrates.Data.ConnectionInfo();
            MySqlConnection conn = new MySqlConnection(ci.Get_Nikola_Connection_String);
            try
            {
                conn.Open();

                string sql = "insert into ZAHTEV_ZA_PROMENU values ('" + this.jmbg_pacijenta + "','" + jmbg_zeljeni_lekar + "', 4)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = false;
            }
            conn.Close();
            */
            #endregion
            return success;

        }
        private void metroButtonPodnesiZahtev_Click(object sender, EventArgs e)
        {
            if (metroGridPonudjeniLekari.RowCount == 0) // someone selected
            {
                MetroMessageBox.Show(this, "Error", "Nemate mogućnosti za izbor drugog lekara", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (metroGridPonudjeniLekari.SelectedRows.Count == 1)
                {
                    //MetroMessageBox.Show(this, "Info", "Selected count == 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    string jmbg_from_grid = "";
                    jmbg_from_grid = metroGridPonudjeniLekari.SelectedRows[0].Cells[0].Value.ToString();
                    if (ChangeDoctor(jmbg_from_grid))
                        MetroMessageBox.Show(this, "Info", "Zahtev uspešno poslat na obradu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MetroMessageBox.Show(this, "Error", "Greška prilikom slanja zahteva na obradu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MetroMessageBox.Show(this, "Warning", "Odaberite željenog lekara", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
