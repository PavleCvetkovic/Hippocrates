using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Hippocrates.Data.EntitetiOracle;

namespace Hippocrates.Data.MapiranjaOracle
{
    public class KlinickiCentarMapiranja:ClassMap<KlinickiCentar>
    {
        public KlinickiCentarMapiranja()
        {
            Table("KLINICKI_CENTAR");
            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();
            Map(x => x.Ime).Column("IME");
            Map(x => x.Lokacija).Column("LOKACIJA");

            HasMany(x => x.Klinike).KeyColumn("ID_KC").LazyLoad().Inverse().Cascade.All();
        }
    }
}
