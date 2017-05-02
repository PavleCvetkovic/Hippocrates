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

namespace HippocratesDoctor
{
    public partial class FormLekar : MetroForm, IView
    {
        private IController _controller;
        private ISession session;
        private IzabraniLekar lekar_local;
        private Smena smena_lekara_local;
        private Pacijent aktivni_pacijent = null;
        //
        private string jmbg_lekara, active_patient_jmbg;
        private int smena_lekara;
        private string sql_search;
        public FormLekar(string jmbg_lekara)
        {
            InitializeComponent();
            session = DataLayer.GetSession();
            lekar_local = session.Load<IzabraniLekar>(jmbg_lekara);

            this.jmbg_lekara = lekar_local.Jmbg;
            this.Text = lekar_local.Ime + " " + lekar_local.Prezime;
            //this.Text = GetDoctorNameAndSurname(jmbg_lekara);
            metroDateTime1.MinDate = System.DateTime.Today;
            metroDateTime1.Value = System.DateTime.Now; // causes event that calls RefreshControls to initialize the controls
            metroTabGlobal.SelectedIndex = 0; // Show 'Raspored pregleda' first
            metroComboBoxIzborPretrage.SelectedIndex = 1; // LBO default way of search
            metroLabelActivePatient.Text = "Prelaz preko dugmeta za info o terminu";

            smena_lekara_local = GetDoctorShift(lekar_local);
            metroLabelSmenaLekara.Text = smena_lekara_local == null ? "Smena nije postavljena" : GetShiftName(smena_lekara_local.SmenaLekara);

            //metroButtonPretraziPacijente_Click += metroComboBoxIzborPretrage_SelectedIndexChanged; 
            foreach (Control c in pnlPopodne.Controls)
            {
                MetroButton mb = c as MetroButton;
                if (mb != null)
                {
                    mb.Click += metroButton_Click;
                    mb.MouseHover += metroButton_MouseHover;
                    mb.MouseLeave += metroButton_MouseLeave;
                    //mb.UseStyleColors = true;
                }
            }
            foreach (Control c in pnlPrepodne.Controls)
            {
                MetroButton mb = c as MetroButton;
                if (mb != null)
                {
                    mb.Click += metroButton_Click;
                    mb.MouseHover += metroButton_MouseHover;
                    mb.MouseLeave += metroButton_MouseLeave;
                    //mb.UseStyleColors = true;
                }
            }
        }

        public void setController(IController controller)
        {
            this._controller = controller;
        }

        /*private string GetDoctorNameAndSurname(string jmbg_lekara)
        {
            string to_return = string.Empty;
            MySqlConnection conn = new MySqlConnection(Hippocrates.Data.ConnectionInfo.connection_string_nikola);
            try
            {
                // Open connection
                conn.Open();
                // Copy to local 
                // Perform database operations
                string sql = "select ime, prezime from IZABRANI_LEKAR where jmbg = '" + jmbg_lekara + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                // rdr[0] = IME, rdr[1] = PREZIME
                while (rdr.Read())
                    to_return = rdr[0].ToString() + " " + rdr[1].ToString();

                rdr.Close();

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Greška prilikom čitanja baze " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                to_return = "Error during doctor database reading";
            }
            finally
            {
                conn.Close();
                // Database is always closed
            }
            return to_return;
        }
        */

        private string GetShiftName(int shift)
        {
            if (shift == 1)
                return "Prepodne";
            else
                return "Poslepodne";
        }

