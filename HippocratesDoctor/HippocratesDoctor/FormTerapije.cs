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

namespace HippocratesDoctor
{
    public partial class FormTerapije : MetroFramework.Forms.MetroForm
    {
        private Pacijent pacijent_local;
        private IList<Dijagnostifikovano> dijagnoze_pacijenta;
        private ISession session_local;

        public FormTerapije(ISession s, Pacijent p)
        {
            InitializeComponent();
            session_local = s;
            pacijent_local = p;
        }
       
        private void FormTerapije_Load(object sender, EventArgs e)
        {
            this.Text = "Dodavanje terapije";
            dijagnoze_pacijenta = pacijent_local.DijagnostifikovanoDijagnoze; // sve dijagnoze

            metroGridDijagnoze.DataSource = dijagnoze_pacijenta;
            
            for (int i = 0; i < metroGridDijagnoze.ColumnCount; i++)
                metroGridDijagnoze.Columns[i].Width = metroGridDijagnoze.Width / (metroGridDijagnoze.ColumnCount);
        }

        private void metroButtonDodajTerapiju_Click(object sender, EventArgs e)
        {
            string opis = metroTextBoxOpisTerapije.Text;
            DateTime pocetak = metroDateTimeDatumPocetka.Value.Date;
            DateTime kraj = metroDateTimeDatumKraja.Value.Date;
            Dijagnostifikovano d = (Dijagnostifikovano) metroGridDijagnoze.SelectedRows[0].DataBoundItem;
            Dijagnoza dijagnoza =  null;

            foreach (Dijagnostifikovano dd in pacijent_local.DijagnostifikovanoDijagnoze) // nadji dijagnozu
                if (dd.Id.DijagnozaDijagnoza == d.Id.DijagnozaDijagnoza)
                    dijagnoza = d.Id.DijagnozaDijagnoza;

            Terapija t = new Terapija()
            {
                Opis = opis,
                Datum_od = pocetak,
                Datum_do = kraj,
                TerapijaPacijent = pacijent_local,
                TerapijaLekar = pacijent_local.Lekar,
                TerapijaDijagnoza = dijagnoza
            };

            pacijent_local.Terapije.Add(t);
            try
            {
                session_local.Save(pacijent_local);
                session_local.Flush();
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, "Greška prilikom dodavanja terapije " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MetroMessageBox.Show(this, "Uspešno dodata terapija", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormTerapije_FormClosing(object sender, FormClosingEventArgs e)
        {
            session_local.Flush();
        }
    }
}
