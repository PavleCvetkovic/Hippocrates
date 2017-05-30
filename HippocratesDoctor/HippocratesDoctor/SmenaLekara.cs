using Hippocrates.Data.Entiteti;
using MetroFramework;
using MetroFramework.Controls;
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

            //metroButtonAzurirajSmenu.Enabled = false;
            metroLabelInfoLekara.Text = selektovani_lekar.Ime + " " + selektovani_lekar.Prezime;
            GetDoctorShift();
        }

        private void GetDoctorShift() 
        {
            metroGridSmenaLekara.DataSource = null;
            //session_local.Refresh(lekar_local);
            metroGridSmenaLekara.DataSource = new
                BindingList<Smena>(lekar_local.Smene.ToList<Smena>());

            for (int i = 0; i < metroGridSmenaLekara.ColumnCount; i++)
                metroGridSmenaLekara.Columns[i].Width = (this.Width) / (metroGridSmenaLekara.ColumnCount);
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

        private bool IsDateRegular()
        {
            bool success = true;
            if (metroDateTimeDatumOd.Value.Date > metroDateTimeDatumDo.Value.Date)
            {
                MetroMessageBox.Show(this, "Početak datuma smene ne može biti veći od kraja datuma smene", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                metroDateTimeDatumDo.Value = metroDateTimeDatumOd.Value.AddDays(1);
                success = false;
            }
            return success;

        }

        private bool IsShiftSelected(MetroGrid mg)
        {
            if (mg.SelectedRows.Count > 0)
                return true;
            else
            {
                MetroMessageBox.Show(this, "Nije selektovana nijedna smena", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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
            metroGridSmenaLekara.Rows.RemoveAt(metroGridSmenaLekara.SelectedRows[0].Index);
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
            Smena s = (Smena)metroGridSmenaLekara.SelectedRows[0].DataBoundItem;
            Smena found = null;
            foreach (Smena ss in lekar.Smene)
                if (ss.Equals(s))
                {
                    found = ss;
                    break;
                }
            found.Datum_Do = metroDateTimeDatumDo.Value.Date;
            found.Id.Datum_Od = metroDateTimeDatumOd.Value.Date;
            found.SmenaLekara = metroRadioButtonSmenaPrepodne.Checked ? 1 : 2;
            //s.Datum_Do = metroDateTimeDatumDo.Value.Date;
            //s.Id.Datum_Od = metroDateTimeDatumOd.Value.Date;
            //s.SmenaLekara = metroRadioButtonSmenaPrepodne.Checked ? 1 : 2;
            try
            {
                session_local.Update(lekar);
                session_local.Flush();
                session_local.Refresh(lekar_local); // Lokalna kopija se osvezava (za svaki slucaj) jer nesto nece da radi kako treba
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Error u funkciji za ažuriranje smene " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = false;
            }
            return success;
        }

        private void metroButtonObrisiSelektovanuSmenu_Click(object sender, EventArgs e)
        {
            if (!IsShiftSelected(metroGridSmenaLekara))
                return ;
            if (DeleteDoctorShift(lekar_local))
                MetroMessageBox.Show(this, "Uspešno obrisana smena", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MetroMessageBox.Show(this, "Error prilikom delete funkcije za smenu", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //GetDoctorShift();
            //if (metroGridSmenaLekara.Rows.Count > 0)
            //    metroGridSmenaLekara.Rows[0].Selected = true;
            //metroGridSmenaLekara.Refresh();
        }

        private void metroButtonDodajSmenu_Click(object sender, EventArgs e)
        {
            if (/*IsDateRegular() &&*/ AddDoctorShift(lekar_local))
                MetroMessageBox.Show(this, "Uspešno dodata smena", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MetroMessageBox.Show(this, "Error prilikom insert funkcije za smenu", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            GetDoctorShift();
            //if (metroGridSmenaLekara.Rows.Count > 0)
            //    metroGridSmenaLekara.Rows[0].Selected = true;
            //metroGridSmenaLekara.Refresh();
        }

        private void metroButtonAzurirajSmenu_Click(object sender, EventArgs e)
        {
            if (!IsShiftSelected(metroGridSmenaLekara)/* || !IsDateRegular()*/)
                return;
            if (UpdateDoctorShift(lekar_local))
                MetroMessageBox.Show(this, "Uspešno ažurirana smena", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MetroMessageBox.Show(this, "Error prilikom update funkcije za smenu", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            GetDoctorShift();
            if (metroGridSmenaLekara.Rows.Count > 0)
                metroGridSmenaLekara.Rows[0].Selected = true;
            //metroGridSmenaLekara.Refresh();
        }

        private void metroGridSmenaLekara_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGridSmenaLekara.Rows.Count > 0) // Nula elemenata
                FromGridToControl();
        }

        private void metroDateTimeDatumOd_ValueChanged(object sender, EventArgs e)
        {
            IsDateRegular();
            //if (metroDateTimeDatumOd.Value.Date > metroDateTimeDatumDo.Value.Date)
            //{
            //    MetroMessageBox.Show(this, "Početak datuma smene ne može biti veći od kraja datuma smene", "Error!",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    metroDateTimeDatumDo.Value = metroDateTimeDatumOd.Value.AddDays(1);
            //}
        }
    }
}
