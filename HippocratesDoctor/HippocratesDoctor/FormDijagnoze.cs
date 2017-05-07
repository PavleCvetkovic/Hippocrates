using Hippocrates.Data.Entiteti;
using MetroFramework;
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
    public partial class FormDijagnoze : MetroFramework.Forms.MetroForm
    {
        private Pacijent pacijent_local;
        private IList<Dijagnoza> sve_dijagnoze;
        private ISession session_local;

        public FormDijagnoze(ISession s, Pacijent p)
        {
            InitializeComponent();
            session_local = s;
            pacijent_local = p;
        }

        private void FromDataToControl(int row_index)
        {
            // Sve vakcine u kontrolu za unos
            metroTextBoxImeDijagnoze.Text = metroGridDijagnoze["Ime", row_index].Value.ToString();
            metroTextBoxSifraDijagnoze.Text = metroGridDijagnoze["Sifra", row_index].Value.ToString();
        }

        private void FormDijagnoze_Load(object sender, EventArgs e)
        {
            this.Text = "Dodavanje dijagnoze";
            sve_dijagnoze = session_local.QueryOver<Dijagnoza>().List(); // sve dijagnoze

            metroGridDijagnoze.DataSource = sve_dijagnoze;

            metroGridDijagnoze.Columns[2].Visible = false;
            metroGridDijagnoze.Columns[3].Visible = false;
            metroGridDijagnoze.Columns[4].Visible = false;
            for (int i = 0; i < metroGridDijagnoze.ColumnCount; i++)
                metroGridDijagnoze.Columns[i].Width = metroGridDijagnoze.Width / (metroGridDijagnoze.ColumnCount - 3);

            FromDataToControl(0); //Input to metroGrid must come before this function // not checked for (if Vakcine table in Database is empty)
        }

        private void metroButtonDodajDijagnozu_Click(object sender, EventArgs e)
        {
            Dijagnostifikovano d = new Dijagnostifikovano()
            {
                Datum = metroDateTimeDatumDijagnoze.Value.Date,
                Id = new DijagnostifikovanoId()
                {
                    DijagnozaPacijent = pacijent_local,
                    DijagnozaLekar = pacijent_local.Lekar,
                    DijagnozaDijagnoza = new Dijagnoza()
                    {
                        Sifra = metroTextBoxSifraDijagnoze.Text,
                        Ime = metroTextBoxImeDijagnoze.Text
                    }
                }
            };
            pacijent_local.DijagnostifikovanoDijagnoze.Add(d);
            try
            {
                session_local.Update(pacijent_local);
                session_local.Flush();
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, "Greška prilikom dodavanja dijagnoze " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MetroMessageBox.Show(this, "Uspešno dodana dijagnoza pacijentu " + pacijent_local.Ime + " " + pacijent_local.Prezime, "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroGridDijagnoze_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MetroFramework.Controls.MetroGrid mg = sender as MetroFramework.Controls.MetroGrid;
            int row_index = mg.CurrentCell.RowIndex;
            FromDataToControl(row_index);
        }

        private void FormDijagnoze_FormClosing(object sender, FormClosingEventArgs e)
        {
            session_local.Flush();
        }
    }
}
