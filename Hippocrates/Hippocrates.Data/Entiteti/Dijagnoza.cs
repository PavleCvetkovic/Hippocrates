using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data.Entiteti
{
    public class Dijagnoza
    {
        public virtual string Sifra { get; set; }
        public virtual string Ime { get; set; }

        public virtual IList<Dijagnostifikovano> DijagnostifikovanoPacijenti { get; set; }
        public virtual IList<Dijagnostifikovano> DijagnostifikovanoLekari { get; set; }
        public virtual IList<Terapija> Terapije { get; set; }

        public Dijagnoza()
        {
            DijagnostifikovanoPacijenti = new List<Dijagnostifikovano>();
            DijagnostifikovanoLekari = new List<Dijagnostifikovano>();
            Terapije = new List<Terapija>();
        }
        public override string ToString()
        {
            
            return this.Ime.ToString();
        }
    }
}
