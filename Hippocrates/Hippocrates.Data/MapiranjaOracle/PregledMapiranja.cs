using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Hippocrates.Data.EntitetiOracle;

namespace Hippocrates.Data.MapiranjaOracle
{
    public class PregledMapiranja:ClassMap<Pregled>
    {
        public PregledMapiranja()
        {
            Table("PREGLED");

            Id(x => x.Id).GeneratedBy.TriggerIdentity();

            Map(x => x.Datum).Column("DATUM");
            Map(x => x.Vreme).Column("VREME");
            Map(x => x.Prostorija).Column("PROSTORIJA");

            References(x => x.Specijalista).Column("ID_SPECIJALISTE");
            References(x => x.Pacijent).Column("ID_PACIJENTA");
        }
    }
}
