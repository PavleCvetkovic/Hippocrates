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
    }
}
