using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hippocrates.Data.Entiteti;
using FluentNHibernate.Mapping;

namespace Hippocrates.Data.Mapiranja
{
    public class MedicinskoOsobljeMapiranja:ClassMap<MedicinskoOsoblje>
    {
        public MedicinskoOsobljeMapiranja()
        {
            Table("MEDICINSKO_OSOBLJE");

            Id(x => x.Jmbg, "JMBG");

            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Srednje_slovo, "SREDNJE_SLOVO");
            Map(x => x.Password, "PASSWORD");
            Map(x => x.Datum_rodjenja, "DATUM_ROĐENJA");

            References(x => x.RadiUDomuZdravlja).Column("MBRZU").LazyLoad();
        }
    }
}
