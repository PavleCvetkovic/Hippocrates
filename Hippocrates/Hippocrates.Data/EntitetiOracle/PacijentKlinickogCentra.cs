using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data.EntitetiOracle
{
    public class PacijentKlinickogCentra
    {
        public virtual int Id { get; protected set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual string JMBG { get; set; }
        public virtual string BracniStatus { get; set; }
        public virtual string Pol { get; set; }
        public virtual string Adresa { get; set; }
        
        public virtual IList<Pregled> Pregledi { get; set; }

        public PacijentKlinickogCentra()
        {
            Pregledi = new List<Pregled>();
        }
    }
}
