﻿using System;
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

        #region listBox_i_dataGridViews_funkcije_za_popunjavanje
        
       
        
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
       
        private void TabControl_za_unos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TabControl_za_unos.SelectedIndex == 1)
            {
                popuni_dgv_domovi(dGV_unosenje_DZ);
            }   
           
           
        }
        private void tabControl_za_brisanje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl_za_brisanje.SelectedIndex == 1)
            {
                popuni_dgv_domovi(dGV_brisanje_dz);
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
        private void cb_odabirDZ_lekar_unos_Enter(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            try
            {

                cb_odabirDZ_lekar_unos.Items.Clear();
                cb_odabirDZ_lekar_unos.Text = string.Empty;
                IQuery iq = s.CreateQuery("from DomZdravlja");
                IList<DomZdravlja> domovi = iq.List<DomZdravlja>();
                foreach (DomZdravlja dz in domovi)
                {

                    cb_odabirDZ_lekar_unos.Items.Add(dz.Mbr + " " + dz.Ime);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Morate oznaciti administratora doma zdravlja. " + ex);
            }
            s.Close();
        }
        private void cb_odabirDZ_lekar_unos_SelectedIndexChanged(object sender, EventArgs e)
        {
            dGV_unosenje_lekar.DataSource = null;
            dGV_unosenje_lekar.Columns.Clear();
            ISession s = DataLayer.GetSession();
            try
            {
                pomIndex = cb_odabirDZ_lekar_unos.SelectedItem.ToString();
                pomIndex = pomIndex.Substring(0, pomIndex.IndexOf(" "));
                IQuery iq = s.CreateQuery("select o from IzabraniLekar as o where o.RadiUDomuZdravlja.Mbr = : mbr");
                iq.SetString("mbr", pomIndex);
                IList<IzabraniLekar> lekari = iq.List<IzabraniLekar>();
                dGV_unosenje_lekar.ColumnCount = 4;
                dGV_unosenje_lekar.Columns[0].Name = "JMBG";
                dGV_unosenje_lekar.Columns[1].Name = "Ime";
                dGV_unosenje_lekar.Columns[2].Name = "Srednje slovo";
                dGV_unosenje_lekar.Columns[3].Name = "Prezime";
                foreach (IzabraniLekar l in lekari)
                {
                    dGV_unosenje_lekar.Rows.Add(l.Jmbg, l.Ime, l.Srednje_slovo, l.Prezime);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Morate izabrati dom zdravlja. " + ex);
            }
            s.Close();
        }
        private void btn_Unesi_lekara_Click(object sender, EventArgs e)
        {
            pomIndex = cb_odabirDZ_lekar_unos.SelectedItem.ToString();
            pomIndex = pomIndex.Substring(0, pomIndex.IndexOf(" "));
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
            
            MessageBox.Show("Uspeno ste uneli novog lekara " + pomIndex);


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
            
            IzabraniLekar l = new IzabraniLekar();
            l = s.Load<IzabraniLekar>(pomIndex);
            
            l.Pacijenti.Add(pac1);
            pac1.Lekar = l;
            s.Save(pac1);
            s.Flush();
            s.Close();
            
            MessageBox.Show("Uspeno ste uneli novog pacijenta");
        }

        private void cb_izborLekara_pac_unos_SelectedIndexChanged(object sender, EventArgs e)
        {
            pomIndex = cb_izborLekara_pac_unos.SelectedItem.ToString();
            pomIndex = pomIndex.Substring(0, pomIndex.IndexOf(" "));
            dGV_unosenje_pacijent.DataSource = null;
            dGV_unosenje_pacijent.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            try
            {  
                string[] parametars = cb_izborLekara_pac_unos.SelectedItem.ToString().Split(' ');
                IQuery iq = s.CreateQuery("select o from Pacijent as o where o.Lekar.Ime = : imeLekara and o.Lekar.Prezime = : prezimeLekara");
                iq.SetString("imeLekara", parametars[1]);
                iq.SetString("prezimeLekara", parametars[2]);
                IList<Pacijent> pacijenti = iq.List<Pacijent>();
                dGV_unosenje_pacijent.ColumnCount = 6;
                dGV_unosenje_pacijent.Columns[0].Name = "JMBG";
                dGV_unosenje_pacijent.Columns[1].Name = "Ime";
                dGV_unosenje_pacijent.Columns[2].Name = "Srednje slovo";
                dGV_unosenje_pacijent.Columns[3].Name = "Prezime";
                dGV_unosenje_pacijent.Columns[4].Name = "Pravo da zakaze";
                dGV_unosenje_pacijent.Columns[5].Name = "Opstina";

                foreach (Pacijent pac in pacijenti)
                {
                    dGV_unosenje_pacijent.Rows.Add(pac.Jmbg, pac.Ime, pac.Srednje_slovo, pac.Prezime, pac.Pravo_da_zakaze, pac.Opstina);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Morate izabrati izabranog lekara za pacijenta. " + ex);
            }
            s.Close();
        }

        private void cb_izborLekara_pac_unos_Enter(object sender, EventArgs e)
        {
            if (cb_izborDZ_pac_unos.Text != string.Empty)
            {
                ISession s = DataLayer.GetSession();
                cb_izborLekara_pac_unos.Items.Clear();
                cb_izborLekara_pac_unos.Text = string.Empty;
                IQuery iq = s.CreateQuery("select o from IzabraniLekar as o where o.RadiUDomuZdravlja.Ime = : imeDoma");
                iq.SetString("imeDoma", cb_izborDZ_pac_unos.SelectedItem.ToString());
                IList<IzabraniLekar> lekari = iq.List<IzabraniLekar>();
                foreach (IzabraniLekar il in lekari)
                {
                    cb_izborLekara_pac_unos.Items.Add(il.Jmbg + " " + il.Ime + " " + il.Prezime);
                }
                s.Close();
            }
        }

        private void cb_izborDZ_pac_unos_Enter(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            cb_izborDZ_pac_unos.Items.Clear();
            cb_izborDZ_pac_unos.Text = string.Empty;
            IQuery iq = s.CreateQuery("from DomZdravlja");
            IList<DomZdravlja> domovi = iq.List<DomZdravlja>();
            foreach (DomZdravlja dz in domovi)
            {
                cb_izborDZ_pac_unos.Items.Add(dz.Ime);
            }

            s.Close();
        }

        #endregion

        #region tab_za_Unos_admina_domZ

        private void cB_izborDZ_adminDZ_unos_Enter(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            cB_izborDZ_adminDZ_unos.Items.Clear();
            cB_izborDZ_adminDZ_unos.Text = string.Empty;
            IQuery iq = s.CreateQuery("from DomZdravlja");
            IList<DomZdravlja> domovi = iq.List<DomZdravlja>();
            foreach (DomZdravlja dz in domovi)
            {
                cB_izborDZ_adminDZ_unos.Items.Add(dz.Mbr + " " + dz.Ime);
            }

            s.Close();
        }
       
        private void cB_izborDZ_adminDZ_unos_SelectedIndexChanged(object sender, EventArgs e)
        {
            dGV_unos_AdminDZ.DataSource = null;
            dGV_unos_AdminDZ.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            try
            {
                string parametars = cB_izborDZ_adminDZ_unos.SelectedItem.ToString();
                parametars = parametars.Substring(0, parametars.IndexOf(" "));
                IQuery iq = s.CreateQuery("select o from AdministratorDomaZdravlja as o where o.RadiUDomuZdravlja.Mbr = : MbrDoma");
                iq.SetString("MbrDoma", parametars);
                IList<AdministratorDomaZdravlja> admini = iq.List<AdministratorDomaZdravlja>();
                dGV_unos_AdminDZ.ColumnCount = 4;
                dGV_unos_AdminDZ.Columns[0].Name = "JMBG";
                dGV_unos_AdminDZ.Columns[1].Name = "Ime";
                dGV_unos_AdminDZ.Columns[2].Name = "Srednje slovo";
                dGV_unos_AdminDZ.Columns[3].Name = "Prezime";


                foreach (AdministratorDomaZdravlja admin in admini)
                {
                    dGV_unos_AdminDZ.Rows.Add(admin.JMBG, admin.Ime, admin.SrednjeSlovo, admin.Prezime);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Morate izabrati dom zdravlja. " + ex);
            }
            s.Close();
        }

        private void btn_unesi_adminaDZ_Click(object sender, EventArgs e)
        {

            pomIndex = cB_izborDZ_adminDZ_unos.SelectedItem.ToString();
            pomIndex = pomIndex.Substring(0, pomIndex.IndexOf(" "));
            ISession s = DataLayer.GetSession();
            try
            {
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
                dGV_unos_AdminDZ.Rows.Add(admin.JMBG, admin.Ime, admin.SrednjeSlovo, admin.Prezime);
                MessageBox.Show("Uspeno ste uneli novog administratora doma zdravlja");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Morate prvo izabrati dom zdravlja");
            }
        }

        #endregion

        #region tab_za_unos_medicinskog_radnika

        private void btn_medRad_unos_Click(object sender, EventArgs e)
        {
            pomIndex = cB_medRad_unosenje_domZ.SelectedItem.ToString();
            pomIndex = pomIndex.Substring(0, pomIndex.IndexOf(" "));
            ISession s = DataLayer.GetSession();
            try
            {
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
                MessageBox.Show("Uspeno ste uneli novog medicinskog radnika");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Morate odabrati dom zdravlja u koji zelite da unesete medicinskog radnika." + ex);
            }
            s.Close();
            
            
        }
        private void cB_medRad_unosenje_domZ_Enter(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            cB_medRad_unosenje_domZ.Items.Clear();
            cB_medRad_unosenje_domZ.Text = string.Empty;
            IQuery iq = s.CreateQuery("from DomZdravlja");
            IList<DomZdravlja> domovi = iq.List<DomZdravlja>();
            foreach (DomZdravlja dz in domovi)
            {
                cB_medRad_unosenje_domZ.Items.Add(dz.Mbr + " " + dz.Ime);
            }

            s.Close();
        }
        
        private void cB_medRad_unosenje_domZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_unos_medRad.DataSource = null;
            dgv_unos_medRad.Columns.Clear();
            ISession s = DataLayer.GetSession();
            string parametars = cB_medRad_unosenje_domZ.SelectedItem.ToString();
            parametars = parametars.Substring(0, parametars.IndexOf(" "));
            IQuery iq = s.CreateQuery("select o from MedicinskoOsoblje as o where o.RadiUDomuZdravlja.Mbr = : MbrDoma");
            iq.SetString("MbrDoma", parametars);
            IList<MedicinskoOsoblje> osoblje = iq.List<MedicinskoOsoblje>();
            dgv_unos_medRad.ColumnCount = 4;
            dgv_unos_medRad.Columns[0].Name = "JMBG";
            dgv_unos_medRad.Columns[1].Name = "Ime";
            dgv_unos_medRad.Columns[2].Name = "Srednje slovo";
            dgv_unos_medRad.Columns[3].Name = "Prezime";


            foreach (MedicinskoOsoblje med in osoblje)
            {
                dgv_unos_medRad.Rows.Add(med.Jmbg, med.Ime, med.Srednje_slovo, med.Prezime);
            }
        }
        #endregion

        #region tab_za_unos_vakcine_dijagnoze_terapije

        private void btn_unos_vakcina_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Vakcina v = new Vakcina()
            {
                Ime = tb_unos_vakcina_ime.Text,
                Opis = tb_unos_vakcina_opis.Text,
                Sifra = tb_unos_vakcina_Sifra.Text
            };
            s.Save(v);
            s.Flush();
            MessageBox.Show("Uspesno ste uneli vakcinu.");
            s.Close();
            tb_unos_vakcina_ime.Text = string.Empty;
            tb_unos_vakcina_opis.Text = string.Empty;
            tb_unos_vakcina_Sifra.Text = string.Empty;
        }

        private void btn_unos_dijagnoze_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Dijagnoza d = new Dijagnoza()
            {
                Ime = tb_unos_dijagnoza_ime.Text,
                Sifra = tb_unos_dijagnoza_sifra.Text
            };
            s.Flush();
            MessageBox.Show("Uspesno ste uneli dijagnozu.");
            s.Close();
            tb_unos_dijagnoza_ime.Text = string.Empty;
            tb_unos_dijagnoza_sifra.Text = string.Empty;
        }

        private void btn_unesi_terapiju_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                string[] parametars = cb_unos_terapija_pacijenti.SelectedItem.ToString().Split(' ');
                Pacijent p = s.Load<Pacijent>(parametars[2]);
                string parametarDijagnoza = cb_unos_terapije_dijagnoza.SelectedItem.ToString();
                Dijagnostifikovano dijag = new Dijagnostifikovano();
                foreach(Dijagnostifikovano d in p.DijagnostifikovanoDijagnoze)
                {
                    if(d.Id.DijagnozaDijagnoza.Sifra == parametarDijagnoza)
                    {
                        dijag = d;
                    }
                }
                Terapija ter = new Terapija()
                {
                    Datum_do = dTP_vakcine_unos_od.Value,
                    Datum_od = dTP_vakcine_unos_do.Value,
                    Opis = tb_unos_terapiju_opis.Text
                };
                ter.TerapijaPacijent = p;
                ter.TerapijaLekar = p.Lekar;
                p.Lekar.Terapije.Add(ter);
                p.Terapije.Add(ter);
                ter.TerapijaDijagnoza = dijag.Id.DijagnozaDijagnoza;
                dijag.Id.DijagnozaDijagnoza.Terapije.Add(ter);
                s.Flush();
                MessageBox.Show("Uspeno ste uneli novu terapiju pacijentu .");
            }
            catch(Exception ex)
            {
                MessageBox.Show("morate izabrati lekara,pacijenta i dijagnozu za koju zelite da dodate terapiju" + ex);
            }
            s.Close();
        }

        private void cb_unos_terapija_lekari_Enter(object sender, EventArgs e)
        {
            cb_unos_terapija_lekari.Items.Clear();
            ISession s = DataLayer.GetSession();
            cb_unos_terapija_lekari.Items.Clear();
            cb_unos_terapija_lekari.Text = string.Empty;
            IQuery iq = s.CreateQuery("from IzabraniLekar");
            IList<IzabraniLekar> lekari = iq.List<IzabraniLekar>();
            foreach (IzabraniLekar il in lekari)
            {
                cb_unos_terapija_lekari.Items.Add(il.Ime + " " + il.Prezime + " " + il.Jmbg);
            }
            s.Close();
        }

        private void cb_unos_terapija_pacijenti_Enter(object sender, EventArgs e)
        {
            cb_unos_terapija_pacijenti.Items.Clear();
            if (cb_unos_terapija_lekari.Text != string.Empty)
            {
                string parametar = cb_unos_terapija_lekari.SelectedItem.ToString();
                parametar = parametar.Substring(0, parametar.IndexOf(" "));
                ISession s = DataLayer.GetSession();
                cb_unos_terapija_pacijenti.Items.Clear();
                cb_unos_terapija_pacijenti.Text = string.Empty;
                IQuery iq = s.CreateQuery("select o from Pacijent as o where o.Lekar.Ime = : imeLekara");
                iq.SetString("imeLekara", parametar);
                IList<Pacijent> pacijenti = iq.List<Pacijent>();
                foreach (Pacijent pac in pacijenti)
                {
                    cb_unos_terapija_pacijenti.Items.Add(pac.Ime + " " + pac.Prezime + " " + pac.Jmbg);
                }
                s.Close();
            }
        }

        private void cb_unos_terapije_dijagnoza_Enter(object sender, EventArgs e)
        {
            cb_unos_terapije_dijagnoza.Items.Clear();
            if (cb_unos_terapija_pacijenti.Text != string.Empty)
            {
                string[] parametars = cb_unos_terapija_pacijenti.SelectedItem.ToString().Split(' ');
                ISession s = DataLayer.GetSession();
                Pacijent p = s.Load<Pacijent>(parametars[2]);
                foreach(Dijagnostifikovano t in p.DijagnostifikovanoDijagnoze)
                {
                    cb_unos_terapije_dijagnoza.Items.Add(t.Id.DijagnozaDijagnoza.Sifra);
                }
                s.Close();
            }
        }
        #endregion

        #endregion

        #region tab_za_brisanje

        #region tab_za_brisanje_dz

        private void btn_brisanje_dz_Click(object sender, EventArgs e)
        {
            
            ISession s = DataLayer.GetSession();
            DomZdravlja dz = s.Load<DomZdravlja>(pomIndex);
            if(dz.Lekari.Count == 0 && dz.Administratori.Count == 0 && dz.MedicinskoOsoblje.Count == 0)
            {
                s.Delete(dz);
            }
            else
            {
                var result = MessageBox.Show("U domu zdravlja postoje medicinski radnici,administratori i lekari kao i njihovi pacijenti,terapije i dijagnoze,ako izvrsite opciju brisanja podaci o navedenim ce biti takodje obrisani. \n Da li zelite da nastavite sa brisanjem? ", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    s.Delete(dz);
                }
                else
                {
                    MessageBox.Show("Promenite dom zdravlja lekarima,medicinskim radnicima i administratorima");
                }
            }
            s.Flush();
            s.Close();
        }
        private void dGV_brisanje_dz_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = dGV_brisanje_dz.CurrentCell.RowIndex;
            pomIndex = dGV_brisanje_dz.Rows[rowindex].Cells[0].Value.ToString();
        }

        #endregion

        #region tab_za_brisanje_lekara
        private void dGV_lekar_brisanje_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = dGV_lekar_brisanje.CurrentCell.RowIndex;
            pomIndex = dGV_lekar_brisanje.Rows[rowindex].Cells[0].Value.ToString();
        }

        private void btn_obrisi_lekara_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IzabraniLekar il = s.Load<IzabraniLekar>(pomIndex);
            if (il.Pacijenti.Count == 0)
            {
                s.Delete(il);
            }
            else
            {
                var result = MessageBox.Show("Lekar je izabran od strane pacijenata, ukoliko izvrsite opciju brisanja podaci o navedenim ce biti takodje obrisani kao i o terapijama i dijagnozama. \n Da li zelite da nastavite sa brisanjem? ", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    s.Delete(il);
                }
                else
                {
                    MessageBox.Show("Promenite izabranog lekara svim pacijentima kojima je izabran lekar oznacen u tabeli");
                }
            }
            s.Flush();
            s.Close();
        }

        private void cB_odabriDZ_lekar_brisanje_Enter(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            cB_odabriDZ_lekar_brisanje.Items.Clear();
            cB_odabriDZ_lekar_brisanje.Text = string.Empty;
            IQuery iq = s.CreateQuery("from DomZdravlja");
            IList<DomZdravlja> domovi = iq.List<DomZdravlja>();
            foreach (DomZdravlja dz in domovi)
            {
                cB_odabriDZ_lekar_brisanje.Items.Add(dz.Ime);
            }
            
            s.Close();
        }
       
        private void cB_odabriDZ_lekar_brisanje_SelectedIndexChanged(object sender, EventArgs e)
        {
            dGV_lekar_brisanje.DataSource = null;
            dGV_lekar_brisanje.Columns.Clear();
            ISession s = DataLayer.GetSession();
            try
            {
                IQuery q = s.CreateQuery("select o from IzabraniLekar as o where o.RadiUDomuZdravlja.Ime = :imeDoma");
                q.SetString("imeDoma", cB_odabriDZ_lekar_brisanje.SelectedItem.ToString());
                IList<IzabraniLekar> ilekari = q.List<IzabraniLekar>();
                dGV_lekar_brisanje.ColumnCount = 4;
                dGV_lekar_brisanje.Columns[0].Name = "Jmbg";
                dGV_lekar_brisanje.Columns[1].Name = "Ime";
                dGV_lekar_brisanje.Columns[2].Name = "Prezime";
                dGV_lekar_brisanje.Columns[3].Name = "Radi u";
                foreach (IzabraniLekar il in ilekari)
                {
                    dGV_lekar_brisanje.Rows.Add(il.Jmbg, il.Ime, il.Prezime, il.RadiUDomuZdravlja.Ime);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem : " + ex);
            }
            s.Close();
        }
        #endregion

        #region tab_za_brisanje_pacijenata
        private void btn_brisanje_pacijenta_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Pacijent pac = s.Load<Pacijent>(pomIndex);
            
                var result = MessageBox.Show("Pacijent sadrzi informacije o vakcinama,terapijama,dijagnozama,ukoliko nastavite sa operacijom brisanja svi podaci o navedenim ce biti obrisani. \n Da li zelite da nastavite sa brisanjem? ", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    s.Delete(pac);
                }
               
            
            s.Flush();
            s.Close();
        }

        private void cB_izborDZ_pac_brisanje_Enter(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            cB_izborDZ_pac_brisanje.Items.Clear();
            cB_izborDZ_pac_brisanje.Text = string.Empty;
            IQuery iq = s.CreateQuery("from DomZdravlja");
            IList<DomZdravlja> domovi = iq.List<DomZdravlja>();
            foreach (DomZdravlja dz in domovi)
            {
                cB_izborDZ_pac_brisanje.Items.Add(dz.Ime);
            }

            s.Close();
        }

        private void cB_izborLekara_pac_brisanje_Enter(object sender, EventArgs e)
        {
            if (cB_izborDZ_pac_brisanje.Text != string.Empty)
            {
                ISession s = DataLayer.GetSession();
                cB_izborLekara_pac_brisanje.Items.Clear();
                cB_izborLekara_pac_brisanje.Text = string.Empty;
                IQuery iq = s.CreateQuery("select o from IzabraniLekar as o where o.RadiUDomuZdravlja.Ime = : imeDoma");
                iq.SetString("imeDoma", cB_izborDZ_pac_brisanje.SelectedItem.ToString());
                IList<IzabraniLekar> lekari = iq.List<IzabraniLekar>();
                foreach (IzabraniLekar il in lekari)
                {
                    cB_izborLekara_pac_brisanje.Items.Add(il.Ime + " " + il.Prezime);
                }
                s.Close();
            }
        }
        
        private void cB_izborLekara_pac_brisanje_SelectedIndexChanged(object sender, EventArgs e)
        {
            dGV_pacijent_brisanje.DataSource = null;
            dGV_pacijent_brisanje.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            try
            {
                string[] parametars = cB_izborLekara_pac_brisanje.SelectedItem.ToString().Split(' ');
                IQuery iq = s.CreateQuery("select o from Pacijent as o where o.Lekar.Ime = : imeLekara and o.Lekar.Prezime = : prezimeLekara");
                iq.SetString("imeLekara", parametars[0]);
                iq.SetString("prezimeLekara", parametars[1]);
                IList<Pacijent> pacijenti = iq.List<Pacijent>();
                dGV_pacijent_brisanje.ColumnCount = 6;
                dGV_pacijent_brisanje.Columns[0].Name = "JMBG";
                dGV_pacijent_brisanje.Columns[1].Name = "Ime";
                dGV_pacijent_brisanje.Columns[2].Name = "Srednje slovo";
                dGV_pacijent_brisanje.Columns[3].Name = "Prezime";
                dGV_pacijent_brisanje.Columns[4].Name = "Pravo da zakaze";
                dGV_pacijent_brisanje.Columns[5].Name = "Opstina";

                foreach (Pacijent pac in pacijenti)
                {
                    dGV_pacijent_brisanje.Rows.Add(pac.Jmbg, pac.Ime, pac.Srednje_slovo, pac.Prezime, pac.Pravo_da_zakaze, pac.Opstina);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Morate izabrati izabranog lekara za pacijenta. " + ex);
            }
            s.Close();
        }

        private void dGV_pacijent_brisanje_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = dGV_pacijent_brisanje.CurrentCell.RowIndex;
            pomIndex = dGV_pacijent_brisanje.Rows[rowindex].Cells[0].Value.ToString();
        }
        #endregion

        #region tab_za_brisanje_admina_domZ

        private void btn_brisanje_admina_DZ_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            AdministratorDomaZdravlja adz = s.Load<AdministratorDomaZdravlja>(pomIndex);                                   
            s.Delete(adz);           
            s.Flush();
            s.Close();
            MessageBox.Show("Uspeno ste obrisali administratora doma zdravlja");
        }
       
        private void cB_odabirDZ_adminDz_brisanje_SelectedIndexChanged(object sender, EventArgs e)
        {
            dGV_adminDZ_brisanje.DataSource = null;
            dGV_adminDZ_brisanje.Columns.Clear();
            ISession s = Hippocrates.Data.DataLayer.GetSession();
            try
            {
                string parametars = cB_odabirDZ_adminDz_brisanje.SelectedItem.ToString();
                IQuery iq = s.CreateQuery("select o from AdministratorDomaZdravlja as o where o.RadiUDomuZdravlja.Ime = : imeDoma");
                iq.SetString("imeDoma", parametars);
                IList<AdministratorDomaZdravlja> admini = iq.List<AdministratorDomaZdravlja>();
                dGV_adminDZ_brisanje.ColumnCount = 6;
                dGV_adminDZ_brisanje.Columns[0].Name = "JMBG";
                dGV_adminDZ_brisanje.Columns[1].Name = "Ime";
                dGV_adminDZ_brisanje.Columns[2].Name = "Srednje slovo";
                dGV_adminDZ_brisanje.Columns[3].Name = "Prezime";


                foreach (AdministratorDomaZdravlja admin in admini)
                {
                    dGV_adminDZ_brisanje.Rows.Add(admin.JMBG, admin.Ime, admin.SrednjeSlovo, admin.Prezime);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Morate izabrati dom zdravlja. " + ex);
            }
            s.Close();
        }


        private void cB_odabirDZ_adminDz_brisanje_Enter(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            cB_odabirDZ_adminDz_brisanje.Items.Clear();
            cB_odabirDZ_adminDz_brisanje.Text = string.Empty;
            IQuery iq = s.CreateQuery("from DomZdravlja");
            IList<DomZdravlja> domovi = iq.List<DomZdravlja>();
            foreach (DomZdravlja dz in domovi)
            {
                cB_odabirDZ_adminDz_brisanje.Items.Add(dz.Ime);
            }

            s.Close();
        }

        private void dGV_adminDZ_brisanje_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = dGV_adminDZ_brisanje.CurrentCell.RowIndex;
            pomIndex = dGV_adminDZ_brisanje.Rows[rowindex].Cells[0].Value.ToString();
        }
        #endregion

        #region tab_za_brisanje_medRadnika
        private void cB_odabirDZ_medRad_brisanje_Enter(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            cB_odabirDZ_medRad_brisanje.Items.Clear();
            cB_odabirDZ_medRad_brisanje.Text = string.Empty;
            IQuery iq = s.CreateQuery("from DomZdravlja");
            IList<DomZdravlja> domovi = iq.List<DomZdravlja>();
            foreach (DomZdravlja dz in domovi)
            {
                cB_odabirDZ_medRad_brisanje.Items.Add(dz.Ime);
            }

            s.Close();
        }
        
        private void cB_odabirDZ_medRad_brisanje_SelectedIndexChanged(object sender, EventArgs e)
        {
            dGV_medRad_brisanje.DataSource = null;
            dGV_medRad_brisanje.Columns.Clear();
            ISession s = DataLayer.GetSession();
            string parametars = cB_odabirDZ_medRad_brisanje.SelectedItem.ToString();
            IQuery iq = s.CreateQuery("select o from MedicinskoOsoblje as o where o.RadiUDomuZdravlja.Ime = : imeDoma");
            iq.SetString("imeDoma", parametars);
            IList<MedicinskoOsoblje> osoblje = iq.List<MedicinskoOsoblje>();
            dGV_medRad_brisanje.ColumnCount = 6;
            dGV_medRad_brisanje.Columns[0].Name = "JMBG";
            dGV_medRad_brisanje.Columns[1].Name = "Ime";
            dGV_medRad_brisanje.Columns[2].Name = "Srednje slovo";
            dGV_medRad_brisanje.Columns[3].Name = "Prezime";


            foreach (MedicinskoOsoblje med in osoblje)
            {
                dGV_medRad_brisanje.Rows.Add(med.Jmbg, med.Ime, med.Srednje_slovo, med.Prezime);
            }
        }

        private void dGV_medRad_brisanje_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = dGV_medRad_brisanje.CurrentCell.RowIndex;
            pomIndex = dGV_medRad_brisanje.Rows[rowindex].Cells[0].Value.ToString();
        }

        private void btn_medRad_brisanje_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            MedicinskoOsoblje med = s.Load<MedicinskoOsoblje>(pomIndex);
            s.Delete(med);
            s.Flush();
            s.Close();
            MessageBox.Show("Uspeno ste obrisali medicinskog radnika");
        }
        #endregion

        #region tab_za_brisanje_vakcina_dijagnoza_terapija
        private void cb_brisanje_dijagnoze_Enter(object sender, EventArgs e)
        {
            cb_brisanje_dijagnoze.Items.Clear();
            ISession s = DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from Dijagnoza");
            IList<Dijagnoza> dijagnoze = iq.List<Dijagnoza>();
            foreach (Dijagnoza d in dijagnoze)
            {
                cb_brisanje_dijagnoze.Items.Add(d.Sifra + " " + d.Ime);
            }
            s.Close();
        }

        private void cb_vakcina_brisanje_Enter(object sender, EventArgs e)
        {
            cb_vakcina_brisanje.Items.Clear();
            ISession s = DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from Vakcina");
            IList<Vakcina> vakcine = iq.List<Vakcina>();
            foreach(Vakcina v in vakcine)
            {
                cb_vakcina_brisanje.Items.Add(v.Ime + " " + v.Sifra);
            }
            s.Close();
        }
        
        private void btn_brisanje_vakcine_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                string[] vakcinaSifra = cb_vakcina_brisanje.SelectedItem.ToString().Split(' ');
                Vakcina v = s.Load<Vakcina>(vakcinaSifra[1]);
                s.Delete(v);
                s.Flush();
                MessageBox.Show("Uspeno ste obrisali vakcinu. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Morate izabrati vakcinu koju zelite da izbrisete. " + ex);
            }
            s.Close();
        }

        private void btn_dijag_brisanje_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                string[] dijagSifra = cb_brisanje_dijagnoze.SelectedItem.ToString().Split(' ');
                Dijagnoza d = s.Load<Dijagnoza>(dijagSifra[0]);
                s.Delete(d);
                s.Flush();
                MessageBox.Show("Uspeno ste obrisali dijagnozu. ");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Izaberite dijagnozu koju zelite da obrisate. " + ex);
            }
            s.Close();
        }

        private void cb_brisanje_ter_lekar_Enter(object sender, EventArgs e)
        {
            cb_brisanje_ter_lekar.Items.Clear();
            ISession s = DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from IzabraniLekar");
            IList<IzabraniLekar> lekari = iq.List<IzabraniLekar>();
            foreach (IzabraniLekar l in lekari)
            {
                cb_brisanje_ter_lekar.Items.Add(l.Ime + " " + l.Prezime + " " + l.Jmbg);
            }
            s.Close();
        }

        private void cb_brisanje_ter_pac_Enter(object sender, EventArgs e)
        {
            cb_brisanje_ter_pac.Items.Clear();
            if (cb_brisanje_ter_lekar.Text != string.Empty)
            {
                string parametar = cb_brisanje_ter_lekar.SelectedItem.ToString();
                parametar = parametar.Substring(0, parametar.IndexOf(" "));
                ISession s = DataLayer.GetSession();
                cb_brisanje_ter_pac.Items.Clear();
                cb_brisanje_ter_pac.Text = string.Empty;
                IQuery iq = s.CreateQuery("select o from Pacijent as o where o.Lekar.Ime = : imeLekara");
                iq.SetString("imeLekara", parametar);
                IList<Pacijent> pacijenti = iq.List<Pacijent>();
                foreach (Pacijent pac in pacijenti)
                {
                    cb_brisanje_ter_pac.Items.Add(pac.Ime + " " + pac.Prezime + " " + pac.Jmbg);
                }
                s.Close();
            }
        }

        private void cb_brisanje_ter_dijag_Enter(object sender, EventArgs e)
        {
            cb_brisanje_ter_dijag.Items.Clear();
            if (cb_brisanje_ter_pac.Text != string.Empty)
            {
                string[] parametars = cb_brisanje_ter_pac.SelectedItem.ToString().Split(' ');
                ISession s = DataLayer.GetSession();
                Pacijent p = s.Load<Pacijent>(parametars[2]);
                foreach (Dijagnostifikovano t in p.DijagnostifikovanoDijagnoze)
                {
                    cb_brisanje_ter_dijag.Items.Add(t.Id.DijagnozaDijagnoza.Sifra);
                }
                s.Close();
            }
        }

        private void cb_brisanje_ter_Enter(object sender, EventArgs e)
        {
            cb_brisanje_ter.Items.Clear();
            if (cb_brisanje_ter_dijag.Text != string.Empty)
            {
                
                ISession s = DataLayer.GetSession();
                IQuery iq = s.CreateQuery("select o from Terapija as o where o.TerapijaPacijent.Jmbg = : jmbgpacijenta and o.TerapijaDijagnoza.Sifra = : sifraDijag");                
                
                string[] paramDijag = cb_brisanje_ter_dijag.SelectedItem.ToString().Split(' ');
                iq.SetString("sifraDijag", paramDijag[0]);
                string[] paramPac = cb_brisanje_ter_pac.SelectedItem.ToString().Split(' ');
                iq.SetString("jmbgpacijenta", paramPac[2]);
                IList<Terapija> terapije = iq.List<Terapija>();
                foreach (Terapija t in terapije)
                {
                    cb_brisanje_ter.Items.Add(t.Id + " " + t.Opis);
                }
                s.Close();
            }
        }

        private void btn_brisanje_ter_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                string[] param = cb_brisanje_ter.SelectedItem.ToString().Split(' ');
                int par = Int32.Parse(param[0]);
                Terapija t = s.Load<Terapija>(par);
               
                
                s.Delete(t);
                s.Flush();
                MessageBox.Show("Uspesno ste obrisali terapiju. ");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Morate oznaciti terapiju koju zelite da obrisete. " + ex);
            }
            s.Close();
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
        
        private void cb_lekar_azuriranje_pretraga_SelectedIndexChanged(object sender, EventArgs e)
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
        
        private void cb_pac_azuriranje_lek_pretraga_SelectedIndexChanged(object sender, EventArgs e)
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
            catch (Exception ex)
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
            PrimioVakcinu pvZaBrisanje = new PrimioVakcinu();
            ISession s = DataLayer.GetSession();
            try
            {
                Pacijent pac = s.Load<Pacijent>(pomIndex);
                IList<PrimioVakcinu> vakcine = pac.PrimioVakcinuVakcine;
                foreach (PrimioVakcinu pv in vakcine)
                {
                    if (pv.Id.PrimioVakcina.Sifra == pomIndex2)
                    {
                        pvZaBrisanje = pv;
                       
                    }
                }
                    
                pac.PrimioVakcinuVakcine.Remove(pvZaBrisanje);
                s.Delete(pvZaBrisanje);

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
        
        private void cb_azuriranje_adminDZ_pretraga_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cB_dz_pretraga_mr_azuriranje_SelectedIndexChanged(object sender, EventArgs e)
        {
            dGV_mr_azuriranje.DataSource = null;
            dGV_mr_azuriranje.Columns.Clear();
            ISession s = DataLayer.GetSession();
            try
            {


                IQuery q = s.CreateQuery("select o from MedicinskoOsoblje as o where o.RadiUDomuZdravlja.Ime = :imeDoma");
                q.SetString("imeDoma", cB_dz_pretraga_mr_azuriranje.SelectedItem.ToString());
                IList<MedicinskoOsoblje> mo = q.List<MedicinskoOsoblje>();
                dGV_mr_azuriranje.ColumnCount = 4;
                dGV_mr_azuriranje.Columns[0].Name = "Jmbg";
                dGV_mr_azuriranje.Columns[1].Name = "Ime";
                dGV_mr_azuriranje.Columns[2].Name = "Prezime";
                dGV_mr_azuriranje.Columns[3].Name = "Radi u";
                foreach (MedicinskoOsoblje o in mo)
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
            cB_dz_pretraga_mr_azuriranje.Items.Clear();
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
            
            ISession s = DataLayer.GetSession();
            try
            {
                int rowindex = dGV_mr_azuriranje.CurrentCell.RowIndex;
                pomIndex = dGV_mr_azuriranje.Rows[rowindex].Cells[0].Value.ToString();
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

        #region tab_azuriranje_vak_dijg_ter

        private void cb_azuriranje_vakcine_Enter(object sender, EventArgs e)
        {
            cb_azuriranje_vakcine.Items.Clear();
            ISession s = DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from Vakcina");
            IList<Vakcina> vakcine = iq.List<Vakcina>();
            foreach (Vakcina v in vakcine)
            {
                cb_azuriranje_vakcine.Items.Add(v.Ime + " " + v.Sifra);
            }
            s.Close();
        }

        private void cb_azuriranje_vakcine_SelectedIndexChanged(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            string[] parametars = cb_azuriranje_vakcine.SelectedItem.ToString().Split(' ');
            Vakcina v = s.Load<Vakcina>(parametars[1]);
            tb_azuriranje_vak_ime.Text = v.Ime;
            tb_azuriranje_vak_opis.Text = v.Opis;
            s.Close();
        }

        private void cb_azuriranje_dijagnoza_Enter(object sender, EventArgs e)
        {
            cb_azuriranje_dijagnoza.Items.Clear();
            ISession s = DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from Dijagnoza");
            IList<Dijagnoza> dijag = iq.List<Dijagnoza>();
            foreach (Dijagnoza d in dijag)
            {
                cb_azuriranje_dijagnoza.Items.Add(d.Ime + " " + d.Sifra);
            }
            s.Close();
        }

        private void cb_azuriranje_dijagnoza_SelectedIndexChanged(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            string[] parametars = cb_azuriranje_dijagnoza.SelectedItem.ToString().Split(' ');
            Dijagnoza d = s.Load<Dijagnoza>(parametars[1]);
            tb_azuriranje_dijag_ime.Text = d.Ime;
            s.Close();
        }

        private void cb_azuriranje_ter_lekar_Enter(object sender, EventArgs e)
        {
            cb_azuriranje_ter_lekar.Items.Clear();
            ISession s = DataLayer.GetSession();
            IQuery iq = s.CreateQuery("from IzabraniLekar");
            IList<IzabraniLekar> lekari = iq.List<IzabraniLekar>();
            foreach (IzabraniLekar l in lekari)
            {
                cb_azuriranje_ter_lekar.Items.Add(l.Ime + " " + l.Prezime + " " + l.Jmbg);
            }
            s.Close();
        }

        private void cb_azuriranje_ter_pac_Enter(object sender, EventArgs e)
        {
            cb_azuriranje_ter_pac.Items.Clear();
            if (cb_azuriranje_ter_lekar.Text != string.Empty)
            {
                string parametar = cb_azuriranje_ter_lekar.SelectedItem.ToString();
                parametar = parametar.Substring(0, parametar.IndexOf(" "));
                ISession s = DataLayer.GetSession();
                cb_azuriranje_ter_pac.Items.Clear();
                cb_azuriranje_ter_pac.Text = string.Empty;
                IQuery iq = s.CreateQuery("select o from Pacijent as o where o.Lekar.Ime = : imeLekara");
                iq.SetString("imeLekara", parametar);
                IList<Pacijent> pacijenti = iq.List<Pacijent>();
                foreach (Pacijent pac in pacijenti)
                {
                    cb_azuriranje_ter_pac.Items.Add(pac.Ime + " " + pac.Prezime + " " + pac.Jmbg);
                }
                s.Close();
            }
        }

        private void cb_azuriranje_ter_dijagnoza_Enter(object sender, EventArgs e)
        {
            cb_azuriranje_ter_dijagnoza.Items.Clear();
            if (cb_azuriranje_ter_pac.Text != string.Empty)
            {
                string[] parametars = cb_azuriranje_ter_pac.SelectedItem.ToString().Split(' ');
                ISession s = DataLayer.GetSession();
                Pacijent p = s.Load<Pacijent>(parametars[2]);
                foreach (Dijagnostifikovano t in p.DijagnostifikovanoDijagnoze)
                {
                    cb_azuriranje_ter_dijagnoza.Items.Add(t.Id.DijagnozaDijagnoza.Sifra);
                }
                s.Close();
            }
        }
        private void cb_azuriranje_ter_ter_Enter(object sender, EventArgs e)
        {
            cb_azuriranje_ter_ter.Items.Clear();
            if (cb_azuriranje_ter_dijagnoza.Text != string.Empty)
            {

                ISession s = DataLayer.GetSession();
                IQuery iq = s.CreateQuery("select o from Terapija as o where o.TerapijaPacijent.Jmbg = : jmbgpacijenta and o.TerapijaDijagnoza.Sifra = : sifraDijag");

                string[] paramDijag = cb_azuriranje_ter_dijagnoza.SelectedItem.ToString().Split(' ');
                iq.SetString("sifraDijag", paramDijag[0]);
                string[] paramPac = cb_azuriranje_ter_pac.SelectedItem.ToString().Split(' ');
                iq.SetString("jmbgpacijenta", paramPac[2]);
                IList<Terapija> terapije = iq.List<Terapija>();
                foreach (Terapija t in terapije)
                {
                    cb_azuriranje_ter_ter.Items.Add(t.Id + " " + t.Opis);
                }
                s.Close();
            }
        }
        private void btn_azuriraj_vakcinu_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                string[] parametars = cb_azuriranje_vakcine.SelectedItem.ToString().Split(' ');
                Vakcina v = s.Load<Vakcina>(parametars[1]);
                v.Ime = tb_azuriranje_vak_ime.Text;
                v.Opis = tb_azuriranje_vak_opis.Text;
                s.Flush();
                MessageBox.Show("Uspesno ste azurirali vakcinu.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Morate odabrati vakcinu koju zelite da azurirate. ");
            }
            s.Close();
        }

        private void btn_azuriranje_dijag_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            try
            {
                string[] parametars = cb_azuriranje_dijagnoza.SelectedItem.ToString().Split(' ');
                Dijagnoza d = s.Load<Dijagnoza>(parametars[1]);
                d.Ime = tb_azuriranje_dijag_ime.Text;
                s.Flush();
                MessageBox.Show("Uspesno ste azurirali dijagnozu. ");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Morate izabrati dijagnozu koju zelite da azurirate. ");
            }
            s.Close();
        }

        private void cb_azuriranje_ter_ter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            string[] parametars = cb_azuriranje_ter_ter.SelectedItem.ToString().Split(' ');
            int parametar = Int32.Parse(parametars[0]);
            Terapija t = s.Load<Terapija>(parametar);
            tb_azuriranje_ter_opis.Text = t.Opis;
            dTP_azuriranje_ter_od.Value = t.Datum_od;
            dTP_azuriranje_ter_do.Value = t.Datum_do;
            s.Close();

        }

        private void btn_azurirajte_terapiju_Click(object sender, EventArgs e)
        {

            ISession s = DataLayer.GetSession();
            try
            {
                string[] parametars = cb_azuriranje_ter_ter.SelectedItem.ToString().Split(' ');
                int parametar = Int32.Parse(parametars[0]);
                Terapija t = s.Load<Terapija>(parametar);
                t.Opis = tb_azuriranje_ter_opis.Text;
                t.Datum_od = dTP_azuriranje_ter_od.Value;
                t.Datum_do = dTP_azuriranje_ter_do.Value;
                s.Flush();
                MessageBox.Show("Uspeno ste azurirali terapiju. ");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Morate izabrati terapiju koju zelite da azurirate. ");
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
