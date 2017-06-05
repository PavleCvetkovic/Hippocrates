using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data.EntitetiOracle
{
    public class KlinickiCentar
    {
        public virtual int Id { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Lokacija { get; set; }
        public virtual IList<Klinika> Klinike { get; set; }

        public KlinickiCentar()
        {
            Klinike = new List<Klinika>();
        }
        public override string ToString()
        {
            return Ime;
        }
    }
}
