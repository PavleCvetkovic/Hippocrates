using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Hippocrates.Data.Entiteti;

namespace Hippocrates.Data.Mapiranja
{
    public class AdminDomaZdravljaMapiranje:ClassMap<AdministratorDomaZdravlja>
    {
        public AdminDomaZdravljaMapiranje()
        {
            Table("ADMINISTRATOR_DOM_ZDRAVLJA");

            Id(x => x.JMBG, "JMBG").GeneratedBy.Assigned();

            Map(x => x.Ime, "IME");
            Map(x => x.SrednjeSlovo, "SREDNJE_SLOVO");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Password, "PASSWORD");

            References(x => x.RadiUDomuZdravlja).Column("MBRZU").LazyLoad();


        }

    }
}
