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
using MySql.Data.MySqlClient;
using MetroFramework.Forms;


namespace HippocratesDoctor
{
    public partial class FormDirektor : MetroForm, IView
    {
        private IController _controller;

        MySqlDataReader dr;
        string conStr;
        string dom_zdravlja_ime,dom_zdravlja_MBRZU,matbrAdmina;
        MySqlConnection conn;
        public FormDirektor(string s)
        {
            matbrAdmina = s;
            InitializeComponent();
            conStr =
                "server=139.59.132.29;user=aki;charset=utf8;database=Hippocrates;port=3306;password=jetion123c;";
            conn = new MySqlConnection(conStr);
            vratiDomZdravlja();
            popunjavanjeDataGridViewa();
            vratiImeDZ();
        }

        private void vratiImeDZ()
        {
            try
            {
                conn.Open();
                string sqlcommand = "SELECT * FROM DOM_ZDRAVLJA WHERE MBR='" + dom_zdravlja_MBRZU + "'";
                MySqlCommand command = new MySqlCommand(sqlcommand,conn);
                dr = command.ExecuteReader();
                if (dr.Read())
                    dom_zdravlja_ime = dr["IME"].ToString();
                
                conn.Close();
                lblImeDomaZ.Text = dom_zdravlja_ime;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Problem: " + exc);
                conn.Close();
            }
        }

        private void vratiDomZdravlja()
        {
            try
            {
                conn.Open();
                string sqlcommand = "SELECT * FROM ADMINISTRATOR_DOM_ZDRAVLJA WHERE JMBG='" + matbrAdmina + "'";
                MySqlCommand command = new MySqlCommand(sqlcommand, conn);
                dr = command.ExecuteReader();
                if (dr.Read())
                    dom_zdravlja_MBRZU = dr["MBRZU"].ToString();
                dr.Close();
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Problem: " + exc);
                conn.Close();
            }
        }


        #region tab_podaci_o_lekarima

        #region unos_lekara
        private void btn_lekar_brisanje_Click(object sender, EventArgs e)
        {
            int smena;
            if (cB_smena_lekar_unos_dva.Checked)
                smena = 2;
            else
                smena = 1;
            try
            {
                conn.Open();
                string commandSqlUnos = "INSERT INTO IZABRANI_LEKAR (JMBG,IME,SREDNJE_SLOVO,PREZIME,DATUM_ROĐENJA,MBRZU,SMENA,PASSWORD) VALUES ('" + tb_unos_lekar_jmbg.Text + "','" + tb_unos_lekar_ime.Text + "','" + tb_unos_lekar_srednjeS.Text + "','" + tb_unos_lekar_prezime.Text + "','" + dTP_lekar_unos.Value.ToString("yyyy-MM-dd") + "','" + dom_zdravlja_MBRZU + "'," + smena + ",'" + tb_unos_lekar_password.Text + "')";
                MySqlCommand mcc = new MySqlCommand(commandSqlUnos, conn);
                mcc.ExecuteNonQuery();
                MessageBox.Show("Uspesno ste uneli novog lekara u bazu podatka");
                //---
                string sqlcommand = "SELECT * FROM IZABRANI_LEKAR WHERE MBRZU = '"+dom_zdravlja_MBRZU+"'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlcommand, conStr);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "IZABRANI_LEKAR");
                dGV_lekar_unos.DataSource = dataSet;
                dGV_lekar_unos.DataMember = "IZABRANI_LEKAR";



                //----
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem" + ex);
                conn.Close();
            }
        }

        //validacija
        private void tb_unos_lekar_jmbg_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tb_unos_lekar_ime_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tb_unos_lekar_prezime_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tb_unos_lekar_password_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tb_unos_lekar_srednjeS_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        #endregion

        #region azuriranje_tab

        private void btn_azuriranje_lekara_Click(object sender, EventArgs e)
        {

        }

        //validacija
        private void tb_azuriranje_lekar_jmbg_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tb_azuriranje_lekar_ime_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tb_azuriranje_lekar_prezime_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tb_azuriranje_lekar_password_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tb_azuriranje_lekar_srednjeS_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        #endregion

        #endregion

        #region popunjavanje_dataGviwa_na_tabovima
        private void popunjavanjeDataGridViewa()
        {
            conn.Open();
            string sqlcommand = "SELECT * FROM IZABRANI_LEKAR WHERE MBRZU = '"+ dom_zdravlja_MBRZU + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sqlcommand, conStr);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

            //tab sa lekarima
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "IZABRANI_LEKAR");
            dGV_lekar_brisanje.DataSource = dataSet;
            dGV_lekar_brisanje.DataMember = "IZABRANI_LEKAR";
            dGV_lekar_unos.DataSource = dataSet;
            dGV_lekar_unos.DataMember = "IZABRANI_LEKAR";
            dGV_lekar_azuriranje.DataSource = dataSet;
            dGV_lekar_azuriranje.DataMember = "IZABRANI_LEKAR";
            //tab sa osobljem fali za sada...

            conn.Close();
        }


        #endregion

        #region MVC
        public void setController(IController controller)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
