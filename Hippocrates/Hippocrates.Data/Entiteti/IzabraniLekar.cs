﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data.Entiteti
{
    public class IzabraniLekar
    {
        public virtual string Jmbg { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Srednje_slovo { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime Datum_rodjenja { get; set; }
        public virtual string Password { get; set; }

        public virtual DomZdravlja RadiUDomuZdravlja { get; set; }

        public virtual IList<Pacijent> Pacijenti { get; set; }
        public virtual IList<Ocena> Ocene { get; set; }

        public IzabraniLekar()
        {
            Pacijenti = new List<Pacijent>();
            Ocene = new List<Ocena>();
        }

    }
}
