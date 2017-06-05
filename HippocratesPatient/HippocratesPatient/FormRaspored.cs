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
using System.Net;
using System.Net.Mail;

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
           // this.MinimumSize = new System.Drawing.Size(698, 365);

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
                if (s.Id.Datum_Od <= metroDateTime1.Value.Date && s.Datum_Do >= metroDateTime1.Value.Date)
                {
                    smena = s;
                    break;
                }
            return smena;
        }

        private void RefreshControls(IzabraniLekar lekar)
        {
            Smena s = GetDoctorShift(lekar);
            if (s == null)
                UpdateForm(3);
            else
                UpdateForm(s.SmenaLekara);

            IQuery query = session_local.CreateQuery("from Termin t where t.Lekar.Jmbg = :lekar and t.Datum = :datum");
            query.SetParameter("lekar", lekar_local.Jmbg);
            query.SetParameter("datum", metroDateTime1.Value.Date);

            IList<Termin> termini_lekara = query.List<Termin>(); // lista svih danasnjih termina zadatog lekara


            #region Reset all buttons

            foreach (Control c in pnlPrepodne.Controls)
            {
                MetroButton mb = c as MetroButton;
                int time = Int32.Parse(System.DateTime.Now.ToShortTimeString().Replace(".", String.Empty));
                // ShortTimeString (example 14.16)

                if (mb != null)
                {
                    mb.Enabled = true; // svi termini dostupni
                    if (metroDateTime1.Value.Date == System.DateTime.Now.Date &&
                        s.SmenaLekara == 1 && 
                        Int32.Parse(mb.Text.Replace(":", String.Empty)) <= (time + 100)) // sledeci sat
                    {
                        mb.Enabled = false;
                    }
                }

            }
            foreach (Control c in pnlPopodne.Controls)
            {
                MetroButton mb = c as MetroButton;
                int time = Int32.Parse(System.DateTime.Now.ToShortTimeString().Replace(".", String.Empty));

                if (mb != null)
                {
                    mb.Enabled = true; // svi termini dostupni
                    if (metroDateTime1.Value.Date == System.DateTime.Now.Date &&
                        s.SmenaLekara == 2 &&
                        Int32.Parse(mb.Text.Replace(":", String.Empty)) <= (time + 100))
                    {
                        mb.Enabled = false;
                    }
                    //mb.BackColor = Color.LightCyan; // LightCyan = Free
                }
            }
            #endregion

            foreach (Termin t in termini_lekara)
            {
                int time = t.Vreme;
                if (time <= 1330)
                {
                    MetroButton mb = this.pnlPrepodne.Controls["metroButton" + time.ToString()] as MetroButton;
                    if (mb != null)
                    {
                        mb.Enabled = false; 
                    }
                }
                else
                {
                    MetroButton mb = this.pnlPopodne.Controls["metroButton" + time.ToString()] as MetroButton;
                    if (mb != null)
                    {
                        mb.Enabled = false;  
                    }
                }
            }
        }

        private void UpdateForm(int smena_lek)
        {
            metroLabelSmenaLekara.ForeColor = Color.DarkGreen;
            if (smena_lek == 1) // Promenjen Visible na Enable svojstvo 
            {
                metroLabelSmenaLekara.Text = "Prepodne";
                pnlPrepodne.Enabled = true;
                pnlPopodne.Enabled = false;
                return;
                //pnlPopodne.Enabled = false;
            }
            if (smena_lek == 2)
            {
                metroLabelSmenaLekara.Text = "Poslepodne";
                pnlPrepodne.Enabled = false;
                pnlPopodne.Enabled = true;
                return;
                //pnlPrepodne.Enabled = false;
            }
            metroLabelSmenaLekara.Text = "Nije određena smena lekara za traženi datum";
            metroLabelSmenaLekara.ForeColor = Color.Red;
            pnlPrepodne.Enabled = false;
            pnlPopodne.Enabled = false;
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
            pacijent_local.Pravo_da_zakaze = 0; // nema vise prava za zakazivanje
            session_local.Save(temp_termin);
            session_local.Update(pacijent_local);
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

        public bool SendEmailConfirmation(string termin_time, string termin_date)
        {
            // 587 port, smtp.gmail.com, tls (secure)
            bool success = true;
            if (pacijent_local.Email == null) // 
            {
                MetroMessageBox.Show(this, "Niste podesili e-mail. Potvrda o zakazanom terminu nije poslata", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var fromAddress = new MailAddress("mshippocrates@gmail.com", "MS Hippocrates");
            var toAddress = new MailAddress(pacijent_local.Email, pacijent_local.Ime + " " + pacijent_local.Prezime);

            
            const string fromPassword = "morfijum";
            const string subject = "Hippocrates sistem - Potvrda o zakazanom terminu";
            string body = "Uspešno ste zakazali termin kod lekara " + lekar_local.Ime + " " + lekar_local.Prezime + ".\n\n"
                + "Zakazani termin je: " + termin_time + " " + termin_date + "\n" + "Molimo da ispoštujete zakazani termin ili" +
                " blagovremeno otkažete isti. U slučaju nepoštovanja i ne dolaska na termin gubite pravo na mogućnost zakazivanja" +
                " termina." + "\n\n" + "Hippocrates sistem © MorphineSurgeons\n" +
                "admin@pavlecvetkovic.me \n" +
                "www.pavlecvetkovic.me\n" +
                "Ovo je automatski generisana poruka, molimo Vas da ne odgovarate na ovaj e-mail.";
            
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                try
                {
                    smtp.Send(message);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Greška prilikom slanja e-mail za potvrdu zakazanog termina " + ex.Message, "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    success = false;
                }
            }
            return success;
        }

        ////////// Events

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            //Each date change refreshes controls
            RefreshControls(pacijent_local.Lekar);
        }
        
        private void metroButton_Click(object sender, EventArgs e)
        {
            MetroButton metro_button = (MetroButton)sender;
            RefreshControls(lekar_local); // Za slucaj da je neko u medjuvremenu zakazao zeljeni termin
            if (metro_button.Enabled == false)
            {
                MetroMessageBox.Show(this, "Željeni termin je u međuvremenu popunjen. Molimo izaberite drugi termin", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            if (pacijent_local.Pravo_da_zakaze == 0)
            {
                MetroMessageBox.Show(this, "Nemate pravo da zakažete termin. Vaš lekar još uvek nije ubeležio Vaš prethodni dolazak", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //MetroMessageBox.Show(this, "Info", "Button " + metro_button.Text + "is clicked", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string napomena = "Treba da dodam formu za upis napomene"; // Add form
            DialogResult dr = MetroMessageBox.Show(this, "Question", "Da li ste sigurni da želite da zakažete " + GetDate() + " " + metro_button.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;

            Napomena_Form nf = new Napomena_Form();
            nf.ShowDialog();
            napomena = nf.GetNote;

            if (MakeAnApointment(metro_button.Text.Replace(":", string.Empty), napomena)) // Replace(string old_string, string new_string) 11:30 -> 1130
            {
                RefreshControls(lekar_local); //Each appointment change refreshed controls
                MetroMessageBox.Show(this, "Info", "Uspešno zakazan termin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (SendEmailConfirmation(metro_button.Text, metroDateTime1.Value.Date.ToShortDateString()))
                {
                    MetroMessageBox.Show(this, "Info", "Uspešno poslat e-mail za potvrdu zakazanog termina", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MetroMessageBox.Show(this, "Info", "Greška prilikom slanja e-mail za potvrdu zakazanog termina", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MetroMessageBox.Show(this, "Info", "Greška prilikom zakazivanja termina", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void FormRaspored_FormClosing(object sender, FormClosingEventArgs e)
        {
            session_local.Flush();
        }
    }
}
