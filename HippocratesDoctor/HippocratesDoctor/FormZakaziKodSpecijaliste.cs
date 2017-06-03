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
            int smena_num = -1;
            if (Int32.TryParse(s.TipSmene, out smena_num))
                UpdateForm(smena_num);
            else
                return;

            /*IQuery query = oracle_session_local.CreateQuery("from Pregled p where p.Specijalista = :spec and p.Datum = :datum");
            query.SetParameter("spec", specijalista_local);
            query.SetParameter("datum", metroDateTime1.Value.Date);*/


            IList<Pregled> termini_lekara = specijalista_local.Pregledi.ToList<Pregled>();
            IList<Pregled> zauzetitermini = new List<Pregled>();
            foreach(Pregled preg in termini_lekara)
            {
                if (preg.Datum.Date == metroDateTime1.Value.Date)
                    zauzetitermini.Add(preg);
            }

            /*#region Reset all buttons
            foreach (Control c in pnlPrepodne.Controls)
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
            #endregion*/
            int[] termini = { 700, 745, 830, 915, 1000, 1045, 1130, 1215, 1300, 1330, 1415, 1500, 1545, 1630, 1715, 1800, 1845 };
            foreach(int ter in termini)
            {
                if (ter <= 1330)
                {
                    MetroButton mb = this.pnlPrepodne.Controls["metroButton" + ter.ToString()] as MetroButton;
                    if (mb != null)
                        mb.Enabled = true;
                }
                else
                {
                    MetroButton mb = this.pnlPopodne.Controls["metroButton" + ter.ToString()] as MetroButton;
                    if (mb != null)
                        mb.Enabled = true;
                }
            }

            foreach (Pregled p in zauzetitermini)
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
            IList<Pregled> zakazaniPregledi = oracle_session_local.QueryOver<Pregled>().List<Pregled>();
            foreach(Pregled p in zakazaniPregledi)
            {
                if (p.Datum.Date == metroDateTime1.Value.Date && p.Vreme == time)
                    return false; //zakazan u medjuvremenu
            }
            PacijentKlinickogCentra pkc = oracle_session_local.QueryOver<PacijentKlinickogCentra>().Where(x => x.JMBG == pacijent_local.Jmbg).SingleOrDefault<PacijentKlinickogCentra>();
            if (pkc == null) //nema ga pacijent u evidenciji KC, treba da se unese
            {
                DomZdravljaOracle dz = new DomZdravljaOracle()
                {
                    Mbr = pacijent_local.Lekar.RadiUDomuZdravlja.Mbr,
                    Adresa = pacijent_local.Lekar.RadiUDomuZdravlja.Adresa,
                    Ime = pacijent_local.Lekar.RadiUDomuZdravlja.Ime,
                    Lokacija = pacijent_local.Lekar.RadiUDomuZdravlja.Lokacija,
                    Opstina = pacijent_local.Lekar.RadiUDomuZdravlja.Opstina
                };
                IzabraniLekarOracle il = new IzabraniLekarOracle()
                {
                    Jmbg = pacijent_local.Lekar.Jmbg,
                    Adresa = "/",
                    DatumRodjenja = pacijent_local.Lekar.Datum_rodjenja,
                    Ime = pacijent_local.Lekar.Ime,
                    DomZdravlja = dz,
                    Prezime = pacijent_local.Lekar.Prezime,
                    Password="/"
                };
                dz.Lekari.Add(il);
                oracle_session_local.SaveOrUpdate(dz);
                oracle_session_local.Flush(); //snimljeni DZ i IL u ORACLE
                PacijentKlinickogCentra pkdodaj = new PacijentKlinickogCentra()
                {
                    Adresa = "/",
                    BracniStatus = "/",
                    DatumRodjenja = pacijent_local.Datum_rodjenja,
                    Ime = pacijent_local.Ime,
                    JMBG = pacijent_local.Jmbg,
                    Pol = "/",
                    Prezime = pacijent_local.Prezime
                };
                Pregled pregled = new Pregled()
                {
                    Datum = metroDateTime1.Value,
                    IdIzabranogLekara = il.Jmbg,
                    Pacijent = pkdodaj,
                    Prostorija = specijalista_local.BrojOrdinacije,
                    Specijalista = specijalista_local,
                    Vreme = time
                };
                oracle_session_local.Save(pkdodaj);
                oracle_session_local.Flush();
                oracle_session_local.Save(pregled);
                oracle_session_local.Flush();
            }
            else
            {
                IzabraniLekarOracle il = oracle_session_local.QueryOver<IzabraniLekarOracle>().Where(x => x.Jmbg == pacijent_local.Lekar.Jmbg).SingleOrDefault<IzabraniLekarOracle>();
                if (il == null)
                {
                    DomZdravljaOracle dz = new DomZdravljaOracle()
                    {
                        Mbr = pacijent_local.Lekar.RadiUDomuZdravlja.Mbr,
                        Adresa = pacijent_local.Lekar.RadiUDomuZdravlja.Adresa,
                        Ime = pacijent_local.Lekar.RadiUDomuZdravlja.Ime,
                        Lokacija = pacijent_local.Lekar.RadiUDomuZdravlja.Lokacija,
                        Opstina = pacijent_local.Lekar.RadiUDomuZdravlja.Opstina
                    };
                    IzabraniLekarOracle iz = new IzabraniLekarOracle()
                    {
                        Jmbg = pacijent_local.Lekar.Jmbg,
                        Adresa = "/",
                        DatumRodjenja = pacijent_local.Lekar.Datum_rodjenja,
                        Ime = pacijent_local.Lekar.Ime,
                        DomZdravlja = dz,
                        Prezime = pacijent_local.Lekar.Prezime
                    };
                    dz.Lekari.Add(iz);
                    oracle_session_local.SaveOrUpdate(dz);
                    oracle_session_local.Flush();
                }
                
                Pregled pregled = new Pregled()
                {
                    Datum = metroDateTime1.Value,
                    IdIzabranogLekara = il.Jmbg,
                    Pacijent = pkc,
                    Prostorija = specijalista_local.BrojOrdinacije,
                    Specijalista = specijalista_local,
                    Vreme = time
                };
                oracle_session_local.Save(pregled);
                oracle_session_local.Flush();
            }
            //termini i bolnica
            Bolnica b = new Bolnica()
            {
                Mbr = specijalista_local.Klinika.Id.ToString(),
                Ime = specijalista_local.Klinika.Naziv,
                Adresa = specijalista_local.Klinika.Lokacija,
                Opstina = "/",
                Lokacija = "/",
            };
           
            Specijalista spec = new Specijalista()
            {
                Ime = specijalista_local.Ime,
                Datum_rodjenja = specijalista_local.DatumRodjenja,
                Jmbg = specijalista_local.JMBG,
                Prezime = specijalista_local.Prezime,
                Srednje_slovo = "/",
                Titula = "/",
            };
            if (mysql_session_local.Get<Bolnica>(specijalista_local.Klinika.Id.ToString()) == null) // ne postoji bolnica sa tim ID-om
            {
                if (!b.Specijaliste.Contains(spec))
                    b.Specijaliste.Add(spec);
                spec.RadiUBolnici = b;
                mysql_session_local.SaveOrUpdate(b);
                mysql_session_local.Flush();
            }
            TerminBolnica t = new TerminBolnica()
            {
                LSpecijalista=spec,
                Datum = metroDateTime1.Value,
                Napomena = napomena,
                Pacijent = pacijent_local,
                Vreme = time
            };
            mysql_session_local.Save(t);
            mysql_session_local.Flush();
            oracle_session_local.Flush();
            oracle_session_local.Refresh(specijalista_local);
            RefreshControls(specijalista_local);
            return true;
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
