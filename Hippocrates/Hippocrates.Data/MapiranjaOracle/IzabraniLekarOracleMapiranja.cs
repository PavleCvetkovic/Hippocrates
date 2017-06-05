using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Hippocrates.Data.EntitetiOracle;

namespace Hippocrates.Data.MapiranjaOracle
{
    public class IzabraniLekarOracleMapiranja:ClassMap<IzabraniLekarOracle>
    {
        public IzabraniLekarOracleMapiranja()
        {
            Table("IZABRANI_LEKAR");
            Id(x => x.Jmbg).Column("JMBG");

            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.DatumRodjenja).Column("DATUM_RODJENJA");
            Map(x => x.Adresa).Column("ADRESA");
            Map(x => x.Password).Column("PASSWORD");

            References(x => x.DomZdravlja).Column("MBRZU");
        }
    }
}
