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
using MySql.Data.MySqlClient;

namespace Hippocrates
{
    public partial class FormRaspored : MetroForm
    {
        public FormRaspored(string jmbglek)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width,
                Screen.PrimaryScreen.WorkingArea.Height);
            this.MinimumSize = new System.Drawing.Size(698, 365);

            metroDateTime1.MinDate = System.DateTime.Today;
            metroDateTime1.Value = System.DateTime.Now;

            string date = GetDate();

            string conStr =
                "server=139.59.132.29;user=djeki;charset=utf8;database=Hippocrates;port=3306;password=volimdoroteju1;";
            MySqlConnection conn = new MySqlConnection(conStr);
            MySqlDataReader rdr;

            try
            {
                conn.Open();

                string smena = "SELECT SMENA FROM IZABRANI_LEKAR WHERE JMBG = "+ jmbglek;
                MySqlCommand cmdSmena = new MySqlCommand(smena,conn);

                int sm = (int)cmdSmena.ExecuteScalar();
                if (sm == 1)
                {
                    pnlPopodne.Enabled = false;
                    pnlPopodne.Visible = false;
                }
                else
                {
                    pnlPrepodne.Enabled = false;
                    pnlPopodne.Visible = false;
                }

                string command = 
                    "SELECT VREME,MATBRP,NAPOMENA FROM TERMIN WHERE MATBRL LIKE '" + jmbglek + "' AND DATUM = '" + date /*"2017-03-22"*/ + "' ;";

                MySqlCommand cmd = new MySqlCommand(command,conn);              
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Control ctn;
                    int time = rdr.GetInt32(0);
                    if (time < 1330)
                    {
                        ctn = this.pnlPrepodne.Controls["metroButton" + time.ToString()];             
                    }
                    else
                    {
                        ctn = this.pnlPopodne.Controls["metroButton" + time.ToString()];
                    }

                    ctn.Enabled = false;



                }

                rdr.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {                
                conn.Close();
            }
        }

        string GetDate()
        {
            return metroDateTime1.Value.Year.ToString() + "-" + metroDateTime1.Value.Month.ToString() + "-" +
                              metroDateTime1.Value.Day.ToString();
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UpdateForm()
        {
            
        }

        private void metroButton_Click()
        {
            
        }

    }
}
