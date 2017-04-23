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
        private string jmbg_pacijenta;
        private Pacijent pacijent;
        private IList<Vakcina> sve_vakcine;
        private ISession s;

        public FormVakcine(string jmbg_pacijenta)
        {
            InitializeComponent();
            this.jmbg_pacijenta = jmbg_pacijenta;
            this.Text = "Dodavanje vakcine";
        }

        private void FromDataToControl(int row_index)
        {
            // Sve vakcine u kontrolu za unos
            metroTextBoxImeVakcine.Text = metroGridVakcine["Ime", row_index].Value.ToString();
            metroTextBoxOpisVakcine.Text = metroGridVakcine["Opis", row_index].Value.ToString();
        }

        private void InsertNewVaccine()
        {
            // session is open
            //Vakcina v;

        }

        private void metroButtonDodajVakcinu_Click(object sender, EventArgs e)
        {
            int sifra_row_index = metroGridVakcine.CurrentCell.RowIndex;
            //string sifra_string = sifra.ToString();

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

            s.SaveOrUpdate(pacijent);
            s.Flush();
            s.Close();
            //this.Close();
        }

        private void FormVakcine_Load(object sender, EventArgs e)
        {
            s = DataLayer.GetSession();
            pacijent = s.Load<Pacijent>(jmbg_pacijenta);
            
            //PrimioVakcinu[] primljene_vakcine = pacijent.PrimioVakcinuVakcine.ToArray();

            //MetroMessageBox.Show(this, primljene_vakcine[0].Id.PrimioPacijent.Jmbg + " " + primljene_vakcine[0].Id.PrimioVakcina.Ime.ToString() + " " + primljene_vakcine[0].Datum.ToString());

            sve_vakcine = s.QueryOver<Vakcina>().List(); // sve vakcine

            //MetroMessageBox.Show(this, "Prva vakcina " + sve_vakcine[0].Ime + " " + sve_vakcine[0].Opis + " " + sve_vakcine[0].Sifra);

            metroGridVakcine.DataSource = sve_vakcine;
            //metroGridVakcine.DataMember = "Vakcine"; // Error Child list cannot be created 
            metroGridVakcine.Columns[3].Visible = false;
            for (int i = 0; i < metroGridVakcine.ColumnCount; i++)
                metroGridVakcine.Columns[i].Width = metroGridVakcine.Width / metroGridVakcine.ColumnCount;

            FromDataToControl(0); //Input to metroGrid must come before this function // not checked for (if Vakcine table in Database is empty)
            //s.Save(pv);
            //s.Flush();
            //s.Close();
            //MetroMessageBox.Show(this, "Dodata vakcina");
            //this.Close();
        }

        private void metroGridVakcine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MetroFramework.Controls.MetroGrid mg = sender as MetroFramework.Controls.MetroGrid;
            int row_index = mg.CurrentCell.RowIndex;
            FromDataToControl(row_index);
        }

        private void FormVakcine_FormClosing(object sender, FormClosingEventArgs e)
        {
            //session close 
            //s.SaveOrUpdate(vakcine);
            //s.SaveOrUpdate(pacijent);
            //s.Close();
        }
    }
}
