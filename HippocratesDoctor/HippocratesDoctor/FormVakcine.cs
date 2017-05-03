using Hippocrates.Data;
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
    public partial class FormVakcine : MetroFramework.Forms.MetroForm
    {
        //private string jmbg_pacijenta;
        private Pacijent pacijent;
        private IList<Vakcina> sve_vakcine;
        private ISession session_local;

        public FormVakcine(ISession s, Pacijent p)
        {
            InitializeComponent();
            session_local = s;
            pacijent = p;
            //this.jmbg_pacijenta = jmbg_pacijenta;
            this.Text = "Dodavanje vakcine";
        }

        private void FromDataToControl(int row_index)
        {
            // Sve vakcine u kontrolu za unos
            metroTextBoxImeVakcine.Text = metroGridVakcine["Ime", row_index].Value.ToString();
            metroTextBoxOpisVakcine.Text = metroGridVakcine["Opis", row_index].Value.ToString();
        }

        private void metroButtonDodajVakcinu_Click(object sender, EventArgs e)
        {
            int sifra_row_index = metroGridVakcine.CurrentCell.RowIndex;
            
            string temp_sifra = metroGridVakcine["Sifra", sifra_row_index].Value.ToString();

            Vakcina vakcina = new Vakcina()
            {
                Ime = metroTextBoxImeVakcine.Text,
                Opis = metroTextBoxOpisVakcine.Text,
                Sifra = temp_sifra,
            };

            PrimioVakcinu pv = new PrimioVakcinu()
            {
                Id = new PrimioVakcinuId()
                {
                    PrimioPacijent = pacijent,
                    PrimioVakcina = vakcina,
                },
                Datum = metroDateTimeDatumVakcine.Value.Date,
            };

            //vakcine.Add(vakcina); // For not in database Vaccine
            pacijent.PrimioVakcinuVakcine.Add(pv);
            vakcina.PrimioVakcinuPacijenti.Add(pv);
            try
            {
                session_local.SaveOrUpdate(pacijent);
                session_local.Flush();
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, "Greška u funkciji za dodavanje vakcine " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MetroMessageBox.Show(this, "Uspešno dodata vakcina pacijentu " + pacijent.Ime + " " + pacijent.Prezime, "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormVakcine_Load(object sender, EventArgs e)
        {
            sve_vakcine = session_local.QueryOver<Vakcina>().List(); // sve vakcine

            metroGridVakcine.DataSource = sve_vakcine;

            metroGridVakcine.Columns[3].Visible = false;
            for (int i = 0; i < metroGridVakcine.ColumnCount; i++)
                metroGridVakcine.Columns[i].Width = metroGridVakcine.Width / metroGridVakcine.ColumnCount;

            FromDataToControl(0); //Input to metroGrid must come before this function // not checked for (if Vakcine table in Database is empty)
        }

        private void metroGridVakcine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MetroFramework.Controls.MetroGrid mg = sender as MetroFramework.Controls.MetroGrid;
            int row_index = mg.CurrentCell.RowIndex;
            FromDataToControl(row_index);
        }

        private void FormVakcine_FormClosing(object sender, FormClosingEventArgs e)
        {
            session_local.Flush();
        }
    }
}
