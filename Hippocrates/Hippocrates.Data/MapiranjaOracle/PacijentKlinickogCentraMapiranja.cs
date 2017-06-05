using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Hippocrates.Data.EntitetiOracle;
namespace Hippocrates.Data.MapiranjaOracle
{
    public class PacijentKlinickogCentraMapiranja:ClassMap<PacijentKlinickogCentra>
    {
        public PacijentKlinickogCentraMapiranja()
        {
            Table("PACIJENT_KLINICKOG_CENTRA");

            Id(x => x.Id).GeneratedBy.TriggerIdentity();

            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.DatumRodjenja).Column("DATUM_RODJENJA");
            Map(x => x.JMBG).Column("JMBG");
            Map(x => x.BracniStatus).Column("BRACNI_STATUS");
            Map(x => x.Pol).Column("POL");
            Map(x => x.Adresa).Column("ADRESA");

            HasMany(x => x.Pregledi).KeyColumn("ID_PACIJENTA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
