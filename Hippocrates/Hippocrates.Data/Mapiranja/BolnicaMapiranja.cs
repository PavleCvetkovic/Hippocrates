using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hippocrates.Data.Entiteti;
using FluentNHibernate.Mapping;

namespace Hippocrates.Data.Mapiranja
{
    public class BolnicaMapiranja:ClassMap<Bolnica>
    {
        public BolnicaMapiranja()
        {
            Table("BOLNICA");

            Id(x => x.Mbr, "MBR").GeneratedBy.Assigned();

            Map(x => x.Ime, "IME");
            Map(x => x.Opstina, "OPŠTINA");
            Map(x => x.Lokacija, "LOKACIJA");
            Map(x => x.Adresa, "ADRESA");

            HasMany(x => x.Specijaliste).KeyColumn("MBRZU").Cascade.SaveUpdate().Inverse().LazyLoad();
        }
    }
}
