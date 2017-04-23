using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data.Entiteti
{
    public class PrimioVakcinu
    {
        public virtual PrimioVakcinuId Id { get; set; }
        public virtual DateTime Datum { get; set; }

        public PrimioVakcinu()
        {
            Id = new PrimioVakcinuId();
        }
    }
}
