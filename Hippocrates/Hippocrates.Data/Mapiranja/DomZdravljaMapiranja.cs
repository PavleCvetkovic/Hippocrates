using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Mapping;
using Hippocrates.Data.Entiteti;
namespace Hippocrates.Data.Mapiranja
{
    public class DomZdravljaMapiranja:ClassMap<DomZdravlja>
    {
        public DomZdravljaMapiranja()
        {
            Table("DOM_ZDRAVLJA");

            Id(x => x.Mbr, "MBR").GeneratedBy.Assigned();

            Map(x => x.Ime, "IME");
            Map(x => x.Opstina, "OPŠTINA");
            Map(x => x.Lokacija, "LOKACIJA");
            Map(x => x.Adresa, "ADRESA");

            HasMany(x => x.Lekari).KeyColumn("MBRZU").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.MedicinskoOsoblje).KeyColumn("MBRZU").Inverse().Cascade.All().LazyLoad();
        }
    }
}