        private void RefreshControls(IzabraniLekar lekar)
        {
            smena_lekara_local = GetDoctorShift(lekar_local);
            UpdateForm(smena_lekara_local.SmenaLekara);

            //lekar_local.Termini[0].Pacijent
            IQuery query = session.CreateQuery("from Termin t where t.Lekar.Jmbg = :lekar and t.Datum = :datum");
            query.SetParameter("lekar", lekar_local.Jmbg);
            query.SetParameter("datum", System.DateTime.Today);

            IList<Termin> termini_lekara = query.List<Termin>(); // lista svih danasnjih termina zadatog lekara


            #region Reset all buttons
            foreach (Control c in pnlPopodne.Controls)
            {
                MetroButton mb = c as MetroButton;
                if (mb != null)
                {
                    mb.Highlight = false;
                    mb.Enabled = false; // ne mogu biti kliknuti (jer nije zakazan termin)
                    //mb.BackColor = Color.LightCyan; // LightCyan = Free
                }

            }
            foreach (Control c in pnlPopodne.Controls)
            {
                MetroButton mb = c as MetroButton;
                if (mb != null)
                {
                    mb.Highlight = false;
                    mb.Enabled = false; // ne mogu biti kliknuti (jer nije zakazan termin)
                    //mb.BackColor = Color.LightCyan; // LightCyan = Free
                }
            }
            #endregion

            foreach(Termin t in termini_lekara)
            {
                int time = t.Vreme;
                //MetroMessageBox.Show(this, "Enter while loop in rdr.Read() " + time.ToString(), "rdr.Read()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (time <= 1330)
                {
                    MetroButton mb = this.pnlPrepodne.Controls["metroButton" + time.ToString()] as MetroButton;
                    if (mb != null)
                    {
                        mb.Highlight = true;
                        mb.Enabled = true; // moze biti kliknutu jer je zakazan termin (postoji pacijent)
                        //mb.BackColor = Color.LightGoldenrodYellow; // NOT Free
                        //this.pnlPrepodne.Controls["metroButton" + time.ToString()].Enabled = false;
                    }
                }
                else
                {
                    MetroButton mb = this.pnlPopodne.Controls["metroButton" + time.ToString()] as MetroButton;
                    if (mb != null)
                    {
                        mb.Highlight = true;
                        mb.Enabled = true; // moze biti kliknutu jer je zakazan termin (postoji pacijent)
                        //mb.BackColor = Color.LightGoldenrodYellow; // NOT Free
                        //this.pnlPopodne.Controls["metroButton" + time.ToString()].Enabled = false;
                    }
                }
            }
        }

        private Smena GetDoctorShift(IzabraniLekar lekar)
        {
            Smena smena = null;
            foreach (Smena s in lekar.Smene)
                if (s.Id.Datum_Od <= System.DateTime.Now && s.Datum_Do >= System.DateTime.Now)
                {
                    smena = s;
                    break;
                }
            return smena; 
        }

        private void UpdateForm(int smena_lek)
        {
            if (smena_lek == 1) // Promenjen Visible na Enable svojstvo 
            {
                metroLabelSmenaLekara.Text = "Prepodne";
                pnlPrepodne.Enabled = true;
                pnlPopodne.Enabled = false;
                //pnlPopodne.Enabled = false;
            }
            else
            {
                metroLabelSmenaLekara.Text = "Poslepodne";
                pnlPrepodne.Enabled = false;
                pnlPopodne.Enabled = true;
                //pnlPrepodne.Enabled = false;
            }
        }

        private Pacijent GetPatientFromClick(int time)
        {
            Pacijent p = null;
            IQuery query = session.CreateQuery("select Pacijent from Termin t where t.Lekar.Jmbg = :lekar and t.Datum = :datum and t.Vreme = :vreme");
            query.SetParameter("lekar", lekar_local.Jmbg);
            query.SetParameter("datum", System.DateTime.Today);
            query.SetParameter("vreme", time);

            p = query.UniqueResult<Pacijent>();
            return p;

            //IList<Termin> termini_lekara = query.List<Termin>(); // lista svih danasnjih termina zadatog lekara
            
        }

        private string GetDate() // Trebalo bi svuda se iskoristi funkcija GetDateFromControl jer univerzalno radi za svaki MetroDateTimePicker
        {
            return metroDateTime1.Value.Year.ToString() + "-" + metroDateTime1.Value.Month.ToString() + "-" +
                              metroDateTime1.Value.Day.ToString();
        }

