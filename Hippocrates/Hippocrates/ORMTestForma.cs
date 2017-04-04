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
                Ime = "imepacijenta1",
                Prezime = "prezime1",
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

        private void button3_Click(object sender, EventArgs e)
        {
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
                Ime = "imepacijenta1",
                Prezime = "prezime1",
                Datum_rodjenja = new DateTime(1995, 01, 01),
                Email = "testORM",
                Telefon = "555-333",
                Lbo = "01",
                Opstina = "aaaaa",
                Srednje_slovo = "D",
                Vazi_do = new DateTime(2017, 12, 30),
            };
            Ocena ocena = new Ocena()
            {
                Vrednost = 1
            };


            ISession s = DataLayer.GetSession();


            dz.Lekari.Add(il);
            il.RadiUDomuZdravlja = dz;

            il.Pacijenti.Add(pac1);
            ocena.Id.Lekar = il;
            ocena.Id.Pacijent = pac1;
            pac1.Lekar = il;
            il.Ocene.Add(ocena);
            pac1.Ocene.Add(ocena);

            s.Save(dz);
            s.Flush();
            s.Close();

        }

        private void button4_Click(object sender, EventArgs e)
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
                Ime = "imepacijenta1",
                Prezime = "prezime1",
                Datum_rodjenja = new DateTime(1995, 01, 01),
                Email = "testORM",
                Telefon = "555-333",
                Lbo = "01",
                Opstina = "aaaaa",
                Srednje_slovo = "D",
                Vazi_do = new DateTime(2017, 12, 30),
            };
            Ocena ocena = new Ocena()
            {
                Vrednost = 3
            };
            Vakcina v = new Vakcina()
            {
                Ime = "test vakcina",
                Opis = "00",
                Sifra = "011",
            };
            //AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA SVEE
            s.Save(v);
            s.Flush();
            
            PrimioVakcinu pr = new PrimioVakcinu();

            pr.Id.PrimioPacijent = pac1;
            pr.Id.PrimioVakcina= v;
            pr.Datum = new DateTime(2000, 10, 10);

            pac1.PrimioVakcinuVakcine.Add(pr);
            v.PrimioVakcinuPacijenti.Add(pr);


            dz.Lekari.Add(il);
            il.RadiUDomuZdravlja = dz;

            il.Pacijenti.Add(pac1);
            ocena.Id.Lekar = il;
            ocena.Id.Pacijent = pac1;
            pac1.Lekar = il;
            il.Ocene.Add(ocena);
            pac1.Ocene.Add(ocena);
          
            
            s.SaveOrUpdate(dz); 
            s.Flush();
            s.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IzabraniLekar il = s.Load<IzabraniLekar>("0112955445023");
            MessageBox.Show(il.Pacijenti[0].Ime);
            MessageBox.Show(il.Pacijenti[0].PrimioVakcinuVakcine[0].Id.PrimioVakcina.Ime);
            MessageBox.Show(il.Ocene[0].Vrednost.ToString());
            MessageBox.Show(il.RadiUDomuZdravlja.Ime);
        }
    }
}
