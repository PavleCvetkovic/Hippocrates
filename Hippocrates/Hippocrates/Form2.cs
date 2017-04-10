using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using Hippocrates.Data;
using Hippocrates.Data.Entiteti;
using NHibernate;
using FluentNHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace Hippocrates
{
    public partial class Form2 : MetroForm
    {
        private IList<Hippocrates.Data.Entiteti.DomZdravlja> domovi;
        //-----------------------
        MySqlDataAdapter adapter;
        DataSet dataSet;
        private string connstr;
        MySqlConnection conn;
        public Form2()
        {

            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1243, 822);
            this.MinimumSize = new System.Drawing.Size(1243, 822);
            //this.popunjavanje_dgva();
            dTP_lekara.CustomFormat = "dd ,MMMM ,yyyy";
            dTP_pacijenta.CustomFormat = "dd ,MMMM ,yyyy";
            connstr = "server=pavlecvetkovic.me; user=aki;charset=utf8;database=Hippocrates;port=3306;password=jetion123c;";
            conn = new MySqlConnection(connstr);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region dataGridViewi_na_tabu_za_pogled_na_bazu


        private void btn_dom_zdravlja_obicanPogled_Click(object sender, EventArgs e)
        {

            dGV_pogled_u_bazu.DataSource = null;
            dGV_pogled_u_bazu.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from DomZdravlja");
            IList<Hippocrates.Data.Entiteti.DomZdravlja> domovi = iq.List<Hippocrates.Data.Entiteti.DomZdravlja>();
            dGV_pogled_u_bazu.ColumnCount = 6;
            dGV_pogled_u_bazu.Columns[0].Name = "MBR";
            dGV_pogled_u_bazu.Columns[1].Name = "Ime";
            dGV_pogled_u_bazu.Columns[2].Name = "Lokacija";
            dGV_pogled_u_bazu.Columns[3].Name = "Adresa";
            dGV_pogled_u_bazu.Columns[4].Name = "Opstina";

            foreach (DomZdravlja d in domovi)
            {
                dGV_pogled_u_bazu.Rows.Add(d.Mbr, d.Ime, d.Lokacija, d.Adresa, d.Opstina);
            }

            s.Close();
        }

        private void btn_obican_pogled_Lekar_Click(object sender, EventArgs e)
        {
            dGV_pogled_u_bazu.DataSource = null;
            dGV_pogled_u_bazu.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from IzabraniLekar");
            IList<Hippocrates.Data.Entiteti.IzabraniLekar> lekari = iq.List<Hippocrates.Data.Entiteti.IzabraniLekar>();
           
            dGV_pogled_u_bazu.ColumnCount = 6;
            dGV_pogled_u_bazu.Columns[0].Name = "JMBG";
            dGV_pogled_u_bazu.Columns[1].Name = "Ime";
            dGV_pogled_u_bazu.Columns[2].Name = "Srednje slovo";
            dGV_pogled_u_bazu.Columns[3].Name = "Prezime";
            dGV_pogled_u_bazu.Columns[4].Name = "Password";
            dGV_pogled_u_bazu.Columns[5].Name = "Radi u";

            foreach (Data.Entiteti.IzabraniLekar l in lekari)
            {
                dGV_pogled_u_bazu.Rows.Add(l.Jmbg, l.Ime, l.Srednje_slovo, l.Prezime, l.Password, l.RadiUDomuZdravlja.Ime);
            }
            s.Close();
        }

        private void btn_obican_pogled_MedicOsoblje_Click(object sender, EventArgs e)
        {
            dGV_pogled_u_bazu.DataSource = null;
            dGV_pogled_u_bazu.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from MedicinskoOsoblje");
            IList<Hippocrates.Data.Entiteti.MedicinskoOsoblje> medOsoblje = iq.List<Hippocrates.Data.Entiteti.MedicinskoOsoblje>();
            dGV_pogled_u_bazu.ColumnCount = 7;
            dGV_pogled_u_bazu.Columns[0].Name = "JMBG";
            dGV_pogled_u_bazu.Columns[1].Name = "Ime";
            dGV_pogled_u_bazu.Columns[2].Name = "Srednje slovo";
            dGV_pogled_u_bazu.Columns[3].Name = "Prezime";
            dGV_pogled_u_bazu.Columns[4].Name = "Password";
            dGV_pogled_u_bazu.Columns[5].Name = "Radi u";
            dGV_pogled_u_bazu.Columns[6].Name = "Datum rodjenja";


            foreach (MedicinskoOsoblje m in medOsoblje)
            {
                dGV_pogled_u_bazu.Rows.Add(m.Jmbg, m.Ime, m.Srednje_slovo,m.Prezime,m.Password,m.RadiUDomuZdravlja.Ime,m.Datum_rodjenja.ToShortDateString());
            }

            s.Close();
        }

        private void btn_obican_pogled_Pacijent_Click(object sender, EventArgs e)
        {
            dGV_pogled_u_bazu.DataSource = null;
            dGV_pogled_u_bazu.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from Pacijent");
            IList<Hippocrates.Data.Entiteti.Pacijent> pacijenti = iq.List<Hippocrates.Data.Entiteti.Pacijent>();
            dGV_pogled_u_bazu.ColumnCount = 11;
            dGV_pogled_u_bazu.Columns[0].Name = "JMBG";
            dGV_pogled_u_bazu.Columns[1].Name = "Ime";
            dGV_pogled_u_bazu.Columns[2].Name = "Srednje slovo";
            dGV_pogled_u_bazu.Columns[3].Name = "Prezime";
            dGV_pogled_u_bazu.Columns[4].Name = "Datum rodjenja";
            dGV_pogled_u_bazu.Columns[5].Name = "Opstina";
            dGV_pogled_u_bazu.Columns[6].Name = "Pravo da zakaze";
            dGV_pogled_u_bazu.Columns[7].Name = "Lbo";
            dGV_pogled_u_bazu.Columns[8].Name = "Vazi do";
            dGV_pogled_u_bazu.Columns[9].Name = "Email";
            dGV_pogled_u_bazu.Columns[10].Name = "Telefon";
            foreach(Pacijent p in pacijenti)
            {
                dGV_pogled_u_bazu.Rows.Add(p.Jmbg, p.Ime, p.Srednje_slovo, p.Prezime, p.Datum_rodjenja.ToShortDateString(), p.Opstina, p.Pravo_da_zakaze, p.Lbo, p.Vazi_do.ToShortDateString(), p.Email, p.Telefon);
            }
            s.Close();
        }

        private void btn_pogled_admini_Click_1(object sender, EventArgs e)
        {
            dGV_pogled_u_bazu.DataSource = null;
            dGV_pogled_u_bazu.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from AdministratorDomaZdravlja");
            IList<Hippocrates.Data.Entiteti.AdministratorDomaZdravlja> admini = iq.List<Hippocrates.Data.Entiteti.AdministratorDomaZdravlja>();
            dGV_pogled_u_bazu.ColumnCount = 6;
            dGV_pogled_u_bazu.Columns[0].Name = "JMBG";
            dGV_pogled_u_bazu.Columns[1].Name = "Ime";
            dGV_pogled_u_bazu.Columns[2].Name = "Srednje slovo";
            dGV_pogled_u_bazu.Columns[3].Name = "Prezime";
            dGV_pogled_u_bazu.Columns[4].Name = "Radi u";
            dGV_pogled_u_bazu.Columns[5].Name = "Password";
            foreach(AdministratorDomaZdravlja a in admini)
            {
                dGV_pogled_u_bazu.Rows.Add(a.JMBG, a.Ime, a.SrednjeSlovo, a.Prezime, a.RadiUDomuZdravlja.Ime, a.Password);
            }
            
            s.Close();
        }
        #endregion

        #region dataGridViews_funkcije_za_popunjavanje

        private void dGV_unosenje_DZ_popuni()
        {
            dGV_pogled_u_bazu.DataSource = null;
            dGV_pogled_u_bazu.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from DomZdravlja");
            IList<Hippocrates.Data.Entiteti.DomZdravlja> domovi = iq.List<Hippocrates.Data.Entiteti.DomZdravlja>();
            dGV_unosenje_DZ.ColumnCount = 6;
            dGV_unosenje_DZ.Columns[0].Name = "MBR";
            dGV_unosenje_DZ.Columns[1].Name = "Ime";
            dGV_unosenje_DZ.Columns[2].Name = "Lokacija";
            dGV_unosenje_DZ.Columns[3].Name = "Adresa";
            dGV_unosenje_DZ.Columns[4].Name = "Opstina";

            foreach (DomZdravlja d in domovi)
            {
                dGV_unosenje_DZ.Rows.Add(d.Mbr, d.Ime, d.Lokacija, d.Adresa, d.Opstina);
            }

            s.Close();
        }
       
        private void dGV_unosenje_lekar_popuni()
        {
            dGV_unosenje_lekar.DataSource = null;
            dGV_unosenje_lekar.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from IzabraniLekar");
            IList<Hippocrates.Data.Entiteti.IzabraniLekar> lekari = iq.List<Hippocrates.Data.Entiteti.IzabraniLekar>();

            dGV_unosenje_lekar.ColumnCount = 6;
            dGV_unosenje_lekar.Columns[0].Name = "JMBG";
            dGV_unosenje_lekar.Columns[1].Name = "Ime";
            dGV_unosenje_lekar.Columns[2].Name = "Srednje slovo";
            dGV_unosenje_lekar.Columns[3].Name = "Prezime";
            dGV_unosenje_lekar.Columns[4].Name = "Password";
            dGV_unosenje_lekar.Columns[5].Name = "Radi u";

            foreach (Data.Entiteti.IzabraniLekar l in lekari)
            {
                dGV_unosenje_lekar.Rows.Add(l.Jmbg, l.Ime, l.Srednje_slovo, l.Prezime, l.Password, l.RadiUDomuZdravlja.Ime);
            }
            s.Close();
        }

        private void dGV_unosenje_pacijent_popuni()
        {
            dGV_unosenje_pacijent.DataSource = null;
            dGV_unosenje_pacijent.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from Pacijent");
            IList<Hippocrates.Data.Entiteti.Pacijent> pacijenti = iq.List<Hippocrates.Data.Entiteti.Pacijent>();
            dGV_unosenje_pacijent.ColumnCount = 11;
            dGV_unosenje_pacijent.Columns[0].Name = "JMBG";
            dGV_unosenje_pacijent.Columns[1].Name = "Ime";
            dGV_unosenje_pacijent.Columns[2].Name = "Srednje slovo";
            dGV_unosenje_pacijent.Columns[3].Name = "Prezime";
            dGV_unosenje_pacijent.Columns[4].Name = "Datum rodjenja";
            dGV_unosenje_pacijent.Columns[5].Name = "Opstina";
            dGV_unosenje_pacijent.Columns[6].Name = "Pravo da zakaze";
            dGV_unosenje_pacijent.Columns[7].Name = "Lbo";
            dGV_unosenje_pacijent.Columns[8].Name = "Vazi do";
            dGV_unosenje_pacijent.Columns[9].Name = "Email";
            dGV_unosenje_pacijent.Columns[10].Name = "Telefon";
            foreach (Pacijent p in pacijenti)
            {
                dGV_unosenje_pacijent.Rows.Add(p.Jmbg, p.Ime, p.Srednje_slovo, p.Prezime, p.Datum_rodjenja.ToShortDateString(), p.Opstina, p.Pravo_da_zakaze, p.Lbo, p.Vazi_do.ToShortDateString(), p.Email, p.Telefon);
            }
            s.Close();
        }

        private void dGV_unos_AdminDZ_popuni()
        {
            dGV_unos_AdminDZ.DataSource = null;
            dGV_unos_AdminDZ.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from AdministratorDomaZdravlja");
            IList<Hippocrates.Data.Entiteti.AdministratorDomaZdravlja> admini = iq.List<Hippocrates.Data.Entiteti.AdministratorDomaZdravlja>();
            dGV_unos_AdminDZ.ColumnCount = 6;
            dGV_unos_AdminDZ.Columns[0].Name = "JMBG";
            dGV_unos_AdminDZ.Columns[1].Name = "Ime";
            dGV_unos_AdminDZ.Columns[2].Name = "Srednje slovo";
            dGV_unos_AdminDZ.Columns[3].Name = "Prezime";
            dGV_unos_AdminDZ.Columns[4].Name = "Radi u";
            dGV_unos_AdminDZ.Columns[5].Name = "Password";
            foreach (AdministratorDomaZdravlja a in admini)
            {
                dGV_unos_AdminDZ.Rows.Add(a.JMBG, a.Ime, a.SrednjeSlovo, a.Prezime, a.RadiUDomuZdravlja.Ime, a.Password);
            }

            s.Close();
        }

        private void dGV_brisanje_dz_popuni()
        {
            dGV_brisanje_dz.DataSource = null;
            dGV_brisanje_dz.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from DomZdravlja");
            IList<Hippocrates.Data.Entiteti.DomZdravlja> domovi = iq.List<Hippocrates.Data.Entiteti.DomZdravlja>();
            dGV_brisanje_dz.ColumnCount = 6;
            dGV_brisanje_dz.Columns[0].Name = "MBR";
            dGV_brisanje_dz.Columns[1].Name = "Ime";
            dGV_brisanje_dz.Columns[2].Name = "Lokacija";
            dGV_brisanje_dz.Columns[3].Name = "Adresa";
            dGV_brisanje_dz.Columns[4].Name = "Opstina";

            foreach (DomZdravlja d in domovi)
            {
                dGV_brisanje_dz.Rows.Add(d.Mbr, d.Ime, d.Lokacija, d.Adresa, d.Opstina);
            }

            s.Close();
        }
        
        private void dGV_lekar_brisanje_popuni()
        {
            dGV_lekar_brisanje.DataSource = null;
            dGV_lekar_brisanje.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from IzabraniLekar");
            IList<Hippocrates.Data.Entiteti.IzabraniLekar> lekari = iq.List<Hippocrates.Data.Entiteti.IzabraniLekar>();

            dGV_lekar_brisanje.ColumnCount = 6;
            dGV_lekar_brisanje.Columns[0].Name = "JMBG";
            dGV_lekar_brisanje.Columns[1].Name = "Ime";
            dGV_lekar_brisanje.Columns[2].Name = "Srednje slovo";
            dGV_lekar_brisanje.Columns[3].Name = "Prezime";
            dGV_lekar_brisanje.Columns[4].Name = "Password";
            dGV_lekar_brisanje.Columns[5].Name = "Radi u";

            foreach (Data.Entiteti.IzabraniLekar l in lekari)
            {
                dGV_lekar_brisanje.Rows.Add(l.Jmbg, l.Ime, l.Srednje_slovo, l.Prezime, l.Password, l.RadiUDomuZdravlja.Ime);
            }
            s.Close();
        }

        private void dGV_pacijent_brisanje_popuni()
        {
            dGV_pacijent_brisanje.DataSource = null;
            dGV_pacijent_brisanje.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from Pacijent");
            IList<Hippocrates.Data.Entiteti.Pacijent> pacijenti = iq.List<Hippocrates.Data.Entiteti.Pacijent>();
            dGV_pacijent_brisanje.ColumnCount = 11;
            dGV_pacijent_brisanje.Columns[0].Name = "JMBG";
            dGV_pacijent_brisanje.Columns[1].Name = "Ime";
            dGV_pacijent_brisanje.Columns[2].Name = "Srednje slovo";
            dGV_pacijent_brisanje.Columns[3].Name = "Prezime";
            dGV_pacijent_brisanje.Columns[4].Name = "Datum rodjenja";
            dGV_pacijent_brisanje.Columns[5].Name = "Opstina";
            dGV_pacijent_brisanje.Columns[6].Name = "Pravo da zakaze";
            dGV_pacijent_brisanje.Columns[7].Name = "Lbo";
            dGV_pacijent_brisanje.Columns[8].Name = "Vazi do";
            dGV_pacijent_brisanje.Columns[9].Name = "Email";
            dGV_pacijent_brisanje.Columns[10].Name = "Telefon";
            foreach (Pacijent p in pacijenti)
            {
                dGV_pacijent_brisanje.Rows.Add(p.Jmbg, p.Ime, p.Srednje_slovo, p.Prezime, p.Datum_rodjenja.ToShortDateString(), p.Opstina, p.Pravo_da_zakaze, p.Lbo, p.Vazi_do.ToShortDateString(), p.Email, p.Telefon);
            }
            s.Close();
        }

        private void dGV_adminDZ_brisanje_popuni()
        {
            dGV_adminDZ_brisanje.DataSource = null;
            dGV_adminDZ_brisanje.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from AdministratorDomaZdravlja");
            IList<Hippocrates.Data.Entiteti.AdministratorDomaZdravlja> admini = iq.List<Hippocrates.Data.Entiteti.AdministratorDomaZdravlja>();
            dGV_adminDZ_brisanje.ColumnCount = 6;
            dGV_adminDZ_brisanje.Columns[0].Name = "JMBG";
            dGV_adminDZ_brisanje.Columns[1].Name = "Ime";
            dGV_adminDZ_brisanje.Columns[2].Name = "Srednje slovo";
            dGV_adminDZ_brisanje.Columns[3].Name = "Prezime";
            dGV_adminDZ_brisanje.Columns[4].Name = "Radi u";
            dGV_adminDZ_brisanje.Columns[5].Name = "Password";
            foreach (AdministratorDomaZdravlja a in admini)
            {
                dGV_adminDZ_brisanje.Rows.Add(a.JMBG, a.Ime, a.SrednjeSlovo, a.Prezime, a.RadiUDomuZdravlja.Ime, a.Password);
            }

            s.Close();
        }

        private void dGV_pacijenti_azuriranje_popuni()
        {
            dGV_pacijenti_azuriranje.DataSource = null;
            dGV_pacijenti_azuriranje.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from Pacijent");
            IList<Hippocrates.Data.Entiteti.Pacijent> pacijenti = iq.List<Hippocrates.Data.Entiteti.Pacijent>();
            dGV_pacijenti_azuriranje.ColumnCount = 11;
            dGV_pacijenti_azuriranje.Columns[0].Name = "JMBG";
            dGV_pacijenti_azuriranje.Columns[1].Name = "Ime";
            dGV_pacijenti_azuriranje.Columns[2].Name = "Srednje slovo";
            dGV_pacijenti_azuriranje.Columns[3].Name = "Prezime";
            dGV_pacijenti_azuriranje.Columns[4].Name = "Datum rodjenja";
            dGV_pacijenti_azuriranje.Columns[5].Name = "Opstina";
            dGV_pacijenti_azuriranje.Columns[6].Name = "Pravo da zakaze";
            dGV_pacijenti_azuriranje.Columns[7].Name = "Lbo";
            dGV_pacijenti_azuriranje.Columns[8].Name = "Vazi do";
            dGV_pacijenti_azuriranje.Columns[9].Name = "Email";
            dGV_pacijenti_azuriranje.Columns[10].Name = "Telefon";
            foreach (Pacijent p in pacijenti)
            {
                dGV_pacijenti_azuriranje.Rows.Add(p.Jmbg, p.Ime, p.Srednje_slovo, p.Prezime, p.Datum_rodjenja.ToShortDateString(), p.Opstina, p.Pravo_da_zakaze, p.Lbo, p.Vazi_do.ToShortDateString(), p.Email, p.Telefon);
            }
            s.Close();
        }

        private void dGV_azuriranje_adminDZ_popuni()
        {
            dGV_azuriranje_adminDZ.DataSource = null;
            dGV_azuriranje_adminDZ.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from AdministratorDomaZdravlja");
            IList<Hippocrates.Data.Entiteti.AdministratorDomaZdravlja> admini = iq.List<Hippocrates.Data.Entiteti.AdministratorDomaZdravlja>();
            dGV_azuriranje_adminDZ.ColumnCount = 6;
            dGV_azuriranje_adminDZ.Columns[0].Name = "JMBG";
            dGV_azuriranje_adminDZ.Columns[1].Name = "Ime";
            dGV_azuriranje_adminDZ.Columns[2].Name = "Srednje slovo";
            dGV_azuriranje_adminDZ.Columns[3].Name = "Prezime";
            dGV_azuriranje_adminDZ.Columns[4].Name = "Radi u";
            dGV_azuriranje_adminDZ.Columns[5].Name = "Password";
            foreach (AdministratorDomaZdravlja a in admini)
            {
                dGV_azuriranje_adminDZ.Rows.Add(a.JMBG, a.Ime, a.SrednjeSlovo, a.Prezime, a.RadiUDomuZdravlja.Ime, a.Password);
            }

            s.Close();
        }

        private void dGV_domZdravlja_azuriranje_popuni()
        {
            dGV_domZdravlja_azuriranje.DataSource = null;
            dGV_domZdravlja_azuriranje.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from DomZdravlja");
            IList<Hippocrates.Data.Entiteti.DomZdravlja> domovi = iq.List<Hippocrates.Data.Entiteti.DomZdravlja>();
            dGV_domZdravlja_azuriranje.ColumnCount = 6;
            dGV_domZdravlja_azuriranje.Columns[0].Name = "MBR";
            dGV_domZdravlja_azuriranje.Columns[1].Name = "Ime";
            dGV_domZdravlja_azuriranje.Columns[2].Name = "Lokacija";
            dGV_domZdravlja_azuriranje.Columns[3].Name = "Adresa";
            dGV_domZdravlja_azuriranje.Columns[4].Name = "Opstina";

            foreach (DomZdravlja d in domovi)
            {
                dGV_domZdravlja_azuriranje.Rows.Add(d.Mbr, d.Ime, d.Lokacija, d.Adresa, d.Opstina);
            }

            s.Close();
        }

        private void dGV_lekari_azuriranje_popuni()
        {
            dGV_lekari_azuriranje.DataSource = null;
            dGV_lekari_azuriranje.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from IzabraniLekar");
            IList<Hippocrates.Data.Entiteti.IzabraniLekar> lekari = iq.List<Hippocrates.Data.Entiteti.IzabraniLekar>();

            dGV_lekari_azuriranje.ColumnCount = 6;
            dGV_lekari_azuriranje.Columns[0].Name = "JMBG";
            dGV_lekari_azuriranje.Columns[1].Name = "Ime";
            dGV_lekari_azuriranje.Columns[2].Name = "Srednje slovo";
            dGV_lekari_azuriranje.Columns[3].Name = "Prezime";
            dGV_lekari_azuriranje.Columns[4].Name = "Password";
            dGV_lekari_azuriranje.Columns[5].Name = "Radi u";

            foreach (Data.Entiteti.IzabraniLekar l in lekari)
            {
                dGV_lekari_azuriranje.Rows.Add(l.Jmbg, l.Ime, l.Srednje_slovo, l.Prezime, l.Password, l.RadiUDomuZdravlja.Ime);
            }
            s.Close();
        }

        #endregion

        #region tab_change
        private void GeneralControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(GeneralControl.SelectedIndex == 1)
            {
                dGV_unosenje_DZ_popuni();
            }
            else if(GeneralControl.SelectedIndex == 2)
            {
                dGV_brisanje_dz_popuni();
            }
            else if(GeneralControl.SelectedIndex == 3)
            {
                dGV_pacijenti_azuriranje_popuni();
            }
            
        }
        private void TabControl_za_unos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TabControl_za_unos.SelectedIndex == 0)
            {
                dGV_unosenje_DZ_popuni();
            }   
            else if(TabControl_za_unos.SelectedIndex == 1)
            {
                dGV_unosenje_lekar_popuni();
            }
            else if (TabControl_za_unos.SelectedIndex == 2)
            {
                dGV_unosenje_pacijent_popuni();
            }
            else if (TabControl_za_unos.SelectedIndex == 3)
            {
                dGV_unos_AdminDZ_popuni();
            }
            else if (TabControl_za_unos.SelectedIndex == 4)
            {
                //tek treba da se dodaju kontrole 
            }
           
        }
        private void tabControl_za_brisanje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl_za_brisanje.SelectedIndex == 0)
            {
                dGV_brisanje_dz_popuni();
            }
            else if (tabControl_za_brisanje.SelectedIndex == 1)
            {
                dGV_lekar_brisanje_popuni();
            }
            else if (tabControl_za_brisanje.SelectedIndex == 2)
            {
                dGV_pacijent_brisanje_popuni();
            }
            else if (tabControl_za_brisanje.SelectedIndex == 3)
            {
                dGV_adminDZ_brisanje_popuni();
            }
            else if (tabControl_za_brisanje.SelectedIndex == 4)
            {
                //tek trebaju kontrole da se dodaju
            }

        }
        private void tab_azuriranje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tab_azuriranje.SelectedIndex == 0)
            {
                dGV_pacijenti_azuriranje_popuni();
            }
            else if(tab_azuriranje.SelectedIndex == 1)
            {
                dGV_azuriranje_adminDZ_popuni();
            }
            else if (tab_azuriranje.SelectedIndex == 2)
            {
                dGV_domZdravlja_azuriranje_popuni();
            }
            else if (tab_azuriranje.SelectedIndex == 3)
            {
                dGV_lekari_azuriranje_popuni();
            }
            else if (tab_azuriranje.SelectedIndex == 4)
            {
                //tek trebaju da se dodaju kontrole
            }
          
        }
        #endregion
        //odavde je stari kod(neupotrebljiv)
        #region Unos_podataka


        #region tab_za_unos_DZ
        private void btn_unosDomaZdr_Click(object sender, EventArgs e)
        {
            
            ISession s = DataLayer.GetSession();

            Data.Entiteti.DomZdravlja dz = new Data.Entiteti.DomZdravlja()
            {
                Mbr = tb_MBR_doma_zdravlja.Text,
                Ime = tb_ime_doma_zdravlja.Text,
                Adresa = tb_adresa_doma_zdravlja.Text,
                Lokacija = tb_lokacija_doma_zdravlja.Text,
                Opstina = tb_opstina_doma_zdravlja.Text
            };

            s.Save(dz);
            s.Flush();

           
            s.Close();
            MessageBox.Show("Uspeno ste uneli nov dom zdravlja ");
        }

        #endregion

        #region tab_za_Unos_lekara
        public string pomIndex;
        private void dgv_odabirDz_unos_lekara_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = dgv_odabirDz_unos_lekara.CurrentCell.RowIndex;
            pomIndex = dgv_odabirDz_unos_lekara.Rows[rowindex].Cells[0].Value.ToString();
        }
        private void btn_Unesi_lekara_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Data.Entiteti.IzabraniLekar il = new Data.Entiteti.IzabraniLekar()
            {
                Jmbg = tb_jmbg_lekara.Text,
                Ime = tb_ime_lekara_unos.Text,
                Datum_rodjenja = dTP_lekara.Value,
                Password = tb_pass_lekara_unos.Text,
                Prezime = tb_prezime_lekara.Text,
                Srednje_slovo = tb_srednje_slovo.Text
            };
            
            Data.Entiteti.DomZdravlja dzi = new Data.Entiteti.DomZdravlja();
            foreach(Data.Entiteti.DomZdravlja dz in domovi)
            {
                if(dz.Mbr == pomIndex)
                {
                    dzi = dz;
                }
            }
            
            dzi.Lekari.Add(il);
            il.RadiUDomuZdravlja = dzi;

            s.Save(il);
            s.Flush();

            
            s.Close();

            MessageBox.Show("Uspeno ste uneli novog lekara ");


        }
        #endregion

        #region tab_za_Unos_pacijenta

        private void btn_unesi_pacijenta_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Data.Entiteti.Pacijent pac1 = new Data.Entiteti.Pacijent()
            {
                Jmbg = tb_JMBG_pacijenta.Text,
                Ime = tb_ime_pac.Text,
                Prezime = tb_prezime_pacijenta.Text,
                Datum_rodjenja = dTP_pacijenta.Value,
                Telefon =  tb_pac_unos_brTel.Text,
                Lbo = tb_LBO_pacujenta.Text,
                Opstina = tb_opstina.Text,
                Srednje_slovo = tb_srednjeSlovo.Text,
                Vazi_do = dTP_Vazi_do.Value,
            };
            s.Save(pac1);
            s.Flush();
            s.Close();
            
            MessageBox.Show("Uspeno ste uneli novog pacijenta");
        }


        #endregion

        #region tab_za_Unos_admina_domZ

        private void dgv_admin_unos_izbor_dz_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_admin_unos_izbor_dz.Rows.Count > 0)
            {
                int rowindex = dgv_admin_unos_izbor_dz.CurrentCell.RowIndex;
                pomIndex = dgv_admin_unos_izbor_dz.Rows[rowindex].Cells[0].Value.ToString();
            }
        }

        private void btn_unesi_adminaDZ_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Data.Entiteti.AdministratorDomaZdravlja admin = new Data.Entiteti.AdministratorDomaZdravlja()
            {
                JMBG = tb_adminDZ_azuriranje_JMBG.Text,
                Ime = tb_adminDZ_azuriranje_Ime.Text,
                SrednjeSlovo = tb_adminDZ_azuriranje_SredSlovo.Text,
                Prezime = tb_adminDZ_azuriranje_Prezime.Text,
                Password = tb_adminDZ_azuriranje_PASS.Text
            };
            Data.Entiteti.DomZdravlja dzi = new Data.Entiteti.DomZdravlja();
            foreach (Data.Entiteti.DomZdravlja dz in domovi)
            {
                if (dz.Mbr == pomIndex)
                {
                    dzi = dz;
                }
            }
            dzi.Administratori.Add(admin);
            admin.RadiUDomuZdravlja = dzi;
            s.Save(admin);
            s.Flush();
            s.Close();
            
            MessageBox.Show("Uspeno ste uneli novog admina ");
        }

        #endregion

            #endregion

        #region tab_za_brisanje
        
        #region tab_za_brisanje_dz

        private void btn_brisanje_dz_Click(object sender, EventArgs e)
        {
            /* OVO FUNKCIJA NE RADI JOS UVEK
            ISession s = DataLayer.GetSession();
            Data.Entiteti.DomZdravlja dz = new Data.Entiteti.DomZdravlja();
            foreach(Data.Entiteti.DomZdravlja d in domovi)
            {
                if(pomIndex == d.Mbr)
                {
                    dz = d;
                }
            }

            foreach(Data.Entiteti.IzabraniLekar i in dz.Lekari)
            {
                i.RadiUDomuZdravlja = null;
            }
            foreach(Data.Entiteti.MedicinskoOsoblje m in dz.MedicinskoOsoblje)
            {
                m.RadiUDomuZdravlja = null;
            }
            foreach(Data.Entiteti.AdministratorDomaZdravlja a in dz.Administratori)
            {
                a.RadiUDomuZdravlja = null;
            }

            dz.Lekari.Clear();
            dz.MedicinskoOsoblje.Clear();
            dz.Administratori.Clear();
            s.Flush();
            s.Close();
            s = DataLayer.GetSession();
            s.Delete(dz);
            s.Flush();
            s.Close();
            popunjavanje_dgv_dz();
            MessageBox.Show("Uspeno ste obrisali dom zdravlja");*/

        }
        private void dGV_brisanje_dz_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = dGV_brisanje_dz.CurrentCell.RowIndex;
            pomIndex = dGV_brisanje_dz.Rows[rowindex].Cells[0].Value.ToString();
        }

        #endregion

        #region tab_za_brisanje_lekara
        private void btn_obrisi_lekara_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region tab_za_brisanje_pacijenata
        private void btn_brisanje_pacijenta_Click(object sender, EventArgs e)
        {
            
        }


        #endregion

        #region tab_za_brisanje_admina_domZ

        private void btn_brisanje_admina_DZ_Click(object sender, EventArgs e)
        {

            
        }

        #endregion

        #endregion

        #region tab_za_azuriranje
        #region pomocnePromenljive
        private string mbr_za_menjanje;
        private string jmbg_lekara_zaMenjanje;
        private string jmbg_pacijenta_zaMenjanje;
        string s;
        string s2;
        string s3;
        string s4;
        string s5;
        string s6;
        string s7;
        string s8;
        string s9;
        string s10;
        string s11;
        #endregion

        #region dataGridViewi_na_tabu_za_azuriranje_baze

       

        #endregion

        #region tab_za_azuriranje_domova_zdravlja


        private void dGV_domZdravlja_azuriranje_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_azuriranje_domZ_Click(object sender, EventArgs e)
        { 
            try
            {
                conn.Open();
                string commandSqlUpdate = "UPDATE DOM_ZDRAVLJA SET MBR = '"+ tb_azuriranje_MBR_domZ.Text +"',IME ='"+ tb_azuriranje_Ime_domZ.Text + "',OPŠTINA='"+ tb_azuriranje_opstina_domZ.Text +"',LOKACIJA='"+ tb_azuriranje_lokacija_domZ.Text +"',ADRESA='"+ tb_azuriranje_adresa_domZ.Text +"' WHERE MBR='"+ mbr_za_menjanje +"'";
                MySqlCommand mcc = new MySqlCommand(commandSqlUpdate, conn);
                mcc.ExecuteNonQuery();
                MessageBox.Show("Uspesno ste azurirali dom zdravlja u bazi podatka");
                //---
                string sqlcommand = "SELECT * FROM DOM_ZDRAVLJA";
                adapter = new MySqlDataAdapter(sqlcommand, connstr);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

                dataSet = new DataSet();
                adapter.Fill(dataSet, "DOM_ZDRAVLJA");
                dGV_domZdravlja_azuriranje.DataSource = dataSet;
                dGV_domZdravlja_azuriranje.DataMember = "DOM_ZDRAVLJA";
                //---
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem" + ex);
                conn.Close();
            }
        }



        #endregion

        #region tab_za_azuriranje_lekara

        private void dGV_lekari_azuriranje_SelectionChanged(object sender, EventArgs e)
        {/*
            int rowindex = dGV_lekari_azuriranje.CurrentCell.RowIndex;
             s  = dGV_lekari_azuriranje.Rows[rowindex].Cells[0].Value.ToString();
             s2 = dGV_lekari_azuriranje.Rows[rowindex].Cells[1].Value.ToString();
             s3 = dGV_lekari_azuriranje.Rows[rowindex].Cells[2].Value.ToString();
             s4 = dGV_lekari_azuriranje.Rows[rowindex].Cells[3].Value.ToString();
             s5 = dGV_lekari_azuriranje.Rows[rowindex].Cells[4].Value.ToString();
             s6 = dGV_lekari_azuriranje.Rows[rowindex].Cells[5].Value.ToString();
             s7 = dGV_lekari_azuriranje.Rows[rowindex].Cells[6].Value.ToString();
             s8 = dGV_lekari_azuriranje.Rows[rowindex].Cells[7].Value.ToString(); 
            tb_azuriranje_jmbg_lekar.Text = s;
            tb_azuriranje_ime_lekar.Text = s2;
            tb_azuriranje_lekar_srednjeSlovo.Text = s3;
            tb_azuriranje_prezime_lekar.Text = s4;
            dTP_azuriranje_lekar.Value = DateTime.Parse(s5);
            tb_azuriranje_mbrzu_lekar.Text = s6;
            if(s7 == "1")
            {
                cb_azuriranje_smenaPrva_leakr.Checked = true ;
                cb_azuriranje_smenaDruga_leakr.Checked = false;
                
            }
            else
            {
                cb_azuriranje_smenaPrva_leakr.Checked = false;
                cb_azuriranje_smenaDruga_leakr.Checked = true;
            }
            tb_azuriranje_pass_lekar.Text = s8;
            jmbg_lekara_zaMenjanje = s;*/
        }

        private void btn_azuriranje_lekara_Click(object sender, EventArgs e)
        {
            int smena = 1;
            if(cb_azuriranje_smenaDruga_leakr.Checked)
            {
                smena = 2;
            }
            try
            {
                conn.Open();
                string commandSqlUpdate = "UPDATE IZABRANI_LEKAR SET JMBG='"+ tb_azuriranje_jmbg_lekar.Text + "',IME='"+ tb_azuriranje_ime_lekar.Text + "',SREDNJE_SLOVO='"+ tb_azuriranje_lekar_srednjeSlovo.Text + "',PREZIME='"+ tb_azuriranje_prezime_lekar.Text + "',DATUM_ROĐENJA='"+ dTP_azuriranje_lekar.Value.ToString("yyyy-MM-dd") + "',MBRZU='"+ tb_azuriranje_mbrzu_lekar.Text + "',SMENA='"+smena+"',PASSWORD='"+ tb_azuriranje_pass_lekar.Text + "' WHERE JMBG='"+ jmbg_lekara_zaMenjanje + "'";
                MySqlCommand mcc = new MySqlCommand(commandSqlUpdate, conn);
                mcc.ExecuteNonQuery();
                MessageBox.Show("Uspesno ste azurirali lekara u bazi podatka");
                //---
                string sqlcommand = "SELECT * FROM IZABRANI_LEKAR";
                adapter = new MySqlDataAdapter(sqlcommand, connstr);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

                dataSet = new DataSet();
                adapter.Fill(dataSet, "IZABRANI_LEKAR");
                dGV_lekari_azuriranje.DataSource = dataSet;
                dGV_lekari_azuriranje.DataMember = "IZABRANI_LEKAR";

                

                //----
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Problem" + ex);
            }
        }






        #endregion

        #region tab_za_azuriranje_pacijenta
        private int pravo_da_zakaze;
        private void dGV_pacijenti_azuriranje_SelectionChanged(object sender, EventArgs e)
        {/*
            int rowindex = dGV_pacijenti_azuriranje.CurrentCell.RowIndex;
             s = dGV_pacijenti_azuriranje.Rows[rowindex].Cells[0].Value.ToString();
            s2 = dGV_pacijenti_azuriranje.Rows[rowindex].Cells[1].Value.ToString();
            s3 = dGV_pacijenti_azuriranje.Rows[rowindex].Cells[2].Value.ToString();
            s4 = dGV_pacijenti_azuriranje.Rows[rowindex].Cells[3].Value.ToString();
            s5 = dGV_pacijenti_azuriranje.Rows[rowindex].Cells[4].Value.ToString();
            s6 = dGV_pacijenti_azuriranje.Rows[rowindex].Cells[5].Value.ToString();
            s7 = dGV_pacijenti_azuriranje.Rows[rowindex].Cells[6].Value.ToString();
            s8 = dGV_pacijenti_azuriranje.Rows[rowindex].Cells[7].Value.ToString();
            s9 = dGV_pacijenti_azuriranje.Rows[rowindex].Cells[8].Value.ToString();
            s10 = dGV_pacijenti_azuriranje.Rows[rowindex].Cells[9].Value.ToString();
            jmbg_pacijenta_zaMenjanje = s;

            tb_pacijent_azuriranje_jmbg.Text = s;
            tb_pacijent_azuriranje_lbo.Text = s8;
            tb_pacijent_azuriranje_ime.Text = s2;
            tb_pacijent_azuriranje_prezime.Text = s4;
            tb_pacijent_azuriranje_opstina.Text = s6;
            dTP_pacijent_azuriranje.Value = DateTime.Parse(s5);
            tb_pacijent_azuriranje_srednjeSlovo.Text = s3;
            tb_pacijent_azuriranje_MATBRL.Text = s9;
            dTP_vaziDo_pacijent.Value = DateTime.Parse(s10);
            if (Int32.Parse(s7) == 1)
            {
                cB_pravo_da_zakaze.Checked = true;
                pravo_da_zakaze = 1;
            }
            else
            {
                pravo_da_zakaze = 0;
                cB_pravo_da_zakaze.Checked = false;
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!cB_pravo_da_zakaze.Checked)
            {
                pravo_da_zakaze = 0;
            }
            else
            {
                pravo_da_zakaze = 1;
            }
            try
            {
                conn.Open();
                string commandSqlUpdate = "UPDATE PACIJENT SET JMBG='" + tb_pacijent_azuriranje_jmbg.Text + "',IME='" + tb_pacijent_azuriranje_ime.Text + "',SREDNJE_SLOVO='" + tb_pacijent_azuriranje_srednjeSlovo.Text + "',PREZIME='" + tb_pacijent_azuriranje_prezime.Text + "',DATUM_ROĐENJA='" + dTP_pacijent_azuriranje.Value.ToString("yyyy-MM-dd") + "',OPŠTINA='" + tb_pacijent_azuriranje_opstina.Text + "',PRAVO_DA_ZAKAŽE='" + pravo_da_zakaze + "',LBO='" + tb_pacijent_azuriranje_lbo.Text + "',MATBRL='" + tb_pacijent_azuriranje_MATBRL.Text + "',VAŽI_DO='" + dTP_vaziDo_pacijent.Value.ToString("yyyy-MM-dd") + "' WHERE JMBG='" + jmbg_pacijenta_zaMenjanje + "'";
                MySqlCommand mcc = new MySqlCommand(commandSqlUpdate, conn);
                mcc.ExecuteNonQuery();
                MessageBox.Show("Uspesno ste azurirali pacijenta u bazi podatka");
                //--- 
                string sqlcommand = "SELECT * FROM PACIJENT";
                adapter = new MySqlDataAdapter(sqlcommand, connstr);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

                dataSet = new DataSet();
                adapter.Fill(dataSet, "PACIJENT");
                dGV_pacijenti_azuriranje.DataSource = dataSet;
                dGV_pacijenti_azuriranje.DataMember = "PACIJENT";



                //---- 
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Problem" + ex);
            }
        }



        #endregion

        #region tab_za_azuriranje_adminaDz

        private void btn_azuriranje_adminDz_Click(object sender, EventArgs e)
        {
            //ADMINISTRATOR_DOM_ZDRAVLJA
            try
            {
                conn.Open();
                string commandSqlUpdate = "UPDATE ADMINISTRATOR_DOM_ZDRAVLJA SET JMBG='" + tb_azuriranje_admindz_jmbg.Text + "',IME='" + tb_azuriranje_admindz_ime.Text + "',SREDNJE_SLOVO='" + tb_azuriranje_admindz_srednjeS.Text + "',PREZIME='" + tb_azuriranje_admindz_prezime.Text + "',MBRZU='" + tb_azuriranje_admindz_mbrzu.Text + "',PASSWORD='" + tb_azuriranje_admindz_password.Text + "' WHERE JMBG='" + tb_azuriranje_admindz_jmbg.Text + "'";
                MySqlCommand mcc = new MySqlCommand(commandSqlUpdate, conn);
                mcc.ExecuteNonQuery();
                MessageBox.Show("Uspesno ste azurirali administratora doma zdravlja u bazi podatka");
                //---
                string sqlcommand = "SELECT * FROM ADMINISTRATOR_DOM_ZDRAVLJA";
                adapter = new MySqlDataAdapter(sqlcommand, connstr);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(adapter);

                dataSet = new DataSet();
                adapter.Fill(dataSet, "ADMINISTRATOR_DOM_ZDRAVLJA");
                dGV_azuriranje_adminDZ.DataSource = dataSet;
                dGV_azuriranje_adminDZ.DataMember = "ADMINISTRATOR_DOM_ZDRAVLJA";
                //---
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem" + ex);
                conn.Close();
            }
        }
        
        #endregion

        #endregion

        #region validacija_za_unos_u_kontrole

        //tab za unos doma zdravlja
        private void tb_MBR_doma_zdravlja_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); 
        }

        private void tb_ime_doma_zdravlja_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void tb_lokacija_doma_zdravlja_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_opstina_doma_zdravlja_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_adresa_doma_zdravlja_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || char.IsDigit(e.KeyChar));
        }

        //tab za unos lekara
        private void tb_jmbg_lekara_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_mbrzu_lekara_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_ime_lekara_unos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_prezime_lekara_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_pass_lekara_unos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar));
        }

        private void tb_srednje_slovo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_lekar_unos_brTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        //tab za unos pacijenta
        private void tb_JMBG_pacijenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_LBO_pacujenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_ime_pac_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_prezime_pacijenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_opstina_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_srednjeSlovo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        //tab za unos admina domaZdravlja
        private void tb_adminDZ_azuriranje_JMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void tb_adminDZ_azuriranje_Ime_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_adminDZ_azuriranje_SredSlovo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_adminDZ_azuriranje_Prezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_adminDZ_azuriranje_MBRZU_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_adminDZ_azuriranje_PASS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar));
        }


        //tab za brisanje doma zdravlja
        private void tb_MBR_za_brisanje_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //tab za brisanje lekara
        private void tB_JMBG_brisanje_lekara_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //tab za brisanje pacijenta
        private void tb_JMBG_brisanja_pacijenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //tab za brisanje admina DomaZ
        private void tb_JMBG_brisanja_administratora_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        //tab azuriranje doma zdravlja
        private void tb_azuriranje_MBR_domZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_azuriranje_Ime_domZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_azuriranje_lokacija_domZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_azuriranje_adresa_domZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || char.IsDigit(e.KeyChar));
        }

        private void tb_azuriranje_opstina_domZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //tab za azuriranje lekara
        private void tb_azuriranje_jmbg_lekar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_azuriranje_mbrzu_lekar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_azuriranje_ime_lekar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_azuriranje_prezime_lekar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_azuriranje_lekar_srednjeSlovo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_azuriranje_pass_lekar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar));
        }

        //tab za azuriranje pacijenta
        private void tb_pacijent_azuriranje_jmbg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_pacijent_azuriranje_lbo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_pacijent_azuriranje_ime_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_pacijent_azuriranje_prezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_pacijent_azuriranje_MATBRL_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_pacijent_azuriranje_opstina_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }


        //tab za azuriranje admina domaZ
        private void tb_azuriranje_admindz_jmbg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_azuriranje_admindz_ime_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_azuriranje_admindz_srednjeS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_azuriranje_admindz_prezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_azuriranje_admindz_mbrzu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_azuriranje_admindz_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsDigit(e.KeyChar));
        }











        #endregion

        
    }
}
