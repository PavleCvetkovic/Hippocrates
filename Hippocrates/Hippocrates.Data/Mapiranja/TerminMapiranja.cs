using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Hippocrates.Data.Entiteti;

namespace Hippocrates.Data.Mapiranja
{
    public class TerminMapiranja:ClassMap<Termin>
    {
        public TerminMapiranja()
        {
            Table("TERMIN");

            Id(x => x.Id, "ID");

            Map(x => x.Napomena, "NAPOMENA");
            Map(x => x.Vreme, "VREME");
            Map(x => x.Datum, "DATUM");

            //References(x => x.Lekar).Column("MATBRSPEC");
            //Ovaj zakomentarisani deo gde je pogresno napisano ime kolone mi je oduzeo 2 sata zivota (Pavle ti si kriv)
            //Dizem ovaj spomenik mojim potrosenim 120 minuta
            //Slava im.
            References(x => x.Lekar).Column("MATBRL");
            References(x => x.Pacijent).Column("MATBRP");
        }
    }
}
