using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data
{
    public class Dijagnoza
    {
        public string sifra;
        public string ime;
        public Dijagnoza(string sifra, string ime)
        {
            this.sifra = sifra;
            this.ime = ime;
        }
        public string Sifra
        {
            get
            {
                return sifra;
            }
            set
            {
                sifra = value;
            }
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
    }
}
