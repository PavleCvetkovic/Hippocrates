using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data.EntitetiOracle
{
    public class SpecijalistaKC
    {
        public virtual int Id { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Telefon { get; set; }
        public virtual string TipZaposlenog { get; set; }
        public virtual Klinika Klinika { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual string BrojOrdinacije { get; set; }
        public virtual string JMBG { get; set; }
        public virtual string Pol { get; set; }
        public virtual string Adresa { get; set; }
        public virtual IList<SmenaKC> Smene { get; set; }
        

        public SpecijalistaKC()
        {
            Smene = new List<SmenaKC>();
        }
    }
}
