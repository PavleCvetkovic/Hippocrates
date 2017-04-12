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
                popuni_dgv_domovi(dGV_domZdravlja_azuriranje);
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
            if(tab_azuriranje.SelectedIndex == 0)
            {
                popuni_dgv_domovi(dGV_domZdravlja_azuriranje);
            }
            else if(tab_azuriranje.SelectedIndex == 1)
            {
                popuni_dgv_pacijenti(dGV_pacijenti_azuriranje);
            }
            else if (tab_azuriranje.SelectedIndex == 2)
            {
                popuni_dgv_admini(dGV_azuriranje_adminDZ);   
            }
            else if (tab_azuriranje.SelectedIndex == 3)
            {
                popuni_dgv_lekari(dGV_lekari_azuriranje);
            }
            else if (tab_azuriranje.SelectedIndex == 4)
            {
                //tek trebaju da se dodaju kontrole
            }
          
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
            popuni_dgv_domovi(dGV_domZdravlja_azuriranje);
            MessageBox.Show("Uspesno ste updatovali dom zdravlja");
        }

        #endregion

        #region tab_za_azuriranje_lekara

        private void dGV_lekari_azuriranje_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void btn_azuriranje_lekara_Click(object sender, EventArgs e)
        {
           
        }

        #endregion

        #region tab_za_azuriranje_pacijenta
        
        private void dGV_pacijenti_azuriranje_SelectionChanged(object sender, EventArgs e)
        {
            
            int rowindex = dGV_pacijenti_azuriranje.CurrentCell.RowIndex;
            pomIndex = dGV_pacijenti_azuriranje.Rows[rowindex].Cells[0].Value.ToString();
            ISession s = DataLayer.GetSession();
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
            IQuery iq = s.CreateQuery("from Vakcina");
            IList<Vakcina> vakcine = iq.List<Vakcina>();
            dGV_azuriranje_pac_vakcine.DataSource = vakcine;
            dGV_azuriranje_pac_vakcine.Columns[3].Visible = false;
            dGV_azuriranje_pac_vakcine.Columns[2].Visible = false;
            dGV_azuriranje_pac_vakcine.Columns[1].Visible = false;
            
            IList<PrimioVakcinu> primioVak = pac.PrimioVakcinuVakcine;
            //ovo nije gotovo

            s.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btn_azuriranje_pac_vakBrisanje_Click(object sender, EventArgs e)
        {

        }

        private void btn_azuriranje_pac_vakDodaj_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region tab_za_azuriranje_adminaDz

        private void btn_azuriranje_adminDz_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        #region tab_mad_radnik_azuriranje

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
