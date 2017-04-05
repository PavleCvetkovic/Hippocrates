using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data.Entiteti
{
    public class TerminBolnica
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime Datum { get; set; }
        public virtual int Vreme { get; set; }
        public virtual string Napomena { get; set; }
        public virtual Specijalista LSpecijalista { get; set; }
        public virtual Pacijent Pacijent { get; set; }
    }
}
