using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data.Entiteti
{//klasa za MxN vezu
    public class Ocena
    {
        public virtual OcenaId Id { get; set; }
        public virtual int Vrednost { get; set; }
        

        public Ocena()
        {
            Id = new OcenaId();
        }
    }
}
