using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
namespace Hippocrates.Data
{
    public class DataLayer
    {
        private static ISessionFactory factory = null;
        private static object lockObj = new object();
        public static ISession GetSession()
        {
            if (factory == null)
            {
                lock (lockObj)
                {
                    if (factory == null)
                        factory = CreateSessionFactory();
                }
            }
            return factory.OpenSession();
        }
        private static ISessionFactory CreateSessionFactory()
        {
            try
            {
                var cfg = MySQLConfiguration.Standard.ConnectionString(c => c.Is("server=139.59.132.29;user=paja;charset=utf8;database=Hippocrates;port=3306;password=pajapro1234;"));
                return Fluently.Configure().Database(cfg).Mappings(m => m.FluentMappings.AddFromAssemblyOf<Mapiranja.DomZdravljaMapiranja>()).BuildSessionFactory();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null; 
            }
        }
    }
}
