using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hippocrates.Data;
using Hippocrates.Controller;
using Hippocrates.View;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;
using MetroFramework;
using MetroFramework.Controls;
using Hippocrates.Data.Entiteti;
using NHibernate;

namespace HippocratesDoctor
{
    public partial class FormDirektor : MetroForm, IView
    {
        private IController _controller;
        //private Hippocrates.Data.IzabraniLekar active_doctor;
        //private string facility_id, facility_name, jmbg_admin;
        private ISession session;
        private AdministratorDomaZdravlja admin_local;
        private DomZdravlja dom_zdravlja_local;

        public FormDirektor(string dom_zdravlja_admin_jmbg)
        {
            InitializeComponent();
            session = DataLayer.GetSession();
            admin_local = session.Get<AdministratorDomaZdravlja>(dom_zdravlja_admin_jmbg);
            dom_zdravlja_local = admin_local.RadiUDomuZdravlja;

            //jmbg_admin = admin_local.JMBG;
            lblImeDomaZ.Text = GetMedicalFacilityInfo(admin_local);
            metroTabControlGlobal.SelectedIndex = 0; // Zove GetAllDoctors(dom_zdravlja_local)
            GetAllDoctors(dom_zdravlja_local); // GetAllDoctors(facility_id) se zove nakon GetMedicalFacilityInfo(jmbg_admin) jer se tu inicijalizuje 'facility_id'
            //metroRadioButtonSmenaPrepodne.MouseHover += MetroRadioButtonSmenaPrepodne_MouseHover;
            //metroRadioButtonSmenaPoslepodne.MouseHover += MetroRadioButtonSmenaPrepodne_MouseHover;
        }

        // Help functions

        #region Get Data Functions

        private string GetMedicalFacilityInfo(AdministratorDomaZdravlja admin)
        {
            string to_return = string.Empty;
            to_return = admin.RadiUDomuZdravlja.Ime + " " + admin.RadiUDomuZdravlja.Adresa;
            #region SQL nacin
            /*
            MySqlConnection conn = new MySqlConnection(Hippocrates.Data.ConnectionInfo.connection_string_nikola);
            try
            {
                conn.Open();
                string sql_command = "select MBR, IME from DOM_ZDRAVLJA where "
                    + " MBR = (select MBRZU from ADMINISTRATOR_DOM_ZDRAVLJA where JMBG = '" + jmbg_admin + "');";
                MySqlCommand cmd = new MySqlCommand(sql_command, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    facility_id = rdr[0].ToString();
                    facility_name = rdr[1].ToString();
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Greška prilikom čitanja iz baze " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            */
            #endregion

            return to_return;
        }

        private void GetAllDoctors(DomZdravlja dom_zdravlja)
        {
            IList<IzabraniLekar> Lekari = dom_zdravlja.Lekari;
            //metroGridData.Refresh();
            //metroGridData.DataSource = null;
            metroGridData.DataSource = new BindingList<IzabraniLekar>(Lekari);
            int to_show_column_number = 6;
            for (int i = to_show_column_number; i < metroGridData.ColumnCount; i++)
                metroGridData.Columns[i].Visible = false;
            for (int i = 0; i < metroGridData.ColumnCount - to_show_column_number; i++)
                metroGridData.Columns[i].Width = (this.Width - 10) / (metroGridData.ColumnCount - to_show_column_number);
        }

        private void GetMedicalStaffData(DomZdravlja dom_zdravlja)
        {
            IList<MedicinskoOsoblje> Osoblje = dom_zdravlja.MedicinskoOsoblje;
            //metroGridData.Refresh();
            metroGridData.DataSource = new BindingList<MedicinskoOsoblje>(Osoblje);
            int to_show_column_number = 0;
            /*for (int i = to_show_column_number; i < metroGridData.ColumnCount; i++)
                metroGridData.Columns[i].Visible = false;*/
            for (int i = 0; i < metroGridData.ColumnCount - to_show_column_number; i++)
                metroGridData.Columns[i].Width = (this.Width - 10) / (metroGridData.ColumnCount - to_show_column_number);
        }