        private string GetDateFromControl(MetroDateTime mdt)
        {
            return mdt.Value.Year.ToString() + "-" + mdt.Value.Month.ToString() + "-" +
                              mdt.Value.Day.ToString();
        }

        //private string GetPatientJMBG(string vreme)
        //{
        //    string to_return = string.Empty;
        //    MySqlConnection conn = new MySqlConnection(Hippocrates.Data.ConnectionInfo.connection_string_nikola);
        //    try
        //    {
        //        conn.Open();
        //        string comm = "select MATBRP from TERMIN where MATBRL = '" + jmbg_lekara + "'" +
        //            "and DATUM = '" + GetDate() + "' and VREME = '" + vreme + "';";
        //        MySqlCommand cmd = new MySqlCommand(comm, conn);
        //        to_return = cmd.ExecuteScalar().ToString();
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show("Error during connection (in GetPatientJMBG())" + ex.Message.ToString());
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return to_return;

        //}

        private string GetPatientBasicInfo(string jmbg_pacijenta)
        {
            string to_return = string.Empty;
            to_return = aktivni_pacijent.Jmbg + " " + aktivni_pacijent.Ime + " " + aktivni_pacijent.Prezime;
            return to_return;
        }

        private void GetAllPatientBasicInfo() // za prikaz svih pacijenata iz DomaZdravlja
        {

            IQuery query = session.CreateQuery("from Pacijent p where p.Opstina = :domZdravljaOpstina");
            query.SetParameter("domZdravljaOpstina", lekar_local.RadiUDomuZdravlja.Opstina);

            IList<Pacijent> lista_pacijenata = query.List<Pacijent>();

            metroGridPacijenti.DataSource = lista_pacijenata;
            metroGridPacijenti.Columns["Ocene"].Visible = false;
            metroGridPacijenti.Columns["Terapije"].Visible = false;
            metroGridPacijenti.Columns["PrimioVakcinuVakcine"].Visible = false;
            metroGridPacijenti.Columns["DijagnostifikovanoDijagnoze"].Visible = false;
            metroGridPacijenti.Columns["Termini"].Visible = false;
            metroGridPacijenti.Columns["Zahtevi"].Visible = false;
            metroGridPacijenti.Columns["TerminiBolnica"].Visible = false;

            for (int i = 0; i < metroGridPacijenti.ColumnCount; i++)
                metroGridPacijenti.Columns[i].Width = metroGridPacijenti.Width / (metroGridPacijenti.ColumnCount - 7);
            /*
            string sql = "select JMBG, LBO, IME, PREZIME, OPŠTINA from PACIJENT " +
                    "where OPŠTINA = (select OPŠTINA from DOM_ZDRAVLJA " +
                    "where MBR = (select MBRZU from IZABRANI_LEKAR where JMBG = '" + jmbg_lekara + "'))";
            */
        }

        private void RefreshTerapijeData(Pacijent pacijent)
        {
            metroGridTerapije.DataSource = pacijent.Terapije;
            metroGridTerapije.Columns["Id"].Visible = false;
            metroGridTerapije.Columns["TerapijaPacijent"].Visible = false;
            metroGridTerapije.Columns["TerapijaLekar"].Visible = false;

            for (int i = 0; i < metroGridTerapije.ColumnCount; i++)
                metroGridTerapije.Columns[i].Width = metroGridTerapije.Width / (metroGridTerapije.ColumnCount - 3);
        }

        private void RefreshVakcineData(Pacijent pacijent)
        {
            metroGridVakcine.DataSource = pacijent.PrimioVakcinuVakcine;
            for (int i = 0; i < metroGridVakcine.ColumnCount; i++)
                metroGridVakcine.Columns[i].Width = metroGridVakcine.Width / metroGridVakcine.ColumnCount;
        }

