using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hippocrates.Data.EntitetiOracle;
using FluentNHibernate.Mapping;

namespace Hippocrates.Data.MapiranjaOracle
{
    public class KlinikaMapiranja:ClassMap<Klinika>
    {
        public KlinikaMapiranja()
        {
            Table("KLINIKA");
            Id(x => x.Id).GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv).Column("NAZIV");
            Map(x => x.Telefon).Column("TELEFON");
            Map(x => x.Lokacija).Column("LOKACIJA");

            References(x => x.KlinickiCentar).Column("ID_KC").LazyLoad();
            HasMany(x => x.Specijaliste).KeyColumn("ID_KLINIKE").LazyLoad().Inverse().Cascade.All();
        }
    }
}
