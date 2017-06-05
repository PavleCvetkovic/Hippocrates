using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hippocrates.SharedForms
{
    public partial class Napomena_Form : MetroFramework.Forms.MetroForm
    {
        //private string napomena;
        public Napomena_Form()
        {
            InitializeComponent();
            //napomena = string.Empty;
        }

        private void metroButtonOK_Click(object sender, EventArgs e)
        {
            // close form
            this.Close();
        }

        public string GetNote
        {
            get { return metroTextBoxNapomena.Text; }
        }
    }
}