        #endregion

        #region Help functions

        private bool ValidateDoctorJMBG(DomZdravlja dz, string jmbg)
        {
            bool success = true;
            if (dz.Lekari.Count > 0)
            {
                foreach(IzabraniLekar il in dz.Lekari)
                {
                    if (il.Jmbg.Equals(jmbg))
                        return false;
                }
            }
            return success; // true is default
        }

        private bool ValidateMedicalStaffJMBG(DomZdravlja dz, string jmbg)
        {
            bool success = true;
            if (dz.MedicinskoOsoblje.Count > 0)
            {
                foreach (MedicinskoOsoblje mo in dz.MedicinskoOsoblje)
                {
                    if (mo.Jmbg.Equals(jmbg))
                        return false;
                }
            }
            return success; // true is default
        }
        private void EmptyControls()
        {
            metroTextBoxJMBG.Text = String.Empty; 
            metroTextBoxIme.Text = String.Empty;
            metroTextBoxPrezime.Text = String.Empty;
            metroTextBoxLozinka.Text = String.Empty;
            metroTextBoxSrednjeSlovo.Text = String.Empty;
        }

        private void TransferDataFromGridToControl(MetroGrid mg)
        {
            metroTextBoxJMBG.Text = mg.SelectedRows[0].Cells["JMBG"].Value.ToString();
            metroTextBoxIme.Text = mg.SelectedRows[0].Cells["IME"].Value.ToString();
            metroTextBoxPrezime.Text = mg.SelectedRows[0].Cells["PREZIME"].Value.ToString();
            metroTextBoxLozinka.Text = mg.SelectedRows[0].Cells["PASSWORD"].Value.ToString();
            metroTextBoxSrednjeSlovo.Text = mg.SelectedRows[0].Cells["SREDNJE_SLOVO"].Value.ToString();

            string str = mg.SelectedRows[0].Cells["DATUM_RODJENJA"].Value.ToString();
            DateTime temp_date = (DateTime)mg.SelectedRows[0].Cells["DATUM_RODJENJA"].Value;
           
            metroDateTimeDatumRodjenja.Value = temp_date;
        }

        private bool IsDoctorDataSelected(MetroGrid mg, out IzabraniLekar selected_doctor)
        {
            if (mg.SelectedRows.Count > 0)
            {
                selected_doctor = (IzabraniLekar) mg.SelectedRows[0].DataBoundItem;
                return true;
            }
            else
            {
                selected_doctor = null;
                return false;
            }
        }

        private bool IsMedicalStaffDataSelected(MetroGrid mg, out MedicinskoOsoblje selected_staff)
        {
            if (mg.SelectedRows.Count > 0)
            {
                selected_staff =
                selected_staff = (MedicinskoOsoblje)mg.SelectedRows[0].DataBoundItem;
                return true;
            }
            else
            {
                selected_staff = null;
                return false;
            }
        }
        
        #endregion

        #region Doctor manipulation

