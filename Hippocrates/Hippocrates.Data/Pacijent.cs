using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data
{
    public class Pacijent
    {
        private string jmbg;
        private string lbo;
        public string ime;
        public string prezime;
        public string srednje_slovo;
        public DateTime datum_rodjenja;
        public string opstina;
        public DateTime osiguranje_vazi_do;
        public IzabraniLekar izabrani_lekar;
        public List<Vakcina> lista_vakcina;
        public List<Dijagnoza> lista_dijagnoza;
        public int pravo_da_zakaze;

        public Pacijent(string jmbg, string lbo, string ime, string prezime, string srednje_slovo, DateTime datum_rodjenja, string opstina, DateTime osiguranje_vazi_do, IzabraniLekar izabrani_lekar)
        {
            this.jmbg = jmbg;
            this.lbo = lbo;
            this.ime = ime;
            this.prezime = prezime;
            this.srednje_slovo = srednje_slovo;
            this.datum_rodjenja = datum_rodjenja;
            this.opstina = opstina;
            this.osiguranje_vazi_do = osiguranje_vazi_do;
            this.izabrani_lekar = izabrani_lekar;
            lista_vakcina = new List<Vakcina>();
            lista_dijagnoza = new List<Dijagnoza>();
            this.pravo_da_zakaze = 1; // inicijalna vrednost
        }
        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                ime = value;
            }
        }
        public string SrednjeSlovo
        {
            get
            {
                return srednje_slovo;
            }
            set
            {
                srednje_slovo = value;
            }
        }
        public string Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                prezime = value;
            }
        }
        public DateTime DatumRodjenja
        {
            get
            {
                return datum_rodjenja;
            }
            set
            {
                datum_rodjenja = value;
            }
        }
        public DateTime OsiguranjeVaziDo
        {
            get
            {
                return osiguranje_vazi_do;
            }
            set
            {
                osiguranje_vazi_do = value;
            }
        }
        public string Opstina
        {
            get
            {
                return opstina;
            }
            set
            {
                opstina = value;
            }
        }
        public IzabraniLekar Izabranilekar
        {
            get
            {
                return izabrani_lekar;
            }
            set
            {
                izabrani_lekar = value;
            }
        }
        public void dodajVakcinu(Vakcina v)
        {
            lista_vakcina.Add(v);
        }
        public void dodajDijagnozu(Dijagnoza d)
        {
            lista_dijagnoza.Add(d);
        }
    }
}

