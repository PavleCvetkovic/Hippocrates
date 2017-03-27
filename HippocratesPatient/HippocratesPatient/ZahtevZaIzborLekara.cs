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

namespace HippocratesPatient
{
    public partial class ZahtevZaIzborLekara : MetroFramework.Forms.MetroForm
    {
        private string puno_ime_lekara, jmbg_lekara, jmbg_pacijenta;
        
        public ZahtevZaIzborLekara(string jmbg_pacijenta, string puno_ime_lekara, string jmbg_prethodni_lekar)
        {
            InitializeComponent();
            this.puno_ime_lekara = puno_ime_lekara;
            this.jmbg_lekara = jmbg_prethodni_lekar;
            this.jmbg_pacijenta = jmbg_pacijenta;
            metroLabelIzabraniLekar.Text = puno_ime_lekara;
            GetAvailableDoctors(this.jmbg_pacijenta);
        }

        private bool GetAvailableDoctors(string jmbg_pacijenta)
        {
            bool success = true;
            Hippocrates.Data.ConnectionInfo ci = new Hippocrates.Data.ConnectionInfo();

            MySqlDataAdapter data_adapter;
            DataSet data_set;
            MySqlConnection conn = new MySqlConnection(ci.Get_Nikola_Connection_String);
            try
            {
                string sql = "select JMBG, IME, SREDNJE_SLOVO, PREZIME, SMENA from IZABRANI_LEKAR" +
                                " where IZABRANI_LEKAR.MBRZU = (select MBR from DOM_ZDRAVLJA, PACIJENT" +
                                                                " where DOM_ZDRAVLJA.OPŠTINA = PACIJENT.OPŠTINA " +
                                                                " and PACIJENT.JMBG = '" + this.jmbg_pacijenta + "')" +
                                " and IZABRANI_LEKAR.JMBG != '" + this.jmbg_lekara +"';";

                data_adapter = new MySqlDataAdapter(sql, conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(data_adapter);

                data_set = new DataSet();
                data_adapter.Fill(data_set, "Doktori");
                metroGridPonudjeniLekari.DataSource = data_set;
                metroGridPonudjeniLekari.DataMember = "Doktori";
                //  metroGridPonudjeniLekari.
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error", "Greška prilikom preuzimanja dostupnih doktora " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = false;
            }
            return success;
        }

        private bool ChangeDoctor(string jmbg_zeljeni_lekar)
        {
            bool success = true;
            Hippocrates.Data.ConnectionInfo ci = new Hippocrates.Data.ConnectionInfo();
            MySqlConnection conn = new MySqlConnection(ci.Get_Nikola_Connection_String);
            try
            {
                conn.Open();

                string sql = "insert into ZAHTEV_ZA_PROMENU values ('" + this.jmbg_pacijenta + "','" + jmbg_zeljeni_lekar + "')";
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
