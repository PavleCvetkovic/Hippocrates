using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data.Entiteti
{
    public class Smena
    {
        public virtual SmenaId Id { get; set; }
        public virtual DateTime Datum_Do { get; set; }
        public virtual int SmenaLekara { get; set; }
        public Smena()
        {
            Id = new SmenaId();
        }
    }
}
