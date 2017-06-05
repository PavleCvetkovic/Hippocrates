using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data
{
    public class ConnectionInfo
    {
        public static string connection_string_pavle = "server=139.59.132.29;user=paja;charset=utf8;database=Hippocrates;port=3306;password=pajapro1234;protocol=TCP";
        public static string connection_string_djela = "server=139.59.132.29;user=djeki;charset=utf8;database=Hippocrates;port=3306;password=volimdoroteju1;";
        public static string connection_string_andrija = "server=pavlecvetkovic.me; user=aki;charset=utf8;database=Hippocrates;port=3306;password=jetion123c;";
        public static string connection_string_nikola = "server=139.59.132.29;user=nikola;charset=utf8;database=Hippocrates;port=3306;password=ceranicceranic1;";


        public string Get_Pavle_Connection_String
        {
            get { return connection_string_pavle; }
        }
        public string Get_Djela_Connection_String
        {
            get { return connection_string_djela; }
        }
        public string Get_Andrija_Connection_String
        {
            get { return connection_string_andrija; }
        }
        public string Get_Nikola_Connection_String
        {
            get { return connection_string_nikola; }
        }
    }
}
