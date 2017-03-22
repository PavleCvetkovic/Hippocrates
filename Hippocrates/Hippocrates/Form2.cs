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
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using Hippocrates.Data;

namespace Hippocrates
{
    public partial class Form2 : MetroForm
    {
        MySqlDataAdapter adapter;
        DataSet dataSet;
        private string connstr;
        MySqlConnection conn;
        public Form2()
        {
           
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1243, 822);
            this.MinimumSize = new System.Drawing.Size(1243, 822);
            dTP_lekara.CustomFormat = "dd ,MMMM ,yyyy";
            dTP_pacijenta.CustomFormat = "dd ,MMMM ,yyyy";
            /*
             string connStr = "server=localhost;user=root;database=world;port=3306;password=******;";
             MySqlConnection conn = new MySqlConnection(connStr);
             */
            connstr = "server=pavlecvetkovic.me; user=aki;charset=utf8;database=Hippocrates;port=3306;password=jetion123c;";
            conn = new MySqlConnection(connstr);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region dataGridViewi_na_tabu_za_pogled_na_bazu
        private void btn_dom_zdravlja_obicanPogled_Click(object sender, EventArgs e)
        {
            string sqlcommand = "SELECT * FROM DOM_ZDRAVLJA";
            adapter = new MySqlDataAdapter(sqlcommand, connstr);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

            dataSet = new DataSet();
            adapter.Fill(dataSet, "DOM_ZDRAVLJA");
            dGV_pogled_u_bazu.DataSource = dataSet;
            dGV_pogled_u_bazu.DataMember = "DOM_ZDRAVLJA";


            conn.Close();
        }

        private void btn_obican_pogled_Lekar_Click(object sender, EventArgs e)
        {
            string sqlcommand = "SELECT * FROM IZABRANI_LEKAR";
            adapter = new MySqlDataAdapter(sqlcommand, connstr);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

            dataSet = new DataSet();
            adapter.Fill(dataSet, "IZABRANI_LEKAR");
            dGV_pogled_u_bazu.DataSource = dataSet;
            dGV_pogled_u_bazu.DataMember = "IZABRANI_LEKAR";


            conn.Close();
        }

        private void btn_obican_pogled_MedicOsoblje_Click(object sender, EventArgs e)
        {
            string sqlcommand = "SELECT * FROM MEDICINSKO_OSOBLJE";
            adapter = new MySqlDataAdapter(sqlcommand, connstr);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

            dataSet = new DataSet();
            adapter.Fill(dataSet, "MEDICINSKO_OSOBLJE");
            dGV_pogled_u_bazu.DataSource = dataSet;
            dGV_pogled_u_bazu.DataMember = "MEDICINSKO_OSOBLJE";


            conn.Close();
        }

        private void btn_obican_pogled_Pacijent_Click(object sender, EventArgs e)
        {
            string sqlcommand = "SELECT * FROM PACIJENT";
            adapter = new MySqlDataAdapter(sqlcommand, connstr);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

            dataSet = new DataSet();
            adapter.Fill(dataSet, "PACIJENT");
            dGV_pogled_u_bazu.DataSource = dataSet;
            dGV_pogled_u_bazu.DataMember = "PACIJENT";
            metro_grid_view.DataSource = dataSet;
            metro_grid_view.DataMember = "PACIJENT";

            conn.Close();
        }
        #endregion

        #region Unos_podataka
        //------------------------------------------------------------------

        #region tab_za_unos_DZ
        private void btn_unosDomaZdr_Click(object sender, EventArgs e)
        {
            if(validacija_za_unos_DZ())
            {
                try
                {
                    conn.Open();
                    string commandSqlUnos = "INSERT INTO DOM_ZDRAVLJA (MBR,IME,OPŠTINA,LOKACIJA,ADRESA) VALUES ('" + tb_MBR_doma_zdravlja.Text + "','" + tb_ime_doma_zdravlja.Text + "','" + tb_opstina_doma_zdravlja.Text + "','" + tb_lokacija_doma_zdravlja.Text + "','" + tb_adresa_doma_zdravlja.Text + "')";
                    MySqlCommand mcc = new MySqlCommand(commandSqlUnos, conn);
                    mcc.ExecuteNonQuery();
                    MessageBox.Show("Uspesno ste uneli nov dom zdravlja u bazu podatka");
                    conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Problem" + ex);
                }

            }
        }
        private bool validacija_za_unos_DZ()
        {
            if (tb_MBR_doma_zdravlja.Text == string.Empty)
            {
                return false;
            }
            else if(tb_ime_doma_zdravlja.Text == string.Empty)
            {
                return false;
            }
            else if(tb_lokacija_doma_zdravlja.Text == string.Empty)
            {
                return false;
            }
            else if (tb_adresa_doma_zdravlja.Text == string.Empty)
            {
                return false;
            }
            else if(tb_opstina_doma_zdravlja.Text == string.Empty)
            {
                return false;
            }
            else
                return true;
        }
        #endregion

