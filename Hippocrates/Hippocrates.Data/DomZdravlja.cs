using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data
{
    public class DomZdravlja
    {
        private string mbr;
        public string ime;
        public string opstina;
        public string lokacija;
        public string adresa;
        public DomZdravlja(string mbr, string ime, string opstina, string lokacija, string adresa)
        {
            this.mbr = mbr;
            this.ime = ime;
            this.opstina = opstina;
            this.lokacija = lokacija;
            this.adresa = adresa;
        }
        public string Mbr
        {
            get
            {
                return mbr;
            }
            set
            {

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
        public string Lokacija
        {
            get
            {
                return lokacija;
            }
            set
            {
                lokacija = value;
            }
        }
        public String Adresa
        {
            get
            {
                return adresa;
            }
            set
            {
                adresa = value;
            }
        }
    }

}
    