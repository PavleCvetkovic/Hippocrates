using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data.Entiteti
{
    public class OcenaId
    {
        public virtual IzabraniLekar Lekar { get; set; }
        public virtual Pacijent Pacijent { get; set; }

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
            return Pacijent.Jmbg;
        }
    }
}
