namespace HippocratesPatient
{
    partial class PacijentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabGlobal = new MetroFramework.Controls.MetroTabControl();
            this.tabIzabraniLekar = new MetroFramework.Controls.MetroTabPage();
            this.metrolabInfoLekar = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tabVakcine = new MetroFramework.Controls.MetroTabPage();
            this.metroButtonObrisiVakcinu = new MetroFramework.Controls.MetroButton();
            this.metroButtonDodajVakcinu = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metrogridVakcine = new MetroFramework.Controls.MetroGrid();
            this.tabTermin = new MetroFramework.Controls.MetroTabPage();
            this.metroLabelPravoZaZakazivanje = new MetroFramework.Controls.MetroLabel();
            this.metroButtonZakaziteTermin = new MetroFramework.Controls.MetroButton();
            this.tabDijagnoze = new MetroFramework.Controls.MetroTabPage();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroGridDijagnoze = new MetroFramework.Controls.MetroGrid();
            this.metroTabPageTerapije = new MetroFramework.Controls.MetroTabPage();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroGridTerapije = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabGlobal.SuspendLayout();
            this.tabIzabraniLekar.SuspendLayout();
            this.tabVakcine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metrogridVakcine)).BeginInit();
            this.tabTermin.SuspendLayout();
            this.tabDijagnoze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridDijagnoze)).BeginInit();
            this.metroTabPageTerapije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridTerapije)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabGlobal
            // 
            this.metroTabGlobal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabGlobal.Controls.Add(this.tabIzabraniLekar);
            this.metroTabGlobal.Controls.Add(this.tabVakcine);
            this.metroTabGlobal.Controls.Add(this.tabTermin);
            this.metroTabGlobal.Controls.Add(this.tabDijagnoze);
            this.metroTabGlobal.Controls.Add(this.metroTabPageTerapije);
            this.metroTabGlobal.Location = new System.Drawing.Point(24, 129);
            this.metroTabGlobal.Name = "metroTabGlobal";
            this.metroTabGlobal.SelectedIndex = 4;
            this.metroTabGlobal.Size = new System.Drawing.Size(443, 282);
            this.metroTabGlobal.TabIndex = 0;
            this.metroTabGlobal.UseSelectable = true;
            this.metroTabGlobal.SelectedIndexChanged += new System.EventHandler(this.tabGlobal_SelectedIndexChanged);
            // 
            // tabIzabraniLekar
            // 
            this.tabIzabraniLekar.Controls.Add(this.metrolabInfoLekar);
            this.tabIzabraniLekar.Controls.Add(this.metroLabel2);
            this.tabIzabraniLekar.Controls.Add(this.metroButton1);
            this.tabIzabraniLekar.HorizontalScrollbarBarColor = true;
            this.tabIzabraniLekar.HorizontalScrollbarHighlightOnWheel = false;
            this.tabIzabraniLekar.HorizontalScrollbarSize = 10;
            this.tabIzabraniLekar.Location = new System.Drawing.Point(4, 38);
            this.tabIzabraniLekar.Name = "tabIzabraniLekar";
            this.tabIzabraniLekar.Size = new System.Drawing.Size(435, 240);
            this.tabIzabraniLekar.TabIndex = 0;
            this.tabIzabraniLekar.Text = "Izabrani Lekar";
            this.tabIzabraniLekar.VerticalScrollbarBarColor = true;
            this.tabIzabraniLekar.VerticalScrollbarHighlightOnWheel = false;
            this.tabIzabraniLekar.VerticalScrollbarSize = 10;
            // 
            // metrolabInfoLekar
            // 
            this.metrolabInfoLekar.AutoSize = true;
            this.metrolabInfoLekar.Location = new System.Drawing.Point(-4, 52);
            this.metrolabInfoLekar.Name = "metrolabInfoLekar";
            this.metrolabInfoLekar.Size = new System.Drawing.Size(120, 19);
            this.metrolabInfoLekar.TabIndex = 4;
            this.metrolabInfoLekar.Text = "info za lekara ovde";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(-4, 22);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(104, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Izabrani lekar je:";
            // 
            // metroButton1
            // 
            this.metroButton1.Enabled = false;
            this.metroButton1.Location = new System.Drawing.Point(-4, 214);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(436, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Podnesite zahtev za promenu lekara";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // tabVakcine
            // 
            this.tabVakcine.Controls.Add(this.metroButtonObrisiVakcinu);
            this.tabVakcine.Controls.Add(this.metroButtonDodajVakcinu);
            this.tabVakcine.Controls.Add(this.metroLabel3);
            this.tabVakcine.Controls.Add(this.metrogridVakcine);
            this.tabVakcine.HorizontalScrollbarBarColor = true;
            this.tabVakcine.HorizontalScrollbarHighlightOnWheel = false;
            this.tabVakcine.HorizontalScrollbarSize = 10;
            this.tabVakcine.Location = new System.Drawing.Point(4, 38);
            this.tabVakcine.Name = "tabVakcine";
            this.tabVakcine.Size = new System.Drawing.Size(435, 240);
            this.tabVakcine.TabIndex = 1;
            this.tabVakcine.Text = "Vakcine";
            this.tabVakcine.VerticalScrollbarBarColor = true;
            this.tabVakcine.VerticalScrollbarHighlightOnWheel = false;
            this.tabVakcine.VerticalScrollbarSize = 10;
            // 
            // metroButtonObrisiVakcinu
            // 
            this.metroButtonObrisiVakcinu.Location = new System.Drawing.Point(3, 212);
            this.metroButtonObrisiVakcinu.Name = "metroButtonObrisiVakcinu";
            this.metroButtonObrisiVakcinu.Size = new System.Drawing.Size(432, 23);
            this.metroButtonObrisiVakcinu.TabIndex = 5;
            this.metroButtonObrisiVakcinu.Text = "Obriši vakcinu";
            this.metroButtonObrisiVakcinu.UseSelectable = true;
            this.metroButtonObrisiVakcinu.Click += new System.EventHandler(this.metroButtonObrisiVakcinu_Click);
            // 
            // metroButtonDodajVakcinu
            // 
            this.metroButtonDodajVakcinu.Location = new System.Drawing.Point(3, 181);
            this.metroButtonDodajVakcinu.Name = "metroButtonDodajVakcinu";
            this.metroButtonDodajVakcinu.Size = new System.Drawing.Size(432, 23);
            this.metroButtonDodajVakcinu.TabIndex = 4;
            this.metroButtonDodajVakcinu.Text = "Dodaj vakcinu";
            this.metroButtonDodajVakcinu.UseSelectable = true;
            this.metroButtonDodajVakcinu.Click += new System.EventHandler(this.metroButtonDodajVakcinu_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 8);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(110, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Primljene vakcine";
            // 
            // metrogridVakcine
            // 
            this.metrogridVakcine.AllowUserToAddRows = false;
            this.metrogridVakcine.AllowUserToDeleteRows = false;
            this.metrogridVakcine.AllowUserToResizeRows = false;
            this.metrogridVakcine.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metrogridVakcine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metrogridVakcine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metrogridVakcine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metrogridVakcine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metrogridVakcine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metrogridVakcine.DefaultCellStyle = dataGridViewCellStyle2;
            this.metrogridVakcine.EnableHeadersVisualStyles = false;
            this.metrogridVakcine.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metrogridVakcine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metrogridVakcine.Location = new System.Drawing.Point(3, 30);
            this.metrogridVakcine.Name = "metrogridVakcine";
            this.metrogridVakcine.ReadOnly = true;
            this.metrogridVakcine.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metrogridVakcine.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metrogridVakcine.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metrogridVakcine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metrogridVakcine.Size = new System.Drawing.Size(429, 132);
            this.metrogridVakcine.TabIndex = 2;
            // 
            // tabTermin
            // 
            this.tabTermin.Controls.Add(this.metroLabelPravoZaZakazivanje);
            this.tabTermin.Controls.Add(this.metroButtonZakaziteTermin);
            this.tabTermin.HorizontalScrollbarBarColor = true;
            this.tabTermin.HorizontalScrollbarHighlightOnWheel = false;
            this.tabTermin.HorizontalScrollbarSize = 10;
            this.tabTermin.Location = new System.Drawing.Point(4, 38);
            this.tabTermin.Name = "tabTermin";
            this.tabTermin.Size = new System.Drawing.Size(435, 240);
            this.tabTermin.TabIndex = 2;
            this.tabTermin.Text = "Termin";
            this.tabTermin.VerticalScrollbarBarColor = true;
            this.tabTermin.VerticalScrollbarHighlightOnWheel = false;
            this.tabTermin.VerticalScrollbarSize = 10;
            // 
            // metroLabelPravoZaZakazivanje
            // 
            this.metroLabelPravoZaZakazivanje.AutoSize = true;
            this.metroLabelPravoZaZakazivanje.Location = new System.Drawing.Point(3, 10);
            this.metroLabelPravoZaZakazivanje.Name = "metroLabelPravoZaZakazivanje";
            this.metroLabelPravoZaZakazivanje.Size = new System.Drawing.Size(184, 19);
            this.metroLabelPravoZaZakazivanje.TabIndex = 4;
            this.metroLabelPravoZaZakazivanje.Text = "ovde ide pravo za zakazivanje";
            // 
            // metroButtonZakaziteTermin
            // 
            this.metroButtonZakaziteTermin.Location = new System.Drawing.Point(0, 214);
            this.metroButtonZakaziteTermin.Name = "metroButtonZakaziteTermin";
            this.metroButtonZakaziteTermin.Size = new System.Drawing.Size(436, 23);
            this.metroButtonZakaziteTermin.TabIndex = 3;
            this.metroButtonZakaziteTermin.Text = "Zakazite termin";
            this.metroButtonZakaziteTermin.UseSelectable = true;
            this.metroButtonZakaziteTermin.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // tabDijagnoze
            // 
            this.tabDijagnoze.Controls.Add(this.metroButton3);
            this.tabDijagnoze.Controls.Add(this.metroButton4);
            this.tabDijagnoze.Controls.Add(this.metroLabel4);
            this.tabDijagnoze.Controls.Add(this.metroGridDijagnoze);
            this.tabDijagnoze.HorizontalScrollbarBarColor = true;
            this.tabDijagnoze.HorizontalScrollbarHighlightOnWheel = false;
            this.tabDijagnoze.HorizontalScrollbarSize = 10;
            this.tabDijagnoze.Location = new System.Drawing.Point(4, 38);
            this.tabDijagnoze.Name = "tabDijagnoze";
            this.tabDijagnoze.Size = new System.Drawing.Size(435, 240);
            this.tabDijagnoze.TabIndex = 3;
            this.tabDijagnoze.Text = "Dijagnoze";
            this.tabDijagnoze.VerticalScrollbarBarColor = true;
            this.tabDijagnoze.VerticalScrollbarHighlightOnWheel = false;
            this.tabDijagnoze.VerticalScrollbarSize = 10;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(3, 212);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(432, 23);
            this.metroButton3.TabIndex = 7;
            this.metroButton3.Text = "Obriši dijagnozu";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(3, 181);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(432, 23);
            this.metroButton4.TabIndex = 6;
            this.metroButton4.Text = "Dodaj dijagnozu";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 10);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(131, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Prethodne dijagnoze";
            // 
            // metroGridDijagnoze
            // 
            this.metroGridDijagnoze.AllowUserToResizeRows = false;
            this.metroGridDijagnoze.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridDijagnoze.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridDijagnoze.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridDijagnoze.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridDijagnoze.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGridDijagnoze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridDijagnoze.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGridDijagnoze.EnableHeadersVisualStyles = false;
            this.metroGridDijagnoze.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridDijagnoze.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridDijagnoze.Location = new System.Drawing.Point(3, 32);
            this.metroGridDijagnoze.Name = "metroGridDijagnoze";
            this.metroGridDijagnoze.ReadOnly = true;
            this.metroGridDijagnoze.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridDijagnoze.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGridDijagnoze.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridDijagnoze.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridDijagnoze.Size = new System.Drawing.Size(429, 121);
            this.metroGridDijagnoze.TabIndex = 2;
            // 
            // metroTabPageTerapije
            // 
            this.metroTabPageTerapije.Controls.Add(this.metroButton2);
            this.metroTabPageTerapije.Controls.Add(this.metroButton5);
            this.metroTabPageTerapije.Controls.Add(this.metroLabel5);
            this.metroTabPageTerapije.Controls.Add(this.metroGridTerapije);
            this.metroTabPageTerapije.HorizontalScrollbarBarColor = true;
            this.metroTabPageTerapije.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageTerapije.HorizontalScrollbarSize = 10;
            this.metroTabPageTerapije.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageTerapije.Name = "metroTabPageTerapije";
            this.metroTabPageTerapije.Size = new System.Drawing.Size(435, 240);
            this.metroTabPageTerapije.TabIndex = 4;
            this.metroTabPageTerapije.Text = "Terapije";
            this.metroTabPageTerapije.VerticalScrollbarBarColor = true;
            this.metroTabPageTerapije.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageTerapije.VerticalScrollbarSize = 10;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(3, 212);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(432, 23);
            this.metroButton2.TabIndex = 7;
            this.metroButton2.Text = "Obriši terapiju";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(3, 181);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(432, 23);
            this.metroButton5.TabIndex = 6;
            this.metroButton5.Text = "Dodaj terapiju";
            this.metroButton5.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 10);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(110, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Terapije pacijenta";
            // 
            // metroGridTerapije
            // 
            this.metroGridTerapije.AllowUserToResizeRows = false;
            this.metroGridTerapije.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridTerapije.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridTerapije.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridTerapije.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridTerapije.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGridTerapije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridTerapije.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGridTerapije.EnableHeadersVisualStyles = false;
            this.metroGridTerapije.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridTerapije.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridTerapije.Location = new System.Drawing.Point(0, 46);
            this.metroGridTerapije.Name = "metroGridTerapije";
            this.metroGridTerapije.ReadOnly = true;
            this.metroGridTerapije.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridTerapije.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGridTerapije.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridTerapije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridTerapije.Size = new System.Drawing.Size(432, 113);
            this.metroGridTerapije.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(109, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "jmbg + lbo ovde";
            // 
            // PacijentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 434);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTabGlobal);
            this.Name = "PacijentForm";
            this.Text = "Pacijent";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.PacijentForm_Load);
            this.metroTabGlobal.ResumeLayout(false);
            this.tabIzabraniLekar.ResumeLayout(false);
            this.tabIzabraniLekar.PerformLayout();
            this.tabVakcine.ResumeLayout(false);
            this.tabVakcine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metrogridVakcine)).EndInit();
            this.tabTermin.ResumeLayout(false);
            this.tabTermin.PerformLayout();
            this.tabDijagnoze.ResumeLayout(false);
            this.tabDijagnoze.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridDijagnoze)).EndInit();
            this.metroTabPageTerapije.ResumeLayout(false);
            this.metroTabPageTerapije.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridTerapije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabGlobal;
        private MetroFramework.Controls.MetroTabPage tabIzabraniLekar;
        private MetroFramework.Controls.MetroLabel metrolabInfoLekar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTabPage tabVakcine;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroGrid metrogridVakcine;
        private MetroFramework.Controls.MetroTabPage tabTermin;
        private MetroFramework.Controls.MetroButton metroButtonZakaziteTermin;
        private MetroFramework.Controls.MetroTabPage tabDijagnoze;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroGrid metroGridDijagnoze;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabelPravoZaZakazivanje;
        private MetroFramework.Controls.MetroButton metroButtonObrisiVakcinu;
        private MetroFramework.Controls.MetroButton metroButtonDodajVakcinu;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroTabPage metroTabPageTerapije;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroGrid metroGridTerapije;
    }
}