using Hippocrates;
using Hippocrates.Data.Entiteti;
using Hippocrates.Data.EntitetiOracle;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using HippocratesPatient;

namespace HippocratesDoctor
{
    public partial class FormZakaziKodSpecijaliste : FormRaspored
    {
        private SpecijalistaKC specijalista_local;
        private Pacijent pacijent_local;
        private ISession oracle_session_local, mysql_session_local;

        public FormZakaziKodSpecijaliste(ISession oracle, ISession sql, Pacijent p, SpecijalistaKC skc) : base()
        {
            InitializeComponent();
            oracle_session_local = oracle;
            mysql_session_local = sql;
            pacijent_local = p;
            specijalista_local = skc;
            this.Text = "Zakazivanje kod specijaliste " + skc.Ime + " " + skc.Prezime;
            metroLabelLekarInfo.Text = "Pacijent: " + p.Ime + " " + p.Prezime;
            RefreshControls(specijalista_local);
        }

        private SmenaKC GetDoctorShift(SpecijalistaKC skc)
        {
            SmenaKC smena = null;
            foreach (SmenaKC s in skc.Smene)
                if (s.DatumOd <= metroDateTime1.Value.Date && s.DatumDo >= metroDateTime1.Value.Date)
                {
                    smena = s;
                    break;
                }
            return smena;
        }

        private void RefreshControls(SpecijalistaKC skc)
        {
            SmenaKC s = GetDoctorShift(skc);
            if (s == null)
            {
                MetroMessageBox.Show(this, "Lekaru izabranog pacijenta nije podešena smena za traženi datum, i nije moguće zakazati termin", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateForm(3); // lekaru nije podesena smena
                return;
            }
            int smena_num = 1;
            if (Int32.TryParse(s.TipSmene, out smena_num))
                UpdateForm(smena_num);
            else
                return;

            IQuery query = oracle_session_local.CreateQuery("from Pregled p where p.Specijalista = :spec and p.Datum = :datum");
            query.SetParameter("spec", specijalista_local);
            query.SetParameter("datum", metroDateTime1.Value.Date);

            IList<Pregled> termini_lekara = query.List<Pregled>(); // lista svih danasnjih termina zadatog lekara

            #region Reset all buttons
            foreach (Control c in pnlPopodne.Controls)
            {
                MetroButton mb = c as MetroButton;
                if (mb != null)
                {
                    //mb.Highlight = false;
                    mb.Enabled = true;
                    //mb.BackColor = Color.LightCyan; // LightCyan = Free
                }

            }
            foreach (Control c in pnlPopodne.Controls)
            {
                MetroButton mb = c as MetroButton;
                if (mb != null)
                {
                    // mb.Highlight = false;
                    mb.Enabled = true;
                    //mb.BackColor = Color.LightCyan; // LightCyan = Free
                }
            }
            #endregion

            foreach (Pregled p in termini_lekara)
            {
                int time = p.Vreme;
                //MetroMessageBox.Show(this, "Enter while loop in rdr.Read() " + time.ToString(), "rdr.Read()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (time <= 1330)
                {
                    MetroButton mb = this.pnlPrepodne.Controls["metroButton" + time.ToString()] as MetroButton;
                    if (mb != null)
                        mb.Enabled = false;
                }
                else
                {
                    MetroButton mb = this.pnlPopodne.Controls["metroButton" + time.ToString()] as MetroButton;
                    if (mb != null)
                        mb.Enabled = false;
                }
            }
        }

        private bool MakeAnApointment(int time, string napomena, SpecijalistaKC specijalista_oracle)
        {
            bool success = true;
            //// (MySQL, TerminBolnica)
            //Specijalista spec_mysql = null;
            //IList<Specijalista> lista_specijalista = mysql_session_local.QueryOver<Specijalista>().List<Specijalista>();
            //bool found = false;
            //foreach (Specijalista s in lista_specijalista)
            //{
            //    if (s.Jmbg == specijalista_oracle.JMBG)
            //    {
            //        found = true;
            //        break;
            //    }
            //}
            //if (!found) // Dodaj specijalistu
            //{

            //}
            //TerminBolnica t = new TerminBolnica
            //{
            //    LSpecijalista = specijalista_local,
            //    Pacijent = pacijent_local,
            //    Napomena = napomena,
            //    Datum = metroDateTime1.Value.Date,
            //    Vreme = time
            //};
            //try
            //{

            //    lekar_local.Termini.Add(t);
            //    pacijent_local.Termini.Add(t);

            //    session_local.Update(lekar_local);
            //    session_local.Update(pacijent_local);
            //    session_local.Flush();
            //}
            //catch (Exception ex)
            //{
            //    MetroMessageBox.Show(this, "Greška prilikom zakazivanja termina " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    success = false;
            //}
            //// (Oracle, Pregled)
            return success;
        }

        private void UpdateConsistency()
        {
            // (Oracle, novi DomZdravlja, novi PacijentDomaZdravlja, novi IzabraniLekar)
            // (MySQL, Specijalista)
        }

        // Events 

        protected override void metroButton_Click(object sender, EventArgs e)
        {
            // Specijalista from click .. make appointment .. etc .. 
            // Make appointment
            MetroButton metro_button = (MetroButton)sender;
            //MetroMessageBox.Show(this, "Info", "Button " + metro_button.Text + "is clicked", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string napomena = "Treba da dodam formu za upis napomene"; // Add form
            DialogResult dr = MetroMessageBox.Show(this, "Question", "Da li ste sigurni da želite da zakažete " + 
                metroDateTime1.Value.ToShortDateString() + " " + metro_button.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
           
            if (MakeAnApointment(time, napomena, specijalista_local)) // Replace(string old_string, string new_string) 11:30 -> 1130
            {
                RefreshControls(specijalista_local); //Each appointment change refreshed controls
                MetroMessageBox.Show(this, "Info", "Uspešno zakazan termin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MetroMessageBox.Show(this, "Info", "Greška prilikom zakazivanja termina", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshControls(specijalista_local);
            
        }

       

        protected override void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            RefreshControls(specijalista_local);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            oracle_session_local.Flush();
            mysql_session_local.Flush(); // Za svaki slucaj
        }
    }
}