        private void RefreshDijagnozeData(Pacijent pacijent)
        {
            metroGridDijagnoze.DataSource = pacijent.DijagnostifikovanoDijagnoze;

            for (int i = 0; i < metroGridDijagnoze.ColumnCount; i++)
                  metroGridDijagnoze.Columns[i].Width = metroGridDijagnoze.Width / metroGridDijagnoze.ColumnCount;
          
        }

        private bool ChangePatientRightForAppointment(out Pacijent pacijent, bool pravo_da_zakaze) 
        {
            pacijent = aktivni_pacijent;
            bool success = true;

            if (pravo_da_zakaze) // checkBox kontrola
                pacijent.Pravo_da_zakaze = 1;
            else
                pacijent.Pravo_da_zakaze = 0;
            
            try
            {
                session.Update(pacijent);
                session.Flush();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Greška u funkciji za promenu prava za zakazivanje " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = false;
            }
            return success;
        }

        private void SearchPatients(IQuery query)
        {
            //Validation Needed
            //Empty current data grid.
            if (query == null)
            {
                MetroMessageBox.Show(this, "Query is null in Search patients");
                return; 
            }

            EmptyMetroDataGrid(metroGridPretragaPacijenata);
            IList<Pacijent> pacijenti = query.List<Pacijent>();
            metroGridPretragaPacijenata.DataSource = pacijenti;
        }   

        private void EmptyMetroDataGrid(MetroGrid mg)
        {
            mg.DataSource = null;
        }

        private IQuery RefreshSQLString()
        {
            IQuery q = null;
            switch (metroComboBoxIzborPretrage.SelectedIndex)
            {
                case 0:
                    {
                        q = session.CreateQuery("from Pacijent p where p.Datum_rodjenja = :datum");
                        q.SetParameter("datum", metroDateTimeDatumParametar.Value.Date);

                        //this.sql_search = "select JMBG, IME, SREDNJE_SLOVO, PREZIME, DATUM_ROĐENJA, OPŠTINA, LBO"
                        //    + " from PACIJENT where DATUM_ROĐENJA = '" + GetDateFromControl(metroDateTimeDatumParametar) + "'";

                        //MessageBox.Show("datum rodjenja je:" + GetDateFromControl(metroDateTimeDatumParametar));

                        metroDateTimeDatumParametar.Enabled = true;
                        metroTextBoxUnosParametra.Enabled = false;
                        break;
                    }

                case 1:
                    {
                        q = session.CreateQuery("from Pacijent p where p.Lbo = :lbo");
                        q.SetParameter("lbo", metroTextBoxUnosParametra.Text);
                        //this.sql_search = "select JMBG, IME, SREDNJE_SLOVO, PREZIME, DATUM_ROĐENJA, OPŠTINA, LBO"
                        //    + " from PACIJENT where LBO = '" + metroTextBoxUnosParametra.Text + "'";
                        metroDateTimeDatumParametar.Enabled = false;
                        metroTextBoxUnosParametra.Enabled = true;
                        break;
                    }
                case 2:
                    {
                        q = session.CreateQuery("from Pacijent p where p.Opstina = :opstina");
                        q.SetParameter("opstina", metroTextBoxUnosParametra.Text);
                        //this.sql_search = "select JMBG, IME, SREDNJE_SLOVO, PREZIME, DATUM_ROĐENJA, OPŠTINA, LBO"
                        //    + " from PACIJENT where OPŠTINA = '" + metroTextBoxUnosParametra.Text + "'";
                        metroDateTimeDatumParametar.Enabled = false;
                        metroTextBoxUnosParametra.Enabled = true;
                        break;
                    }
            }
            return q;
        }

        ///////////// Events

        private void metroTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTabControl mtc = sender as MetroFramework.Controls.MetroTabControl;

            //MessageBox.Show("Selected inex changed event" + mtc.SelectedIndex);
            switch (mtc.SelectedIndex)
            {
                case 0: { RefreshControls(lekar_local); break; }
                case 1: { GetAllPatientBasicInfo(); break; }
            }
        }

