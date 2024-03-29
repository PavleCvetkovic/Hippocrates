﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Hippocrates.Data.Entiteti;

namespace Hippocrates.Data.Mapiranja
{
    public class SpecijalistaMapiranja:ClassMap<Specijalista>
    {
        public SpecijalistaMapiranja()
        {
            Table("SPECIJALISTA");

            Id(x => x.Jmbg, "JMBG").GeneratedBy.Assigned();

            Map(x => x.Ime, "IME");
            Map(x => x.Srednje_slovo).Column("SREDNJE_SLOVO");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Datum_rodjenja, "DATUM_ROĐENJA");
            Map(x => x.Titula, "TITULA");

            References(x => x.RadiUBolnici).Column("MBRZU").LazyLoad();

            HasMany(x => x.Termini).KeyColumn("MATBRSPEC").Cascade.All().Inverse().LazyLoad();
        }
    }
}
