﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data.Entiteti
{
    public class DijagnostifikovanoId
    {
        public virtual Pacijent DijagnozaPacijent { get; set; }
        public virtual Dijagnoza DijagnozaDijagnoza { get; set; }
        public virtual IzabraniLekar DijagnozaLekar { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            //return base.ToString();
            return DijagnozaDijagnoza.Ime.ToString();
        }
    }
}
