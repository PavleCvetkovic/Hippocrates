using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data
{
    public class IzabraniLekar
    {
        private string jmbg;
        public string ime;
        public string srednje_slovo;
        public string prezime;
        public int smena;
        public DateTime datum_rodjenja;
        public DomZdravlja radiU;
        public List<int> lista_ocena;

        public IzabraniLekar(string jmbg, string ime, string srednje_slovo, string prezime, DateTime datum_rodjenja, DomZdravlja radiU, int smena)
        {
            this.jmbg = jmbg;
            this.ime = ime;
            this.srednje_slovo = srednje_slovo;
            this.prezime = prezime;
            this.datum_rodjenja = datum_rodjenja;
            this.radiU = radiU;
            this.smena = smena;
        }
        public string Jmbg
        {
            get
            {
                return jmbg;
            }
            set { }
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
        public int Smena
        {
            get
            {
                return smena;
            }
            set
            {
                smena = value;
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
        public void dodajOcenu(int ocena)
        {
            lista_ocena.Add(ocena);
        }
    }
}
