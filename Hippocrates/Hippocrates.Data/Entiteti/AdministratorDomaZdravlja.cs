using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data.Entiteti
{
    public class AdministratorDomaZdravlja
    {
        public virtual string JMBG { get; set; }
        public virtual string Ime { get; set; }
        public virtual string SrednjeSlovo { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string MBRZU { get; set; }
        public virtual string Password { get; set; }

        public virtual DomZdravlja RadiUDomuZdravlja { get; set; }
    }
}
