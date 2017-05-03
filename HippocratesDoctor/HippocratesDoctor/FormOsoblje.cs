using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hippocrates.Controller;
using Hippocrates.View;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using MetroFramework;
using MetroFramework.Controls;
using HippocratesPatient;
using NHibernate;
using Hippocrates.Data.Entiteti;
using Hippocrates.Data;
using Hippocrates;

namespace HippocratesDoctor
{
    public partial class FormOsoblje : MetroForm, IView
    {
        private IzabraniLekar il;
        private Pacijent pac;
        private DomZdravlja dz;
        private Smena smena_lekara_local;
        private IController _controller;
        public FormOsoblje()
        {
            InitializeComponent();
        }
        public FormOsoblje(string jmbg)
        {
            InitializeComponent();
            ISession s = DataLayer.GetSession();
            MedicinskoOsoblje mo = s.Load<MedicinskoOsoblje>(jmbg);
            this.Text = mo.Ime + " " + mo.Prezime;
            dz = mo.RadiUDomuZdravlja;
            lblDomZdravlja.Text = mo.RadiUDomuZdravlja.Ime;
            s.Close();
            il = new IzabraniLekar();
            pac = new Pacijent();
            lblImePacijenta.Text = string.Empty;
            lblImeLekara.Text = string.Empty;
        }
        public void setController(IController controller)
        {
            this._controller = controller;
        }

        private void mB_nadjiPacijenta_Click(object sender, EventArgs e)
        {
            
            ISession s = DataLayer.GetSession();
            try
            {
                IQuery iq = null;
                if (tB_pretraga.Text != string.Empty)
                {
                    if (mBC_pacijenti_nacinPretrage.SelectedItem.ToString() == "Jmbg")
                    {
                        iq = s.CreateQuery("from Pacijent o where o.Jmbg = : jmbg and o.Opstina = : opstina");
                        iq.SetParameter("jmbg", tB_pretraga.Text);
                        iq.SetParameter("opstina", dz.Opstina);
                        pac = iq.UniqueResult<Pacijent>();
                        il = pac.Lekar;
                        lblImeLekara.Text = il.Ime;
                        lblImeLekara.Visible = true;
                        lblPrezimeLekara.Text = il.Prezime;
                        lblPrezimeLekara.Visible = true;
                        infomacijeOPac(pac);
                    }
                    else
                    {
                        iq = s.CreateQuery("from Pacijent o where o.Lbo = : lbo and o.Opstina = : opstina");
                        iq.SetParameter("lbo", tB_pretraga.Text);
                        iq.SetParameter("opstina", dz.Opstina);
                        pac = iq.UniqueResult<Pacijent>();
                        il = pac.Lekar;
                        lblImeLekara.Text = il.Ime;
                        lblImeLekara.Visible = true;
                        lblPrezimeLekara.Text = il.Prezime;
                        lblPrezimeLekara.Visible = true;
                        infomacijeOPac(pac);                        
                    }
                    lblImePacijenta.Text = pac.Ime;
                    lblImePacijenta.Visible = true;
                    lblPrezimePacijenta.Text = pac.Prezime;
                    lblPrezimePacijenta.Visible = true;
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nijedan pacijent sa navedenim kriterijumom za pretragu nije pronadjen,pokusajte ponovo.");
            }
            s.Close();
        }

       

        private void infomacijeOPac(Pacijent p)
        {
            lblJmbgPacInformacije.Text = p.Jmbg;
            lblJmbgPacInformacije.Visible = true;
            lblImePacInformacije.Text = p.Ime;
            lblImePacInformacije.Visible = true;
            lblPrezimePacInformacije.Text = p.Prezime;
            lblPrezimePacInformacije.Visible = true;
            lblSrednjeSlovoPacInfromacije.Text = p.Srednje_slovo;
            lblSrednjeSlovoPacInfromacije.Visible = true;
            lblDatumRodjenjaPacInformacije.Text = p.Datum_rodjenja.ToShortDateString();
            lblDatumRodjenjaPacInformacije.Visible = true;
            lblOpstinaPacInformacije.Text = p.Opstina;
            lblOpstinaPacInformacije.Visible = true;
            if (p.Pravo_da_zakaze == 1)
            {
                lblPravoDaZakPacInformacije.Text = "Dozvoljeno";
                lblPravoDaZakPacInformacije.ForeColor = Color.Black;
            }
            else
            {
                lblPravoDaZakPacInformacije.Text = "Zabranjeno";
                lblPravoDaZakPacInformacije.ForeColor = Color.Red;
            }
            lblPravoDaZakPacInformacije.Visible = true;
            lblLboPacInformacije.Text = p.Lbo;
            lblLboPacInformacije.Visible = true;
            lblVaziDoPacInformacije.Text = p.Vazi_do.ToShortDateString();
            lblVaziDoPacInformacije.Visible = true;
            lblEmailPacInformacije.Text = pac.Email;
            lblEmailPacInformacije.Visible = true;
            lblTelefonPacInformacije.Text = p.Telefon;
            lblTelefonPacInformacije.Visible = true;
            foreach(PrimioVakcinu v in pac.PrimioVakcinuVakcine)
            {
                lB_vakcine.Items.Add(v.Id.PrimioVakcina.Ime + " " + v.Id.PrimioVakcina.Sifra + " " + v.Id.PrimioVakcina.Opis);
            }
            foreach(Dijagnostifikovano d in pac.DijagnostifikovanoDijagnoze)
            {
                lB_dijagnoze.Items.Add(d.Id.DijagnozaDijagnoza.Ime + " " + d.Id.DijagnozaDijagnoza.Sifra + " " + d.Datum.ToShortDateString());
            }
            foreach(Terapija t in pac.Terapije)
            {
                lB_terapije.Items.Add(t.Id + " " + t.Opis + " " + t.Datum_od.ToShortDateString() + " - " + t.Datum_do.ToShortDateString());
            }
           
        }

        private void btn_zakazivanje_Click(object sender, EventArgs e)
        {
            if (lblImeLekara.Text != string.Empty && lblImePacijenta.Text != string.Empty)
            {
                FormRaspored fr = new FormRaspored(il.Jmbg, pac.Jmbg);
                fr.Show();
            }
            else
            {
                MetroMessageBox.Show(this,"Morate izabrati pacijenta.","Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
