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
        
        public string pomIndex;
        public Form2()
        {

            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1268, 872);
            this.MinimumSize = new System.Drawing.Size(1268, 872);
            dTP_lekara.CustomFormat = "dd ,MMMM ,yyyy";
            dTP_pacijenta.CustomFormat = "dd ,MMMM ,yyyy";
            pomIndex = string.Empty;
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

            
            dGV_pogled_u_bazu.ColumnCount = 5;
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
        
       
        
        private void popuni_dgv_domovi(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Columns.Clear();

            ISession s = Hippocrates.Data.DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from DomZdravlja");
            IList<Hippocrates.Data.Entiteti.DomZdravlja> domovi = iq.List<Hippocrates.Data.Entiteti.DomZdravlja>();
            dgv.ColumnCount = 6;
            dgv.Columns[0].Name = "MBR";
            dgv.Columns[1].Name = "Ime";
            dgv.Columns[2].Name = "Lokacija";
            dgv.Columns[3].Name = "Adresa";
            dgv.Columns[4].Name = "Opstina";

            foreach (DomZdravlja d in domovi)
            {
                dgv.Rows.Add(d.Mbr, d.Ime, d.Lokacija, d.Adresa, d.Opstina);
            }

            s.Close();
        }
        
        private void popuni_dgv_lekari(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from IzabraniLekar");
            IList<Hippocrates.Data.Entiteti.IzabraniLekar> lekari = iq.List<Hippocrates.Data.Entiteti.IzabraniLekar>();

            dgv.ColumnCount = 6;
            dgv.Columns[0].Name = "JMBG";
            dgv.Columns[1].Name = "Ime";
            dgv.Columns[2].Name = "Srednje slovo";
            dgv.Columns[3].Name = "Prezime";
            dgv.Columns[4].Name = "Password";
            dgv.Columns[5].Name = "Radi u";

            foreach (Data.Entiteti.IzabraniLekar l in lekari)
            {
                dgv.Rows.Add(l.Jmbg, l.Ime, l.Srednje_slovo, l.Prezime, l.Password, l.RadiUDomuZdravlja.Ime);
            }
            s.Close();
        }

        private void popuni_dgv_lekari(DataGridView dgv,String parametar)
        {
            dgv.DataSource = null;
            dgv.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from IzabraniLekar");
            IList<Hippocrates.Data.Entiteti.IzabraniLekar> lekari = iq.List<Hippocrates.Data.Entiteti.IzabraniLekar>();

            dgv.ColumnCount = 6;

            dgv.Columns[0].Name = "Ime";
            dgv.Columns[1].Name = "Srednje slovo";
            dgv.Columns[2].Name = "Prezime";


            foreach (Data.Entiteti.IzabraniLekar l in lekari)
            {
                if (parametar == l.RadiUDomuZdravlja.Opstina)
                    dgv.Rows.Add(l.Ime, l.Srednje_slovo, l.Prezime);
            }
            s.Close();
        }

        private void popuni_dgv_admini(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from AdministratorDomaZdravlja");
            IList<Hippocrates.Data.Entiteti.AdministratorDomaZdravlja> admini = iq.List<Hippocrates.Data.Entiteti.AdministratorDomaZdravlja>();
            dgv.ColumnCount = 6;
            dgv.Columns[0].Name = "JMBG";
            dgv.Columns[1].Name = "Ime";
            dgv.Columns[2].Name = "Srednje slovo";
            dgv.Columns[3].Name = "Prezime";
            dgv.Columns[4].Name = "Radi u";
            dgv.Columns[5].Name = "Password";
            foreach (AdministratorDomaZdravlja a in admini)
            {
                dgv.Rows.Add(a.JMBG, a.Ime, a.SrednjeSlovo, a.Prezime, a.RadiUDomuZdravlja.Ime, a.Password);
            }

            s.Close();
        }

        private void popuni_dgv_pacijenti(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from Pacijent");
            IList<Hippocrates.Data.Entiteti.Pacijent> pacijenti = iq.List<Hippocrates.Data.Entiteti.Pacijent>();
            dgv.ColumnCount = 11;
            dgv.Columns[0].Name = "JMBG";
            dgv.Columns[1].Name = "Ime";
            dgv.Columns[2].Name = "Srednje slovo";
            dgv.Columns[3].Name = "Prezime";
            dgv.Columns[4].Name = "Datum rodjenja";
            dgv.Columns[5].Name = "Opstina";
            dgv.Columns[6].Name = "Pravo da zakaze";
            dgv.Columns[7].Name = "Lbo";
            dgv.Columns[8].Name = "Vazi do";
            dgv.Columns[9].Name = "Email";
            dgv.Columns[10].Name = "Telefon";
            foreach (Pacijent p in pacijenti)
            {
                dgv.Rows.Add(p.Jmbg, p.Ime, p.Srednje_slovo, p.Prezime, p.Datum_rodjenja.ToShortDateString(), p.Opstina, p.Pravo_da_zakaze, p.Lbo, p.Vazi_do.ToShortDateString(), p.Email, p.Telefon);
            }
            s.Close();
        }

        private void popuni_dgv_medOsoblje(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from MedicinskoOsoblje");
            IList<Hippocrates.Data.Entiteti.MedicinskoOsoblje> medOsoblje = iq.List<Hippocrates.Data.Entiteti.MedicinskoOsoblje>();
            dgv.ColumnCount = 7;
            dgv.Columns[0].Name = "JMBG";
            dgv.Columns[1].Name = "Ime";
            dgv.Columns[2].Name = "Srednje slovo";
            dgv.Columns[3].Name = "Prezime";
            dgv.Columns[4].Name = "Password";
            dgv.Columns[5].Name = "Radi u";
            dgv.Columns[6].Name = "Datum rodjenja";


            foreach (MedicinskoOsoblje m in medOsoblje)
            {
                dgv.Rows.Add(m.Jmbg, m.Ime, m.Srednje_slovo, m.Prezime, m.Password, m.RadiUDomuZdravlja.Ime, m.Datum_rodjenja.ToShortDateString());
            }

            s.Close();
        }
        //-------------------------------------------
        private void popuni_dGV_azuriranje_pacijent_VakcinePacijentove(DataGridView dgv,Pacijent p)
        {
            dgv.DataSource = null;
            dgv.Columns.Clear();
            ISession s1 = DataLayer.GetSession();
            IList<PrimioVakcinu> vakcinePac = p.PrimioVakcinuVakcine;
            List<Vakcina> vakcineZaDgv = new List<Vakcina>();
            foreach (PrimioVakcinu pv in vakcinePac)
            {
                vakcineZaDgv.Add(pv.Id.PrimioVakcina);
            }
            dgv.DataSource = vakcineZaDgv;
            dgv.Columns[3].Visible = false;
            s1.Close();
        }
        
        private void popuni_dgv_azuriranje_pac_terapije(DataGridView dgv,Pacijent p)
        {
            dgv.DataSource = null;
            dgv.Columns.Clear();
            ISession s1 = DataLayer.GetSession();
            IList<Terapija> terapije = p.Terapije;
            dgv.ColumnCount = 2;
            dgv.Columns[0].Name = "Opis";
            dgv.Columns[1].Name = "Dijagnoza";
            foreach (Terapija t in terapije)
            {
                dgv_azuriranje_pac_terapije.Rows.Add(t.Opis, t.TerapijaDijagnoza.Ime);
            }
            s1.Close();
        }
        
        private void popuni_dGV_pac_dijagnoze(DataGridView dgv, Pacijent p)
        {
            dgv.DataSource = null;
            dgv.Columns.Clear();
            ISession s1 = DataLayer.GetSession();
            IList<Dijagnostifikovano> dijagnoze = p.DijagnostifikovanoDijagnoze;
            dgv.ColumnCount = 2;
            dgv.Columns[0].Name = "Sifra";
            dgv.Columns[1].Name = "Ime";
            foreach(Dijagnostifikovano d in dijagnoze)
            {
                dgv.Rows.Add(d.Id.DijagnozaDijagnoza.Sifra, d.Id.DijagnozaDijagnoza.Ime);
            }
            s1.Close();
        }

        private void popuni_lb_vakcine(ListBox lb,Pacijent pac)
        {
            lb.Items.Clear();
            ISession s1 = DataLayer.GetSession();
            IList<PrimioVakcinu> vakcine = pac.PrimioVakcinuVakcine;
            foreach (PrimioVakcinu pv in vakcine)
            {
                lb.Items.Add(pv.Id.PrimioVakcina.Sifra + " " + pv.Id.PrimioVakcina.Ime);
            }
            s1.Close();
        }

        #endregion

        #region tab_change
        private void GeneralControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(GeneralControl.SelectedIndex == 1)
            {
                popuni_dgv_domovi(dGV_unosenje_DZ);
            }
            else if(GeneralControl.SelectedIndex == 2)
            {
                popuni_dgv_domovi(dGV_brisanje_dz);
                
            }
            else if(GeneralControl.SelectedIndex == 3)
            {
               // popuni_dgv_domovi(dGV_domZdravlja_azuriranje);
            }
            
        }
        private void TabControl_za_unos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TabControl_za_unos.SelectedIndex == 0)
            {
                popuni_dgv_domovi(dGV_unosenje_DZ);
            }   
            else if(TabControl_za_unos.SelectedIndex == 1)
            {
                popuni_dgv_lekari(dGV_unosenje_lekar);
                popuni_dgv_domovi(dgv_odabirDz_unos_lekara);
            }
            else if (TabControl_za_unos.SelectedIndex == 2)
            {
                popuni_dgv_pacijenti(dGV_unosenje_pacijent);
            }
            else if (TabControl_za_unos.SelectedIndex == 3)
            {
                popuni_dgv_admini(dGV_unos_AdminDZ);
                popuni_dgv_domovi(dgv_admin_unos_izbor_dz);
            }
            else if (TabControl_za_unos.SelectedIndex == 4)
            {
                popuni_dgv_medOsoblje(dgv_unos_medRad);
            }
           
        }
        private void tabControl_za_brisanje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl_za_brisanje.SelectedIndex == 0)
            {
                popuni_dgv_domovi(dGV_brisanje_dz);
            }
            else if (tabControl_za_brisanje.SelectedIndex == 1)
            {
                popuni_dgv_lekari(dGV_lekar_brisanje);
            }
            else if (tabControl_za_brisanje.SelectedIndex == 2)
            {
               popuni_dgv_pacijenti(dGV_pacijent_brisanje);
            }
            else if (tabControl_za_brisanje.SelectedIndex == 3)
            {
                popuni_dgv_admini(dGV_adminDZ_brisanje);
            }
            else if (tabControl_za_brisanje.SelectedIndex == 4)
            {
                //tek trebaju da se dodaju kontrole
            }

        }
        private void tab_azuriranje_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
               
        }
        #endregion
       
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
            popuni_dgv_domovi(dGV_unosenje_DZ);
            MessageBox.Show("Uspeno ste uneli nov dom zdravlja ");
        }

        #endregion

        #region tab_za_Unos_lekara
        
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
            dzi = s.Load<DomZdravlja>(pomIndex);
            
            dzi.Lekari.Add(il);
            il.RadiUDomuZdravlja = dzi;

            s.Save(il);
            s.Flush();

            
            s.Close();
            popuni_dgv_lekari(dGV_unosenje_lekar);
            MessageBox.Show("Uspeno ste uneli novog lekara " + pomIndex);


        }
        #endregion

        #region tab_za_Unos_pacijenta

        private void dgv_pac_unos_izborLekara_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_odabirDz_unos_lekara.RowCount != 0)
            {
                int rowindex = dgv_odabirDz_unos_lekara.CurrentCell.RowIndex;
                pomIndex = dgv_odabirDz_unos_lekara.Rows[rowindex].Cells[0].Value.ToString();
            }
            else
                MessageBox.Show("Ne postoji nijedan lekar u navedenoj opstini ili ste pogresno uneli ime opstine");
        }

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
            
            IzabraniLekar l = new IzabraniLekar();
            l = s.Load<IzabraniLekar>(pomIndex);

            l.Pacijenti.Add(pac1);
            pac1.Lekar = l;
            s.Save(pac1);
            s.Flush();
            s.Close();
            popuni_dgv_pacijenti(dGV_unosenje_pacijent);
            MessageBox.Show("Uspeno ste uneli novog pacijenta");
        }

        private void btn_odabir_lekara_unos_pac_Click(object sender, EventArgs e)
        {
            if(tb_opstina.Text != string.Empty)
            {
                popuni_dgv_lekari(dgv_pac_unos_izborLekara,tb_opstina.Text);
            }
            else
            {
                MessageBox.Show("Prvo morate uneti opstinu pacijenta");
            }
        }

        #endregion

        #region tab_za_Unos_admina_domZ

        private void dgv_admin_unos_izbor_dz_SelectionChanged(object sender, EventArgs e)
        {
           
                int rowindex = dgv_admin_unos_izbor_dz.CurrentCell.RowIndex;
                pomIndex = dgv_admin_unos_izbor_dz.Rows[rowindex].Cells[0].Value.ToString();
            
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
            dzi = s.Load<DomZdravlja>(pomIndex);
            dzi.Administratori.Add(admin);
            admin.RadiUDomuZdravlja = dzi;
            s.Save(admin);
            s.Flush();
            s.Close();
            popuni_dgv_admini(dGV_unos_AdminDZ);
            MessageBox.Show("Uspeno ste uneli novog admina");
        }

        #endregion

        #region tab_za_unos_medicinskog_radnika
        
        private void dgv_unos_medRad_izborDz_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = dgv_admin_unos_izbor_dz.CurrentCell.RowIndex;
            pomIndex = dgv_admin_unos_izbor_dz.Rows[rowindex].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            MedicinskoOsoblje m = new MedicinskoOsoblje()
            {
                Jmbg = tb_unos_medRadnik_jmbg.Text,
                Ime = tb_unos_medRad_Ime.Text,
                Srednje_slovo = tb_unos_medRad_srednjeS.Text,
                Prezime = tb_unos_medRad_Prezime.Text,
                Password = tb_unos_medRad_Password.Text
            };
            Data.Entiteti.DomZdravlja dzi = new Data.Entiteti.DomZdravlja();
            dzi = s.Load<DomZdravlja>(pomIndex);
            dzi.MedicinskoOsoblje.Add(m);
            m.RadiUDomuZdravlja = dzi;
            s.Flush();
            s.Close();
            popuni_dgv_medOsoblje(dgv_unos_medRad);
            MessageBox.Show("Uspeno ste uneli novog admina");
        }

        #endregion

        #endregion
       
        #region tab_za_brisanje

        #region tab_za_brisanje_dz

        private void btn_brisanje_dz_Click(object sender, EventArgs e)
        {
            

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

        #region tab_za_azuriranje_domova_zdravlja

        private void btn_dz_pretraga_opstina_Click(object sender, EventArgs e)
        {
            dGV_domZdravlja_azuriranje.DataSource = null;
            dGV_domZdravlja_azuriranje.Columns.Clear();
            ISession s = DataLayer.GetSession();
            try
            {
                IQuery q = s.CreateQuery("select o from DomZdravlja as o where o.Opstina = :opstina");
                q.SetString("opstina", tb_dz_azuriranje_pretraga.Text);
                IList<DomZdravlja> domovi = q.List<DomZdravlja>();
                dGV_domZdravlja_azuriranje.ColumnCount = 3;
                dGV_domZdravlja_azuriranje.Columns[0].Name = "Mbr";
                dGV_domZdravlja_azuriranje.Columns[1].Name = "Ime";
                dGV_domZdravlja_azuriranje.Columns[2].Name = "Lokacija";
                foreach (DomZdravlja o in domovi)
                {
                    dGV_domZdravlja_azuriranje.Rows.Add(o.Mbr,o.Ime,o.Opstina);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem : " + ex);
            }
            s.Close();
        }

        private void dGV_domZdravlja_azuriranje_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = dGV_domZdravlja_azuriranje.CurrentCell.RowIndex;
            pomIndex = dGV_domZdravlja_azuriranje.Rows[rowindex].Cells[0].Value.ToString();
            ISession s = DataLayer.GetSession();
            DomZdravlja dzi = new DomZdravlja();
            dzi = s.Load<DomZdravlja>(pomIndex);
            tb_azuriranje_MBR_domZ.Text = dzi.Mbr;
            tb_azuriranje_Ime_domZ.Text = dzi.Ime;
            tb_azuriranje_lokacija_domZ.Text = dzi.Lokacija;
            tb_azuriranje_opstina_domZ.Text = dzi.Opstina;
            tb_azuriranje_adresa_domZ.Text = dzi.Adresa;
            s.Close();
        }

        private void btn_azuriranje_domZ_Click(object sender, EventArgs e)
        { 
            ISession s = DataLayer.GetSession();
            DomZdravlja dzi = new DomZdravlja();
            dzi = s.Load<DomZdravlja>(pomIndex);
            dzi.Mbr = tb_azuriranje_MBR_domZ.Text;
            dzi.Ime = tb_azuriranje_Ime_domZ.Text;
            dzi.Lokacija =tb_azuriranje_lokacija_domZ.Text;
            dzi.Opstina = tb_azuriranje_opstina_domZ.Text;
            dzi.Adresa = tb_azuriranje_adresa_domZ.Text;
            s.Save(dzi);
            s.Flush();


            s.Close();
            
            MessageBox.Show("Uspesno ste updatovali dom zdravlja");
        }

        #endregion

        #region tab_za_azuriranje_lekara

        private void cb_lekar_azuriranje_pretraga_Enter(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            try
            {

                cb_lekar_azuriranje_pretraga.Items.Clear();
                cb_lekar_azuriranje_pretraga.Text = string.Empty;
                IQuery iq = s.CreateQuery("from DomZdravlja");
                IList<DomZdravlja> domovi = iq.List<DomZdravlja>();
                foreach (DomZdravlja dz in domovi)
                {

                    cb_lekar_azuriranje_pretraga.Items.Add(dz.Ime);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Morate oznaciti administratora doma zdravlja. " + ex);
            }
            s.Close();
        }

        private void btn_lekar_azuriranje_pretraga_Click(object sender, EventArgs e)
        {
            dGV_lekari_azuriranje.DataSource = null;
            dGV_lekari_azuriranje.Columns.Clear();
            ISession s = DataLayer.GetSession();
            try
            {


                IQuery q = s.CreateQuery("select o from IzabraniLekar as o where o.RadiUDomuZdravlja.Ime = :imeDoma");
                q.SetString("imeDoma", cb_lekar_azuriranje_pretraga.SelectedItem.ToString());
                IList<IzabraniLekar> ilekari = q.List<IzabraniLekar>();
                dGV_lekari_azuriranje.ColumnCount = 4;
                dGV_lekari_azuriranje.Columns[0].Name = "Jmbg";
                dGV_lekari_azuriranje.Columns[1].Name = "Ime";
                dGV_lekari_azuriranje.Columns[2].Name = "Prezime";
                dGV_lekari_azuriranje.Columns[3].Name = "Radi u";
                foreach (IzabraniLekar il in ilekari)
                {
                    dGV_lekari_azuriranje.Rows.Add(il.Jmbg, il.Ime, il.Prezime, il.RadiUDomuZdravlja.Ime);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem : " + ex);
            }
            s.Close();
        }

        private void dGV_lekari_azuriranje_SelectionChanged(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                int rowindex = dGV_lekari_azuriranje.CurrentCell.RowIndex;
                pomIndex = dGV_lekari_azuriranje.Rows[rowindex].Cells[0].Value.ToString();
                
                IzabraniLekar il = s.Load<IzabraniLekar>(pomIndex);

                lBSmeneLekara.Items.Clear();
                tb_azuriranje_jmbg_lekar.Text = il.Jmbg;
                tb_azuriranje_mbrzu_lekar.Text = il.RadiUDomuZdravlja.Ime;
                tb_azuriranje_ime_lekar.Text = il.Ime;
                tb_azuriranje_prezime_lekar.Text = il.Prezime;
                tb_azuriranje_pass_lekar.Text = il.Password;
                dTP_azuriranje_lekar.Value = il.Datum_rodjenja;
                tb_azuriranje_lekar_srednjeSlovo.Text = il.Srednje_slovo;
                foreach(Smena smen in il.Smene)
                {
                    lBSmeneLekara.Items.Add(smen.Id.Datum_Od + " - " + smen.Datum_Do + " smena: " + smen.SmenaLekara);
                }
               
                cb_domovi_za_promenu_lekar.Items.Clear();
                cb_domovi_za_promenu_lekar.Text = string.Empty;
                IQuery iq = s.CreateQuery("from DomZdravlja");
                IList<DomZdravlja> domovi = iq.List<DomZdravlja>();
                foreach(DomZdravlja dz in domovi)
                {
                    if(il.RadiUDomuZdravlja.Mbr != dz.Mbr)
                        cb_domovi_za_promenu_lekar.Items.Add(dz.Mbr + " " + dz.Ime);
                }
               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Morate izabrati lekara za kojeg hocete da azurirate podatke. " + ex);
            }
            s.Close();
        }

        private void btn_azuriranje_lekara_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                
                IzabraniLekar il = s.Load<IzabraniLekar>(pomIndex);
                il.Ime = tb_azuriranje_ime_lekar.Text;
                il.Prezime = tb_azuriranje_prezime_lekar.Text;
                il.Password = tb_azuriranje_pass_lekar.Text;
                il.Datum_rodjenja = dTP_azuriranje_lekar.Value;
                il.Jmbg = tb_azuriranje_jmbg_lekar.Text;
                il.Srednje_slovo = tb_azuriranje_lekar_srednjeSlovo.Text;
                s.Flush();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Morate oznaciti lekara za kojeg zelite da azurirate podatke." + ex);
            }

            s.Close();
            
        }

        private void btn_dodaj_smenu_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                IzabraniLekar il = s.Load<IzabraniLekar>(pomIndex);
                double razlika = (dTP_smena_od.Value - il.Smene[il.Smene.Count - 1].Datum_Do).TotalDays;

                if (cb_azuriranje_smenaPrva_leakr.Checked == true || cb_azuriranje_smenaDruga_leakr.Checked == false)
                {
                    if (cb_azuriranje_smenaPrva_leakr.Checked == true && cb_azuriranje_smenaDruga_leakr.Checked == true)
                    {
                        MessageBox.Show("Ne mozete izabrati obe smene za lekara u odredjenom periodu.");
                    }
                    else
                    {
                        if (razlika == 1 || (razlika > 1 && razlika < 2))
                        {
                            int SmenaLekara1;
                            if (cb_azuriranje_smenaPrva_leakr.Checked == true)
                            {
                                SmenaLekara1 = 1;
                            }
                            else
                            {
                                SmenaLekara1 = 2;
                            }

                            Smena smena = new Smena()
                            {
                                Datum_Do = dTP_smena_do.Value,
                                SmenaLekara = SmenaLekara1,

                            };
                            smena.Id.Datum_Od = dTP_smena_od.Value;
                            smena.Id.Lekar = il;
                            il.Smene.Add(smena);
                            s.Save(smena);
                            s.Flush();
                            lBSmeneLekara.Items.Clear();
                            foreach (Smena smene in il.Smene)
                            {
                                lBSmeneLekara.Items.Add(smene.Id.Datum_Od + " - " + smene.Datum_Do + " smena: " + smene.SmenaLekara);
                            }
                            dTP_smena_do.Value = DateTime.Now;
                            dTP_smena_od.Value = DateTime.Now;
                            cb_azuriranje_smenaPrva_leakr.Checked = false;
                            cb_azuriranje_smenaDruga_leakr.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("Datum od kojeg pocinje nova smena koju zelite da kreirate mora da bude za jedan dan veca od poslednjeg datuma iz liste smena.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Morate izabrati smenu lekara za odredjeni datum.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Morate oznaciti lekara kome zelite smenu da dodate. " + ex);
            }
            s.Close();
        }

        private void btn_azuriraj_smenu_Click(object sender, EventArgs e)
        {
            string datumOd = lBSmeneLekara.SelectedItem.ToString();
            datumOd = datumOd.Substring(0, datumOd.IndexOf(" "));
            ISession s = DataLayer.GetSession();
            try
            {
                IzabraniLekar il = s.Load<IzabraniLekar>(pomIndex);
                Smena smen = new Smena();
                foreach (Smena s1 in il.Smene)
                {
                    if (s1.Id.Datum_Od == DateTime.Parse(datumOd))
                    {
                        if (cb_azuriranje_smenaPrva_leakr.Checked == true)
                        {
                            s1.SmenaLekara = 1;
                        }
                        else
                        {
                            s1.SmenaLekara = 2;
                        }
                    }
                }
                s.Flush();
                
                lBSmeneLekara.Items.Clear();
                foreach (Smena smene in il.Smene)
                {
                    lBSmeneLekara.Items.Add(smene.Id.Datum_Od + " - " + smene.Datum_Do + " smena: " + smene.SmenaLekara);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Morate oznaciti lekara za kojeg zelite da azurirate smenu." + ex);
            }
            s.Close();
            dTP_smena_do.Value = DateTime.Now;
            dTP_smena_od.Value = DateTime.Now;
            cb_azuriranje_smenaPrva_leakr.Checked = false;
            cb_azuriranje_smenaDruga_leakr.Checked = false;
        }

        private void btn_lekar_promeniDz_Click(object sender, EventArgs e)
        {
            string dzMbr = cb_domovi_za_promenu_lekar.SelectedItem.ToString();
            dzMbr = dzMbr.Substring(0, dzMbr.IndexOf(" "));
            ISession s = DataLayer.GetSession();
            try
            {
                IzabraniLekar il = s.Load<IzabraniLekar>(pomIndex);
                if (il.Pacijenti.Count == 0)
                {
                    DomZdravlja dz = s.Load<DomZdravlja>(dzMbr);
                    il.RadiUDomuZdravlja.Lekari.Remove(il);
                    il.RadiUDomuZdravlja = dz;
                    dz.Lekari.Add(il);
                    s.Flush();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Svi pacijenti moraju promeniti izabranog lekara da bi lekar mogao da promeni dom zdravlja. "+ ex);
            }


            s.Close();
        }

        private void lBSmeneLekara_SelectedIndexChanged(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                string datumOd = lBSmeneLekara.SelectedItem.ToString();
                datumOd = datumOd.Substring(0, datumOd.IndexOf(" "));
                
                IzabraniLekar il = s.Load<IzabraniLekar>(pomIndex);
                Smena smen = new Smena();
                foreach (Smena s1 in il.Smene)
                {
                    if (s1.Id.Datum_Od == DateTime.Parse(datumOd))
                    {
                        if (s1.SmenaLekara == 1)
                        {
                            cb_azuriranje_smenaPrva_leakr.Checked = true;
                            cb_azuriranje_smenaDruga_leakr.Checked = false;
                        }
                        else
                        {
                            cb_azuriranje_smenaDruga_leakr.Checked = true;
                            cb_azuriranje_smenaPrva_leakr.Checked = false;
                        }
                        dTP_smena_od.Value = s1.Id.Datum_Od;
                        dTP_smena_do.Value = s1.Datum_Do;

                    }
                }

               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Morate prvo oznaciti lekara za kojeg zelite da azurirate podatke." + ex);
            }
            s.Close();
        }
        #endregion

        #region tab_za_azuriranje_pacijenta
        private void cB_pac_azuriranje_dz_pretraga_Enter(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            cB_pac_azuriranje_dz_pretraga.Items.Clear();
            cB_pac_azuriranje_dz_pretraga.Text = string.Empty;
            IQuery iq = s.CreateQuery("from DomZdravlja");
            IList<DomZdravlja> domovi = iq.List<DomZdravlja>();
            foreach (DomZdravlja dz in domovi)
            {
                cB_pac_azuriranje_dz_pretraga.Items.Add(dz.Ime);
            }

            s.Close();
        }

        private void cb_pac_azuriranje_lek_pretraga_Enter(object sender, EventArgs e)
        {
            
            if (cB_pac_azuriranje_dz_pretraga.Text != string.Empty)
            {
                ISession s = DataLayer.GetSession();
                cb_pac_azuriranje_lek_pretraga.Items.Clear();
                cb_pac_azuriranje_lek_pretraga.Text = string.Empty;
                IQuery iq = s.CreateQuery("select o from IzabraniLekar as o where o.RadiUDomuZdravlja.Ime = : imeDoma");
                iq.SetString("imeDoma", cB_pac_azuriranje_dz_pretraga.SelectedItem.ToString());
                IList<IzabraniLekar> lekari = iq.List<IzabraniLekar>();
                foreach (IzabraniLekar il in lekari)
                {
                    cb_pac_azuriranje_lek_pretraga.Items.Add(il.Ime + " " + il.Prezime);
                }
                s.Close();
            }
           
        }

        private void btn_lekar_azur_pretraga_Click(object sender, EventArgs e)
        {
          
            dGV_pacijenti_azuriranje.DataSource = null;
            dGV_pacijenti_azuriranje.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            try
            {
                string[] parametars = cb_pac_azuriranje_lek_pretraga.SelectedItem.ToString().Split(' ');
                IQuery iq = s.CreateQuery("select o from Pacijent as o where o.Lekar.Ime = : imeLekara and o.Lekar.Prezime = : prezimeLekara");
                iq.SetString("imeLekara", parametars[0]);
                iq.SetString("prezimeLekara", parametars[1]);
                IList<Pacijent> pacijenti = iq.List<Pacijent>();
                dGV_pacijenti_azuriranje.ColumnCount = 6;
                dGV_pacijenti_azuriranje.Columns[0].Name = "JMBG";
                dGV_pacijenti_azuriranje.Columns[1].Name = "Ime";
                dGV_pacijenti_azuriranje.Columns[2].Name = "Srednje slovo";
                dGV_pacijenti_azuriranje.Columns[3].Name = "Prezime";
                dGV_pacijenti_azuriranje.Columns[4].Name = "Pravo da zakaze";
                dGV_pacijenti_azuriranje.Columns[5].Name = "Opstina";
                ;
                foreach (Pacijent pac in pacijenti)
                {
                    dGV_pacijenti_azuriranje.Rows.Add(pac.Jmbg, pac.Ime, pac.Srednje_slovo, pac.Prezime, pac.Pravo_da_zakaze, pac.Opstina);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Morate izabrati izabranog lekara za pacijenta. " + ex);
            }
            s.Close();
        }

        private void dGV_pacijenti_azuriranje_SelectionChanged(object sender, EventArgs e)
        {
            cB_Dijagnoze_pacijenta_azuriranje.Items.Clear();
            cB_Dijagnoze_pacijenta_azuriranje.Text = string.Empty;
            cB_dijagnoze_Azuriranje_tabDij.Items.Clear();
            cB_dijagnoze_Azuriranje_tabDij.Text = string.Empty;
            int rowindex = dGV_pacijenti_azuriranje.CurrentCell.RowIndex;
            pomIndex = dGV_pacijenti_azuriranje.Rows[rowindex].Cells[0].Value.ToString();
            ISession s = DataLayer.GetSession();
            try
            {
                Pacijent pac = new Pacijent();
                pac = s.Load<Pacijent>(pomIndex);
                tb_pacijent_azuriranje_jmbg.Text = pac.Jmbg;
                tb_pacijent_azuriranje_ime.Text = pac.Ime;
                tb_pacijent_azuriranje_prezime.Text = pac.Prezime;
                tb_pacijent_azuriranje_srednjeSlovo.Text = pac.Srednje_slovo;
                tb_pacijent_azuriranje_lbo.Text = pac.Lbo;
                tb_pacijent_azuriranje_opstina.Text = pac.Opstina;
                tb_pacijent_azuriranje_telefon.Text = pac.Telefon;
                tb_pacijent_azuriranje_email.Text = pac.Email;
                popuni_lb_vakcine(lb_pac_vakcine, pac);
                //---combobox dijagnoze pacijenta
                foreach (Dijagnostifikovano d in pac.DijagnostifikovanoDijagnoze)
                {
                    cB_Dijagnoze_pacijenta_azuriranje.Items.Add(d.Id.DijagnozaDijagnoza.Sifra + "-" + d.Id.DijagnozaDijagnoza.Ime);
                }
                IQuery iq1 = s.CreateQuery("from Dijagnoza");
                IList<Dijagnoza> dijagnoze = iq1.List<Dijagnoza>();
                foreach (Dijagnoza d in dijagnoze)
                {
                    if (cB_Dijagnoze_pacijenta_azuriranje.Items.Contains(d.Sifra + "-" + d.Ime) == false)
                        cB_dijagnoze_Azuriranje_tabDij.Items.Add(d.Sifra + "-" + d.Ime);
                }
                label_lekar_pac.Text = pac.Lekar.Ime;
                label_lekar_prezime_pac.Text = pac.Lekar.Prezime;
                iq1 = s.CreateQuery("from IzabraniLekar");
                IList<IzabraniLekar> lekari = iq1.List<IzabraniLekar>();
                foreach (IzabraniLekar l in lekari)
                {
                    if (l.RadiUDomuZdravlja.Opstina == pac.Opstina && l.Ime != label_lekar_pac.Text && l.Prezime != label_lekar_prezime_pac.Text)
                    {
                        cB_lekari_za_izmenu.Items.Add(l.Jmbg + " " + l.Ime + " " + l.Prezime);
                    }
                }
                IQuery iq = s.CreateQuery("from Vakcina");
                IList<Vakcina> vakcine = iq.List<Vakcina>();
                dGV_azuriranje_pac_vakcine.DataSource = vakcine;
                dGV_azuriranje_pac_vakcine.Columns[3].Visible = false;
                dGV_azuriranje_pac_vakcine.Columns[2].Visible = false;
                popuni_dgv_azuriranje_pac_terapije(dgv_azuriranje_pac_terapije, pac);
                popuni_dGV_pac_dijagnoze(dGV_pac_dijagnoze, pac);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Morate izabrati pacijenta. " + ex);
            }
            
            s.Close();
        }

        private void btn_azuriraj_pac_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Pacijent pac = s.Load<Pacijent>(pomIndex);
                pac.Jmbg = tb_pacijent_azuriranje_jmbg.Text;
                pac.Srednje_slovo = tb_pacijent_azuriranje_srednjeSlovo.Text;
                if(cB_pravo_da_zakaze.Checked == true)
                {
                    pac.Pravo_da_zakaze = 1;
                }
                else
                {
                    pac.Pravo_da_zakaze = 0;
                }
                pac.Prezime = tb_pacijent_azuriranje_prezime.Text;
                pac.Ime = tb_pacijent_azuriranje_ime.Text;
                pac.Opstina = tb_pacijent_azuriranje_opstina.Text;
                pac.Datum_rodjenja = dTP_pacijent_azuriranje.Value;
                pac.Lbo = tb_pacijent_azuriranje_lbo.Text;
                pac.Vazi_do = dTP_vaziDo_pacijent.Value;
                pac.Telefon = tb_pacijent_azuriranje_telefon.Text;
                pac.Email = tb_pacijent_azuriranje_email.Text;
                s.Flush();
                s.Close();
                MessageBox.Show("Uspeno ste azurirali podatke o pacijentu");
                popuni_dgv_pacijenti(dGV_pacijenti_azuriranje);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Morate oznaciti pacijenta u tabeli na tabu");
            }
        }

        private void btn_azuriranje_pac_vakBrisanje_Click(object sender, EventArgs e)
        {
            string pomIndex2 = lb_pac_vakcine.SelectedItem.ToString();
            pomIndex2 = pomIndex2.Substring(0, pomIndex2.IndexOf(" "));
            ISession s = DataLayer.GetSession();
            try
            {
                Pacijent pac = s.Load<Pacijent>(pomIndex);
                IList<PrimioVakcinu> vakcine = pac.PrimioVakcinuVakcine;
                foreach (PrimioVakcinu pv in vakcine)
                {
                    if (pv.Id.PrimioVakcina.Sifra == pomIndex2)
                    {
                        pv.Id.PrimioPacijent = null;
                        pv.Id.PrimioVakcina = null;
                        pac.PrimioVakcinuVakcine.Remove(pv);
                        s.Delete(pv);
                    }
                }
                
                s.Flush();
                popuni_lb_vakcine(lb_pac_vakcine, pac);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Morate oznaciti vakcinu koju zelite da izbrisete. " + ex);
            }


            s.Close();
        }

        private void btn_azuriranje_pac_vakDodaj_Click(object sender, EventArgs e)
        {
            int rowindex = dGV_azuriranje_pac_vakcine.CurrentCell.RowIndex;
            string pomIndex2 = dGV_azuriranje_pac_vakcine.Rows[rowindex].Cells[1].Value.ToString();
            ISession s = DataLayer.GetSession();
            Pacijent pac = s.Load<Pacijent>(pomIndex);
            Vakcina v = s.Load<Vakcina>(pomIndex2);
            bool vecPrimio = false;
            PrimioVakcinu pv = new PrimioVakcinu();
            pv.Datum = DateTime.Now;
            pv.Id.PrimioPacijent = pac;
            pv.Id.PrimioVakcina = v;
            IList<PrimioVakcinu> vakcinePac = pac.PrimioVakcinuVakcine;
            foreach (PrimioVakcinu pri in vakcinePac)
            {
                if(pv.Id.PrimioPacijent == pri.Id.PrimioPacijent && pv.Id.PrimioVakcina == pri.Id.PrimioVakcina)
                {
                    vecPrimio = true;
                }
            }
            if (vecPrimio == false)
            {
                pac.PrimioVakcinuVakcine.Add(pv);
                v.PrimioVakcinuPacijenti.Add(pv);
                
                s.SaveOrUpdate(pac);
                s.Flush();
                //popuni_dGV_azuriranje_pacijent_VakcinePacijentove(dGV_azuriranje_pacijent_VakcinePacijentove, pac);
                popuni_lb_vakcine(lb_pac_vakcine, pac);
                s.Close();

            }
            else
            {
                MessageBox.Show("Pacijent je vec primio izabranu vakcinu .");
            }
            
            
        }

        private void btn_dodaj_Terapiju_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Pacijent pac = s.Load<Pacijent>(pomIndex);
                string dijagnozaIzCB = cB_Dijagnoze_pacijenta_azuriranje.SelectedItem.ToString();
                string indexDijagnoze = dijagnozaIzCB.Substring(0, dijagnozaIzCB.IndexOf("-"));
                Dijagnoza d = s.Load<Dijagnoza>(indexDijagnoze);
                Terapija ter = new Terapija()
                {
                    Datum_do = dTP_pac_terap_od.Value,
                    Datum_od = dTP_pac_terap_do.Value,
                    Opis = rtB_opis_terapije.Text
                };
                ter.TerapijaPacijent = pac;
                ter.TerapijaLekar = pac.Lekar;
                pac.Lekar.Terapije.Add(ter);
                pac.Terapije.Add(ter);
                ter.TerapijaDijagnoza = d;
                d.Terapije.Add(ter);
                s.Flush();


                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Morate oznaciti pacijenta u tabeli na tabu");
            }
        }


        private void btn_pac_dijagnoza_dodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Pacijent pac = s.Load<Pacijent>(pomIndex);
                string dijagnozaIzCB = cB_Dijagnoze_pacijenta_azuriranje.SelectedItem.ToString();
                string indexDijagnoze = dijagnozaIzCB.Substring(0, dijagnozaIzCB.IndexOf("-"));
                Dijagnoza d = s.Load<Dijagnoza>(indexDijagnoze);
                Dijagnostifikovano dij = new Dijagnostifikovano()
                {
                    Datum = DateTime.Now
                };
                dij.Id.DijagnozaLekar = pac.Lekar;
                dij.Id.DijagnozaPacijent = pac;
                dij.Id.DijagnozaDijagnoza = d;
                pac.Lekar.DijagnostifikovanoDijagnoze.Add(dij);
                pac.DijagnostifikovanoDijagnoze.Add(dij);

                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Morate oznaciti pacijenta u tabeli na tabu");
            }
        }

        private void btn_promena_lekara_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Pacijent pac = s.Load<Pacijent>(pomIndex);
                IzabraniLekar l = new IzabraniLekar();
                string lekar = cB_lekari_za_izmenu.SelectedItem.ToString();
                lekar = lekar.Substring(0, lekar.IndexOf(" "));
                l = s.Load<IzabraniLekar>(lekar);
                pac.Lekar.Pacijenti.Remove(pac);
                l.Pacijenti.Add(pac);
                pac.Lekar = l;
                s.Flush();
                label_lekar_pac.Text = l.Ime;
                label_lekar_prezime_pac.Text = l.Prezime;
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Morate oznaciti pacijenta u tabeli na tabu");
            }
        }

        #endregion

        #region tab_za_azuriranje_adminaDz
        private void btn_adminDz_azuriranje_pretrazi_Click(object sender, EventArgs e)
        {
            dGV_azuriranje_adminDZ.DataSource = null;
            dGV_azuriranje_adminDZ.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            IQuery iq = s.CreateQuery("select o from AdministratorDomaZdravlja as o where o.RadiUDomuZdravlja.Ime = : imeDoma");
            iq.SetString("imeDoma", cb_azuriranje_adminDZ_pretraga.SelectedItem.ToString());
            IList<AdministratorDomaZdravlja> admini = iq.List<AdministratorDomaZdravlja>();
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

        private void dGV_azuriranje_adminDZ_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = dGV_azuriranje_adminDZ.CurrentCell.RowIndex;
            pomIndex = dGV_azuriranje_adminDZ.Rows[rowindex].Cells[0].Value.ToString();
            ISession s = DataLayer.GetSession();
            try
            {
                AdministratorDomaZdravlja adz = s.Load<AdministratorDomaZdravlja>(pomIndex);
                tb_azuriranje_admindz_jmbg.Text = adz.JMBG;
                tb_azuriranje_admindz_ime.Text = adz.Ime;
                tb_azuriranje_admindz_srednjeS.Text = adz.SrednjeSlovo;
                tb_azuriranje_admindz_prezime.Text = adz.Prezime;
                tb_azuriranje_admindz_password.Text = adz.Password;
                tb_azuriranje_admindz_mbrzu.Text = adz.RadiUDomuZdravlja.Ime;

                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Morate oznaciti administratora kojeg zelite da azurirate " + ex);
            }
            s.Close();
        }
        private void cb_azuriranje_adminDZ_pretraga_Enter(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            cb_azuriranje_adminDZ_pretraga.Items.Clear();
            cb_azuriranje_adminDZ_pretraga.Text = string.Empty;
            IQuery iq = s.CreateQuery("from DomZdravlja");
            IList<DomZdravlja> domovi = iq.List<DomZdravlja>();
            foreach (DomZdravlja dz in domovi)
              {
                cb_azuriranje_adminDZ_pretraga.Items.Add(dz.Ime);
              }
            
            s.Close();
        }
        private void cB_domovi_za_menjanje_adz_Enter(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                AdministratorDomaZdravlja adz = s.Load<AdministratorDomaZdravlja>(pomIndex);
                cB_domovi_za_menjanje_adz.Items.Clear();
                cB_domovi_za_menjanje_adz.Text = string.Empty;
                IQuery iq = s.CreateQuery("from DomZdravlja");
                IList<DomZdravlja> domovi = iq.List<DomZdravlja>();
                foreach (DomZdravlja dz in domovi)
                {
                    if (adz.RadiUDomuZdravlja.Mbr != dz.Mbr)
                        cB_domovi_za_menjanje_adz.Items.Add(dz.Mbr + " " + dz.Ime);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Morate oznaciti administratora doma zdravlja. " + ex);
            }
            s.Close();
        }
        private void btn_azuriranje_adminDz_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                AdministratorDomaZdravlja adz = s.Load<AdministratorDomaZdravlja>(pomIndex);
                adz.JMBG = tb_azuriranje_admindz_jmbg.Text;
                adz.Ime = tb_azuriranje_admindz_ime.Text;
                adz.SrednjeSlovo = tb_azuriranje_admindz_srednjeS.Text;
                adz.Prezime = tb_azuriranje_admindz_prezime.Text;
                adz.Password = tb_azuriranje_admindz_password.Text;

                MessageBox.Show("Uspeno ste azurirali podatke o administratoru doma zdravlja.");
                s.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Morate oznaciti administratora kojem zelite da promenite podatke " + ex);
            }
            s.Close();
        }

        private void btn_promeniDZ_admin_Click(object sender, EventArgs e)
        {
            string dzMbr = cB_domovi_za_menjanje_adz.SelectedItem.ToString();
            dzMbr = dzMbr.Substring(0, dzMbr.IndexOf(" "));
            
            ISession s = DataLayer.GetSession();
            try
            {
                DomZdravlja dz = s.Load<DomZdravlja>(dzMbr);
                AdministratorDomaZdravlja adz = s.Load<AdministratorDomaZdravlja>(pomIndex);
                adz.RadiUDomuZdravlja.Administratori.Remove(adz);
                adz.RadiUDomuZdravlja = dz;
                dz.Administratori.Add(adz);
                s.Flush();
                MessageBox.Show("Uspeno ste promenili dom zdravlja administratoru.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Morate oznaciti administratora kojem zelite da promenite dom zdravlja " + ex);
            }
            s.Close();
        }
        #endregion

        #region tab_med_radnik_azuriranje
        

        private void btn_pretrazi_Click(object sender, EventArgs e)
        {
            dGV_mr_azuriranje.DataSource = null;
            dGV_mr_azuriranje.Columns.Clear();
            ISession s = DataLayer.GetSession();
            try
            {
                
                
                IQuery q = s.CreateQuery("select o from MedicinskoOsoblje as o where o.Ime = :ime and o.RadiUDomuZdravlja.Ime = :imeDoma");
                q.SetString("ime", tb_pretraga_mr_ime.Text);
                q.SetString("imeDoma", cB_dz_pretraga_mr_azuriranje.SelectedItem.ToString());
                IList<MedicinskoOsoblje> mo = q.List<MedicinskoOsoblje>();
                dGV_mr_azuriranje.ColumnCount = 4;
                dGV_mr_azuriranje.Columns[0].Name = "Jmbg";
                dGV_mr_azuriranje.Columns[1].Name = "Ime";
                dGV_mr_azuriranje.Columns[2].Name = "Prezime";
                dGV_mr_azuriranje.Columns[3].Name = "Radi u";
                foreach(MedicinskoOsoblje o in mo)
                {
                    dGV_mr_azuriranje.Rows.Add(o.Jmbg, o.Ime, o.Prezime, o.RadiUDomuZdravlja.Ime);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem : " + ex);
            }
            s.Close();
        }
        private void cB_dz_pretraga_mr_azuriranje_Enter(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IQuery q = s.CreateQuery("from DomZdravlja");
            IList<DomZdravlja> domovi = q.List<DomZdravlja>();
            foreach (DomZdravlja dz in domovi)
            {
                cB_dz_pretraga_mr_azuriranje.Items.Add(dz.Ime);
            }
            s.Close();
        }

        private void dGV_mr_azuriranje_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = dGV_mr_azuriranje.CurrentCell.RowIndex;
            pomIndex = dGV_mr_azuriranje.Rows[rowindex].Cells[0].Value.ToString();
            ISession s = DataLayer.GetSession();
            try
            {
                MedicinskoOsoblje mo = s.Load<MedicinskoOsoblje>(pomIndex);
                tb_jmbg_mr_azuriranje.Text = mo.Jmbg;
                tb_ime_mr_azuriranje.Text = mo.Ime;
                tb_prezime_mr_azuriranje.Text = mo.Prezime;
                tb_radiU_mr_azuriranje.Text = mo.RadiUDomuZdravlja.Ime;
                tb_pass_mr_azuriranje.Text = mo.Password;
                tb_ss_mr_azuriranje.Text = mo.Srednje_slovo;
                dTP_mr_datumRodj_azuriranje.Value = mo.Datum_rodjenja;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Morate oznaciti zeljenog medicinskog radnika. " + ex);
            }
            s.Close();
        }
        private void cb_promeniDZ_MR_azuriranje_Enter(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                IQuery q = s.CreateQuery("from DomZdravlja");
                IList<DomZdravlja> domovi = q.List<DomZdravlja>();
                MedicinskoOsoblje mo = s.Load<MedicinskoOsoblje>(pomIndex);
                foreach (DomZdravlja dz in domovi)
                {
                    if (dz.Mbr != mo.RadiUDomuZdravlja.Mbr)
                        cb_promeniDZ_MR_azuriranje.Items.Add(dz.Mbr + " " + dz.Ime);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Morate oznaciti zeljenog medicinskog radnika. " + ex);
            }
            s.Close();
        }
        private void btn_mr_azuriranje_menjanjeDZ_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                MedicinskoOsoblje mo = s.Load<MedicinskoOsoblje>(pomIndex);
                string dz = cb_promeniDZ_MR_azuriranje.SelectedItem.ToString();
                dz = dz.Substring(0, dz.IndexOf(" "));
                DomZdravlja dom = s.Load<DomZdravlja>(dz);
                mo.RadiUDomuZdravlja.MedicinskoOsoblje.Remove(mo);
                dom.MedicinskoOsoblje.Add(mo);
                mo.RadiUDomuZdravlja = dom;
                s.Flush();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Morate oznaciti zeljenog medicinskog radnika. " + ex);
            }
            s.Close();
        }

        private void btn_azuriraj_mr_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                MedicinskoOsoblje mo = s.Load<MedicinskoOsoblje>(pomIndex);
                mo.Jmbg = tb_jmbg_mr_azuriranje.Text;
                mo.Ime = tb_ime_mr_azuriranje.Text;
                mo.Prezime = tb_prezime_mr_azuriranje.Text;
                mo.Password = tb_pass_mr_azuriranje.Text;
                mo.Datum_rodjenja = dTP_mr_datumRodj_azuriranje.Value;
                mo.Srednje_slovo = tb_ss_mr_azuriranje.Text;
                s.Flush();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Morate oznaciti zeljenog medicinskog radnika. " + ex);
            }
            s.Close();
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
