using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data.Entiteti
{
    public class ZahtevZaPromenu
    {
        public virtual int Id { get; protected set; }
        public virtual IzabraniLekar ZeljeniLekar { get; set; }
        public virtual Pacijent ZahtevPacijenta { get; set; }
    }
}
