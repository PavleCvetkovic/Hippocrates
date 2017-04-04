using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Hippocrates.Data.Entiteti;

namespace Hippocrates.Data.Mapiranja
{
    public class OcenaMapiranja:ClassMap<Ocena>
    {
        public OcenaMapiranja()
        {
            Table("OCENA");

            CompositeId(x => x.Id)
                .KeyReference(x => x.Lekar, "MATBRL")
                .KeyReference(x => x.Pacijent, "MATBRP");

            Map(x => x.Vrednost, "OCENA");
        }
    }
}
