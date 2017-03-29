using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using Hippocrates.Data.Entiteti;
using Hippocrates.Data;

namespace Hippocrates
{
    public partial class ORMTestForma : Form
    {
        public ORMTestForma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();

            DomZdravlja dz = new DomZdravlja()
            {
                Mbr = "test",
                Lokacija = "test",
                Adresa = "test",
                Ime = "test",
                Opstina = "aaaaa"
            };
            IzabraniLekar il = new IzabraniLekar()
            {
                Jmbg = "55555",
                Ime = "ime",
                Datum_rodjenja = new DateTime(2000, 10, 14),
                Password = "test",
                Prezime = "prezie",
                Srednje_slovo = "s"
            };

            
            dz.Lekari.Add(il);
            il.RadiUDomuZdravlja = dz;
            s.Save(dz);
            

            /*
            s.Save(dz);
            il.RadiUDomuZdravlja = dz;
            s.Save(il);
            */
            s.Flush();
            s.Close();
        }
    }
}
