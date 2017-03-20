using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data
{
    public class Vakcina
    {
        public string ime;
        public string sifra;
        public string opis;
        public Vakcina(string sifra,string ime,string opis)
        {
            this.sifra = sifra;
            this.ime = ime;
            this.opis = opis;
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
        public string Opis
        {
            get
            {
                return opis;
            }
            set
            {
                opis = value;
            }
        }
    }
}
