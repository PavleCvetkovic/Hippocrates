using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Hippocrates.Data.Entiteti;

namespace Hippocrates.Data.Mapiranja
{
    public class VakcinaMapiranja:ClassMap<Vakcina>
    {
        public VakcinaMapiranja()
        {
            Table("VAKCINA");

            Id(x => x.Sifra, "ŠIFRA");

            Map(x => x.Ime, "IME");
            Map(x => x.Opis, "OPIS");

            HasMany(x => x.PrimioVakcinuPacijenti).KeyColumn("SIFRA_VAKCINE").Cascade.All();
        }
    }
}