        private void metroGridPacijenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MetroGrid mg = sender as MetroGrid;
            if (mg == null)
                throw new Exception("Error in MetroGrid conversion");
            MetroMessageBox.Show(this, "Selektovali ste " + mg.SelectedCells[0].Value.ToString() + " LBO " + mg.SelectedCells[1].Value.ToString(), "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            aktivni_pacijent = (Pacijent)mg.SelectedRows[0].DataBoundItem;
            PacijentForm pf = new PacijentForm(session ,aktivni_pacijent); // jmbg (from MetroGrid), lbo(not needed)
            pf.ShowDialog();
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            smena_lekara_local = GetDoctorShift(lekar_local);
            RefreshControls(lekar_local);
        }

        private void metroButton_MouseLeave(object sender, EventArgs e)
        {
            MetroButton metro_button = (MetroButton)sender; // Current patient to show
            metroLabelActivePatient.Text = "Prelaz preko dugmeta za kratak info";
            metroLabelActivePatient.BackColor = Color.Aqua;
            metroLabelActivePatient.UseCustomBackColor = true;
        }

        private void metroButton_MouseHover(object sender, EventArgs e)
        {
            MetroButton metro_button = (MetroButton)sender;
            if (metro_button.Highlight == false) // Slobodan termin
            {
                metroLabelActivePatient.Text = "Slobodan termin";
                metroLabelActivePatient.BackColor = Color.Green;
            }
            else
            {
                metroLabelActivePatient.Text = "Zakazan termin (klik na dugme za info o pacijentu)";
                metroLabelActivePatient.BackColor = Color.OrangeRed;
            }
            metroLabelActivePatient.UseCustomBackColor = true;

        }

        private void metroTabPacijentInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTabControl mtc = sender as MetroFramework.Controls.MetroTabControl;
            //MessageBox.Show("Selected inex changed event" + mtc.SelectedIndex);
            switch (mtc.SelectedIndex)
            {
                case 0: { RefreshDijagnozeData(aktivni_pacijent); break; }
                case 1: { RefreshVakcineData(aktivni_pacijent); break; }
                case 2: { RefreshTerapijeData(aktivni_pacijent); break; }
                case 3: { metroLabelOceniPacijentaInfo.Text = GetPatientBasicInfo(active_patient_jmbg); break; }
            }
        }

        private void metroButtonOceniPacijenta_Click(object sender, EventArgs e)
        {
            //MetroMessageBox.Show(this, "Da li ste sigurni da želite da ocenite dolazak pacijenta?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            DialogResult dr = MetroMessageBox.Show(this, "Da li ste sigurni da želite da ocenite dolazak pacijenta?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel)
                return;

            bool dolazak = metroCheckBoxDosaoUTerminu.Checked;
            if (ChangePatientRightForAppointment(out aktivni_pacijent, dolazak))
                MetroMessageBox.Show(this, "Uspešno ocenjen dolazak pacijenta", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MetroMessageBox.Show(this, "Greška prilikom ocenjivanja pacijenta", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void metroButtonPretraziPacijente_Click(object sender, EventArgs e)
        {
            //string sql = string.Empty;
            //Validation needed
            SearchPatients(RefreshSQLString());
        }

        private void metroComboBoxIzborPretrage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Validation Needed
            RefreshSQLString();
        }

        private void metroButton_Click(object sender, EventArgs e)
        {
            // Open 'Informacije o pacijentu tab'
            MetroButton metro_button = (MetroButton)sender;
            metroTabGlobal.SelectedIndex = 2; // Change tab
            metroTabPacijentInfo.SelectedIndex = 0; // Informacije o pacijentu -> Dijagnoze
            //active_patient_jmbg = GetPatientJMBG(metro_button.Text.Replace(":", string.Empty));
            Int32 time = 0;
            if (Int32.TryParse(metro_button.Text.Replace(":", string.Empty), out time))
                aktivni_pacijent = GetPatientFromClick(time);
            
            RefreshDijagnozeData(aktivni_pacijent);
        }

    }
}
