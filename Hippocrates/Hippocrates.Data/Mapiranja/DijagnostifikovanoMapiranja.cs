﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Hippocrates.Data.Entiteti;

namespace Hippocrates.Data.Mapiranja
{
    public class DijagnostifikovanoMapiranja:ClassMap<Dijagnostifikovano>
    {
        public DijagnostifikovanoMapiranja()
        {
            Table("DIJAGNOSTIFIKOVANO");

            CompositeId(x => x.Id)
                .KeyReference(x => x.DijagnozaDijagnoza, "ŠIFRA_DIJAGNOZE")
                .KeyReference(x => x.DijagnozaPacijent, "MATBRP")
                .KeyReference(x => x.DijagnozaLekar, "MATBRL");

            Map(x => x.Datum, "DATUM");
        }
    }
}
