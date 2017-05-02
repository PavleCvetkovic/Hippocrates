using Hippocrates;
using Hippocrates.Data;
using Hippocrates.Data.Entiteti;
using HippocratesDoctor;
using MetroFramework;
using MySql.Data.MySqlClient;
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
    public partial class PacijentForm : MetroFramework.Forms.MetroForm//, View.IView
    {
        private Pacijent pacijent_local = null;
        private ISession session_local;
        public PacijentForm(ISession s, Pacijent p)
        {
            InitializeComponent();
            pacijent_local = p;
            session_local = s;
            metroLabel1.Text = pacijent_local.Jmbg + " " + pacijent_local.Lbo;
            UpdateAppointment(pacijent_local.Pravo_da_zakaze);
        }

        private void UpdateAppointment(int priviledge)
        {
            if (priviledge >= 1)
            {
                metroLabelPravoZaZakazivanje.Text = "Imate pravo da zakazete termin";
                metroLabelPravoZaZakazivanje.ForeColor = System.Drawing.Color.Aqua;
                metroLabelPravoZaZakazivanje.BackColor = System.Drawing.Color.Aqua;
                metroButtonZakaziteTermin.Enabled = true;
            }
            else
            {
                metroLabelPravoZaZakazivanje.Text = "Nemate pravo da zakazete termin";
                metroLabelPravoZaZakazivanje.ForeColor = System.Drawing.Color.Red;
                metroButtonZakaziteTermin.Enabled = false;
            }
        }
        private string GetNameAndSurname(Pacijent p)
        {
            return p.Ime + " " + p.Prezime;
        } 

        private string GetDoctorNameAndSurname(Pacijent p)
        {
            if (p.Lekar != null)
                return p.Lekar.Ime + " " + p.Lekar.Prezime;
            else
                return "Pacijent nema izabranog lekara";
        } // Return doctor name and surname from Database
        private void GetTerapijeData(Pacijent pacijent)
        {
            metroGridTerapije.DataSource = pacijent.Terapije;
            for (int i = 0; i < metroGridTerapije.ColumnCount; i++)
                metroGridTerapije.Columns[i].Width = metroGridTerapije.Width / metroGridTerapije.ColumnCount;
        }

        private void GetVakcineData(Pacijent p)
        {
            metrogridVakcine.DataSource = p.PrimioVakcinuVakcine;
            for (int i = 0; i < metrogridVakcine.ColumnCount; i++)
                metrogridVakcine.Columns[i].Width = metrogridVakcine.Width / metrogridVakcine.ColumnCount;
        } // Fill metroDataGrid in Vakcine

        private void GetDijagnozeData(Pacijent pacijent)
        {
            metroGridDijagnoze.DataSource = pacijent.DijagnostifikovanoDijagnoze;

            for (int i = 0; i < metroGridDijagnoze.ColumnCount; i++)
                metroGridDijagnoze.Columns[i].Width = metroGridDijagnoze.Width / metroGridDijagnoze.ColumnCount;
        } // Fill metroDataGrid in Dijagnoze

        private void tabGlobal_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTabControl mtc = sender as MetroFramework.Controls.MetroTabControl;

            //MessageBox.Show("Selected inex changed event" + mtc.SelectedIndex);
            switch(mtc.SelectedIndex)
            {
                case 1: { GetVakcineData(pacijent_local); break; }
                case 2: { GetDijagnozeData(pacijent_local); break; }
                case 3: { GetTerapijeData(pacijent_local); break; }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //MetroMessageBox.Show(this, "This is a message in MetroBox");
            FormRaspored raspored_form = new FormRaspored(session_local ,pacijent_local.Lekar, pacijent_local);
            raspored_form.StartPosition = FormStartPosition.CenterScreen;
            raspored_form.Show();
        }

        private void metroButtonDodajVakcinu_Click(object sender, EventArgs e)
        {
            FormVakcine fv = new FormVakcine(pacijent_local.Jmbg);
            fv.StartPosition = FormStartPosition.CenterScreen;
            fv.ShowDialog();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void metroButtonObrisiVakcinu_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "not implemented");
            //int row_index = metrogridVakcine.CurrentCell.RowIndex;
            //string sifra = metrogridVakcine["SIFRA_VAKCINE", row_index].Value.ToString();
            //ISession session = DataLayer.GetSession();
            //var query = session.CreateQuery("delete from PRIMIO_VAKCINU where JMBGP = :id and SIFRA_VAKCINE = :sifra");
            //query.SetParameter("id", jmbg);
            //query.SetParameter("sifra", sifra);
            //query.ExecuteUpdate();
            //Pacijent active_patient = session.Load<Pacijent>(jmbg);
            //PrimioVakcinu pv = new PrimioVakcinu
            //{
            //    Datum = (DateTime)metrogridVakcine["DATUM", metrogridVakcine.CurrentCell.RowIndex].Value,
            //    Id = new PrimioVakcinuId()
            //    {
            //        PrimioPacijent = active_patient,
            //        PrimioVakcina = new Vakcina()
            //        {
            //            Sifra = 
            //        }
            //    }
            //};
            //int i = 0;
            //for (i = 0; i < active_patient.PrimioVakcinuVakcine.Count; i++)
            //{
            //    if (PrimioVakcinu.Equals(active_patient.PrimioVakcinuVakcine[i], pv))
            //        break; // i 
            //}

            //active_patient.PrimioVakcinuVakcine.RemoveAt(i);
            ////v.PrimioVakcinuPacijenti.Remove(pv);
            //session.Save(active_patient);
            //session.Flush();
            //session.Close();
        }

        private void PacijentForm_Load(object sender, EventArgs e)
        {
            GetVakcineData(pacijent_local);
            GetDijagnozeData(pacijent_local);
            this.Text = GetNameAndSurname(pacijent_local);
            UpdateAppointment(pacijent_local.Pravo_da_zakaze); // UpdateAppointment MORA ISPOD GetNameAndSurname jer se tu vrsi inicijalizacija za "pravo_da_zakaze"
            metrolabInfoLekar.Text = GetDoctorNameAndSurname(pacijent_local);
            metroTabGlobal.SelectedIndex = 0; // Show 'Izabrani Lekar' tab
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //ZahtevZaIzborLekara zahtev_form = new ZahtevZaIzborLekara(jmbg ,GetDoctorNameAndSurname(jmbg_lekara), jmbg_lekara);
            //zahtev_form.StartPosition = FormStartPosition.CenterScreen;
            ////zahtev_form.MdiParent = this; // To make it impossible to NOT focus
            //zahtev_form.Show();
        }
    }
}