        private bool InsertNewDoctor()
        {
            bool success = true;

            IzabraniLekar novi_lekar = new IzabraniLekar()
            {
                Jmbg = metroTextBoxJMBG.Text,
                Ime = metroTextBoxIme.Text,
                Srednje_slovo = metroTextBoxSrednjeSlovo.Text,
                Prezime = metroTextBoxPrezime.Text,
                Datum_rodjenja = metroDateTimeDatumRodjenja.Value.Date,
                Password = metroTextBoxLozinka.Text
            };
            dom_zdravlja_local.Lekari.Add(novi_lekar); 
            novi_lekar.RadiUDomuZdravlja = dom_zdravlja_local;
            try
            {
                session.Save(novi_lekar);
                session.SaveOrUpdate(dom_zdravlja_local);
                session.Flush();
                //session.Refresh(dom_zdravlja_local); // added (may cause problems)
            }
            catch (Exception e)
            {
                MetroMessageBox.Show(this, "Greška u InsertNewDoctor funkciji " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = false;
            }

            
            //GetAllDoctors(dom_zdravlja_local); // Zove se u button_click handleru za dodavanje 
            return success;
        }

        private int DeleteSelectedDoctor(IzabraniLekar lekar_za_brisanje)
        {
            int success = -1;
            bool to_delete_permission = true;
            #region SQL nacin
            /*
            MySqlConnection conn = new MySqlConnection(Hippocrates.Data.ConnectionInfo.connection_string_nikola);
            try
            {
                conn.Open();
                string sql = "delete from IZABRANI_LEKAR where JMBG = '" + jmbg_lekara + "';";
                //MessageBox.Show(sql);

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = false;
            }
            conn.Close();
            */
            #endregion
            DialogResult dr;

            if (lekar_za_brisanje.Pacijenti.Count > 0)
            {
                MetroMessageBox.Show(this, "Izabrani lekar ima pacijente. Preporuka je da pacijentima promenite izabranog lekara pre brisanja", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dr = MetroMessageBox.Show(this, "Da li ste sigurni da želite da obrišete selektovanog lekara?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    to_delete_permission = false;
                    success = 2;
                }
            }
            //else
            //{
            if (to_delete_permission)
                try
                {
                    metroGridData.Rows.RemoveAt(metroGridData.SelectedRows[0].Index);
                    session.Delete(lekar_za_brisanje);
                    dom_zdravlja_local.Lekari.Remove(lekar_za_brisanje); //     
                    session.Flush();
                    //metroGridData.Refresh();
                    success = 1;
                }
                catch (Exception ex)
                {
                    success = -1;
                    MetroMessageBox.Show(this, "Greška u DeleteSelectedDoctor funkciji" + ex.Message);
                }
            //}
            return success;
        }

        private bool UpdateSelectedDoctor(IzabraniLekar lekar_za_azuriranje)
        {
            bool success = true;

            lekar_za_azuriranje.Jmbg = metroTextBoxJMBG.Text;
            lekar_za_azuriranje.Ime = metroTextBoxIme.Text;
            lekar_za_azuriranje.Srednje_slovo = metroTextBoxSrednjeSlovo.Text;
            lekar_za_azuriranje.Prezime = metroTextBoxPrezime.Text;
            lekar_za_azuriranje.Datum_rodjenja = metroDateTimeDatumRodjenja.Value.Date;
            lekar_za_azuriranje.Password = metroTextBoxLozinka.Text;
            try
            {
                session.Update(lekar_za_azuriranje); // maybe not needed (because of session.Update(dom_zdravlja_local);)
                session.Update(dom_zdravlja_local);
                session.Flush();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Greška u UpdateSelectedDoctor funkciji " + ex.Message);
                success = false;
            }
            return success;
        }

        #endregion

        #region Medical staff manipulation

        private bool InsertNewMedicalStaff()
        {
            bool success = true;
            //ISession s = DataLayer.GetSession();
            //DomZdravlja dz = s.Load<DomZdravlja>(facility_id);

            MedicinskoOsoblje mo = new MedicinskoOsoblje()
            {
                Jmbg = metroTextBoxJMBG.Text,
                Ime = metroTextBoxIme.Text,
                Prezime = metroTextBoxPrezime.Text,
                Srednje_slovo = metroTextBoxSrednjeSlovo.Text,
                Password = metroTextBoxLozinka.Text,
                Datum_rodjenja = metroDateTimeDatumRodjenja.Value.Date,
                RadiUDomuZdravlja = dom_zdravlja_local
            };

            dom_zdravlja_local.MedicinskoOsoblje.Add(mo);
            try
            {
                session.Save(dom_zdravlja_local);
                //s.Save(mo);
                session.Flush();
            }
            catch(Exception e)
            {
                MetroMessageBox.Show(this, "Greška u InsertNewMedicalStaff funkciji prilikom dodavanja novog osoblja " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = false;
            }
            session.Refresh(dom_zdravlja_local); // maybe not needed (may cause slow performance)
            metroGridData.DataSource = dom_zdravlja_local.MedicinskoOsoblje;
            metroGridData.Refresh();
            return success;

        }

        private bool DeleteSelectedMedicalStaff(MedicinskoOsoblje osoblje_za_brisanje)
        {
            bool success = false;
            bool to_delete_permission = true;
            DialogResult dr;

            dr = MetroMessageBox.Show(this, "Da li ste sigurni da želite da obrišete selektovano medicinsko osoblje?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                to_delete_permission = false;

            if (to_delete_permission)
                try
                {
                    metroGridData.Rows.RemoveAt(metroGridData.SelectedRows[0].Index);
                    session.Delete(osoblje_za_brisanje);
                    dom_zdravlja_local.MedicinskoOsoblje.Remove(osoblje_za_brisanje); //     
                    session.Flush();
                    success = true;
                }
                catch (Exception ex)
                {
                    success = false;
                    MetroMessageBox.Show(this, "Greška u DeleteSelectedMedicalStaff funkciji " + ex.Message);
                }
            return success;
        }

        private bool UpdateSelectedMedicalStaff(MedicinskoOsoblje osoblje_za_azuriranje)
        {
            bool success = true;
           
            osoblje_za_azuriranje.Ime = metroTextBoxIme.Text;
            osoblje_za_azuriranje.Srednje_slovo = metroTextBoxSrednjeSlovo.Text;
            osoblje_za_azuriranje.Prezime = metroTextBoxPrezime.Text;
            osoblje_za_azuriranje.Password = metroTextBoxLozinka.Text;
            osoblje_za_azuriranje.Datum_rodjenja = metroDateTimeDatumRodjenja.Value.Date;
            //osoblje_za_azuriranje.RadiUDomuZdravlja = dom_zdravlja_local; // not needed
            try
            {
                session.Update(dom_zdravlja_local);
                session.Flush();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Greška u UpdateSelectedMedicalStaff " + ex.Message);
                success = false;
            }
            return success;
        }

        #endregion

        #region Doctor Events
        private void metroButtonUnesiteLekara_Click(object sender, EventArgs e)
        {
            // Validation from controls
            metroButtonUnesiteLekara.Text = "Unošenje u toku ...";
            if (!ValidateDoctorJMBG(dom_zdravlja_local, metroTextBoxJMBG.Text))
            {
                MetroMessageBox.Show(this, "Nije moguće uneti dva lekara sa istim JMBG-om. " +
                    "Lekar sa JMBG-om " + metroTextBoxJMBG.Text + " već postoji", 
                    "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (InsertNewDoctor())
                MetroMessageBox.Show(this, "Uspešno dodat lekar", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MetroMessageBox.Show(this, "Error prilikom insert funkcije za dodavanje novog lekara", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //session.Refresh(dom_zdravlja_local);
            GetAllDoctors(dom_zdravlja_local);
            metroButtonUnesiteLekara.Text = "Unesite lekara";
        }

        private void metroButtonObrisiLekara_Click(object sender, EventArgs e)
        {
            IzabraniLekar lekar_za_brisanje;
            metroButtonObrisiLekara.Text = "Brisanje u toku ...";
            if (IsDoctorDataSelected(metroGridData, out lekar_za_brisanje))
            {
                DialogResult dr = MetroMessageBox.Show(this, " Da li ste sigurni da želite da obrišete lekara " + lekar_za_brisanje.Jmbg + " "
                    + lekar_za_brisanje.Ime + " " + lekar_za_brisanje.Prezime, "Question!", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
                if (dr == DialogResult.No)
                    return;
                int result = DeleteSelectedDoctor(lekar_za_brisanje);
                if (result == 1)
                {
                    
                    MetroMessageBox.Show(this, "Uspešno obrisan lekar " + lekar_za_brisanje.Ime + " " + lekar_za_brisanje.Prezime
                        , "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (result == -1)
                    MetroMessageBox.Show(this, "Greška prilikom brisanja lekara", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MetroMessageBox.Show(this, "Odaberite lekara iz tabele", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //session.Refresh(dom_zdravlja_local);
            metroButtonObrisiLekara.Text = "Obrišite lekara";
            //GetAllDoctors(dom_zdravlja_local);
        }

        private void metroButtonAzurirajLekara_Click(object sender, EventArgs e)
        {
            MetroGrid mg = metroGridData; // hard-coded
            metroButtonAzurirajLekara.Text = "Ažuriranje u toku ...";
            if (!ValidateDoctorJMBG(dom_zdravlja_local, metroTextBoxJMBG.Text))
            {
                MetroMessageBox.Show(this, "Nije moguće ažurirati lekara sa unetim JMBG-om. " +
                    "Lekar sa JMBG-om " + metroTextBoxJMBG.Text + " već postoji",
                    "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //string jmbg = string.Empty;
            IzabraniLekar lekar_za_azuriranje;
            if (IsDoctorDataSelected(mg, out lekar_za_azuriranje))
            {
                if (UpdateSelectedDoctor(lekar_za_azuriranje))
                    MetroMessageBox.Show(this, "Uspešno ažuriran lekar " + lekar_za_azuriranje.Ime + " " +
                        lekar_za_azuriranje.Prezime, "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MetroMessageBox.Show(this, "Error prilikom update funkcije za ažuriranje lekara", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //session.Refresh(dom_zdravlja_local);
                GetAllDoctors(dom_zdravlja_local);
                metroButtonAzurirajLekara.Text = "Ažurirajte lekara";
            }
        }

        private void metroGridLekari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TransferDataFromGridToControl(metroGridData);
        }

        private void metroButtonSmenaLekara_Click(object sender, EventArgs e)
        {
            IzabraniLekar selektovani_lekar;
            if (IsDoctorDataSelected(metroGridData, out selektovani_lekar) == false) // nothing selected
                MetroMessageBox.Show(this, "Molimo selektujte lekara za izbor smene", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                SmenaLekara sm = new SmenaLekara(session, selektovani_lekar);
                sm.StartPosition = FormStartPosition.CenterScreen;
                sm.ShowDialog();
            }
        }
        #endregion

        #region Medical Staff Events

        private void metroButtonUnesiOsobu_Click(object sender, EventArgs e)
        {
            // Controls to data
            // Update
            // Refresh view
            metroButtonUnesiOsobu.Text = "Unošenje u toku ...";
            if (!ValidateMedicalStaffJMBG(dom_zdravlja_local, metroTextBoxJMBG.Text))
            {
                MetroMessageBox.Show(this, "Nije moguće uneti dva medicinska osoblja sa istim JMBG-om. " +
                    "Osoba sa JMBG-om " + metroTextBoxJMBG.Text + " već postoji",
                    "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (InsertNewMedicalStaff())
                MetroMessageBox.Show(this, "Uspešno dodato novo medicinsko osoblje", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MetroMessageBox.Show(this, "Error prilikom save funkcije za dodavanje novog medicinskog osoblja", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //session.Refresh(dom_zdravlja_local);
            GetMedicalStaffData(dom_zdravlja_local);
            metroButtonUnesiOsobu.Text = "Unesite osobu";
        }

        private void metroButtonObrisiOsobu_Click(object sender, EventArgs e)
        {
            metroButtonObrisiOsobu.Text = "Brisanje u toku ...";
            MetroGrid mg = metroGridData; // hard-coded
            MedicinskoOsoblje selektovano_osoblje;
            if (IsMedicalStaffDataSelected(mg, out selektovano_osoblje))
            {
                //MessageBox.Show("Selected jmbg " + jmbg);
                if (DeleteSelectedMedicalStaff(selektovano_osoblje))
                    MetroMessageBox.Show(this, "Uspešno obrisano medicinsko osoblje " + selektovano_osoblje.Ime + " " +selektovano_osoblje.Prezime
                        , "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MetroMessageBox.Show(this, "Error prilikom delete funkcije za brisanje medicinskog osoblja", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

               // session.Refresh(dom_zdravlja_local);
                GetMedicalStaffData(dom_zdravlja_local);
                metroButtonObrisiOsobu.Text = "Obrišite osobu";

            }
        }

        private void metroButtonAzurirajOsobu_Click(object sender, EventArgs e)
        {
            metroButtonAzurirajOsobu.Text = "Ažuriranje u toku ... ";
            if (!ValidateMedicalStaffJMBG(dom_zdravlja_local, metroTextBoxJMBG.Text))
            {
                MetroMessageBox.Show(this, "Nije moguće ažurirati medicinsko osoblje sa unetim JMBG-om. " +
                    "Osoba sa JMBG-om " + metroTextBoxJMBG.Text + " već postoji",
                    "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MetroGrid mg = metroGridData; // hard-coded
            MedicinskoOsoblje selektovano_osoblje;
            if (IsMedicalStaffDataSelected(mg, out selektovano_osoblje))
            {
                if (UpdateSelectedMedicalStaff(selektovano_osoblje))
                    MetroMessageBox.Show(this, "Uspešno ažurirano medicinsko osoblje " + selektovano_osoblje.Ime + " " + selektovano_osoblje.Prezime
                        , "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MetroMessageBox.Show(this, "Error prilikom update funkcije za ažuriranje medicinskog osoblja", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //session.Refresh(dom_zdravlja_local);
                GetMedicalStaffData(dom_zdravlja_local);
                metroButtonAzurirajOsobu.Text = "Ažurirajte osobu";
            }

        }

        #endregion

        #region Other Events
        private void metroTabControlGlobal_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetroTabControl mtc = sender as MetroTabControl;
            switch(mtc.SelectedIndex)
            {
                case 0: // Lekari
                    {
                        //metroPanel1.Enabled = true;
                        metroButtonSmenaLekara.Enabled = true; GetAllDoctors(dom_zdravlja_local);
                        EmptyControls();
                        if (metroGridData.Rows.Count != 0)
                        {
                            metroGridData.Rows[0].Selected = true;
                            TransferDataFromGridToControl(metroGridData);
                        }
                        break;
                    }
                case 1: // Medicinsko osoblje
                    {
                        //metroPanel1.Enabled = true;
                        metroButtonSmenaLekara.Enabled = false; GetMedicalStaffData(dom_zdravlja_local);
                        EmptyControls();
                        if (metroGridData.Rows.Count != 0)
                        {
                            metroGridData.Rows[0].Selected = true;
                            TransferDataFromGridToControl(metroGridData);
                        }
                        break;
                    }
                case 2: // Zahtevi pacijenata
                    {
                        EmptyControls();
                        //metroPanel1.Enabled = false;
                        break;
                    }
            }
        }

        private void MetroRadioButtonSmenaPrepodne_MouseHover(object sender, EventArgs e)
        {
            //notifyIcon1.ShowBalloonTip(2000, "Info", "Za dodavanje smene lekaru pogledajte 'Ažuriranje podataka o lekarima' deo", ToolTipIcon.Info);
            //var icon = new NotifyIcon();
            //icon.ShowBalloonTip(2000, "Info", "Za dodavanje smene lekaru pogledajte 'Ažuriranje podataka o lekarima' deo", ToolTipIcon.Info);
        }
        
        private void FormDirektor_FormClosing(object sender, FormClosingEventArgs e)
        {
            session.Close();
        }

        private void metroButtonZahteviPacijenata_Click(object sender, EventArgs e)
        {
            FormZahteviPacijenata fzp = new FormZahteviPacijenata(session, dom_zdravlja_local);
            fzp.StartPosition = FormStartPosition.CenterScreen;
            fzp.ShowDialog();
        }

        private void metroTextBoxJMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (Char.IsControl(e.KeyChar))))
                e.Handled = true;
        }
        #endregion

        #region MVC
        public void setController(IController controller)
        {
            throw new NotImplementedException();
        }


        #endregion

        
    }
}
