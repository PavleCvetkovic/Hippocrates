using Hippocrates.Data.Entiteti;
using MetroFramework;
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

namespace HippocratesPatient
{
    public partial class FormZakazaniTermini : MetroFramework.Forms.MetroForm
    {
        private ISession session_local;
        private Pacijent pacijent_local;

        public FormZakazaniTermini(ISession s, Pacijent p)
        {
            InitializeComponent();
            session_local = s;
            pacijent_local = p;
            this.Text = "Zakazani termini";
            if (pacijent_local != null)
            {
                GetAppointmentData(pacijent_local);
                SetCancelLabelInfo(SetCancelRight(pacijent_local));
            }
        }

        private void SetCancelLabelInfo(bool b)
        {
            if (SetCancelRight(pacijent_local))
                metroLabelOtkazivanjeInfo.Text = "Klik na dugme otkazuje nadolazeći termin";
            else
                metroLabelOtkazivanjeInfo.Text = "Ne postoje nadolazeći termini koje je moguće otkazati";
        }

        private bool SetCancelRight(Pacijent p)
        {
            bool can_cancel = false;
            metroButtonOtkaziSledeciTermin.Enabled = false;
            if (FindUpcomingAppointment(pacijent_local) != null)
                can_cancel = true;
            return can_cancel;
        }

        private Termin FindUpcomingAppointment(Pacijent p)
        {
            Termin to_return = null;
            foreach (Termin t in p.Termini)
            {
                if (t.Datum >= System.DateTime.Now.Date)
                {
                    metroButtonOtkaziSledeciTermin.Enabled = true;
                    to_return = t;
                    break;
                }
            }
            return to_return;
        }

        private void GetAppointmentData(Pacijent p)
        {
            metroGridZakazaniTermini.DataSource = null;
            IList<Termin> lista_termina = null;
            foreach (Termin t in p.Termini)
                if (t.Datum >= System.DateTime.Now.Date)
                    lista_termina.Add(t);
            //metroGridZakazaniTermini.DataSource = p.Termini;
            metroGridZakazaniTermini.DataSource = lista_termina;
            metroGridZakazaniTermini.Columns["Id"].Visible = false;
            metroGridZakazaniTermini.Columns["Pacijent"].Visible = false;
            for (int i = 0; i < metroGridZakazaniTermini.Columns.Count - 2; i++)
                metroGridZakazaniTermini.Columns[i].Width = metroGridZakazaniTermini.Width / (metroGridZakazaniTermini.Columns.Count - 2);

        }

        private void metroButtonOtkaziSledeciTermin_Click(object sender, EventArgs e)
        {
            Termin t = FindUpcomingAppointment(pacijent_local);
            DialogResult dr = MetroMessageBox.Show(this, "Da li ste sigurni da želite da otkažete nadolazeći termin " + t.Datum.ToShortDateString() + " " + t.Vreme, "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;

            try
            {
                pacijent_local.Termini.Remove(t);
                pacijent_local.Pravo_da_zakaze = 1;
                
                session_local.Delete(t);
                session_local.Save(pacijent_local);
                session_local.Flush();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Greška prilikom otkazivanja termina " + t.Datum.ToShortDateString() + " " + t.Vreme + " " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MetroMessageBox.Show(this, "Uspešno otkazan termin " + t.Datum.ToShortDateString() + " " + t.Vreme, "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetAppointmentData(pacijent_local); // Refresh DGV view
            SetCancelLabelInfo(SetCancelRight(pacijent_local)); // Refresh label and button
        }
    }
}
