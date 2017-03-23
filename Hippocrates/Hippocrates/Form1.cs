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
        public Form1()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(404, 340);
            this.MinimumSize = new System.Drawing.Size(404, 340);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.ShowDialog();
            this.Close();
        }

    }
}
