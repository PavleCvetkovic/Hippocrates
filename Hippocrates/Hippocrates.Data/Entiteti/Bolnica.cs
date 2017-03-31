using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data.Entiteti
{
    public class Bolnica
    {
        public virtual string Mbr { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Opstina { get; set; }
        public virtual string Lokacija { get; set; }
        public virtual string Adresa { get; set; }

        public virtual IList<Specijalista> Specijaliste { get; set; }

        public Bolnica()
        {
            Specijaliste = new List<Specijalista>();
        }
    }
}
