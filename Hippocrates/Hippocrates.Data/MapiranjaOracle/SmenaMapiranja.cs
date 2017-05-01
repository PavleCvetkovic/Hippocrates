using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hippocrates.Data.EntitetiOracle;
using FluentNHibernate.Mapping;

namespace Hippocrates.Data.MapiranjaOracle
{
    public class SmenaMapiranja:ClassMap<SmenaKC>
    {
        public SmenaMapiranja()
        {
            Table("SMENA");

            Id(x => x.Id).GeneratedBy.TriggerIdentity();

            Map(x => x.DatumDo).Column("DATUM_DO");
            Map(x => x.DatumOd).Column("DATUM_OD");
            Map(x => x.TipSmene).Column("TIP_SMENE");

            References(x => x.Specijalista).Column("ID_ZAPOSLENOG");
        }

    }
}
