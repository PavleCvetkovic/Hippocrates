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
    public partial class Form1 : MetroForm
    {
        private string connstr;
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(404, 340);
            this.MinimumSize = new System.Drawing.Size(404, 340);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            connstr = "server=pavlecvetkovic.me; user=aki;charset=utf8;database=Hippocrates;port=3306;password=jetion123c;";
            conn = new MySqlConnection(connstr);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try {
                conn.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM ADMINISTRATOR WHERE USERNAME='" + tb_username.Text + "'", conn);
                MySqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    if (tb_pass.Text == dr.GetString("PASSWORD"))
                    {
                        conn.Close();
                        this.Hide();
                        Form2 f = new Form2();
                        f.ShowDialog();
                        this.Close();
                    }

                    else
                    {
                        conn.Close();
                        MessageBox.Show("Pogresno ste uneli password,pokusajte ponovo!");
                        tb_pass.Text = string.Empty;

                    }
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Pogresno ste uneli username,pokusajte ponovo!");
                    tb_pass.Text = string.Empty;
                    tb_username.Text = string.Empty;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Postoji problem u konekciji,proverite internet.");
            }
        }
       
    }
}
