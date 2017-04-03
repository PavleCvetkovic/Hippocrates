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
using MySql.Data.MySqlClient;
using MetroFramework.Forms;
using MetroFramework;
using MetroFramework.Controls;

namespace HippocratesDoctor
{
    public partial class FormDirektor : MetroForm, IView
    {
        private IController _controller;
        //private Hippocrates.Data.IzabraniLekar active_doctor;
        private string facility_id, facility_name, jmbg_admin;

        public FormDirektor(string dom_zdravlja_admin_jmbg)
        {
            InitializeComponent();
            //metroTabControlGlobal.SelectedIndex = 0;
            jmbg_admin = dom_zdravlja_admin_jmbg;
            lblImeDomaZ.Text = GetMedicalFacilityInfo(jmbg_admin);
            GetAllDoctors(facility_id); // GetAllDoctors(facility_id) se zove nakon GetMedicalFacilityInfo(jmbg_admin) jer se tu inicijalizuje 'facility_id'
            //metroRadioButtonSmenaPrepodne.MouseHover += MetroRadioButtonSmenaPrepodne_MouseHover;
            //metroRadioButtonSmenaPoslepodne.MouseHover += MetroRadioButtonSmenaPrepodne_MouseHover;
        }


        private string GetMedicalFacilityInfo(string jmbg_admina)
        {
            string to_return = string.Empty;
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
            return facility_name + " " + this.facility_id;
        }

