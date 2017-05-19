using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data.Entiteti
{
    public class SmenaId
    {
        public virtual IzabraniLekar Lekar { get; set; }
        public virtual DateTime Datum_Od { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return Lekar.Ime + " " + Lekar.Prezime + " " + Datum_Od.Date.ToShortDateString();
        }
    }
}
