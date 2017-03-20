using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data
{
    public class MedicinskoOsoblje
    {
        private string jmbg;
        public string ime;
        public string srednje_slovo;
        public string prezime;
        public DateTime datum_rodjenja;
        public DomZdravlja radiU;

        public MedicinskoOsoblje(string jmbg, string ime, string srednje_slovo, string prezime, DateTime datum_rodjenja, DomZdravlja radiU)
        {
            this.jmbg = jmbg;
            this.ime = ime;
            this.srednje_slovo = srednje_slovo;
            this.prezime = prezime;
            this.datum_rodjenja = datum_rodjenja;
            this.radiU = radiU;
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
    }
}
