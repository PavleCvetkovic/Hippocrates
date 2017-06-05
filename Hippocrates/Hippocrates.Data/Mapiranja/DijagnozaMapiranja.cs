using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Hippocrates.Data.Entiteti;
namespace Hippocrates.Data.Mapiranja
{
    public class DijagnozaMapiranja:ClassMap<Dijagnoza>
    {
        public DijagnozaMapiranja()
        {
            Table("DIJAGNOZA");

            Id(x => x.Sifra, "ŠIFRA");

            Map(x => x.Ime, "IME");
            HasMany(x => x.Dijagnostifikovano).KeyColumn("ŠIFRA_DIJAGNOZE");
           
        }
    }
}
