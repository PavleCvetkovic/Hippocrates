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
using Hippocrates.Data.Entiteti;
using MetroFramework;

namespace HippocratesDoctor
{
    public partial class FormZahteviPacijenata : MetroFramework.Forms.MetroForm
    {
        private ISession session_local;
        private DomZdravlja dom_zdravlja_local = null;
        private IList<ZahtevZaPromenu> zahtevi = null;
        public FormZahteviPacijenata(ISession s, DomZdravlja dz)
        {
            InitializeComponent();
            session_local = s;
            dom_zdravlja_local = dz;
            this.Text = "Zahtevi pacijenata za promenu izabranog lekara";
            GetRequests();
        }

        private void GetRequests()
        {
            metroGridZahtevi.DataSource = null;
            
            IQuery query = session_local.CreateQuery("from ZahtevZaPromenu z where z.ZeljeniLekar.RadiUDomuZdravlja = :dom");
            query.SetParameter("dom", dom_zdravlja_local);
            zahtevi = query.List<ZahtevZaPromenu>();
            if (zahtevi.Count == 0)
            {
                MetroMessageBox.Show(this, "Trenutno nema zahteva", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metroButtonOdbiZahtev.Enabled = false;
                metroButtonOdobriZahtev.Enabled = false;
            }
            else
            {
                metroButtonOdbiZahtev.Enabled = true;
                metroButtonOdobriZahtev.Enabled = true;
            }
            // Id je ostavljen da se prikazuje (cisto mozda zbog preglednosti)

            metroGridZahtevi.DataSource = zahtevi;
            for (int i = 0; i < metroGridZahtevi.ColumnCount; i++)
                metroGridZahtevi.Columns[i].Width = (this.Width - 10) / metroGridZahtevi.ColumnCount;
        }

        // Events

        private void FormZahteviPacijenata_FormClosing(object sender, FormClosingEventArgs e)
        {
            session_local.Flush();
        }

        private void metroButtonOdobriZahtev_Click(object sender, EventArgs e)
        {
            // Promeniti pacijentu izabranog lekara
            ZahtevZaPromenu z = (ZahtevZaPromenu)metroGridZahtevi.SelectedRows[0].DataBoundItem;
            z.ZahtevPacijenta.Lekar = z.ZeljeniLekar;
            try
            {
                session_local.Update(z.ZahtevPacijenta); //pacijentu se u bazi menja Lekar
                zahtevi.Remove(z); // lokalna lista
                session_local.Delete(z); // baza
                session_local.Flush();
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, "Greška prilikom odobravanja zahteva pacijentu " + z.ZahtevPacijenta.ToString() + " " + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MetroMessageBox.Show(this, "Uspešno odobren zahtev za promenu lekara pacijentu " + z.ZahtevPacijenta.ToString(),
                "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetRequests(); // refresh view
        }

        private void metroButtonOdbiZahtev_Click(object sender, EventArgs e)
        {
            // Pacijentu ostaje lekar (samo se zahtev brise iz baze)
            ZahtevZaPromenu z = (ZahtevZaPromenu)metroGridZahtevi.SelectedRows[0].DataBoundItem;
            z.ZahtevPacijenta.Lekar = z.ZeljeniLekar;
            try
            {
                zahtevi.Remove(z); // lokalna lista
                session_local.Delete(z); // baza
                session_local.Flush();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Greška prilikom odbijanja zahteva pacijentu " + z.ZahtevPacijenta.ToString() + " " + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MetroMessageBox.Show(this, "Uspešno odbijen zahtev za promenu lekara pacijentu " + z.ZahtevPacijenta.ToString(),
                "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetRequests(); // refresh view
        }
    }
}
