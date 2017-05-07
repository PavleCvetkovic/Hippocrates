using Hippocrates.Data.Entiteti;
using MetroFramework;
using MySql.Data.MySqlClient;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HippocratesDoctor
{
    public partial class SmenaLekara : MetroFramework.Forms.MetroForm
    {
        private ISession session_local;
        private IzabraniLekar lekar_local;

        public SmenaLekara(ISession s, IzabraniLekar selektovani_lekar)
        {
            InitializeComponent();
            this.Text = "Smena lekara " + selektovani_lekar.Ime + " " + selektovani_lekar.Prezime;
            lekar_local = selektovani_lekar;
            session_local = s;

            //this.jmbg_lekara = selektovani_lekar.Jmbg;
            metroLabelInfoLekara.Text = selektovani_lekar.Ime + " " + selektovani_lekar.Prezime;
            GetDoctorShift();
        }

        private void GetDoctorShift() // Vraca smenu za trenutno sistemsko vreme (u kojoj smeni lekar sada radi)
        {
            metroGridSmenaLekara.DataSource = null;
            metroGridSmenaLekara.DataSource = lekar_local.Smene;
            for (int i = 0; i < metroGridSmenaLekara.ColumnCount; i++)
                metroGridSmenaLekara.Columns[i].Width = metroGridSmenaLekara.Width / (metroGridSmenaLekara.ColumnCount);
        }

        private void FromGridToControl()
        {
            Smena s = (Smena)metroGridSmenaLekara.SelectedRows[0].DataBoundItem;
            metroDateTimeDatumOd.Value = s.Id.Datum_Od;
            metroDateTimeDatumDo.Value = s.Datum_Do;
            if (s.SmenaLekara == 1)
                metroRadioButtonSmenaPrepodne.Checked = true;
            else
                metroRadioButtonSmenaPoslepodne.Checked = true;
        }
      
        private bool AddDoctorShift(IzabraniLekar lekar)
        {
            bool success = true;
            Smena s = new Smena()
            {
                SmenaLekara = metroRadioButtonSmenaPrepodne.Checked ? 1 : 2,
                Datum_Do = metroDateTimeDatumDo.Value.Date,
                Id = new SmenaId()
                {
                    Datum_Od = metroDateTimeDatumOd.Value.Date,
                    Lekar = lekar
                }
            };
            lekar.Smene.Add(s);
            try
            {
                session_local.Save(lekar);
                session_local.Flush();
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, "Error u funkciji za dodavanje smene " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = false;
            }
            return success;
        }

        private bool DeleteDoctorShift(IzabraniLekar lekar)
        {
            bool success = true;
            Smena s = (Smena)metroGridSmenaLekara.SelectedRows[0].DataBoundItem;
            lekar.Smene.Remove(s);
            try
            {
                session_local.Delete(s);
                session_local.Save(lekar);
                session_local.Flush();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error u funkciji za brisanje smene " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = false;
            }
            return success;
        }

        private bool UpdateDoctorShift(IzabraniLekar lekar)
        {
            bool success = true;
            DeleteDoctorShift(lekar);
            AddDoctorShift(lekar);
            return success;
        }

        private string ParseYear(string date)
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
            return year;
        }

        private string ParseMonth(string date)
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

            return month;
        }

        private string ParseDay(string date)
        {
            // dd.MM.yyyy or d.MM.yyyy
            // 0123456789
            string day = string.Empty;
            day += date[0];
            if (date[1] != '.')
                day += date[1];

            return day;
        }

        private void metroButtonObrisiSelektovanuSmenu_Click(object sender, EventArgs e)
        {
            if (DeleteDoctorShift(lekar_local))
                MetroMessageBox.Show(this, "Uspešno obrisana smena", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MetroMessageBox.Show(this, "Error prilikom delete funkcije za smenu", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            GetDoctorShift();
        }

        private void metroButtonDodajSmenu_Click(object sender, EventArgs e)
        {
            if (AddDoctorShift(lekar_local))
                MetroMessageBox.Show(this, "Uspešno dodata smena", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MetroMessageBox.Show(this, "Error prilikom insert funkcije za smenu", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            GetDoctorShift();
        }

        private void metroButtonAzurirajSmenu_Click(object sender, EventArgs e)
        {
            if (UpdateDoctorShift(lekar_local))
                MetroMessageBox.Show(this, "Uspešno ažurirana smena", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MetroMessageBox.Show(this, "Error prilikom update funkcije za smenu", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            GetDoctorShift();
        }

        private void metroGridSmenaLekara_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FromGridToControl();
        }
    }
}
