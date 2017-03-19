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

        public string getJMBG()
        {
            return metroTextBox1.Text;
        }

        public string getLBO()
        {
            return metroTextBox2.Text;
        }

        public void Message(string s)
        {
            MessageBox.Show(s, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            controller.OnLogin();
        }
    }
}
