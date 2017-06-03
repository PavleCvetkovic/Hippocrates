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

namespace HippocratesDoctor
{
    public partial class FormRaspored : MetroForm
    {
        private ISession session_local;
        private IzabraniLekar lekar_local = null;
        private Pacijent pacijent_local = null;

        public FormRaspored()
        {
            InitializeComponent();
            foreach (Control c in pnlPopodne.Controls)
                c.Click += metroButton_Click;
            foreach (Control c in pnlPrepodne.Controls)
                c.Click += metroButton_Click;

            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width,
                Screen.PrimaryScreen.WorkingArea.Height);
            this.MinimumSize = new System.Drawing.Size(698, 365);
        }

        public FormRaspored(ISession session_passed, IzabraniLekar lekar, Pacijent p) : this()
        {
            //InitializeComponent();
            session_local = session_passed;
            pacijent_local = p;
            lekar_local = lekar;
            //session_local = DataLayer.GetSession();
            
            //this.WindowState = FormWindowState.Maximized;
            //this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width,
            //    Screen.PrimaryScreen.WorkingArea.Height);
            //this.MinimumSize = new System.Drawing.Size(698, 365);

            metroDateTime1.MinDate = System.DateTime.Today;
            metroDateTime1.Value = System.DateTime.Now; // causes event that calls RefreshControls to initialize the controls
            metroLabelLekarInfo.Text = "Izabrani lekar: " + lekar.Ime + " " + lekar.Prezime + " " + lekar.Jmbg;

            // Binding handler to control
            //foreach (Control c in pnlPopodne.Controls)
            //    c.Click += metroButton_Click;
            //foreach (Control c in pnlPrepodne.Controls)
            //    c.Click += metroButton_Click;

        }
        //----------------------------------------------
        //Ovaj konstruktor mi treba za medicinskog radnika i glob Admina (Andrija)
        public FormRaspored(string lekar, string p)
        {
            InitializeComponent();
            session_local = DataLayer.GetSession();
            pacijent_local = session_local.Load<Pacijent>(p);
            lekar_local = session_local.Load<IzabraniLekar>(lekar);

        //    //this.WindowState = FormWindowState.Maximized;
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width,
            Screen.PrimaryScreen.WorkingArea.Height);
            this.MinimumSize = new System.Drawing.Size(698, 365);

            metroDateTime1.MinDate = System.DateTime.Today;
            metroDateTime1.Value = System.DateTime.Now; // causes event that calls RefreshControls to initialize the controls
            metroLabelLekarInfo.Text = "Izabrani lekar: " + lekar_local.Ime + " " + lekar_local.Prezime + " " + lekar_local.Jmbg;

