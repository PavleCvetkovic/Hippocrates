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
                metroLabelPravoZaZakazivanje.ForeColor = System.Drawing.Color.Green;
                //metroLabelPravoZaZakazivanje.BackColor = System.Drawing.Color.Aqua;
                metroButtonZakaziteTermin.Enabled = true;
            }
            else
            {
                metroLabelPravoZaZakazivanje.Text = "Nemate pravo da zakazete termin";
                metroLabelPravoZaZakazivanje.ForeColor = System.Drawing.Color.Red;
                metroButtonZakaziteTermin.Enabled = false;
            }
        } // Update pravo_za_zakazivanje

        private string GetNameAndSurname(Pacijent p)
        {
            return p.Ime + " " + p.Prezime;
        } // Return patient name + surname

        private string GetDoctorNameAndSurname(Pacijent p)
        {
            if (p.Lekar != null)
                return p.Lekar.Ime + " " + p.Lekar.Prezime;
            else
                return "Pacijent nema izabranog lekara";
        } // Return doctor name and surname from Database

        private void GetTerapijeData(Pacijent pacijent)
        {
            metroGridTerapije.DataSource = null;
            metroGridTerapije.DataSource = new
                BindingList<Terapija>(pacijent.Terapije.ToList<Terapija>());
            metroGridTerapije.Columns["Id"].Visible = false;
            metroGridTerapije.Columns["TerapijaPacijent"].Visible = false;
            metroGridTerapije.Columns["TerapijaLekar"].Visible = false;

            for (int i = 0; i < metroGridTerapije.ColumnCount; i++)
                metroGridTerapije.Columns[i].Width = metroGridTerapije.Width / (metroGridTerapije.ColumnCount - 3);
        } // Fill metroDatagrid in Terapije

        private void GetVakcineData(Pacijent p)
        {
            metrogridVakcine.DataSource = null;
            metrogridVakcine.DataSource = new
                BindingList<PrimioVakcinu>(p.PrimioVakcinuVakcine.ToList<PrimioVakcinu>());
            for (int i = 0; i < metrogridVakcine.ColumnCount; i++)
                metrogridVakcine.Columns[i].Width = metrogridVakcine.Width / metrogridVakcine.ColumnCount;
        } // Fill metroDataGrid in Vakcine

        private void GetDijagnozeData(Pacijent pacijent)
        {
            metroGridDijagnoze.DataSource = null;
            metroGridDijagnoze.DataSource =
                new BindingList<Dijagnostifikovano>(pacijent.DijagnostifikovanoDijagnoze.ToList<Dijagnostifikovano>()); // omogucava dinamicko brisanje iz DGV-a


            for (int i = 0; i < metroGridDijagnoze.ColumnCount; i++)
                metroGridDijagnoze.Columns[i].Width = metroGridDijagnoze.Width / metroGridDijagnoze.ColumnCount;
        } // Fill metroDataGrid in Dijagnoze

        // Events

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
            if (pacijent_local.Lekar == null)
            {
                MetroMessageBox.Show(this, "Izabrani pacijent nema izabranog lekara, i nije moguće zakazati termin", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            FormRaspored raspored_form = new FormRaspored(session_local , pacijent_local.Lekar, pacijent_local);
            raspored_form.StartPosition = FormStartPosition.CenterScreen;
            raspored_form.ShowDialog();
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

        private void metroButtonDodajVakcinu_Click(object sender, EventArgs e)
        {
            FormVakcine fv = new FormVakcine(session_local, pacijent_local);
            fv.StartPosition = FormStartPosition.CenterScreen;
            fv.ShowDialog();
            GetVakcineData(pacijent_local); // nakon dodavanja se osvezava pogled
        }

        private void metroButtonObrisiVakcinu_Click(object sender, EventArgs e)
        {
            if (metrogridVakcine.Rows.Count == 0)
            {
                MetroMessageBox.Show(this, "Ne postoje vakcine koje je moguće obrisati", "Warning!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrimioVakcinu pv = (PrimioVakcinu)metrogridVakcine.SelectedRows[0].DataBoundItem;
            metrogridVakcine.Rows.RemoveAt(metrogridVakcine.SelectedRows[0].Index);

            pacijent_local.PrimioVakcinuVakcine.Remove(pv);
            try
            {
                session_local.Delete(pv);
                session_local.Save(pacijent_local); // NE RADI KAKO TREBA 
                session_local.Flush();
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, "Greška prilikom brisanja vakcine " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //GetVakcineData(pacijent_local);
        }

        private void metroButtonDodajDijagnozu_Click(object sender, EventArgs e)
        {
            FormDijagnoze fv = new FormDijagnoze(session_local, pacijent_local);
            fv.StartPosition = FormStartPosition.CenterScreen;
            fv.ShowDialog();
            GetDijagnozeData(pacijent_local); // nakon dodavanja se osvezava pogled
        }

        private void metroButtonObrisiDijagnozu_Click(object sender, EventArgs e)
        {
            if (metroGridDijagnoze.Rows.Count == 0)
            {
                MetroMessageBox.Show(this, "Ne postoje dijagnoze koje je moguće obrisati", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Dijagnostifikovano d = (Dijagnostifikovano)metroGridDijagnoze.SelectedRows[0].DataBoundItem;
            metroGridDijagnoze.Rows.RemoveAt(metroGridDijagnoze.SelectedRows[0].Index);

            pacijent_local.DijagnostifikovanoDijagnoze.Remove(d);
            try
            {
                session_local.Delete(d);
                session_local.Save(pacijent_local); 
                session_local.Flush();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Greška prilikom brisanja dijagnoze " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //metroGridDijagnoze.Refresh();

            //GetVakcineData(pacijent_local); // nije potrebno
        }

        private void metroButtonDodajTerapiju_Click(object sender, EventArgs e)
        {
            FormTerapije fv = new FormTerapije(session_local, pacijent_local);
            fv.StartPosition = FormStartPosition.CenterScreen;
            fv.ShowDialog();
            GetTerapijeData(pacijent_local); // nakon dodavanja se osvezava pogled
        }

        private void metroButtonObrisiTerapiju_Click(object sender, EventArgs e)
        {
            if (metroGridTerapije.Rows.Count == 0)
            {
                MetroMessageBox.Show(this, "Ne postoje terapije koje je moguće obrisati", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Terapija t = (Terapija)metroGridTerapije.SelectedRows[0].DataBoundItem;
            metroGridTerapije.Rows.RemoveAt(metroGridTerapije.SelectedRows[0].Index);

            pacijent_local.Terapije.Remove(t);
            try
            {
                session_local.Delete(t);
                session_local.Flush();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Greška prilikom brisanja terapije " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //GetTerapijeData(pacijent_local); 
            //metroGridTerapije.DataSource = null;
            //metroGridTerapije.DataSource = pacijent_local.Terapije;

        }
    }
}
