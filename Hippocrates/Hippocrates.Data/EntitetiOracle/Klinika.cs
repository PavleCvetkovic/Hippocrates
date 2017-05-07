using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data.EntitetiOracle
{
    public class Klinika
    {
        public virtual int Id { get; protected set; }
        public virtual string Naziv { get; set; }
        public virtual string Telefon { get; set; }
        public virtual string Lokacija { get; set; }
        public virtual KlinickiCentar KlinickiCentar { get; set; }
        public virtual IList<SpecijalistaKC> Specijaliste { get; set; }

        public Klinika()
        {
            Specijaliste = new List<SpecijalistaKC>();
        }

    }
}
