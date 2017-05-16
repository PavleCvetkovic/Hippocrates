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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabGlobal = new MetroFramework.Controls.MetroTabControl();
            this.tabIzabraniLekar = new MetroFramework.Controls.MetroTabPage();
            this.metrolabInfoLekar = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tabVakcine = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metrogridVakcine = new MetroFramework.Controls.MetroGrid();
            this.tabTermin = new MetroFramework.Controls.MetroTabPage();
            this.metroLabelPravoZaZakazivanje = new MetroFramework.Controls.MetroLabel();
            this.metroButtonZakaziteTermin = new MetroFramework.Controls.MetroButton();
            this.tabDijagnoze = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroGridDijagnoze = new MetroFramework.Controls.MetroGrid();
            this.metroTabPageTerapije = new MetroFramework.Controls.MetroTabPage();
            this.metroGridTerapije = new MetroFramework.Controls.MetroGrid();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelJMBGLBO = new MetroFramework.Controls.MetroLabel();
            this.metroTabPageKontakt = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxTelefon = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonSacuvajKontakt = new MetroFramework.Controls.MetroButton();
            this.metroTabGlobal.SuspendLayout();
            this.tabIzabraniLekar.SuspendLayout();
            this.tabVakcine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metrogridVakcine)).BeginInit();
            this.tabTermin.SuspendLayout();
            this.tabDijagnoze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridDijagnoze)).BeginInit();
            this.metroTabPageTerapije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridTerapije)).BeginInit();
            this.metroTabPageKontakt.SuspendLayout();
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
            this.metroTabGlobal.Controls.Add(this.metroTabPageKontakt);
            this.metroTabGlobal.Location = new System.Drawing.Point(24, 129);
            this.metroTabGlobal.Name = "metroTabGlobal";
            this.metroTabGlobal.SelectedIndex = 5;
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
            this.metrogridVakcine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metrogridVakcine.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metrogridVakcine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metrogridVakcine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metrogridVakcine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metrogridVakcine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.metrogridVakcine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metrogridVakcine.DefaultCellStyle = dataGridViewCellStyle11;
            this.metrogridVakcine.EnableHeadersVisualStyles = false;
            this.metrogridVakcine.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metrogridVakcine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metrogridVakcine.Location = new System.Drawing.Point(3, 30);
            this.metrogridVakcine.Name = "metrogridVakcine";
            this.metrogridVakcine.ReadOnly = true;
            this.metrogridVakcine.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metrogridVakcine.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.metrogridVakcine.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metrogridVakcine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metrogridVakcine.Size = new System.Drawing.Size(429, 214);
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
            this.metroLabelPravoZaZakazivanje.Location = new System.Drawing.Point(3, 18);
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
            this.metroGridDijagnoze.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGridDijagnoze.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridDijagnoze.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridDijagnoze.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridDijagnoze.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridDijagnoze.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.metroGridDijagnoze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridDijagnoze.DefaultCellStyle = dataGridViewCellStyle14;
            this.metroGridDijagnoze.EnableHeadersVisualStyles = false;
            this.metroGridDijagnoze.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridDijagnoze.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridDijagnoze.Location = new System.Drawing.Point(3, 32);
            this.metroGridDijagnoze.Name = "metroGridDijagnoze";
            this.metroGridDijagnoze.ReadOnly = true;
            this.metroGridDijagnoze.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridDijagnoze.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.metroGridDijagnoze.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridDijagnoze.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridDijagnoze.Size = new System.Drawing.Size(429, 205);
            this.metroGridDijagnoze.TabIndex = 2;
            // 
            // metroTabPageTerapije
            // 
            this.metroTabPageTerapije.Controls.Add(this.metroGridTerapije);
            this.metroTabPageTerapije.Controls.Add(this.metroLabel5);
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
            // metroGridTerapije
            // 
            this.metroGridTerapije.AllowUserToResizeRows = false;
            this.metroGridTerapije.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGridTerapije.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridTerapije.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridTerapije.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridTerapije.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridTerapije.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.metroGridTerapije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridTerapije.DefaultCellStyle = dataGridViewCellStyle17;
            this.metroGridTerapije.EnableHeadersVisualStyles = false;
            this.metroGridTerapije.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridTerapije.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridTerapije.Location = new System.Drawing.Point(3, 32);
            this.metroGridTerapije.Name = "metroGridTerapije";
            this.metroGridTerapije.ReadOnly = true;
            this.metroGridTerapije.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridTerapije.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.metroGridTerapije.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridTerapije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridTerapije.Size = new System.Drawing.Size(429, 205);
            this.metroGridTerapije.TabIndex = 6;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 10);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(110, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Terapije pacijenta";
            // 
            // metroLabelJMBGLBO
            // 
            this.metroLabelJMBGLBO.AutoSize = true;
            this.metroLabelJMBGLBO.Location = new System.Drawing.Point(28, 76);
            this.metroLabelJMBGLBO.Name = "metroLabelJMBGLBO";
            this.metroLabelJMBGLBO.Size = new System.Drawing.Size(109, 19);
            this.metroLabelJMBGLBO.TabIndex = 1;
            this.metroLabelJMBGLBO.Text = "jmbg + lbo ovde";
            // 
            // metroTabPageKontakt
            // 
            this.metroTabPageKontakt.Controls.Add(this.metroButtonSacuvajKontakt);
            this.metroTabPageKontakt.Controls.Add(this.metroTextBoxEmail);
            this.metroTabPageKontakt.Controls.Add(this.metroTextBoxTelefon);
            this.metroTabPageKontakt.Controls.Add(this.metroLabel6);
            this.metroTabPageKontakt.Controls.Add(this.metroLabel1);
            this.metroTabPageKontakt.HorizontalScrollbarBarColor = true;
            this.metroTabPageKontakt.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageKontakt.HorizontalScrollbarSize = 10;
            this.metroTabPageKontakt.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageKontakt.Name = "metroTabPageKontakt";
            this.metroTabPageKontakt.Size = new System.Drawing.Size(435, 240);
            this.metroTabPageKontakt.TabIndex = 5;
            this.metroTabPageKontakt.Text = "Kontakt";
            this.metroTabPageKontakt.VerticalScrollbarBarColor = true;
            this.metroTabPageKontakt.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageKontakt.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Broj telefona";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 86);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(47, 19);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "E-mail";
            // 
            // metroTextBoxTelefon
            // 
            // 
            // 
            // 
            this.metroTextBoxTelefon.CustomButton.Image = null;
            this.metroTextBoxTelefon.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.metroTextBoxTelefon.CustomButton.Name = "";
            this.metroTextBoxTelefon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxTelefon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxTelefon.CustomButton.TabIndex = 1;
            this.metroTextBoxTelefon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxTelefon.CustomButton.UseSelectable = true;
            this.metroTextBoxTelefon.CustomButton.Visible = false;
            this.metroTextBoxTelefon.Lines = new string[] {
        "...Unesite broj telefona"};
            this.metroTextBoxTelefon.Location = new System.Drawing.Point(132, 36);
            this.metroTextBoxTelefon.MaxLength = 32767;
            this.metroTextBoxTelefon.Name = "metroTextBoxTelefon";
            this.metroTextBoxTelefon.PasswordChar = '\0';
            this.metroTextBoxTelefon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTelefon.SelectedText = "";
            this.metroTextBoxTelefon.SelectionLength = 0;
            this.metroTextBoxTelefon.SelectionStart = 0;
            this.metroTextBoxTelefon.ShortcutsEnabled = true;
            this.metroTextBoxTelefon.Size = new System.Drawing.Size(242, 23);
            this.metroTextBoxTelefon.TabIndex = 4;
            this.metroTextBoxTelefon.Text = "...Unesite broj telefona";
            this.metroTextBoxTelefon.UseSelectable = true;
            this.metroTextBoxTelefon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxTelefon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxTelefon_KeyPress);
            // 
            // metroTextBoxEmail
            // 
            // 
            // 
            // 
            this.metroTextBoxEmail.CustomButton.Image = null;
            this.metroTextBoxEmail.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.metroTextBoxEmail.CustomButton.Name = "";
            this.metroTextBoxEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEmail.CustomButton.TabIndex = 1;
            this.metroTextBoxEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEmail.CustomButton.UseSelectable = true;
            this.metroTextBoxEmail.CustomButton.Visible = false;
            this.metroTextBoxEmail.Lines = new string[] {
        "...Unesite e-mail"};
            this.metroTextBoxEmail.Location = new System.Drawing.Point(132, 86);
            this.metroTextBoxEmail.MaxLength = 32767;
            this.metroTextBoxEmail.Name = "metroTextBoxEmail";
            this.metroTextBoxEmail.PasswordChar = '\0';
            this.metroTextBoxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEmail.SelectedText = "";
            this.metroTextBoxEmail.SelectionLength = 0;
            this.metroTextBoxEmail.SelectionStart = 0;
            this.metroTextBoxEmail.ShortcutsEnabled = true;
            this.metroTextBoxEmail.Size = new System.Drawing.Size(242, 23);
            this.metroTextBoxEmail.TabIndex = 5;
            this.metroTextBoxEmail.Text = "...Unesite e-mail";
            this.metroTextBoxEmail.UseSelectable = true;
            this.metroTextBoxEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonSacuvajKontakt
            // 
            this.metroButtonSacuvajKontakt.Location = new System.Drawing.Point(0, 214);
            this.metroButtonSacuvajKontakt.Name = "metroButtonSacuvajKontakt";
            this.metroButtonSacuvajKontakt.Size = new System.Drawing.Size(435, 23);
            this.metroButtonSacuvajKontakt.TabIndex = 6;
            this.metroButtonSacuvajKontakt.Text = "Sačuvaj";
            this.metroButtonSacuvajKontakt.UseSelectable = true;
            this.metroButtonSacuvajKontakt.Click += new System.EventHandler(this.metroButtonSacuvajKontakt_Click);
            // 
            // PacijentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 434);
            this.Controls.Add(this.metroLabelJMBGLBO);
            this.Controls.Add(this.metroTabGlobal);
            this.Name = "PacijentForm";
            this.Text = "Pacijent";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PacijentForm_FormClosing);
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
            this.metroTabPageKontakt.ResumeLayout(false);
            this.metroTabPageKontakt.PerformLayout();
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
        private MetroFramework.Controls.MetroLabel metroLabelJMBGLBO;
        private MetroFramework.Controls.MetroLabel metroLabelPravoZaZakazivanje;
        private MetroFramework.Controls.MetroTabPage metroTabPageTerapije;
        private MetroFramework.Controls.MetroGrid metroGridTerapije;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTabPage metroTabPageKontakt;
        private MetroFramework.Controls.MetroButton metroButtonSacuvajKontakt;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEmail;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTelefon;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}