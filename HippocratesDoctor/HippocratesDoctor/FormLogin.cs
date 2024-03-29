﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hippocrates.Data;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using MetroFramework;

namespace HippocratesDoctor
{
    public partial class FormLogin : MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void mbtnLekarSubmit_Click(object sender, EventArgs e)
        {
            mbtnLekarSubmit.Text = "Učitavanje ...";
            string conStr =
                "server=139.59.132.29;user=djeki;charset=utf8;database=Hippocrates;port=3306;password=volimdoroteju1;";
            MySqlConnection conn = new MySqlConnection(conStr);

            try
            {
                conn.Open();
                string cmdText = 
                    "SELECT PASSWORD FROM IZABRANI_LEKAR WHERE JMBG LIKE '" + mtbxLekarJMBG.Text + "' ;";
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);

                if (mtbxLekarSifra.Text == (string)cmd.ExecuteScalar())
                {
                    /*
                    FormLekar frmLekar = new FormLekar();
                    frmLekar.FormClosing += new FormClosingEventHandler(showThisForm);
                    this.Visible = false;
                    frmLekar.ShowDialog();*/
                    //this.Hide();
                    FormLekar f = new FormLekar(mtbxLekarJMBG.Text);
                    f.ShowDialog();
                   

                    //this.Close();
                }
                else
                {
                    MetroMessageBox.Show(this, "Pogrešan JMBG ili lozinka", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw new Exception("Pogrešan JMBG ili šifra.");
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                mbtnLekarSubmit.Text = "Uloguj se";
            }
        }

        private void showThisForm(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void mbtnOsobljeSubmit_Click(object sender, EventArgs e)
        {
            mbtnOsobljeSubmit.Text = "Učitavanje ...";
            string conStr =
                "server=139.59.132.29;user=djeki;charset=utf8;database=Hippocrates;port=3306;password=volimdoroteju1;";
            MySqlConnection conn = new MySqlConnection(conStr);

            try
            {
                conn.Open();
                string cmdText =
                    "SELECT PASSWORD FROM MEDICINSKO_OSOBLJE WHERE JMBG LIKE '" + mtbxOsobljeJMBG.Text + "' ;";
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);

                if (mtbxOsobljeSifra.Text == (string)cmd.ExecuteScalar())
                {
                    //this.Hide();
                    FormOsoblje f = new FormOsoblje(mtbxOsobljeJMBG.Text);
                    f.ShowDialog();
                   
                    //this.Close();
                }
                else
                {
                    throw new Exception("Pogrešan JMBG ili šifra.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                mbtnOsobljeSubmit.Text = "Uloguj se";
            }
        }

        private void mbtnDirektorSubmit_Click(object sender, EventArgs e)
        {
            mbtnDirektorSubmit.Text = "Učitavanje ...";
            string conStr =
                "server=139.59.132.29;user=aki;charset=utf8;database=Hippocrates;port=3306;password=jetion123c;";
            MySqlConnection conn = new MySqlConnection(conStr);

            try
            {
                conn.Open();
                string cmdText =
                    "SELECT PASSWORD FROM ADMINISTRATOR_DOM_ZDRAVLJA WHERE JMBG LIKE '" + mtbxDirektorJMBG.Text + "' ;";
                MySqlCommand cmd = new MySqlCommand(cmdText, conn);

                if (mtbxDirektorSifra.Text == (string)cmd.ExecuteScalar())
                {
                    //this.Hide();
                    FormDirektor f = new FormDirektor(this.mtbxDirektorJMBG.Text);
                    f.ShowDialog();
                   
                    //this.Close();
                }
                else
                {
                    throw new Exception("Pogrešan JMBG ili šifra.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                mbtnDirektorSubmit.Text = "Uloguj se";
            }
        }

        private void mtbxDirektorJMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (Char.IsControl(e.KeyChar))))
                e.Handled = true;
        }
    }
}
