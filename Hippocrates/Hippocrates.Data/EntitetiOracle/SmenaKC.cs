using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data.EntitetiOracle
{
    public class SmenaKC
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime DatumDo { get; set; }
        public virtual string TipSmene { get; set; }
        public virtual SpecijalistaKC Specijalista { get; set; }
    }
}
