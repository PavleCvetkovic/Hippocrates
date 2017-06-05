using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data.Entiteti
{
    public class Dijagnostifikovano
    {
        public virtual DijagnostifikovanoId Id { get; set; }
        public virtual DateTime Datum { get; set; }

        public Dijagnostifikovano()
        {
            Id = new DijagnostifikovanoId();
        }
    }
}
