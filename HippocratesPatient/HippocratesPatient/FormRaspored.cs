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
using MetroFramework;
using MetroFramework.Controls;
using HippocratesPatient;
using Hippocrates.Data.Entiteti;
using NHibernate;
using Hippocrates.Data;

namespace Hippocrates
{
    public partial class FormRaspored : MetroForm
    {
        private string conStr =
                "server=139.59.132.29;user=djeki;charset=utf8;database=Hippocrates;port=3306;password=volimdoroteju1;";
        //private int smena_lekara; // Local copy
        //private string jmbg_lekara; // Local copy
        //private string jmbg_pacijenta;
        private Pacijent pacijent_local;
        private IzabraniLekar lekar_local;
        private IList<Termin> termin_list; // Local copy
        private ISession session;

        public FormRaspored(Pacijent pacijent)
        {
            InitializeComponent();
            pacijent_local = pacijent;
            //this.jmbg_pacijenta = pacijent.Jmbg;
            //this.jmbg_lekara = pacijent.Lekar.Jmbg; 
            //this.WindowState = FormWindowState.Maximized;
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width,
                Screen.PrimaryScreen.WorkingArea.Height);
            this.MinimumSize = new System.Drawing.Size(698, 365);

            metroLabelLekarInfo.Text = "Izabrani lekar: " + pacijent.Lekar.Ime + " " + pacijent.Lekar.Prezime + " " + pacijent.Lekar.Jmbg;
            metroDateTime1.MinDate = System.DateTime.Today;
            metroDateTime1.Value = System.DateTime.Now; // causes event that calls RefreshControls to initialize the controls

            // Binding handler to control
            foreach (Control c in pnlPopodne.Controls)
                c.Click += metroButton_Click;
            foreach (Control c in pnlPrepodne.Controls)
                c.Click += metroButton_Click;

        }

        private void RefreshControls(string jmbglek)
        {
            //int to_return = 1; // prva smena inicijalno

            session = DataLayer.GetSession();
            lekar_local = session.Get<IzabraniLekar>(pacijent_local.Lekar.Jmbg);
            var smena_lekara = session.CreateQuery("select s from Smena s where s.Id.Lekar = '" + lekar_local.Jmbg + 
                "' and s.Id.Datum_Od > '" + metroDateTime1.Value.Date +"'");
            //MetroMessageBox.Show(this, smena_lekara.List<Smena>()[0].Id.Lekar.Ime.ToString());
            IList<Smena> smena_list = smena_lekara.List<Smena>();
            int i = 0, smena_temp = 1; // for error avoid
            for(i = 0; i < smena_list.Count; i++) 
            {
                if (smena_list[i].Id.Datum_Od <= metroDateTime1.Value.Date && smena_list[i].Datum_Do >= metroDateTime1.Value.Date)
                {
                    smena_temp = smena_list[i].SmenaLekara;
                    break;
                }
            }
            UpdateForm(smena_temp);

            //Enable all buttons (later disable the ones with appointments)
            foreach (Control c in pnlPopodne.Controls)
                c.Enabled = true;
            foreach (Control c in pnlPrepodne.Controls)
                c.Enabled = true;

            //DOESN'T WORK OKAY
            try
            {
                // COULD NOT EXECUTE QUERY ?? (WHY, PORQUE ALEXANDRO..????????????????)
                var termin_lekara = session.CreateQuery("select t from Termin t where t.Lekar = '" + lekar_local.Jmbg +
                    "' and t.Pacijent = '" + pacijent_local.Jmbg + /*"' and t.Datum = '" + metroDateTime1.Value.Date + */"'");

                termin_list = termin_lekara.List<Termin>();
                
                foreach (Termin t in termin_list)
                    if (t.Datum == metroDateTime1.Value.Date)
                        if (t.Vreme <= 1330)
                            this.pnlPrepodne.Controls["metroButton" + t.Vreme.ToString()].Enabled = false;
                        else
                            this.pnlPopodne.Controls["metroButton" + t.Vreme.ToString()].Enabled = false;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Greška prilikom učitavanja podataka o zakazanim terminima " + ex.Message);
            }

            #region SQL varijanta

            //MySqlConnection conn = new MySqlConnection(conStr);
            //MySqlDataReader rdr;
            //try
            //{
            //    conn.Open();
            //    string smena = "select SMENA from SMENA  where MATBRL = '" + jmbglek + "'" +
            //        " and '" + GetDate() + "'between DATUM_OD and DATUM_DO; ";
            //    MySqlCommand cmdSmena = new MySqlCommand(smena, conn);

            //    //short smena_byte = (short)cmdSmena.ExecuteScalar();
            //    //smena_lekara = (int)smena_byte;
            //    smena_lekara = (int)cmdSmena.ExecuteScalar();
            //    UpdateForm(smena_lekara); // Panel showing

            //    string command =
            //        "SELECT VREME FROM TERMIN WHERE MATBRL LIKE '" + jmbglek + "' AND DATUM = '" + GetDate() /*"2017-03-22"*/ + "' ;";

            //    MySqlCommand cmd = new MySqlCommand(command, conn);
            //    rdr = cmd.ExecuteReader();

            //    foreach (Control c in pnlPopodne.Controls)
            //        c.Enabled = true;
            //    foreach (Control c in pnlPrepodne.Controls)
            //        c.Enabled = true;

            //    while (rdr.Read())
            //    {
            //        int time = rdr.GetInt32(0);
            //        //MetroMessageBox.Show(this, "Enter while loop in rdr.Read() " + time.ToString(), "rdr.Read()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        if (time <= 1330)
            //            this.pnlPrepodne.Controls["metroButton" + time.ToString()].Enabled = false;
            //        else
            //            this.pnlPopodne.Controls["metroButton" + time.ToString()].Enabled = false;
            //    }
            //    rdr.Close();
            //}
            //catch (Exception ex)
            //{
            //    MetroMessageBox.Show(this, ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    conn.Close();
            //}
            #endregion
        }

