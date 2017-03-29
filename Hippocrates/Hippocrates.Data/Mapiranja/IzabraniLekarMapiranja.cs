using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Hippocrates.Data.Entiteti;
namespace Hippocrates.Data.Mapiranja
{
    public class IzabraniLekarMapiranja:ClassMap<IzabraniLekar>
    {
        public IzabraniLekarMapiranja()
        {
            Table("IZABRANI_LEKAR");

            Id(x => x.Jmbg, "JMBG").GeneratedBy.Assigned();

            Map(x => x.Ime, "IME");
            Map(x => x.Srednje_slovo, "SREDNJE_SLOVO");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Datum_rodjenja, "DATUM_ROĐENJA");
            Map(x => x.Password, "PASSWORD");

            References(x => x.RadiUDomuZdravlja).Column("MBRZU").LazyLoad();
        }
    }
}