        //    // Binding handler to control
            foreach (Control c in pnlPopodne.Controls)
               c.Click += metroButton_Click;
            foreach (Control c in pnlPrepodne.Controls)
               c.Click += metroButton_Click;

       }

        //----------------------------------------------
        private Smena GetDoctorShift(IzabraniLekar lekar)
        {
            Smena smena = null;
            foreach (Smena s in lekar.Smene)
                if (s.Id.Datum_Od <= metroDateTime1.Value.Date && s.Datum_Do >= metroDateTime1.Value.Date)
                {
                    smena = s;
                    break;
                }
            return smena;
        }

        protected void UpdateForm(int smena_lek)
        {
            metroLabelSmenaLekara.ForeColor = Color.DarkGreen;
            if (smena_lek == 1) // Promenjen Visible na Enable svojstvo 
            {
                metroLabelSmenaLekara.Text = "Prepodne";
                pnlPrepodne.Enabled = true;
                pnlPopodne.Enabled = false;
                return;
            }
            if (smena_lek == 2)
            {
                metroLabelSmenaLekara.Text = "Poslepodne";
                pnlPrepodne.Enabled = false;
                pnlPopodne.Enabled = true;
                return;
            }
            metroLabelSmenaLekara.ForeColor = Color.Red;
            metroLabelSmenaLekara.Text = "Lekaru nije podešena smena za izabrani datum";
            pnlPrepodne.Enabled = false;
            pnlPopodne.Enabled = false;
        }

        private void RefreshControls(IzabraniLekar lekar)
        {
            Smena s = GetDoctorShift(lekar);
            if (s == null)
            {
                MetroMessageBox.Show(this, "Lekaru izabranog pacijenta nije podešena smena za traženi datum, i nije moguće zakazati termin", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateForm(3); // lekaru nije podesena smena
                return;
            }
            UpdateForm(GetDoctorShift(lekar).SmenaLekara);

            IQuery query = session_local.CreateQuery("from Termin t where t.Lekar.Jmbg = :lekar and t.Datum = :datum");
            query.SetParameter("lekar", lekar_local.Jmbg);
            query.SetParameter("datum", metroDateTime1.Value.Date);

            IList<Termin> termini_lekara = query.List<Termin>(); // lista svih danasnjih termina zadatog lekara


            #region Reset all buttons
            foreach (Control c in pnlPrepodne.Controls)
            {
                MetroButton mb = c as MetroButton;
                if (mb != null)
                {
                    mb.Enabled = true;
                }

            }
            foreach (Control c in pnlPopodne.Controls)
            {
                MetroButton mb = c as MetroButton;
                if (mb != null)
                {
                    mb.Enabled = true; 
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
                        mb.Enabled = false; // moze biti kliknutu jer je zakazan termin (postoji pacijent)
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
                        mb.Enabled = false; // moze biti kliknutu jer je zakazan termin (postoji pacijent)
                        //mb.BackColor = Color.LightGoldenrodYellow; // NOT Free
                        //this.pnlPopodne.Controls["metroButton" + time.ToString()].Enabled = false;
                    }
                }
            }
        }

        private string GetDate()
        {
            return metroDateTime1.Value.Year.ToString() + "-" + metroDateTime1.Value.Month.ToString() + "-" +
                              metroDateTime1.Value.Day.ToString();
        }

        private bool MakeAnApointment(int time, string napomena) // time - metroButton name (730, 745, 800 ...)
        {
            bool success = true;
            Termin t = new Termin
            {
                Lekar = lekar_local,
                Pacijent = pacijent_local,
                Napomena = napomena,
                Datum = metroDateTime1.Value.Date,
                Vreme = time
            };
            try
            {
                lekar_local.Termini.Add(t);
                pacijent_local.Termini.Add(t);

                session_local.Update(lekar_local);
                session_local.Update(pacijent_local);
                session_local.Flush();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Greška prilikom zakazivanja termina " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = false;
            }
            return success;
        }

        protected virtual void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            //Each date change refreshes controls
            RefreshControls(lekar_local);
        }

        protected virtual void metroButton_Click(object sender, EventArgs e)
        {
            MetroButton metro_button = (MetroButton)sender;
            //MetroMessageBox.Show(this, "Info", "Button " + metro_button.Text + "is clicked", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string napomena = "Treba da dodam formu za upis napomene"; // Add form
            DialogResult dr = MetroMessageBox.Show(this, "Question", "Da li ste sigurni da želite da zakažete " + GetDate() + " " + metro_button.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;

            Napomena_Form nf = new Napomena_Form();
            nf.ShowDialog();
            napomena = nf.GetNote;

            int time;
            if (Int32.TryParse(metro_button.Text.Replace(":", string.Empty), out time) == false)
            {
                MetroMessageBox.Show(this, "Info", "Error u parsovanju", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MakeAnApointment(time, napomena)) // Replace(string old_string, string new_string) 11:30 -> 1130
            {
                RefreshControls(lekar_local); //Each appointment change refreshed controls
                MetroMessageBox.Show(this, "Info", "Uspešno zakazan termin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MetroMessageBox.Show(this, "Info", "Greška prilikom zakazivanja termina", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshControls(lekar_local);
        }

        protected void FormRaspored_FormClosing(object sender, FormClosingEventArgs e)
        {
            session_local.Flush();
            //session_local.Close();//ja sam ovo zamenio,tj sklonio da je komentar

            // Ti koji si sklonio ovo (budi fin pa se potpisi sledeci put) NikolaCeranic trenutno ovo pise
            // Zasto se "to" ne zatvara:
            // Sessija je prosledjena od strane prethodne forme
            // Jedna sesija se vuce kroz celu aplikaciju (samo jedna)
            // Zato ako se ovde zatvori u prethodnoj formi nije moguce raditi sa objektima (javlja se izuzetak)
        }
    }
}
