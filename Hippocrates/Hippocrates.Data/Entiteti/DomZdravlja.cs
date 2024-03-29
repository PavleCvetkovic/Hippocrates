﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data.Entiteti
{
    public class DomZdravlja
    {
        public virtual string Mbr { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Opstina { get; set; }
        public virtual string Lokacija { get; set; }
        public virtual string Adresa { get; set; }

        public virtual IList<IzabraniLekar> Lekari { get; set; }
        public virtual IList<MedicinskoOsoblje> MedicinskoOsoblje { get; set; }
        public virtual IList<AdministratorDomaZdravlja> Administratori { get; set; }

        public DomZdravlja()
        {
            Lekari = new List<IzabraniLekar>();
            MedicinskoOsoblje = new List<MedicinskoOsoblje>();
            Administratori = new List<AdministratorDomaZdravlja>();
        }
       /* public override string ToString()
        {
            return Ime+" Mbr: "+ Mbr;
        }*/
    }
}
