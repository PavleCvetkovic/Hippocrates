using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data.EntitetiOracle
{
    public class Pregled
    {
        public virtual int Id { get; protected set; }
        public virtual  DateTime Datum { get; set; }
        public virtual int Vreme { get; set; }
        public virtual string Prostorija { get; set; }
        public virtual string IdIzabranogLekara { get; set; }  //nije stavljeno kao referenca vec kao ID, nema pristup iz pregleda na klinici do IzabranogLekara 

        public virtual SpecijalistaKC Specijalista { get; set; }
        public virtual PacijentKlinickogCentra Pacijent { get; set; }

    }
}
