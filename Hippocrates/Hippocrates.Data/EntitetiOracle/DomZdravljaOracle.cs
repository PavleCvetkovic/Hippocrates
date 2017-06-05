using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data.EntitetiOracle
{
    public class DomZdravljaOracle
    {
        public virtual string Mbr { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Opstina { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string Lokacija { get; set; }

        public virtual IList<IzabraniLekarOracle> Lekari { get; set; }

        public DomZdravljaOracle()
        {
            Lekari = new List<IzabraniLekarOracle>();
        }
    }
}
