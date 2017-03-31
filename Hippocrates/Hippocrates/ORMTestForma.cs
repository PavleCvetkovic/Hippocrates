using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using Hippocrates.Data.Entiteti;
using Hippocrates.Data;

namespace Hippocrates
{
    public partial class ORMTestForma : Form
    {
        public ORMTestForma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();

            DomZdravlja dz = new DomZdravlja()
            {
                Mbr = "test",
                Lokacija = "test",
                Adresa = "test",
                Ime = "test",
                Opstina = "aaaaa"
            };
            IzabraniLekar il = new IzabraniLekar()
            {
                Jmbg = "55555",
                Ime = "ime",
                Datum_rodjenja = new DateTime(2000, 10, 14),
                Password = "test",
                Prezime = "prezie",
                Srednje_slovo = "s"
            };
            Pacijent pac1 = new Pacijent()
            {
                Jmbg = "01",
                Ime = "Prvo mace",
                Prezime = "Ide u vodu",
                Datum_rodjenja = new DateTime(1995, 01, 01),
                //bez mejla
                Telefon = "555-333",
                Lbo = "01",
                Opstina = "aaaaa",
                Srednje_slovo = "D",
                Vazi_do = new DateTime(2017, 12, 30),
            };

            //dodaj lekara i dom zdravlja
            dz.Lekari.Add(il);
            il.RadiUDomuZdravlja = dz;
            //dodaj lekaru pacijente
            il.Pacijenti.Add(pac1);
            pac1.Lekar = il;
            s.Save(dz);

            s.Flush();
            s.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Specijalista spec = new Specijalista()
            {
                Datum_rodjenja = DateTime.Now,
                Ime = "specijalac",
                Prezime = "Aaaa",
                Jmbg = "123456",
                Srednje_slovo = "Ž",
                Titula = "PSIHIJATAR BRE"
            };
            Bolnica bol = new Bolnica()
            {
                Ime = "Bolnica1",
                Adresa = "Adresa1",
                Lokacija = "Lokacija1",
                Mbr = "1001",
                Opstina = "Opstina1",
            };
            bol.Specijaliste.Add(spec);
            spec.RadiUBolnici = bol;
            ISession s = DataLayer.GetSession();
            s.Save(bol);
            s.Flush();
            s.Close();
        }
    }
}
