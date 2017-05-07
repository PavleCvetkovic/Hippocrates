using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hippocrates.Data.EntitetiOracle;
using FluentNHibernate.Mapping;

namespace Hippocrates.Data.MapiranjaOracle
{
    public class SpecijalistaMapiranja:ClassMap<SpecijalistaKC>
    {
        public SpecijalistaMapiranja()
        {
            Table("ZAPOSLENI");

            Id(x => x.Id).GeneratedBy.TriggerIdentity();

            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.Telefon).Column("TELEFON");
            Map(x => x.TipZaposlenog).Column("TIP_ZAPOSLENOG");
            Map(x => x.BrojOrdinacije).Column("BROJ_ORDINACIJE");
            Map(x => x.JMBG).Column("JMBG");
            Map(x => x.Pol).Column("POL");
            Map(x => x.Adresa).Column("ADRESA");
            Map(x => x.DatumRodjenja).Column("DATUM_RODJENJA");


            References(x => x.Klinika).Column("ID_KLINIKE").LazyLoad();
            HasMany(x => x.Smene).KeyColumn("ID_ZAPOSLENOG").LazyLoad().Inverse().Cascade.All();

        }
    }
}
