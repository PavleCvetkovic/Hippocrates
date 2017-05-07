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
        private Pacijent pacijent_local;
        private IzabraniLekar lekar_local;
        private IList<Termin> termin_list; // Local copy
        private ISession session_local;

        public FormRaspored(ISession s, Pacijent pacijent)
        {
            InitializeComponent();
            session_local = s;
            pacijent_local = pacijent;
            lekar_local = pacijent.Lekar;

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

        private Smena GetDoctorShift(IzabraniLekar lekar)
        {
            Smena smena = null;
            foreach (Smena s in lekar.Smene)
                if (s.Id.Datum_Od <= System.DateTime.Now && s.Datum_Do >= System.DateTime.Now)
                {
                    smena = s;
                    break;
                }
            return smena;
        }

        private void RefreshControls(IzabraniLekar lekar)
        {
            UpdateForm(GetDoctorShift(lekar).SmenaLekara);

            //lekar_local.Termini[0].Pacijent
            IQuery query = session_local.CreateQuery("from Termin t where t.Lekar.Jmbg = :lekar and t.Datum = :datum");
            query.SetParameter("lekar", lekar_local.Jmbg);
            query.SetParameter("datum", metroDateTime1.Value.Date);

            IList<Termin> termini_lekara = query.List<Termin>(); // lista svih danasnjih termina zadatog lekara


            #region Reset all buttons
            foreach (Control c in pnlPopodne.Controls)
            {
                MetroButton mb = c as MetroButton;
                if (mb != null)
                {
                    mb.Enabled = true; // svi termini dostupni
                    //mb.BackColor = Color.LightCyan; // LightCyan = Free
                }

            }
            foreach (Control c in pnlPopodne.Controls)
            {
                MetroButton mb = c as MetroButton;
                if (mb != null)
                {
                    mb.Enabled = true; // svi termini dostupni
                    //mb.BackColor = Color.LightCyan; // LightCyan = Free
                }
            }
            #endregion

            foreach (Termin t in termini_lekara)
            {
                int time = t.Vreme;
                //MetroMessageBox.Show(this, "Enter while loop in rdr.Read() " + time.ToString(), "rdr.Read()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (time <= 1330)
                {
                    MetroButton mb = this.pnlPrepodne.Controls["metroButton" + time.ToString()] as MetroButton;
                    if (mb != null)
                    {
                        //mb.Highlight = true;
                        mb.Enabled = false; // ne moze biti kliknuto (zakazan termin)
                        //mb.BackColor = Color.LightGoldenrodYellow; // NOT Free
                        //this.pnlPrepodne.Controls["metroButton" + time.ToString()].Enabled = false;
                    }
                }
                else
                {
                    MetroButton mb = this.pnlPopodne.Controls["metroButton" + time.ToString()] as MetroButton;
                    if (mb != null)
                    {
                        //mb.Highlight = true;
                        mb.Enabled = false;  // ne moze biti kliknuto (zakazan termin)
                        //mb.BackColor = Color.LightGoldenrodYellow; // NOT Free
                        //this.pnlPopodne.Controls["metroButton" + time.ToString()].Enabled = false;
                    }
                }
            }
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
            session_local.Save(temp_termin);
            session_local.Flush(); // to see changes
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
            RefreshControls(pacijent_local.Lekar);
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
                RefreshControls(lekar_local); //Each appointment change refreshed controls
                MetroMessageBox.Show(this, "Info", "Uspešno zakazan termin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MetroMessageBox.Show(this, "Info", "Greška prilikom zakazivanja termina", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FormRaspored_FormClosing(object sender, FormClosingEventArgs e)
        {
            session_local.Flush();
        }
    }
}
