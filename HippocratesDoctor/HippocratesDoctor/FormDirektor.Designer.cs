namespace HippocratesDoctor
{
    partial class FormDirektor
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
            this.metroTabControlGlobal = new MetroFramework.Controls.MetroTabControl();
            this.tabLekar = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.tabLeakrBrisanje = new MetroFramework.Controls.MetroTabPage();
            this.metroButtonObrisiLekara = new MetroFramework.Controls.MetroButton();
            this.tabLekarUnos = new MetroFramework.Controls.MetroTabPage();
            this.metroButtonUnesiteLekara = new MetroFramework.Controls.MetroButton();
            this.tabLekarAzuriranje = new MetroFramework.Controls.MetroTabPage();
            this.metroButtonAzurirajLekara = new MetroFramework.Controls.MetroButton();
            this.tabOsoblje = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroButtonObrisiOsobu = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroButtonUnesiOsobu = new MetroFramework.Controls.MetroButton();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroButtonAzurirajOsobu = new MetroFramework.Controls.MetroButton();
            this.lblImeDomaZ = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroGridData = new MetroFramework.Controls.MetroGrid();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxJMBG = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxSrednjeSlovo = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTimeDatumRodjenja = new MetroFramework.Controls.MetroDateTime();
            this.metroTextBoxIme = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPrezime = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxLozinka = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonSmenaLekara = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPageZahteviPacijenata = new MetroFramework.Controls.MetroTabPage();
            this.metroButtonZahteviPacijenata = new MetroFramework.Controls.MetroButton();
            this.metroTabControlGlobal.SuspendLayout();
            this.tabLekar.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.tabLeakrBrisanje.SuspendLayout();
            this.tabLekarUnos.SuspendLayout();
            this.tabLekarAzuriranje.SuspendLayout();
            this.tabOsoblje.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridData)).BeginInit();
            this.metroTabPageZahteviPacijenata.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControlGlobal
            // 
            this.metroTabControlGlobal.Controls.Add(this.tabLekar);
            this.metroTabControlGlobal.Controls.Add(this.tabOsoblje);
            this.metroTabControlGlobal.Controls.Add(this.metroTabPageZahteviPacijenata);
            this.metroTabControlGlobal.Location = new System.Drawing.Point(23, 72);
            this.metroTabControlGlobal.Name = "metroTabControlGlobal";
            this.metroTabControlGlobal.SelectedIndex = 2;
            this.metroTabControlGlobal.Size = new System.Drawing.Size(849, 168);
            this.metroTabControlGlobal.TabIndex = 3;
            this.metroTabControlGlobal.UseSelectable = true;
            this.metroTabControlGlobal.SelectedIndexChanged += new System.EventHandler(this.metroTabControlGlobal_SelectedIndexChanged);
            // 
            // tabLekar
            // 
            this.tabLekar.Controls.Add(this.metroTabControl2);
            this.tabLekar.HorizontalScrollbarBarColor = true;
            this.tabLekar.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLekar.HorizontalScrollbarSize = 10;
            this.tabLekar.Location = new System.Drawing.Point(4, 38);
            this.tabLekar.Name = "tabLekar";
            this.tabLekar.Size = new System.Drawing.Size(841, 126);
            this.tabLekar.TabIndex = 0;
            this.tabLekar.Text = "Podaci o lekarima";
            this.tabLekar.VerticalScrollbarBarColor = true;
            this.tabLekar.VerticalScrollbarHighlightOnWheel = false;
            this.tabLekar.VerticalScrollbarSize = 10;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.tabLeakrBrisanje);
            this.metroTabControl2.Controls.Add(this.tabLekarUnos);
            this.metroTabControl2.Controls.Add(this.tabLekarAzuriranje);
            this.metroTabControl2.Location = new System.Drawing.Point(3, 4);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 0;
            this.metroTabControl2.Size = new System.Drawing.Size(842, 100);
            this.metroTabControl2.TabIndex = 2;
            this.metroTabControl2.UseSelectable = true;
            // 
            // tabLeakrBrisanje
            // 
            this.tabLeakrBrisanje.Controls.Add(this.metroButtonObrisiLekara);
            this.tabLeakrBrisanje.HorizontalScrollbarBarColor = true;
            this.tabLeakrBrisanje.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLeakrBrisanje.HorizontalScrollbarSize = 10;
            this.tabLeakrBrisanje.Location = new System.Drawing.Point(4, 38);
            this.tabLeakrBrisanje.Name = "tabLeakrBrisanje";
            this.tabLeakrBrisanje.Size = new System.Drawing.Size(834, 58);
            this.tabLeakrBrisanje.TabIndex = 0;
            this.tabLeakrBrisanje.Text = "Brisanje podataka o lekarima";
            this.tabLeakrBrisanje.VerticalScrollbarBarColor = true;
            this.tabLeakrBrisanje.VerticalScrollbarHighlightOnWheel = false;
            this.tabLeakrBrisanje.VerticalScrollbarSize = 10;
            // 
            // metroButtonObrisiLekara
            // 
            this.metroButtonObrisiLekara.Location = new System.Drawing.Point(0, 18);
            this.metroButtonObrisiLekara.Name = "metroButtonObrisiLekara";
            this.metroButtonObrisiLekara.Size = new System.Drawing.Size(831, 23);
            this.metroButtonObrisiLekara.TabIndex = 2;
            this.metroButtonObrisiLekara.Text = "Obriši lekara";
            this.metroButtonObrisiLekara.UseSelectable = true;
            this.metroButtonObrisiLekara.Click += new System.EventHandler(this.metroButtonObrisiLekara_Click);
            // 
            // tabLekarUnos
            // 
            this.tabLekarUnos.Controls.Add(this.metroButtonUnesiteLekara);
            this.tabLekarUnos.HorizontalScrollbarBarColor = true;
            this.tabLekarUnos.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLekarUnos.HorizontalScrollbarSize = 10;
            this.tabLekarUnos.Location = new System.Drawing.Point(4, 38);
            this.tabLekarUnos.Name = "tabLekarUnos";
            this.tabLekarUnos.Size = new System.Drawing.Size(834, 58);
            this.tabLekarUnos.TabIndex = 1;
            this.tabLekarUnos.Text = "Unošenje podataka o novom lekaru";
            this.tabLekarUnos.VerticalScrollbarBarColor = true;
            this.tabLekarUnos.VerticalScrollbarHighlightOnWheel = false;
            this.tabLekarUnos.VerticalScrollbarSize = 10;
            // 
            // metroButtonUnesiteLekara
            // 
            this.metroButtonUnesiteLekara.Location = new System.Drawing.Point(0, 18);
            this.metroButtonUnesiteLekara.Name = "metroButtonUnesiteLekara";
            this.metroButtonUnesiteLekara.Size = new System.Drawing.Size(833, 23);
            this.metroButtonUnesiteLekara.TabIndex = 26;
            this.metroButtonUnesiteLekara.Text = "Unesite lekara";
            this.metroButtonUnesiteLekara.UseSelectable = true;
            this.metroButtonUnesiteLekara.Click += new System.EventHandler(this.metroButtonUnesiteLekara_Click);
            // 
            // tabLekarAzuriranje
            // 
            this.tabLekarAzuriranje.Controls.Add(this.metroButtonAzurirajLekara);
            this.tabLekarAzuriranje.HorizontalScrollbarBarColor = true;
            this.tabLekarAzuriranje.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLekarAzuriranje.HorizontalScrollbarSize = 10;
            this.tabLekarAzuriranje.Location = new System.Drawing.Point(4, 38);
            this.tabLekarAzuriranje.Name = "tabLekarAzuriranje";
            this.tabLekarAzuriranje.Size = new System.Drawing.Size(834, 58);
            this.tabLekarAzuriranje.TabIndex = 2;
            this.tabLekarAzuriranje.Text = "Ažuriranje podataka o lekaru";
            this.tabLekarAzuriranje.VerticalScrollbarBarColor = true;
            this.tabLekarAzuriranje.VerticalScrollbarHighlightOnWheel = false;
            this.tabLekarAzuriranje.VerticalScrollbarSize = 10;
            // 
            // metroButtonAzurirajLekara
            // 
            this.metroButtonAzurirajLekara.Location = new System.Drawing.Point(0, 18);
            this.metroButtonAzurirajLekara.Name = "metroButtonAzurirajLekara";
            this.metroButtonAzurirajLekara.Size = new System.Drawing.Size(833, 23);
            this.metroButtonAzurirajLekara.TabIndex = 42;
            this.metroButtonAzurirajLekara.Text = "Ažurirajte lekara";
            this.metroButtonAzurirajLekara.UseSelectable = true;
            this.metroButtonAzurirajLekara.Click += new System.EventHandler(this.metroButtonAzurirajLekara_Click);
            // 
            // tabOsoblje
            // 
            this.tabOsoblje.Controls.Add(this.metroTabControl1);
            this.tabOsoblje.HorizontalScrollbarBarColor = true;
            this.tabOsoblje.HorizontalScrollbarHighlightOnWheel = false;
            this.tabOsoblje.HorizontalScrollbarSize = 10;
            this.tabOsoblje.Location = new System.Drawing.Point(4, 38);
            this.tabOsoblje.Name = "tabOsoblje";
            this.tabOsoblje.Size = new System.Drawing.Size(841, 126);
            this.tabOsoblje.TabIndex = 1;
            this.tabOsoblje.Text = "Podaci o medicinskom osoblju";
            this.tabOsoblje.VerticalScrollbarBarColor = true;
            this.tabOsoblje.VerticalScrollbarHighlightOnWheel = false;
            this.tabOsoblje.VerticalScrollbarSize = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(841, 100);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroButtonObrisiOsobu);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(833, 58);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Brisanje podatka o osoblju";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroButtonObrisiOsobu
            // 
            this.metroButtonObrisiOsobu.Location = new System.Drawing.Point(1, 18);
            this.metroButtonObrisiOsobu.Name = "metroButtonObrisiOsobu";
            this.metroButtonObrisiOsobu.Size = new System.Drawing.Size(831, 23);
            this.metroButtonObrisiOsobu.TabIndex = 3;
            this.metroButtonObrisiOsobu.Text = "Obriši osobu";
            this.metroButtonObrisiOsobu.UseSelectable = true;
            this.metroButtonObrisiOsobu.Click += new System.EventHandler(this.metroButtonObrisiOsobu_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroButtonUnesiOsobu);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(833, 58);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Unošenje podataka o osoblju";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroButtonUnesiOsobu
            // 
            this.metroButtonUnesiOsobu.Location = new System.Drawing.Point(0, 18);
            this.metroButtonUnesiOsobu.Name = "metroButtonUnesiOsobu";
            this.metroButtonUnesiOsobu.Size = new System.Drawing.Size(833, 23);
            this.metroButtonUnesiOsobu.TabIndex = 27;
            this.metroButtonUnesiOsobu.Text = "Unesite osobu";
            this.metroButtonUnesiOsobu.UseSelectable = true;
            this.metroButtonUnesiOsobu.Click += new System.EventHandler(this.metroButtonUnesiOsobu_Click);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroButtonAzurirajOsobu);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(833, 58);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Ažuriraj osobu";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroButtonAzurirajOsobu
            // 
            this.metroButtonAzurirajOsobu.Location = new System.Drawing.Point(0, 18);
            this.metroButtonAzurirajOsobu.Name = "metroButtonAzurirajOsobu";
            this.metroButtonAzurirajOsobu.Size = new System.Drawing.Size(833, 23);
            this.metroButtonAzurirajOsobu.TabIndex = 27;
            this.metroButtonAzurirajOsobu.Text = "Ažurirajte osobu";
            this.metroButtonAzurirajOsobu.UseSelectable = true;
            this.metroButtonAzurirajOsobu.Click += new System.EventHandler(this.metroButtonAzurirajOsobu_Click);
            // 
            // lblImeDomaZ
            // 
            this.lblImeDomaZ.AutoSize = true;
            this.lblImeDomaZ.Location = new System.Drawing.Point(698, 50);
            this.lblImeDomaZ.Name = "lblImeDomaZ";
            this.lblImeDomaZ.Size = new System.Drawing.Size(174, 19);
            this.lblImeDomaZ.TabIndex = 4;
            this.lblImeDomaZ.Text = "ovde ide ime doma zdravlja";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(421, 355);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(97, 19);
            this.metroLabel7.TabIndex = 51;
            this.metroLabel7.Text = "Datum rođenja";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(421, 306);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(49, 19);
            this.metroLabel6.TabIndex = 50;
            this.metroLabel6.Text = "Smena";
            // 
            // metroGridData
            // 
            this.metroGridData.AllowUserToResizeRows = false;
            this.metroGridData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridData.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridData.EnableHeadersVisualStyles = false;
            this.metroGridData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridData.Location = new System.Drawing.Point(31, 442);
            this.metroGridData.Name = "metroGridData";
            this.metroGridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridData.Size = new System.Drawing.Size(831, 195);
            this.metroGridData.TabIndex = 36;
            this.metroGridData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridLekari_CellContentClick);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(421, 256);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(87, 19);
            this.metroLabel5.TabIndex = 49;
            this.metroLabel5.Text = "Srednje slovo";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(70, 355);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(52, 19);
            this.metroLabel4.TabIndex = 48;
            this.metroLabel4.Text = "Lozinka";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(70, 256);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 37;
            this.metroLabel1.Text = "JMBG";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(70, 323);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(57, 19);
            this.metroLabel3.TabIndex = 47;
            this.metroLabel3.Text = "Prezime";
            // 
            // metroTextBoxJMBG
            // 
            // 
            // 
            // 
            this.metroTextBoxJMBG.CustomButton.Image = null;
            this.metroTextBoxJMBG.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.metroTextBoxJMBG.CustomButton.Name = "";
            this.metroTextBoxJMBG.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxJMBG.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxJMBG.CustomButton.TabIndex = 1;
            this.metroTextBoxJMBG.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxJMBG.CustomButton.UseSelectable = true;
            this.metroTextBoxJMBG.CustomButton.Visible = false;
            this.metroTextBoxJMBG.Lines = new string[0];
            this.metroTextBoxJMBG.Location = new System.Drawing.Point(148, 256);
            this.metroTextBoxJMBG.MaxLength = 32767;
            this.metroTextBoxJMBG.Name = "metroTextBoxJMBG";
            this.metroTextBoxJMBG.PasswordChar = '\0';
            this.metroTextBoxJMBG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxJMBG.SelectedText = "";
            this.metroTextBoxJMBG.SelectionLength = 0;
            this.metroTextBoxJMBG.SelectionStart = 0;
            this.metroTextBoxJMBG.ShortcutsEnabled = true;
            this.metroTextBoxJMBG.Size = new System.Drawing.Size(223, 23);
            this.metroTextBoxJMBG.TabIndex = 38;
            this.metroTextBoxJMBG.UseSelectable = true;
            this.metroTextBoxJMBG.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxJMBG.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(70, 291);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(31, 19);
            this.metroLabel2.TabIndex = 46;
            this.metroLabel2.Text = "Ime";
            // 
            // metroTextBoxSrednjeSlovo
            // 
            // 
            // 
            // 
            this.metroTextBoxSrednjeSlovo.CustomButton.Image = null;
            this.metroTextBoxSrednjeSlovo.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.metroTextBoxSrednjeSlovo.CustomButton.Name = "";
            this.metroTextBoxSrednjeSlovo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxSrednjeSlovo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxSrednjeSlovo.CustomButton.TabIndex = 1;
            this.metroTextBoxSrednjeSlovo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxSrednjeSlovo.CustomButton.UseSelectable = true;
            this.metroTextBoxSrednjeSlovo.CustomButton.Visible = false;
            this.metroTextBoxSrednjeSlovo.Lines = new string[0];
            this.metroTextBoxSrednjeSlovo.Location = new System.Drawing.Point(555, 256);
            this.metroTextBoxSrednjeSlovo.MaxLength = 32767;
            this.metroTextBoxSrednjeSlovo.Name = "metroTextBoxSrednjeSlovo";
            this.metroTextBoxSrednjeSlovo.PasswordChar = '\0';
            this.metroTextBoxSrednjeSlovo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSrednjeSlovo.SelectedText = "";
            this.metroTextBoxSrednjeSlovo.SelectionLength = 0;
            this.metroTextBoxSrednjeSlovo.SelectionStart = 0;
            this.metroTextBoxSrednjeSlovo.ShortcutsEnabled = true;
            this.metroTextBoxSrednjeSlovo.Size = new System.Drawing.Size(223, 23);
            this.metroTextBoxSrednjeSlovo.TabIndex = 39;
            this.metroTextBoxSrednjeSlovo.UseSelectable = true;
            this.metroTextBoxSrednjeSlovo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxSrednjeSlovo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroDateTimeDatumRodjenja
            // 
            this.metroDateTimeDatumRodjenja.CustomFormat = "yyyy-MM-dd";
            this.metroDateTimeDatumRodjenja.Location = new System.Drawing.Point(555, 349);
            this.metroDateTimeDatumRodjenja.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimeDatumRodjenja.Name = "metroDateTimeDatumRodjenja";
            this.metroDateTimeDatumRodjenja.Size = new System.Drawing.Size(223, 29);
            this.metroDateTimeDatumRodjenja.TabIndex = 45;
            // 
            // metroTextBoxIme
            // 
            // 
            // 
            // 
            this.metroTextBoxIme.CustomButton.Image = null;
            this.metroTextBoxIme.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.metroTextBoxIme.CustomButton.Name = "";
            this.metroTextBoxIme.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxIme.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxIme.CustomButton.TabIndex = 1;
            this.metroTextBoxIme.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxIme.CustomButton.UseSelectable = true;
            this.metroTextBoxIme.CustomButton.Visible = false;
            this.metroTextBoxIme.Lines = new string[0];
            this.metroTextBoxIme.Location = new System.Drawing.Point(148, 291);
            this.metroTextBoxIme.MaxLength = 32767;
            this.metroTextBoxIme.Name = "metroTextBoxIme";
            this.metroTextBoxIme.PasswordChar = '\0';
            this.metroTextBoxIme.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxIme.SelectedText = "";
            this.metroTextBoxIme.SelectionLength = 0;
            this.metroTextBoxIme.SelectionStart = 0;
            this.metroTextBoxIme.ShortcutsEnabled = true;
            this.metroTextBoxIme.Size = new System.Drawing.Size(223, 23);
            this.metroTextBoxIme.TabIndex = 40;
            this.metroTextBoxIme.UseSelectable = true;
            this.metroTextBoxIme.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxIme.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxPrezime
            // 
            // 
            // 
            // 
            this.metroTextBoxPrezime.CustomButton.Image = null;
            this.metroTextBoxPrezime.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.metroTextBoxPrezime.CustomButton.Name = "";
            this.metroTextBoxPrezime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxPrezime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPrezime.CustomButton.TabIndex = 1;
            this.metroTextBoxPrezime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPrezime.CustomButton.UseSelectable = true;
            this.metroTextBoxPrezime.CustomButton.Visible = false;
            this.metroTextBoxPrezime.Lines = new string[0];
            this.metroTextBoxPrezime.Location = new System.Drawing.Point(148, 323);
            this.metroTextBoxPrezime.MaxLength = 32767;
            this.metroTextBoxPrezime.Name = "metroTextBoxPrezime";
            this.metroTextBoxPrezime.PasswordChar = '\0';
            this.metroTextBoxPrezime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPrezime.SelectedText = "";
            this.metroTextBoxPrezime.SelectionLength = 0;
            this.metroTextBoxPrezime.SelectionStart = 0;
            this.metroTextBoxPrezime.ShortcutsEnabled = true;
            this.metroTextBoxPrezime.Size = new System.Drawing.Size(223, 23);
            this.metroTextBoxPrezime.TabIndex = 41;
            this.metroTextBoxPrezime.UseSelectable = true;
            this.metroTextBoxPrezime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPrezime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxLozinka
            // 
            // 
            // 
            // 
            this.metroTextBoxLozinka.CustomButton.Image = null;
            this.metroTextBoxLozinka.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.metroTextBoxLozinka.CustomButton.Name = "";
            this.metroTextBoxLozinka.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxLozinka.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxLozinka.CustomButton.TabIndex = 1;
            this.metroTextBoxLozinka.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxLozinka.CustomButton.UseSelectable = true;
            this.metroTextBoxLozinka.CustomButton.Visible = false;
            this.metroTextBoxLozinka.Lines = new string[0];
            this.metroTextBoxLozinka.Location = new System.Drawing.Point(148, 355);
            this.metroTextBoxLozinka.MaxLength = 32767;
            this.metroTextBoxLozinka.Name = "metroTextBoxLozinka";
            this.metroTextBoxLozinka.PasswordChar = '\0';
            this.metroTextBoxLozinka.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxLozinka.SelectedText = "";
            this.metroTextBoxLozinka.SelectionLength = 0;
            this.metroTextBoxLozinka.SelectionStart = 0;
            this.metroTextBoxLozinka.ShortcutsEnabled = true;
            this.metroTextBoxLozinka.Size = new System.Drawing.Size(223, 23);
            this.metroTextBoxLozinka.TabIndex = 42;
            this.metroTextBoxLozinka.UseSelectable = true;
            this.metroTextBoxLozinka.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxLozinka.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonSmenaLekara
            // 
            this.metroButtonSmenaLekara.Location = new System.Drawing.Point(555, 291);
            this.metroButtonSmenaLekara.Name = "metroButtonSmenaLekara";
            this.metroButtonSmenaLekara.Size = new System.Drawing.Size(223, 43);
            this.metroButtonSmenaLekara.TabIndex = 52;
            this.metroButtonSmenaLekara.Text = "Pregled / Unos smene";
            this.metroButtonSmenaLekara.UseSelectable = true;
            this.metroButtonSmenaLekara.Click += new System.EventHandler(this.metroButtonSmenaLekara_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(70, 404);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(330, 19);
            this.metroLabel8.TabIndex = 53;
            this.metroLabel8.Text = "Odaberite lekara/osobu za brisanje/ažuriranje iz tabele";
            // 
            // metroTabPageZahteviPacijenata
            // 
            this.metroTabPageZahteviPacijenata.Controls.Add(this.metroButtonZahteviPacijenata);
            this.metroTabPageZahteviPacijenata.HorizontalScrollbarBarColor = true;
            this.metroTabPageZahteviPacijenata.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageZahteviPacijenata.HorizontalScrollbarSize = 10;
            this.metroTabPageZahteviPacijenata.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageZahteviPacijenata.Name = "metroTabPageZahteviPacijenata";
            this.metroTabPageZahteviPacijenata.Size = new System.Drawing.Size(841, 126);
            this.metroTabPageZahteviPacijenata.TabIndex = 2;
            this.metroTabPageZahteviPacijenata.Text = "Podaci o zahtevima za promenu lekara";
            this.metroTabPageZahteviPacijenata.VerticalScrollbarBarColor = true;
            this.metroTabPageZahteviPacijenata.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageZahteviPacijenata.VerticalScrollbarSize = 10;
            // 
            // metroButtonZahteviPacijenata
            // 
            this.metroButtonZahteviPacijenata.Location = new System.Drawing.Point(0, 18);
            this.metroButtonZahteviPacijenata.Name = "metroButtonZahteviPacijenata";
            this.metroButtonZahteviPacijenata.Size = new System.Drawing.Size(833, 23);
            this.metroButtonZahteviPacijenata.TabIndex = 2;
            this.metroButtonZahteviPacijenata.Text = "Prikaži zahteve pacijenata";
            this.metroButtonZahteviPacijenata.UseSelectable = true;
            this.metroButtonZahteviPacijenata.Click += new System.EventHandler(this.metroButtonZahteviPacijenata_Click);
            // 
            // FormDirektor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 673);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroButtonSmenaLekara);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroGridData);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroTextBoxJMBG);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTextBoxSrednjeSlovo);
            this.Controls.Add(this.metroDateTimeDatumRodjenja);
            this.Controls.Add(this.metroTextBoxIme);
            this.Controls.Add(this.metroTextBoxPrezime);
            this.Controls.Add(this.metroTextBoxLozinka);
            this.Controls.Add(this.lblImeDomaZ);
            this.Controls.Add(this.metroTabControlGlobal);
            this.Name = "FormDirektor";
            this.Text = "Administrator panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDirektor_FormClosing);
            this.metroTabControlGlobal.ResumeLayout(false);
            this.tabLekar.ResumeLayout(false);
            this.metroTabControl2.ResumeLayout(false);
            this.tabLeakrBrisanje.ResumeLayout(false);
            this.tabLekarUnos.ResumeLayout(false);
            this.tabLekarAzuriranje.ResumeLayout(false);
            this.tabOsoblje.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridData)).EndInit();
            this.metroTabPageZahteviPacijenata.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControlGlobal;
        private MetroFramework.Controls.MetroTabPage tabLekar;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage tabLeakrBrisanje;
        private MetroFramework.Controls.MetroTabPage tabLekarUnos;
        private MetroFramework.Controls.MetroTabPage tabLekarAzuriranje;
        private MetroFramework.Controls.MetroTabPage tabOsoblje;
        private MetroFramework.Controls.MetroLabel lblImeDomaZ;
        private MetroFramework.Controls.MetroButton metroButtonObrisiLekara;
        private MetroFramework.Controls.MetroButton metroButtonUnesiteLekara;
        private MetroFramework.Controls.MetroButton metroButtonAzurirajLekara;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroGrid metroGridData;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBoxJMBG;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSrednjeSlovo;
        private MetroFramework.Controls.MetroDateTime metroDateTimeDatumRodjenja;
        private MetroFramework.Controls.MetroTextBox metroTextBoxIme;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPrezime;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLozinka;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton metroButtonObrisiOsobu;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton metroButtonUnesiOsobu;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton metroButtonAzurirajOsobu;
        private MetroFramework.Controls.MetroButton metroButtonSmenaLekara;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTabPage metroTabPageZahteviPacijenata;
        private MetroFramework.Controls.MetroButton metroButtonZahteviPacijenata;
    }
}