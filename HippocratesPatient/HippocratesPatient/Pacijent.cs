using Hippocrates;
using Hippocrates.Data;
using Hippocrates.Data.Entiteti;
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
        //private string jmbg_pacijenta, jmbg_lekara;
       // private string puno_ime;
        private Pacijent pacijent;
        private ISession session;
        //private int pravo_da_zakaze;
        //private byte pravo_da_zakaze;
        //private string connection = "server=139.59.132.29;user=paja;charset=utf8;database=Hippocrates;port=3306;password=pajapro1234;protocol=TCP";
        //private MySqlDataAdapter daCountry;
        //private DataSet dsCountry;
        public PacijentForm(string jmbg, string lbo)
        {
            InitializeComponent();
            LoadPatientData(jmbg); // using ORM
            metroTabGlobal.SelectedIndex = 0; // Show 'Izabrani Lekar' tab
            this.Text = pacijent.Ime + " " + pacijent.Prezime;
            metrolabInfoLekar.Text = pacijent.Lekar.Ime + " " + pacijent.Lekar.Prezime;
            metroLabelJMBGLBO.Text = pacijent.Jmbg + " " + pacijent.Lbo;

            UpdateAppointment(pacijent.Pravo_da_zakaze);
        }

        private void LoadPatientData(string jmbg_pacijenta)
        {
            try
            {
                session = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                pacijent = session.Load<Pacijent>(jmbg_pacijenta);

                //MessageBox.Show(p.Naziv);

                //s.Close();
            }
            catch (Exception ec)
            {
                MetroMessageBox.Show(this, "Greška prilikom učitavanja podataka o pacijentu iz baze " + ec.Message);
            }
        }

        private void UpdateAppointment(int priviledge)
        {
            if (priviledge >= 1)
            {
                metroLabelPravoZaZakazivanje.Text = "Imate pravo da zakazete termin";
                metroLabelPravoZaZakazivanje.UseCustomForeColor = true;
                metroLabelPravoZaZakazivanje.ForeColor = System.Drawing.Color.Aqua;
                metroLabelPravoZaZakazivanje.BackColor = System.Drawing.Color.Aqua;
                metroButtonZakaziteTermin.Enabled = true;
            }
            else
            {
                metroLabelPravoZaZakazivanje.Text = "Nemate pravo da zakazete termin";
                metroLabelPravoZaZakazivanje.UseCustomForeColor = true;
                metroLabelPravoZaZakazivanje.ForeColor = System.Drawing.Color.Red;
                metroButtonZakaziteTermin.Enabled = false;
            }
        }

        private void GetTerapijeData(Pacijent pacijent)
        {
            metroGridTerapije.DataSource = null;
            metroGridTerapije.DataSource = pacijent.Terapije;
            metroGridTerapije.Columns["Id"].Visible = false;
            metroGridTerapije.Columns["TerapijaPacijent"].Visible = false;
            metroGridTerapije.Columns["TerapijaLekar"].Visible = false;

            for (int i = 0; i < metroGridTerapije.ColumnCount; i++)
                metroGridTerapije.Columns[i].Width = metroGridTerapije.Width / (metroGridTerapije.ColumnCount - 3);
        } // Fill metroDatagrid in Terapije

        private void GetVakcineData(Pacijent p)
        {
            metrogridVakcine.DataSource = null;
            metrogridVakcine.DataSource = p.PrimioVakcinuVakcine;
            for (int i = 0; i < metrogridVakcine.ColumnCount; i++)
                metrogridVakcine.Columns[i].Width = metrogridVakcine.Width / metrogridVakcine.ColumnCount;
        } // Fill metroDataGrid in Vakcine

        private void GetDijagnozeData(Pacijent pacijent)
        {
            metroGridDijagnoze.DataSource = null;
            metroGridDijagnoze.DataSource = pacijent.DijagnostifikovanoDijagnoze;

            for (int i = 0; i < metroGridDijagnoze.ColumnCount; i++)
                metroGridDijagnoze.Columns[i].Width = metroGridDijagnoze.Width / metroGridDijagnoze.ColumnCount;
        } // Fill metroDataGrid in Dijagnoze

        private void GetContactInfo(Pacijent pacijent)
        {
            metroTextBoxEmail.Text = pacijent.Email;
            metroTextBoxTelefon.Text = pacijent.Telefon;
        }// Fill textBoxes in "Kontakt" tab

        // Events

        private void tabGlobal_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTabControl mtc = sender as MetroFramework.Controls.MetroTabControl;

            //MessageBox.Show("Selected inex changed event" + mtc.SelectedIndex);
            switch(mtc.SelectedTab.Text)
            {
                case "Vakcine" : { GetVakcineData(pacijent); break; }
                case "Dijagnoze" : { GetDijagnozeData(pacijent); break; }
                case "Terapije": { GetTerapijeData(pacijent); break; }
                case "Kontakt": { GetContactInfo(pacijent); break; }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //MetroMessageBox.Show(this, "This is a message in MetroBox");
            if (pacijent.Pravo_da_zakaze == 0)
            {
                MetroMessageBox.Show(this, "Nemate pravo da zakažete termin. Vaš lekar još uvek nije ubeležio Vaš prethodni dolazak", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormRaspored raspored_form = new FormRaspored(session, pacijent);
            raspored_form.StartPosition = FormStartPosition.CenterScreen;
            raspored_form.ShowDialog();
        }

        private void PacijentForm_Load(object sender, EventArgs e)
        {
            //this.Text = GetNameAndSurname(jmbg_pacijenta, lbo);
            //UpdateAppointment(pravo_da_zakaze); // UpdateAppointment MORA ISPOD GetNameAndSurname jer se tu vrsi inicijalizacija za "pravo_da_zakaze"
            //metrolabInfoLekar.Text = GetDoctorNameAndSurname(jmbg_lekara);
            //metroTabGlobal.SelectedIndex = 0; // Show 'Izabrani Lekar' tab
        }

        private void PacijentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            session.Save(pacijent); // just in case
            session.Close();
        }

        private void metroButtonSacuvajKontakt_Click(object sender, EventArgs e)
        {
            pacijent.Email = metroTextBoxEmail.Text;
            pacijent.Telefon = metroTextBoxTelefon.Text;
            try
            {
                session.Save(pacijent);
                session.Flush();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Greška prilikom čuvanja podataka " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MetroMessageBox.Show(this, "Uspešno sačuvane kontaktne informacije", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroTextBoxTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ZahtevZaIzborLekara zahtev_form = new ZahtevZaIzborLekara(session, pacijent);
            zahtev_form.StartPosition = FormStartPosition.CenterScreen;
            //zahtev_form.MdiParent = this; // To make it impossible to NOT focus
            zahtev_form.ShowDialog();
        }
    }
}
