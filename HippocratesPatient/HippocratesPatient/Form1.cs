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
using Hippocrates.Data;
using HippocratesPatient.Controller;
using MetroFramework;
using System.Net;

namespace HippocratesPatient
{
    public partial class Form1 : MetroForm, View.IView
    {
        IController controller;

        public Form1()
        {
            InitializeComponent();  
        }

        public void AddListener(IController ic)
        {
            controller = ic;
        }

        public string GetJMBG()
        {
            return metroTextBox1.Text;
        }

        public string GetLBO()
        {
            return metroTextBox2.Text;
        }

        public void Message(string s)
        {
            //MetroMessageBox
            //MetroMessageBox.Show(this, s, "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //StandardMessageBox
            //MessageBox.Show(s, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (!CheckForInternetConnection())
            {
                MetroMessageBox.Show(this, "Nije dostupna internet konekcija. Molimo pokušajte nakon uspostavljanja " +
                    "internet konekcije.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            metroButton1.Text = "Učitavanje u toku...";

            controller.OnLogin();
            metroButton1.Text = "Uloguj se";

            //MetroMessageBox.Show(this, s, "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //controller.OnSuccessfulConnection(); // OnSuccessfulConnection is called in OnLogin function
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