        private void UpdateForm(int smena_lek)
        {
            if (smena_lek == 1) // Promenjen Visible na Enable svojstvo 
            {
                metroLabelSmenaLekara.Text = "Prepodne";
                pnlPrepodne.Enabled = true;
                pnlPopodne.Enabled = false;
                //pnlPopodne.Enabled = false;
            }
            else
            {
                metroLabelSmenaLekara.Text = "Poslepodne";
                pnlPrepodne.Enabled = false;
                pnlPopodne.Enabled = true;
                //pnlPrepodne.Enabled = false;
            }
        }

        private string GetDate()
        {
            return metroDateTime1.Value.Year.ToString() + "-" + metroDateTime1.Value.Month.ToString() + "-" +
                              metroDateTime1.Value.Day.ToString();
        }

        private bool MakeAnApointment(string time, string napomena) // time - metroButton name (730, 745, 800 ...)
        {
            bool success = true;
            int time_parse = 0;
            if (!Int32.TryParse(time, out time_parse))
            {
                MetroMessageBox.Show(this, "Greška prilikom učitavanja vremena " + time);
                return false;
            }

            Termin temp_termin = new Termin()
            {
                Lekar = lekar_local,
                Pacijent = pacijent_local,
                Datum = metroDateTime1.Value.Date,
                Vreme = time_parse,
                Napomena = napomena
            };

            //termin_list.Add(temp_termin);
            session.Save(temp_termin);
            session.Flush(); // to see changes
            #region SQL nacin
            //MySqlConnection conn = new MySqlConnection(conStr);
            //try
            //{
            //    conn.Open();

            //    string sql = "INSERT INTO TERMIN VALUES ('" + jmbg_lekara + "','" + jmbg_pacijenta + "','" + GetDate() + "','" + Int32.Parse(time) + "','" + napomena + "')";
            //    MySqlCommand cmd = new MySqlCommand(sql, conn);
            //    cmd.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{
            //    MetroMessageBox.Show(this, ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    success = false;
            //}

            //conn.Close();
            #endregion
            return success;
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            //Each date change refreshes controls
            RefreshControls(pacijent_local.Lekar.Jmbg);
        }
        
        private void metroButton_Click(object sender, EventArgs e)
        {
            MetroButton metro_button = (MetroButton)sender;
            //MetroMessageBox.Show(this, "Info", "Button " + metro_button.Text + "is clicked", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string napomena = "Treba da dodam formu za upis napomene"; // Add form
            DialogResult dr = MetroMessageBox.Show(this, "Question", "Da li ste sigurni da želite da zakažete " + GetDate() + " " + metro_button.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) // Doesn't work okay
                return;

            Napomena_Form nf = new Napomena_Form();
            nf.ShowDialog();
            napomena = nf.GetNote;

            if (MakeAnApointment(metro_button.Text.Replace(":", string.Empty), napomena)) // Replace(string old_string, string new_string) 11:30 -> 1130
            {
                RefreshControls(lekar_local.Jmbg); //Each appointment change refreshed controls
                MetroMessageBox.Show(this, "Info", "Uspešno zakazan termin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MetroMessageBox.Show(this, "Info", "Greška prilikom zakazivanja termina", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FormRaspored_FormClosing(object sender, FormClosingEventArgs e)
        {
            session.Close();
        }
    }
}
