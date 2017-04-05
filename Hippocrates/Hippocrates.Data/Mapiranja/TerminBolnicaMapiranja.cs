using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Hippocrates.Data.Entiteti;
namespace Hippocrates.Data.Mapiranja
{
    public class TerminBolnicaMapiranja:ClassMap<TerminBolnica>
    {
        public TerminBolnicaMapiranja()
        {
            Table("TERMIN_BOLNICA");

            Id(x => x.Id, "ID");
            Map(x => x.Napomena, "NAPOMENA");
            Map(x => x.Vreme, "VREME");
            Map(x => x.Datum, "DATUM");

            References(x => x.LSpecijalista).Column("MATBRSPEC");
            References(x => x.Pacijent).Column("MATBRP");
        }
    }
}
