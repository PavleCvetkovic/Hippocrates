using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Hippocrates.Data.Entiteti;

namespace Hippocrates.Data.Mapiranja
{
    public class ZahtevZaPromenuMapiranja:ClassMap<ZahtevZaPromenu>
    {
        public ZahtevZaPromenuMapiranja()
        {
            Table("ZAHTEV_ZA_PROMENU");

            Id(x => x.Id, "ID");
            //Id(x => x.Id, "ID").GeneratedBy.Increment();
            //Id(x => x.Id, "ID").GeneratedBy.Native();

            References(x => x.ZahtevPacijenta).Column("MATBRP");
            References(x => x.ZeljeniLekar).Column("MATBR_ŽELJENOG");

        }
    }
}
