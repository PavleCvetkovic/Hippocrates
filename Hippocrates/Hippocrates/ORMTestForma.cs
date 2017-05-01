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
using Hippocrates.Data.EntitetiOracle;


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

        private void button6_Click(object sender, EventArgs e)
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
                Jmbg = "12345",
                Datum_rodjenja = new DateTime(1960, 10, 10),
                Ime = "testDijagnostifikovano",
                Prezime = "test",
                Password = "12345",
                Srednje_slovo = "A",

            };
            Pacijent pac = new Pacijent()
            {
                Jmbg = "6789",
                Ime = "test",
                Prezime = "prezime1",
                Datum_rodjenja = new DateTime(1995, 01, 01),
                Email = "testORM",
                Telefon = "555-333",
                Lbo = "01",
                Opstina = "aaaaa",
                Srednje_slovo = "D",
                Vazi_do = new DateTime(2017, 12, 30)
            };
            il.RadiUDomuZdravlja = dz;
            dz.Lekari.Add(il);
            il.Pacijenti.Add(pac);
            pac.Lekar = il;
            Dijagnoza d = new Dijagnoza()
            {
                Ime = "test",
                Sifra = "test"
            };
            s.Save(d);
            s.Flush();
            Dijagnostifikovano dij = new Dijagnostifikovano()
            {
                Datum = new DateTime(2000,5,5)
            };
            dij.Id.DijagnozaLekar = il;
            dij.Id.DijagnozaPacijent = pac;
            dij.Id.DijagnozaDijagnoza = d;
            il.DijagnostifikovanoDijagnoze.Add(dij);
            pac.DijagnostifikovanoDijagnoze.Add(dij);
            
            s.Save(dz);
            s.Flush();
            s.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IzabraniLekar il = s.Get<IzabraniLekar>("0112955445023");
            Smena smena = new Smena()
            {
                Datum_Do = new DateTime(2018, 12, 30),
                SmenaLekara = 2
            };
            smena.Id.Datum_Od = new DateTime(2018, 1, 1);
            smena.Id.Lekar = il;
            il.Smene.Add(smena);
            s.Save(il);
            s.Flush();
            s.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IzabraniLekar il = s.Get<IzabraniLekar>("0112955445023");
            Pacijent pac = s.Get<Pacijent>("0000");

            Terapija ter = new Terapija()
            {
                Datum_do = new DateTime(2018, 10, 10),
                Datum_od = new DateTime(2017, 4, 5),
                Opis = "ORM TEST",
                
            };
            Dijagnoza dij = new Dijagnoza()
            {
                Ime = "ORM",
                Sifra = "ORM1",

            };

    
            ter.TerapijaLekar = il;
            ter.TerapijaPacijent = pac;
            il.Terapije.Add(ter);
            pac.Terapije.Add(ter);
            ter.TerapijaDijagnoza = dij;
            dij.Terapije.Add(ter);
            s.SaveOrUpdate(dij);
            
            s.Flush();
            s.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IzabraniLekar il = s.Get<IzabraniLekar>("0112955445023");
            Pacijent pac = s.Get<Pacijent>("0000");
            Termin t = new Termin()
            {
                Datum = new DateTime(2020, 5, 5),
                Napomena = "ORM TEST",
                Vreme = 2220
            };
            t.Pacijent = pac;
            pac.Termini.Add(t);
            t.Lekar = il;
            il.Termini.Add(t);
            s.Save(t);
            s.Flush();
            s.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IzabraniLekar il = s.Get<IzabraniLekar>("1203970666630");
            Pacijent pac = s.Get<Pacijent>("0000");
            ZahtevZaPromenu z= new ZahtevZaPromenu();
            z.ZeljeniLekar = il;
            z.ZahtevPacijenta = pac;
            s.Save(z);
            s.Flush();
            s.Close();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Pacijent pac = s.Get<Pacijent>("0000");
            Specijalista sp = new Specijalista()
            {
                Datum_rodjenja = new DateTime(1950, 5, 5),
                Ime = "ORM",
                Prezime = "TEST",
                Jmbg = "testorm",
                Srednje_slovo = "a",
                Titula = "aaa"
            };
            Bolnica b = new Bolnica()
            {
                Adresa = "test",
                Ime = "test",
                Lokacija = "test",
                Mbr = "1",
                Opstina = "22"
            };
            b.Specijaliste.Add(sp);
            sp.RadiUBolnici = b;
            TerminBolnica tb = new TerminBolnica()
            {
                Datum = new DateTime(2018, 1, 1),
                LSpecijalista = sp,
                Napomena = "aa",
                Pacijent = pac,
                Vreme = 1200
            };
            pac.TerminiBolnica.Add(tb);
            sp.Termini.Add(tb);
            s.Save(b);
            s.Flush();
            s.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ISession s = DataLayerOracle.GetSession();
            KlinickiCentar kc = s.Load<KlinickiCentar>(1);
            foreach (Klinika k in kc.Klinike)
            {
                foreach(SpecijalistaKC sckc in k.Specijaliste)
                {
                    MessageBox.Show(sckc.Ime);
                }
            }
            s.Close();
            
        }
    }
}