        #region dataGridViewi_na_tabu_za_unos_u_bazu
        private void TabControl_za_unos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl_za_unos.SelectedIndex == 0)
            {
                string sqlcommand = "SELECT * FROM DOM_ZDRAVLJA";
                adapter = new MySqlDataAdapter(sqlcommand, connstr);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

                dataSet = new DataSet();
                adapter.Fill(dataSet, "DOM_ZDRAVLJA");
                dGV_unosenje_DZ.DataSource = dataSet;
                dGV_unosenje_DZ.DataMember = "DOM_ZDRAVLJA";

                conn.Close();
            }
            else if(TabControl_za_unos.SelectedIndex == 1)
            {
                string sqlcommand = "SELECT * FROM IZABRANI_LEKAR";
                adapter = new MySqlDataAdapter(sqlcommand, connstr);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

                dataSet = new DataSet();
                adapter.Fill(dataSet, "IZABRANI_LEKAR");
                dGV_unosenje_lekar.DataSource = dataSet;
                dGV_unosenje_lekar.DataMember = "IZABRANI_LEKAR";

                conn.Close();
            }
            else
            {
                string sqlcommand = "SELECT * FROM PACIJENT";
                adapter = new MySqlDataAdapter(sqlcommand, connstr);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

                dataSet = new DataSet();
                adapter.Fill(dataSet, "PACIJENT");
                dGV_unosenje_pacijent.DataSource = dataSet;
                dGV_unosenje_pacijent.DataMember = "PACIJENT";

                conn.Close();
            }
        }
        #endregion

        #region tab_za_Unos_lekara
        private void btn_Unesi_lekara_Click(object sender, EventArgs e)
        {
            int smena;
            if (checkB_Druga_smena.Checked)
                smena = 2;
            else
                smena = 1;
               try
              {
                  conn.Open();
                string commandSqlUnos = "INSERT INTO IZABRANI_LEKAR (JMBG,IME,SREDNJE_SLOVO,PREZIME,DATUM_ROĐENJA,MBRZU,SMENA,PASSWORD) VALUES ('" + tb_jmbg_lekara.Text + "','" + tb_ime_lekara_unos.Text + "','" + tb_srednje_slovo.Text + "','" + tb_prezime_lekara.Text + "','" + dTP_lekara.Value.ToString("yyyy-MM-dd") + "','" + tb_mbrzu_lekara.Text + "'," + smena + ",'" + tb_pass_lekara_unos.Text + "')";
                  MySqlCommand mcc = new MySqlCommand(commandSqlUnos, conn);
                  mcc.ExecuteNonQuery();
                  MessageBox.Show("Uspesno ste uneli novog lekara u bazu podatka");
                  conn.Close();
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Problem" + ex);
              }
              
        }
    
        private bool validacija_za_unos_lekara()
        {
            if (tb_jmbg_lekara.Text == string.Empty)
            {
                return false;
            }
            else if(tb_mbrzu_lekara.Text == string.Empty)
            {
                return false;
            }
            else if (tb_ime_lekara_unos.Text==string.Empty)
            {
                return false;
            }
            else if (tb_prezime_lekara.Text == string.Empty)
            {
                return false;
            }
            else if (tb_pass_lekara_unos.Text == string.Empty)
            {
                return false;
            }
            else
                return true;
        }

        #endregion

        #region tab_za_Unos_pacijenta

        private void btn_unesi_pacijenta_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string commandSqlUnos = "INSERT INTO IZABRANI_LEKAR (JMBG,IME,SREDNJE_SLOVO,PREZIME,DATUM_ROĐENJA,OPSTINA,PRAVO_DA_ZAKAŽE,LBO,VAŽI_DO) VALUES ('" + tb_JMBG_pacijenta.Text + "','" + tb_ime_pac.Text + "','" + tb_srednjeSlovo.Text + "','" + tb_prezime_pacijenta.Text + "','" + dTP_pacijenta.Value.ToString("yyyy-MM-dd") + "','" + tb_opstina.Text + "','" + 1 + "','" + tb_LBO_pacujenta.Text + "','" + dTP_Vazi_do.Value.ToString("yyyy-MM-dd") + "')";
                MySqlCommand mcc = new MySqlCommand(commandSqlUnos, conn);
                mcc.ExecuteNonQuery();
                MessageBox.Show("Uspesno ste uneli novog pacijenta u bazu podatka");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem" + ex);
            }
        }
        private bool validacija()
        {
            return true;
        }

        #endregion
        //------------------------------------------------------------------
        #endregion

        #region tab_za_brisanje
        private void tabControl_za_brisanje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_za_brisanje.SelectedIndex == 0)
            {
                string sqlcommand = "SELECT * FROM DOM_ZDRAVLJA";
                adapter = new MySqlDataAdapter(sqlcommand, connstr);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

                dataSet = new DataSet();
                adapter.Fill(dataSet, "DOM_ZDRAVLJA");
                dGV_brisanje_dz.DataSource = dataSet;
                dGV_brisanje_dz.DataMember = "DOM_ZDRAVLJA";

                conn.Close();
            }
            else if (tabControl_za_brisanje.SelectedIndex == 1)
            {
                string sqlcommand = "SELECT * FROM IZABRANI_LEKAR";
                adapter = new MySqlDataAdapter(sqlcommand, connstr);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

                dataSet = new DataSet();
                adapter.Fill(dataSet, "IZABRANI_LEKAR");
                dGV_lekar_brisanje.DataSource = dataSet;
                dGV_lekar_brisanje.DataMember = "IZABRANI_LEKAR";

                conn.Close();
            }
            else
            {
                string sqlcommand = "SELECT * FROM PACIJENT";
                adapter = new MySqlDataAdapter(sqlcommand, connstr);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

                dataSet = new DataSet();
                adapter.Fill(dataSet, "PACIJENT");
                dGV_pacijent_brisanje.DataSource = dataSet;
                dGV_pacijent_brisanje.DataMember = "PACIJENT";

                conn.Close();
            }
        }


        #endregion


    }
}
