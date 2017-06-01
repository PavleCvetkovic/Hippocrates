using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hippocrates.Data.EntitetiOracle;
using FluentNHibernate.Mapping;

namespace Hippocrates.Data.MapiranjaOracle
{
    public class DomZdravljaOracleMapiranja:ClassMap<DomZdravljaOracle>
    {
        public DomZdravljaOracleMapiranja()
        {
            Table("DOM_ZDRAVLJA");
            Id(x => x.Mbr).Column("MBR");

            Map(x => x.Ime).Column("IME");
            Map(x => x.Adresa).Column("ADRESA");
            Map(x => x.Lokacija).Column("LOKACIJA");
            Map(x => x.Opstina).Column("OPSTINA");

            HasMany(x => x.Lekari).KeyColumn("MBRZU").Cascade.All().Inverse().LazyLoad();
        }
    }
}
