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


            conn.Close();
        }


        #endregion

        #region starting_panel_updates
        private void GeneralControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GeneralControl.SelectedIndex == 1)
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
            else if (GeneralControl.SelectedIndex == 2)
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
            else if (GeneralControl.SelectedIndex == 3)
            {

                string sqlcommand = "SELECT * FROM DOM_ZDRAVLJA";
                adapter = new MySqlDataAdapter(sqlcommand, connstr);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

                dataSet = new DataSet();
                adapter.Fill(dataSet, "DOM_ZDRAVLJA");
                dGV_domZdravlja_azuriranje.DataSource = dataSet;
                dGV_domZdravlja_azuriranje.DataMember = "DOM_ZDRAVLJA";

                conn.Close();
            }
        }
        #endregion

        #region Unos_podataka


        #region tab_za_unos_DZ
        private void btn_unosDomaZdr_Click(object sender, EventArgs e)
        {
            if (validacija_za_unos_DZ())
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
                catch (Exception ex)
                {
                    MessageBox.Show("Problem" + ex);
                    conn.Close();
                }

            }
        }
        private bool validacija_za_unos_DZ()
        {
            if (tb_MBR_doma_zdravlja.Text == string.Empty)
            {
                return false;
            }
            else if (tb_ime_doma_zdravlja.Text == string.Empty)
            {
                return false;
            }
            else if (tb_lokacija_doma_zdravlja.Text == string.Empty)
            {
                return false;
            }
            else if (tb_adresa_doma_zdravlja.Text == string.Empty)
            {
                return false;
            }
            else if (tb_opstina_doma_zdravlja.Text == string.Empty)
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
            else if (TabControl_za_unos.SelectedIndex == 1)
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
                conn.Close();
            }

        }

        private bool validacija_za_unos_lekara()
        {
            if (tb_jmbg_lekara.Text == string.Empty)
            {
                return false;
            }
            else if (tb_mbrzu_lekara.Text == string.Empty)
            {
                return false;
            }
            else if (tb_ime_lekara_unos.Text == string.Empty)
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
                conn.Close();
            }
        }
        private bool validacija()
        {
            return true;
        }

        #endregion

        #endregion

        #region tab_za_brisanje

        #region dataGridViewi_na_tabu_za_brisanje_iz_baze
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

        #region tab_za_brisanje_dz

        private void btn_brisanje_dz_Click(object sender, EventArgs e)
        {
            string s;
            if (rB_brisanje_pomocu_MBR.Checked)
            {
                if (tb_MBR_za_brisanje.Text != string.Empty && tb_MBR_za_brisanje.TextLength == 13)
                {
                    s = tb_MBR_za_brisanje.Text;
                    try
                    {
                        conn.Open();
                        string commandSqlDelete = "DELETE FROM DOM_ZDRAVLJA WHERE JMBG='" + s + "' ";
                        MySqlCommand mcc = new MySqlCommand(commandSqlDelete, conn);
                        mcc.ExecuteNonQuery();
                        MessageBox.Show("Uspesno ste obrisali dom zdravlja iz baze podatka");
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problem" + ex);
                        conn.Close();
                    }
                }
            }
            else
            {
                int rowindex = dGV_brisanje_dz.CurrentCell.RowIndex;
                int columnindex = dGV_brisanje_dz.CurrentCell.ColumnIndex;

                s = dGV_brisanje_dz.Rows[rowindex].Cells[columnindex].Value.ToString();


                try
                {
                    conn.Open();
                    string commandSqlDelete = "DELETE FROM DOM_ZDRAVLJA WHERE MBR='" + s + "' ";
                    MySqlCommand mcc = new MySqlCommand(commandSqlDelete, conn);
                    mcc.ExecuteNonQuery();
                    MessageBox.Show("Uspesno ste obrisali dom zdravlja iz baze podatka");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem" + ex);
                    conn.Close();
                }
            }
        }


        #endregion

        #region tab_za_brisanje_lekara
        private void btn_obrisi_lekara_Click(object sender, EventArgs e)
        {
            string s;
            if (rB_alternativno_brisanje_lekara.Checked)
            {
                if (tB_JMBG_brisanje_lekara.Text != string.Empty && tB_JMBG_brisanje_lekara.TextLength == 13)
                {
                    s = tB_JMBG_brisanje_lekara.Text;
                    try
                    {
                        conn.Open();
                        string commandSqlDelete = "DELETE FROM IZABRANI_LEKAR WHERE JMBG='" + s + "' ";
                        MySqlCommand mcc = new MySqlCommand(commandSqlDelete, conn);
                        mcc.ExecuteNonQuery();
                        MessageBox.Show("Uspesno ste obrisali lekara iz baze podatka");
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problem" + ex);
                        conn.Close();
                    }
                }
            }
            else
            {
                int rowindex = dGV_lekar_brisanje.CurrentCell.RowIndex;
                int columnindex = dGV_lekar_brisanje.CurrentCell.ColumnIndex;

                s = dGV_lekar_brisanje.Rows[rowindex].Cells[columnindex].Value.ToString();


                try
                {
                    conn.Open();
                    string commandSqlDelete = "DELETE FROM IZABRANI_LEKAR WHERE JMBG='" + s + "' ";
                    MySqlCommand mcc = new MySqlCommand(commandSqlDelete, conn);
                    mcc.ExecuteNonQuery();
                    MessageBox.Show("Uspesno ste obrisali lekara iz baze podatka");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem" + ex);
                    conn.Close();
                }
            }
        }
        #endregion

        #region tab_za_brisanje_pacijenata
        private void btn_brisanje_pacijenta_Click(object sender, EventArgs e)
        {
            string s;
            if (rB_brisanje_pacijenta_alternativa.Checked)
            {
                if (tb_JMBG_brisanja_pacijenta.Text != string.Empty && tb_JMBG_brisanja_pacijenta.TextLength == 13)
                {
                    s = tb_JMBG_brisanja_pacijenta.Text;
                    try
                    {
                        conn.Open();
                        string commandSqlDelete = "DELETE FROM PACIJENT WHERE JMBG='" + s + "' ";
                        MySqlCommand mcc = new MySqlCommand(commandSqlDelete, conn);
                        mcc.ExecuteNonQuery();
                        MessageBox.Show("Uspesno ste obrisali pacijenta iz baze podatka");
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problem" + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Pogresno unet maticni broj pacijenta");
                    conn.Close();
                }
            }
            else
            {
                int rowindex = dGV_pacijent_brisanje.CurrentCell.RowIndex;
                int columnindex = dGV_pacijent_brisanje.CurrentCell.ColumnIndex;
                s = dGV_pacijent_brisanje.Rows[rowindex].Cells[columnindex].Value.ToString();
                try
                {
                    conn.Open();
                    string commandSqlDelete = "DELETE FROM PACIJENT WHERE JMBG='" + s + "' ";
                    MySqlCommand mcc = new MySqlCommand(commandSqlDelete, conn);
                    mcc.ExecuteNonQuery();
                    MessageBox.Show("Uspesno ste obrisali pacijenta iz baze podatka");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem" + ex);
                    conn.Close();
                }
            }
        }


        #endregion

        #endregion

        //fali kod za azuriranje pacijenta
        #region tab_za_azuriranje
        #region pomocnePromenljive
        private string mbr_za_menjanje;
        private string jmbg_lekara_zaMenjanje;
        private string jmbg_pacijenta_zaMenjanje;
        string s;
        string s2;
        string s3;
        string s4;
        string s5;
        string s6;
        string s7;
        string s8;
        string s9;
        string s10;
        string s11;
        #endregion

        #region dataGridViewi_na_tabu_za_azuriranje_baze

        private void tab_azuriranje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_azuriranje.SelectedIndex == 0)
            {
                string sqlcommand = "SELECT * FROM DOM_ZDRAVLJA";
                adapter = new MySqlDataAdapter(sqlcommand, connstr);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

                dataSet = new DataSet();
                adapter.Fill(dataSet, "DOM_ZDRAVLJA");
                dGV_domZdravlja_azuriranje.DataSource = dataSet;
                dGV_domZdravlja_azuriranje.DataMember = "DOM_ZDRAVLJA";

                conn.Close();
            }
            else if (tab_azuriranje.SelectedIndex == 1)
            {
                string sqlcommand = "SELECT * FROM IZABRANI_LEKAR";
                adapter = new MySqlDataAdapter(sqlcommand, connstr);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

                dataSet = new DataSet();
                adapter.Fill(dataSet, "IZABRANI_LEKAR");
                dGV_lekari_azuriranje.DataSource = dataSet;
                dGV_lekari_azuriranje.DataMember = "IZABRANI_LEKAR";

                conn.Close();
            }
            else
            {
                string sqlcommand = "SELECT * FROM PACIJENT";
                adapter = new MySqlDataAdapter(sqlcommand, connstr);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

                dataSet = new DataSet();
                adapter.Fill(dataSet, "PACIJENT");
                dGV_pacijenti_azuriranje.DataSource = dataSet;
                dGV_pacijenti_azuriranje.DataMember = "PACIJENT";

                conn.Close();
            }
        }

        #endregion

        #region tab_za_azuriranje_domova_zdravlja


        private void dGV_domZdravlja_azuriranje_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = dGV_domZdravlja_azuriranje.CurrentCell.RowIndex;
             s = dGV_domZdravlja_azuriranje.Rows[rowindex].Cells[0].Value.ToString();
             s2 = dGV_domZdravlja_azuriranje.Rows[rowindex].Cells[1].Value.ToString();
             s3 = dGV_domZdravlja_azuriranje.Rows[rowindex].Cells[2].Value.ToString();
             s4 = dGV_domZdravlja_azuriranje.Rows[rowindex].Cells[3].Value.ToString();
             s5 = dGV_domZdravlja_azuriranje.Rows[rowindex].Cells[4].Value.ToString();
            tb_azuriranje_MBR_domZ.Text = s;
            tb_azuriranje_Ime_domZ.Text = s2;
            tb_azuriranje_opstina_domZ.Text = s3;
            tb_azuriranje_lokacija_domZ.Text = s4;
            tb_azuriranje_adresa_domZ.Text = s5;
            mbr_za_menjanje = s;
        }

        private void btn_azuriranje_domZ_Click(object sender, EventArgs e)
        { 
            try
            {
                conn.Open();
                string commandSqlUpdate = "UPDATE DOM_ZDRAVLJA SET MBR = '"+ tb_azuriranje_MBR_domZ.Text +"',IME ='"+ tb_azuriranje_Ime_domZ.Text + "',OPŠTINA='"+ tb_azuriranje_opstina_domZ.Text +"',LOKACIJA='"+ tb_azuriranje_lokacija_domZ.Text +"',ADRESA='"+ tb_azuriranje_adresa_domZ.Text +"' WHERE MBR='"+ mbr_za_menjanje +"'";
                MySqlCommand mcc = new MySqlCommand(commandSqlUpdate, conn);
                mcc.ExecuteNonQuery();
                MessageBox.Show("Uspesno ste azurirali dom zdravlja u bazi podatka");
                //---
                string sqlcommand = "SELECT * FROM DOM_ZDRAVLJA";
                adapter = new MySqlDataAdapter(sqlcommand, connstr);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

                dataSet = new DataSet();
                adapter.Fill(dataSet, "DOM_ZDRAVLJA");
                dGV_domZdravlja_azuriranje.DataSource = dataSet;
                dGV_domZdravlja_azuriranje.DataMember = "DOM_ZDRAVLJA";
                //---
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem" + ex);
                conn.Close();
            }
        }



        #endregion

        #region tab_za_azuriranje_lekara

        private void dGV_lekari_azuriranje_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = dGV_lekari_azuriranje.CurrentCell.RowIndex;
             s  = dGV_lekari_azuriranje.Rows[rowindex].Cells[0].Value.ToString();
             s2 = dGV_lekari_azuriranje.Rows[rowindex].Cells[1].Value.ToString();
             s3 = dGV_lekari_azuriranje.Rows[rowindex].Cells[2].Value.ToString();
             s4 = dGV_lekari_azuriranje.Rows[rowindex].Cells[3].Value.ToString();
             s5 = dGV_lekari_azuriranje.Rows[rowindex].Cells[4].Value.ToString();
             s6 = dGV_lekari_azuriranje.Rows[rowindex].Cells[5].Value.ToString();
             s7 = dGV_lekari_azuriranje.Rows[rowindex].Cells[6].Value.ToString();
             s8 = dGV_lekari_azuriranje.Rows[rowindex].Cells[7].Value.ToString(); 
            tb_azuriranje_jmbg_lekar.Text = s;
            tb_azuriranje_ime_lekar.Text = s2;
            tb_azuriranje_lekar_srednjeSlovo.Text = s3;
            tb_azuriranje_prezime_lekar.Text = s4;
            dTP_azuriranje_lekar.Value = DateTime.Parse(s5);
            tb_azuriranje_mbrzu_lekar.Text = s6;
            if(s7 == "1")
            {
                cb_azuriranje_smenaPrva_leakr.Checked = true ;
                cb_azuriranje_smenaDruga_leakr.Checked = false;
                
            }
            else
            {
                cb_azuriranje_smenaPrva_leakr.Checked = false;
                cb_azuriranje_smenaDruga_leakr.Checked = true;
            }
            tb_azuriranje_pass_lekar.Text = s8;
            jmbg_lekara_zaMenjanje = s;
        }

        private void btn_azuriranje_lekara_Click(object sender, EventArgs e)
        {
            int smena = 1;
            if(cb_azuriranje_smenaDruga_leakr.Checked)
            {
                smena = 2;
            }
            try
            {
                conn.Open();
                string commandSqlUpdate = "UPDATE IZABRANI_LEKAR SET JMBG='"+ tb_azuriranje_jmbg_lekar.Text + "',IME='"+ tb_azuriranje_ime_lekar.Text + "',SREDNJE_SLOVO='"+ tb_azuriranje_lekar_srednjeSlovo.Text + "',PREZIME='"+ tb_azuriranje_prezime_lekar.Text + "',DATUM_ROĐENJA='"+ dTP_azuriranje_lekar.Value.ToString("yyyy-MM-dd") + "',MBRZU='"+ tb_azuriranje_mbrzu_lekar.Text + "',SMENA='"+smena+"',PASSWORD='"+ tb_azuriranje_pass_lekar.Text + "' WHERE JMBG='"+ jmbg_lekara_zaMenjanje + "'";
                MySqlCommand mcc = new MySqlCommand(commandSqlUpdate, conn);
                mcc.ExecuteNonQuery();
                MessageBox.Show("Uspesno ste azurirali lekara u bazi podatka");
                //---
                string sqlcommand = "SELECT * FROM IZABRANI_LEKAR";
                adapter = new MySqlDataAdapter(sqlcommand, connstr);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

                dataSet = new DataSet();
                adapter.Fill(dataSet, "IZABRANI_LEKAR");
                dGV_lekari_azuriranje.DataSource = dataSet;
                dGV_lekari_azuriranje.DataMember = "IZABRANI_LEKAR";

                conn.Close();

                //----
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Problem" + ex);
            }
        }






        #endregion

        #region tab_za_azuriranje_pacijenta
        private int pravo_da_zakaze;
        private void dGV_pacijenti_azuriranje_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = dGV_pacijenti_azuriranje.CurrentCell.RowIndex;
             s = dGV_pacijenti_azuriranje.Rows[rowindex].Cells[0].Value.ToString();
            s2 = dGV_pacijenti_azuriranje.Rows[rowindex].Cells[1].Value.ToString();
            s3 = dGV_pacijenti_azuriranje.Rows[rowindex].Cells[2].Value.ToString();
            s4 = dGV_pacijenti_azuriranje.Rows[rowindex].Cells[3].Value.ToString();
            s5 = dGV_pacijenti_azuriranje.Rows[rowindex].Cells[4].Value.ToString();
            s6 = dGV_pacijenti_azuriranje.Rows[rowindex].Cells[5].Value.ToString();
            s7 = dGV_pacijenti_azuriranje.Rows[rowindex].Cells[6].Value.ToString();
            s8 = dGV_pacijenti_azuriranje.Rows[rowindex].Cells[7].Value.ToString();
            s9 = dGV_pacijenti_azuriranje.Rows[rowindex].Cells[8].Value.ToString();
            s10 = dGV_pacijenti_azuriranje.Rows[rowindex].Cells[9].Value.ToString();
            jmbg_pacijenta_zaMenjanje = s;

            tb_pacijent_azuriranje_jmbg.Text = s;
            tb_pacijent_azuriranje_lbo.Text = s8;
            tb_pacijent_azuriranje_ime.Text = s2;
            tb_pacijent_azuriranje_prezime.Text = s4;
            tb_pacijent_azuriranje_opstina.Text = s6;
            dTP_pacijent_azuriranje.Value = DateTime.Parse(s5);
            tb_pacijent_azuriranje_srednjeSlovo.Text = s3;
            tb_pacijent_azuriranje_MATBRL.Text = s9;
            dTP_vaziDo_pacijent.Value = DateTime.Parse(s10);
            if (Int32.Parse(s7) == 1)
            {
                cB_pravo_da_zakaze.Checked = true;
                pravo_da_zakaze = 1;
            }
            else
            {
                pravo_da_zakaze = 0;
                cB_pravo_da_zakaze.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!cB_pravo_da_zakaze.Checked)
            {
                pravo_da_zakaze = 0;
            }
            else
            {
                pravo_da_zakaze = 1;
            }
            try
            {
                conn.Open();
                string commandSqlUpdate = "UPDATE PACIJENT SET JMBG='" + tb_pacijent_azuriranje_jmbg.Text + "',IME='" + tb_pacijent_azuriranje_ime.Text + "',SREDNJE_SLOVO='" + tb_pacijent_azuriranje_srednjeSlovo.Text + "',PREZIME='" + tb_pacijent_azuriranje_prezime.Text + "',DATUM_ROĐENJA='" + dTP_pacijent_azuriranje.Value.ToString("yyyy-MM-dd") + "',OPŠTINA='" + tb_pacijent_azuriranje_opstina.Text + "',PRAVO_DA_ZAKAŽE='" + pravo_da_zakaze + "',LBO='" + tb_pacijent_azuriranje_lbo.Text + "',MATBRL='" + tb_pacijent_azuriranje_MATBRL.Text + "',VAŽI_DO='" + dTP_vaziDo_pacijent.Value.ToString("yyyy-MM-dd") + "' WHERE JMBG='" + jmbg_pacijenta_zaMenjanje + "'";
                MySqlCommand mcc = new MySqlCommand(commandSqlUpdate, conn);
                mcc.ExecuteNonQuery();
                MessageBox.Show("Uspesno ste azurirali pacijenta u bazi podatka");
                //--- 
                string sqlcommand = "SELECT * FROM PACIJENT";
                adapter = new MySqlDataAdapter(sqlcommand, connstr);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

                dataSet = new DataSet();
                adapter.Fill(dataSet, "PACIJENT");
                dGV_pacijenti_azuriranje.DataSource = dataSet;
                dGV_pacijenti_azuriranje.DataMember = "PACIJENT";



                //---- 
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Problem" + ex);
            }
        }



        #endregion

        #endregion

        
    }
}
