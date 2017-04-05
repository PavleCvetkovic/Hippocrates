using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data.Entiteti
{
    public class Termin
    {
        public virtual int Id { get; protected set; }
        public virtual IzabraniLekar Lekar { get; set; }
        public virtual Pacijent Pacijent { get; set; }
        public virtual DateTime Datum { get; set; }
        public virtual int Vreme { get; set; }
        public virtual string Napomena { get; set; }

    }
}