        private void GetAllDoctors(string dom_zdravlja_id)
        {
            MySqlDataAdapter data_adapter;
            DataSet data_set;
            MySqlConnection conn = new MySqlConnection(Hippocrates.Data.ConnectionInfo.connection_string_nikola);
            try
            {
                string sql = "select * from IZABRANI_LEKAR where MBRZU = '" + dom_zdravlja_id + "'";
                data_adapter = new MySqlDataAdapter(sql, conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(data_adapter);

                data_set = new DataSet();
                data_adapter.Fill(data_set, "Lekari");
                metroGridData.DataSource = data_set;
                metroGridData.DataMember = "Lekari";
                for (int i = 0; i < metroGridData.ColumnCount; i++)
                    metroGridData.Columns[i].Width = metroGridData.Width / metroGridData.ColumnCount;

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error during connection " + ex.Message.ToString());
            }
        }

        private int GetDoctorShift(string doctor_id) // Vraca smenu za trenutno sistemsko vreme (u kojoj smeni lekar sada radi)
        {
            int to_return = 0;
            //string to_return = string.Empty;
            string date = System.DateTime.Now.Year + "-" + System.DateTime.Now.Month + "-" + System.DateTime.Now.Day;
            //MessageBox.Show(date);
            MySqlConnection conn = new MySqlConnection(Hippocrates.Data.ConnectionInfo.connection_string_nikola);
            try
            {
                conn.Open();
                string sql_command = "select SMENA from SMENA where MATBRL = '" + doctor_id + "' and '"
                    + date + "' between DATUM_OD and DATUM_DO;";

                MySqlCommand cmd = new MySqlCommand(sql_command, conn);
                to_return = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Greška prilikom čitanja iz baze " + ex.Message + " (Moguće je da lekaru (za koga se traži smena) nije dodeljena smena u bazi)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return to_return;
        }

        private void GetMedicalStaffData(string dom_zdravlja_id)
        {
            MySqlDataAdapter data_adapter;
            DataSet data_set;
            MySqlConnection conn = new MySqlConnection(Hippocrates.Data.ConnectionInfo.connection_string_nikola);
            try
            {
                string sql = "select * from MEDICINSKO_OSOBLJE where MBRZU = '" + dom_zdravlja_id + "'";
                data_adapter = new MySqlDataAdapter(sql, conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(data_adapter);

                data_set = new DataSet();
                data_adapter.Fill(data_set, "Osoblje");
                metroGridData.DataSource = data_set;
                metroGridData.DataMember = "Osoblje";
                for (int i = 0; i < metroGridData.ColumnCount; i++)
                    metroGridData.Columns[i].Width = metroGridData.Width / metroGridData.ColumnCount;

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error during connection " + ex.Message.ToString());
            }

        }

        private void TransferDataFromGridToControl(MetroGrid mg)
        {
            metroTextBoxJMBG.Text = mg.SelectedRows[0].Cells["JMBG"].Value.ToString();
            metroTextBoxIme.Text = mg.SelectedRows[0].Cells["IME"].Value.ToString();
            metroTextBoxPrezime.Text = mg.SelectedRows[0].Cells["PREZIME"].Value.ToString();
            metroTextBoxLozinka.Text = mg.SelectedRows[0].Cells["PASSWORD"].Value.ToString();
            metroTextBoxSrednjeSlovo.Text = mg.SelectedRows[0].Cells["SREDNJE_SLOVO"].Value.ToString();

            //if (metroButtonSmenaLekara.Enabled == true) // medicinsko_osoblje nema smenu (ne pamti se u bazi)
            //{
            //    int smena = GetDoctorShift(mg.SelectedRows[0].Cells["JMBG"].Value.ToString());
            //    if (smena == 1)
            //        metroRadioButtonSmenaPrepodne.Checked = true;
            //    else
            //        metroRadioButtonSmenaPoslepodne.Checked = true;
            //}
            string str = mg.SelectedRows[0].Cells["DATUM_ROĐENJA"].Value.ToString();
            // dd.MM.yyyy.
            // 0123456789
            //MessageBox.Show(Int32.Parse(str.Substring(0, 4)).ToString() + " " + Int32.Parse(str.Substring(5, 2)).ToString() + " " + Int32.Parse(str.Substring(8, 2)).ToString());

            //System.DateTime temp_date = new DateTime(Int32.Parse(str.Substring(0, 4)), Int32.Parse(str.Substring(5, 2)), Int32.Parse(str.Substring(8, 2)));
            //System.DateTime temp_date = new DateTime(2000, 10, 3);
            //temp_date.Year = Int32.Parse(str.Substring(0, 4));
            //temp_date.Month = 
            //MessageBox.Show(temp_date.ToString());


            //MessageBox.Show(ParseYear(str).ToString() + ParseMonth(str).ToString() + ParseDay(str).ToString());
            System.DateTime temp_date = new DateTime(ParseYear(str), ParseMonth(str), ParseDay(str));
            metroDateTimeDatumRodjenja.Value = temp_date;
            //metroDateTimeDatumRodjenja.Value.Year = 2000;

            /////////////
            //Ovi komentari ostaju ovde kao spomen ploca na prethodna 2 sata utrosena da se konvertuje format 
            //da se uklopi sa DateTimePicker-om 
            ////////////
        }
        
        private int ParseYear(string date)
        {
            string year = string.Empty;
            int occurence = 0, i = 0;
            while (occurence != 2)
            {
                if (date[i] == '.')
                    occurence++;
                i++;
            }
            year += date[i];
            year += date[i + 1];
            year += date[i + 2];
            year += date[i + 3];
            return Int32.Parse(year);
        }

        private int ParseMonth(string date)
        {
            // dd.MM.yyyy or dd.M.yyyy or d.MM.yyyy or d.M.yyyy
            // 0123456789
            string month = string.Empty;
            int i = 0;
            while (date[i] != '.')
                i++;
            month += date[i + 1];

            if (date[i + 2] != '.')
                month += date[i + 2];

            return Int32.Parse(month);
        }

        private int ParseDay(string date)
        {
            // dd.MM.yyyy or d.MM.yyyy
            // 0123456789
            string day = string.Empty;
            day += date[0];
            if (date[1] != '.')
                day += date[1];

            return Int32.Parse(day);
        }

        private bool IsDataSelected(MetroGrid mg, out string selected_jmbg)
        {
            if (mg.SelectedRows.Count > 0)
            {
                selected_jmbg = mg.SelectedRows[0].Cells["JMBG"].Value.ToString();
                return true;
            }
            else
            {
                selected_jmbg = "Nothing selected";
                return false;
            }
        }

        private bool InsertNewDoctor()
        {
            bool success = true;
            MySqlConnection conn = new MySqlConnection(Hippocrates.Data.ConnectionInfo.connection_string_nikola);
            try
            {
                conn.Open();
                string temp_date = metroDateTimeDatumRodjenja.Value.Date.ToString();
                string datum_rodjenja = ParseYear(temp_date).ToString() + "-" + ParseMonth(temp_date).ToString() + "-" + ParseDay(temp_date).ToString();
                string sql = "insert into IZABRANI_LEKAR values ('" + 
                    metroTextBoxJMBG.Text + "', '" + 
                    metroTextBoxIme.Text + "', '" + 
                    metroTextBoxSrednjeSlovo.Text + "', '" +
                    metroTextBoxPrezime.Text + "', '" +
                    datum_rodjenja + "', '" + 
                    facility_id + "', '" + 
                    metroTextBoxLozinka.Text + "');";

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

            return success;
        }

        private bool DeleteSelectedDoctor(string jmbg_lekara)
        {
            bool success = true;
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
            return success;

        }

        private bool UpdateSelectedDoctor(string jmbg_lekara)
        {
            bool success = true;
            MySqlConnection conn = new MySqlConnection(Hippocrates.Data.ConnectionInfo.connection_string_nikola);
            try
            {
                conn.Open();
                string temp_date = metroDateTimeDatumRodjenja.Value.Date.ToString();
                string datum_rodjenja = ParseYear(temp_date).ToString() + "-" + ParseMonth(temp_date).ToString() + "-" + ParseDay(temp_date).ToString();
                string sql = "update IZABRANI_LEKAR set " +
                    " JMBG = '" + metroTextBoxJMBG.Text + "', IME = '" + metroTextBoxIme.Text + "'," +
                    " SREDNJE_SLOVO = '" + metroTextBoxSrednjeSlovo.Text + "', PREZIME = ' " + metroTextBoxPrezime.Text +
                    " ', DATUM_ROĐENJA = '" + datum_rodjenja + "', MBRZU = '" + facility_id + "', PASSWORD = '" + metroTextBoxLozinka.Text + "'" +
                    " where JMBG = '" + jmbg_lekara + "';";

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
            return success;

        }

        private void metroGridLekari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TransferDataFromGridToControl(metroGridData);
        }

        private void metroTabControlGlobal_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetroTabControl mtc = sender as MetroTabControl;
            switch(mtc.SelectedIndex)
            {
                case 0: { metroButtonSmenaLekara.Enabled = true; GetAllDoctors(facility_id);  break; }
                case 1: { metroButtonSmenaLekara.Enabled = false; GetMedicalStaffData(facility_id); break; }
            }
        }

        private void metroButtonUnesiteLekara_Click(object sender, EventArgs e)
        {
            // Validation from controls
            if (InsertNewDoctor())
                MetroMessageBox.Show(this, "Uspešno dodat lekar", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MetroMessageBox.Show(this, "Error prilikom insert funkcije za dodavanje novog lekara", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            GetAllDoctors(facility_id);
        }

        private void metroButtonSmenaLekara_Click(object sender, EventArgs e)
        {
            string jmbg_lekara = string.Empty;
            if (IsDataSelected(metroGridData, out jmbg_lekara) == false) // nothing selected
                MetroMessageBox.Show(this, "Molimo selektujte lekara za izbor smene", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                SmenaLekara sm = new SmenaLekara(jmbg_lekara);
                sm.StartPosition = FormStartPosition.CenterScreen;
                sm.ShowDialog();
            }
        }

        private void metroButtonObrisiLekara_Click(object sender, EventArgs e)
        {
            MetroGrid mg = metroGridData; // hard-coded
            string jmbg = string.Empty;
            if (IsDataSelected(mg, out jmbg))
            {
                if (DeleteSelectedDoctor(jmbg))
                    MetroMessageBox.Show(this, "Uspešno obrisan lekar", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MetroMessageBox.Show(this, "Error prilikom delete funkcije za brisanje lekara", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GetAllDoctors(facility_id);
            }

        }

        private void MetroRadioButtonSmenaPrepodne_MouseHover(object sender, EventArgs e)
        {
            //notifyIcon1.ShowBalloonTip(2000, "Info", "Za dodavanje smene lekaru pogledajte 'Ažuriranje podataka o lekarima' deo", ToolTipIcon.Info);
            //var icon = new NotifyIcon();
            //icon.ShowBalloonTip(2000, "Info", "Za dodavanje smene lekaru pogledajte 'Ažuriranje podataka o lekarima' deo", ToolTipIcon.Info);
        }

        private void metroButtonAzurirajLekara_Click(object sender, EventArgs e)
        {
            MetroGrid mg = metroGridData; // hard-coded
            string jmbg = string.Empty;
            if (IsDataSelected(mg, out jmbg))
            {
                if (UpdateSelectedDoctor(jmbg))
                    MetroMessageBox.Show(this, "Uspešno ažuriran lekar", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MetroMessageBox.Show(this, "Error prilikom update funkcije za ažuriranje lekara", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GetAllDoctors(facility_id);
            }
        }

        private void metroButtonObrisiOsobu_Click(object sender, EventArgs e)
        {
            
        }
        #region MVC
        public void setController(IController controller)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
