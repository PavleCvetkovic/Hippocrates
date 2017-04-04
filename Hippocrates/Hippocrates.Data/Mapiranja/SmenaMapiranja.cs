using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Hippocrates.Data.Entiteti;
namespace Hippocrates.Data.Mapiranja
{
    public class SmenaMapiranja:ClassMap<Smena>
    {
        public SmenaMapiranja()
        {
            Table("SMENA");

            CompositeId(x => x.Id)
                .KeyProperty(x => x.Datum_Od, "DATUM_OD")
                .KeyReference(x => x.Lekar, "MATBRL");

            Map(x => x.SmenaLekara, "SMENA");
            Map(x => x.Datum_Do, "DATUM_DO");
        }
    }
}
