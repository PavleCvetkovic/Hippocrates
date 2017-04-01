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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabLekar = new MetroFramework.Controls.MetroTabPage();
            this.metroGridLekari = new MetroFramework.Controls.MetroGrid();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.tabLeakrBrisanje = new MetroFramework.Controls.MetroTabPage();
            this.metroButtonObrisiLekara = new MetroFramework.Controls.MetroButton();
            this.tabLekarUnos = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTimeDatumRodjenja = new MetroFramework.Controls.MetroDateTime();
            this.metroRadioButtonSmenaPoslepodne = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButtonSmenaPrepodne = new MetroFramework.Controls.MetroRadioButton();
            this.metroButtonUnesiteLekara = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxLozinka = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPrezime = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxIme = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxSrednjeSlovo = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxJMBG = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabLekarAzuriranje = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroButtonAzurirajLekara = new MetroFramework.Controls.MetroButton();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox6 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox7 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox8 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox9 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.tabOsoblje = new MetroFramework.Controls.MetroTabPage();
            this.lblImeDomaZ = new MetroFramework.Controls.MetroLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroTabControl1.SuspendLayout();
            this.tabLekar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridLekari)).BeginInit();
            this.metroTabControl2.SuspendLayout();
            this.tabLeakrBrisanje.SuspendLayout();
            this.tabLekarUnos.SuspendLayout();
            this.tabLekarAzuriranje.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabLekar);
            this.metroTabControl1.Controls.Add(this.tabOsoblje);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 72);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(849, 578);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabLekar
            // 
            this.tabLekar.Controls.Add(this.metroGridLekari);
            this.tabLekar.Controls.Add(this.metroTabControl2);
            this.tabLekar.HorizontalScrollbarBarColor = true;
            this.tabLekar.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLekar.HorizontalScrollbarSize = 10;
            this.tabLekar.Location = new System.Drawing.Point(4, 38);
            this.tabLekar.Name = "tabLekar";
            this.tabLekar.Size = new System.Drawing.Size(841, 536);
            this.tabLekar.TabIndex = 0;
            this.tabLekar.Text = "Podaci o lekarima";
            this.tabLekar.VerticalScrollbarBarColor = true;
            this.tabLekar.VerticalScrollbarHighlightOnWheel = false;
            this.tabLekar.VerticalScrollbarSize = 10;
            // 
            // metroGridLekari
            // 
            this.metroGridLekari.AllowUserToResizeRows = false;
            this.metroGridLekari.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridLekari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridLekari.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridLekari.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridLekari.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.metroGridLekari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridLekari.DefaultCellStyle = dataGridViewCellStyle23;
            this.metroGridLekari.EnableHeadersVisualStyles = false;
            this.metroGridLekari.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridLekari.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridLekari.Location = new System.Drawing.Point(7, 265);
            this.metroGridLekari.Name = "metroGridLekari";
            this.metroGridLekari.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridLekari.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.metroGridLekari.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridLekari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridLekari.Size = new System.Drawing.Size(831, 221);
            this.metroGridLekari.TabIndex = 3;
            this.metroGridLekari.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridLekari_CellContentClick);
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.tabLeakrBrisanje);
            this.metroTabControl2.Controls.Add(this.tabLekarUnos);
            this.metroTabControl2.Controls.Add(this.tabLekarAzuriranje);
            this.metroTabControl2.Location = new System.Drawing.Point(3, 4);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 1;
            this.metroTabControl2.Size = new System.Drawing.Size(842, 275);
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
            this.tabLeakrBrisanje.Size = new System.Drawing.Size(834, 233);
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
            // 
            // tabLekarUnos
            // 
            this.tabLekarUnos.Controls.Add(this.metroLabel7);
            this.tabLekarUnos.Controls.Add(this.metroLabel6);
            this.tabLekarUnos.Controls.Add(this.metroLabel5);
            this.tabLekarUnos.Controls.Add(this.metroLabel4);
            this.tabLekarUnos.Controls.Add(this.metroLabel3);
            this.tabLekarUnos.Controls.Add(this.metroLabel2);
            this.tabLekarUnos.Controls.Add(this.metroDateTimeDatumRodjenja);
            this.tabLekarUnos.Controls.Add(this.metroRadioButtonSmenaPoslepodne);
            this.tabLekarUnos.Controls.Add(this.metroRadioButtonSmenaPrepodne);
            this.tabLekarUnos.Controls.Add(this.metroButtonUnesiteLekara);
            this.tabLekarUnos.Controls.Add(this.metroTextBoxLozinka);
            this.tabLekarUnos.Controls.Add(this.metroTextBoxPrezime);
            this.tabLekarUnos.Controls.Add(this.metroTextBoxIme);
            this.tabLekarUnos.Controls.Add(this.metroTextBoxSrednjeSlovo);
            this.tabLekarUnos.Controls.Add(this.metroTextBoxJMBG);
            this.tabLekarUnos.Controls.Add(this.metroLabel1);
            this.tabLekarUnos.HorizontalScrollbarBarColor = true;
            this.tabLekarUnos.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLekarUnos.HorizontalScrollbarSize = 10;
            this.tabLekarUnos.Location = new System.Drawing.Point(4, 38);
            this.tabLekarUnos.Name = "tabLekarUnos";
            this.tabLekarUnos.Size = new System.Drawing.Size(834, 233);
            this.tabLekarUnos.TabIndex = 1;
            this.tabLekarUnos.Text = "Unošenje podataka o novom lekaru";
            this.tabLekarUnos.VerticalScrollbarBarColor = true;
            this.tabLekarUnos.VerticalScrollbarHighlightOnWheel = false;
            this.tabLekarUnos.VerticalScrollbarSize = 10;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(354, 95);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(97, 19);
            this.metroLabel7.TabIndex = 35;
            this.metroLabel7.Text = "Datum rođenja";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(354, 56);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(49, 19);
            this.metroLabel6.TabIndex = 34;
            this.metroLabel6.Text = "Smena";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(354, 21);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(87, 19);
            this.metroLabel5.TabIndex = 33;
            this.metroLabel5.Text = "Srednje slovo";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 120);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(52, 19);
            this.metroLabel4.TabIndex = 32;
            this.metroLabel4.Text = "Lozinka";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(0, 88);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(57, 19);
            this.metroLabel3.TabIndex = 31;
            this.metroLabel3.Text = "Prezime";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 56);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(31, 19);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Ime";
            // 
            // metroDateTimeDatumRodjenja
            // 
            this.metroDateTimeDatumRodjenja.CustomFormat = "yyyy-MM-dd";
            this.metroDateTimeDatumRodjenja.Location = new System.Drawing.Point(488, 95);
            this.metroDateTimeDatumRodjenja.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimeDatumRodjenja.Name = "metroDateTimeDatumRodjenja";
            this.metroDateTimeDatumRodjenja.Size = new System.Drawing.Size(200, 29);
            this.metroDateTimeDatumRodjenja.TabIndex = 29;
            // 
            // metroRadioButtonSmenaPoslepodne
            // 
            this.metroRadioButtonSmenaPoslepodne.AutoSize = true;
            this.metroRadioButtonSmenaPoslepodne.Location = new System.Drawing.Point(626, 64);
            this.metroRadioButtonSmenaPoslepodne.Name = "metroRadioButtonSmenaPoslepodne";
            this.metroRadioButtonSmenaPoslepodne.Size = new System.Drawing.Size(85, 15);
            this.metroRadioButtonSmenaPoslepodne.TabIndex = 28;
            this.metroRadioButtonSmenaPoslepodne.Text = "Poslepodne";
            this.metroRadioButtonSmenaPoslepodne.UseSelectable = true;
            // 
            // metroRadioButtonSmenaPrepodne
            // 
            this.metroRadioButtonSmenaPrepodne.AutoSize = true;
            this.metroRadioButtonSmenaPrepodne.Location = new System.Drawing.Point(488, 64);
            this.metroRadioButtonSmenaPrepodne.Name = "metroRadioButtonSmenaPrepodne";
            this.metroRadioButtonSmenaPrepodne.Size = new System.Drawing.Size(74, 15);
            this.metroRadioButtonSmenaPrepodne.TabIndex = 27;
            this.metroRadioButtonSmenaPrepodne.Text = "Prepodne";
            this.metroRadioButtonSmenaPrepodne.UseSelectable = true;
            // 
            // metroButtonUnesiteLekara
            // 
            this.metroButtonUnesiteLekara.Location = new System.Drawing.Point(0, 194);
            this.metroButtonUnesiteLekara.Name = "metroButtonUnesiteLekara";
            this.metroButtonUnesiteLekara.Size = new System.Drawing.Size(833, 23);
            this.metroButtonUnesiteLekara.TabIndex = 26;
            this.metroButtonUnesiteLekara.Text = "Unesite lekara";
            this.metroButtonUnesiteLekara.UseSelectable = true;
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
            this.metroTextBoxLozinka.Location = new System.Drawing.Point(81, 120);
            this.metroTextBoxLozinka.MaxLength = 32767;
            this.metroTextBoxLozinka.Name = "metroTextBoxLozinka";
            this.metroTextBoxLozinka.PasswordChar = '\0';
            this.metroTextBoxLozinka.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxLozinka.SelectedText = "";
            this.metroTextBoxLozinka.SelectionLength = 0;
            this.metroTextBoxLozinka.SelectionStart = 0;
            this.metroTextBoxLozinka.ShortcutsEnabled = true;
            this.metroTextBoxLozinka.Size = new System.Drawing.Size(223, 23);
            this.metroTextBoxLozinka.TabIndex = 25;
            this.metroTextBoxLozinka.UseSelectable = true;
            this.metroTextBoxLozinka.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxLozinka.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.metroTextBoxPrezime.Location = new System.Drawing.Point(81, 88);
            this.metroTextBoxPrezime.MaxLength = 32767;
            this.metroTextBoxPrezime.Name = "metroTextBoxPrezime";
            this.metroTextBoxPrezime.PasswordChar = '\0';
            this.metroTextBoxPrezime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPrezime.SelectedText = "";
            this.metroTextBoxPrezime.SelectionLength = 0;
            this.metroTextBoxPrezime.SelectionStart = 0;
            this.metroTextBoxPrezime.ShortcutsEnabled = true;
            this.metroTextBoxPrezime.Size = new System.Drawing.Size(223, 23);
            this.metroTextBoxPrezime.TabIndex = 24;
            this.metroTextBoxPrezime.UseSelectable = true;
            this.metroTextBoxPrezime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPrezime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.metroTextBoxIme.Location = new System.Drawing.Point(81, 56);
            this.metroTextBoxIme.MaxLength = 32767;
            this.metroTextBoxIme.Name = "metroTextBoxIme";
            this.metroTextBoxIme.PasswordChar = '\0';
            this.metroTextBoxIme.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxIme.SelectedText = "";
            this.metroTextBoxIme.SelectionLength = 0;
            this.metroTextBoxIme.SelectionStart = 0;
            this.metroTextBoxIme.ShortcutsEnabled = true;
            this.metroTextBoxIme.Size = new System.Drawing.Size(223, 23);
            this.metroTextBoxIme.TabIndex = 23;
            this.metroTextBoxIme.UseSelectable = true;
            this.metroTextBoxIme.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxIme.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.metroTextBoxSrednjeSlovo.Location = new System.Drawing.Point(488, 21);
            this.metroTextBoxSrednjeSlovo.MaxLength = 32767;
            this.metroTextBoxSrednjeSlovo.Name = "metroTextBoxSrednjeSlovo";
            this.metroTextBoxSrednjeSlovo.PasswordChar = '\0';
            this.metroTextBoxSrednjeSlovo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSrednjeSlovo.SelectedText = "";
            this.metroTextBoxSrednjeSlovo.SelectionLength = 0;
            this.metroTextBoxSrednjeSlovo.SelectionStart = 0;
            this.metroTextBoxSrednjeSlovo.ShortcutsEnabled = true;
            this.metroTextBoxSrednjeSlovo.Size = new System.Drawing.Size(223, 23);
            this.metroTextBoxSrednjeSlovo.TabIndex = 22;
            this.metroTextBoxSrednjeSlovo.UseSelectable = true;
            this.metroTextBoxSrednjeSlovo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxSrednjeSlovo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.metroTextBoxJMBG.Location = new System.Drawing.Point(81, 21);
            this.metroTextBoxJMBG.MaxLength = 32767;
            this.metroTextBoxJMBG.Name = "metroTextBoxJMBG";
            this.metroTextBoxJMBG.PasswordChar = '\0';
            this.metroTextBoxJMBG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxJMBG.SelectedText = "";
            this.metroTextBoxJMBG.SelectionLength = 0;
            this.metroTextBoxJMBG.SelectionStart = 0;
            this.metroTextBoxJMBG.ShortcutsEnabled = true;
            this.metroTextBoxJMBG.Size = new System.Drawing.Size(223, 23);
            this.metroTextBoxJMBG.TabIndex = 21;
            this.metroTextBoxJMBG.UseSelectable = true;
            this.metroTextBoxJMBG.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxJMBG.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "JMBG";
            // 
            // tabLekarAzuriranje
            // 
            this.tabLekarAzuriranje.Controls.Add(this.metroLabel8);
            this.tabLekarAzuriranje.Controls.Add(this.metroLabel9);
            this.tabLekarAzuriranje.Controls.Add(this.metroLabel10);
            this.tabLekarAzuriranje.Controls.Add(this.metroLabel11);
            this.tabLekarAzuriranje.Controls.Add(this.metroLabel12);
            this.tabLekarAzuriranje.Controls.Add(this.metroLabel13);
            this.tabLekarAzuriranje.Controls.Add(this.metroDateTime2);
            this.tabLekarAzuriranje.Controls.Add(this.metroRadioButton1);
            this.tabLekarAzuriranje.Controls.Add(this.metroRadioButton2);
            this.tabLekarAzuriranje.Controls.Add(this.metroButtonAzurirajLekara);
            this.tabLekarAzuriranje.Controls.Add(this.metroTextBox5);
            this.tabLekarAzuriranje.Controls.Add(this.metroTextBox6);
            this.tabLekarAzuriranje.Controls.Add(this.metroTextBox7);
            this.tabLekarAzuriranje.Controls.Add(this.metroTextBox8);
            this.tabLekarAzuriranje.Controls.Add(this.metroTextBox9);
            this.tabLekarAzuriranje.Controls.Add(this.metroLabel14);
            this.tabLekarAzuriranje.HorizontalScrollbarBarColor = true;
            this.tabLekarAzuriranje.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLekarAzuriranje.HorizontalScrollbarSize = 10;
            this.tabLekarAzuriranje.Location = new System.Drawing.Point(4, 38);
            this.tabLekarAzuriranje.Name = "tabLekarAzuriranje";
            this.tabLekarAzuriranje.Size = new System.Drawing.Size(834, 233);
            this.tabLekarAzuriranje.TabIndex = 2;
            this.tabLekarAzuriranje.Text = "Ažuriranje podataka o lekaru";
            this.tabLekarAzuriranje.VerticalScrollbarBarColor = true;
            this.tabLekarAzuriranje.VerticalScrollbarHighlightOnWheel = false;
            this.tabLekarAzuriranje.VerticalScrollbarSize = 10;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(354, 95);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(97, 19);
            this.metroLabel8.TabIndex = 51;
            this.metroLabel8.Text = "Datum rođenja";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(354, 56);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(49, 19);
            this.metroLabel9.TabIndex = 50;
            this.metroLabel9.Text = "Smena";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(354, 21);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(87, 19);
            this.metroLabel10.TabIndex = 49;
            this.metroLabel10.Text = "Srednje slovo";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(3, 120);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(52, 19);
            this.metroLabel11.TabIndex = 48;
            this.metroLabel11.Text = "Lozinka";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(0, 88);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(57, 19);
            this.metroLabel12.TabIndex = 47;
            this.metroLabel12.Text = "Prezime";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(3, 56);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(31, 19);
            this.metroLabel13.TabIndex = 46;
            this.metroLabel13.Text = "Ime";
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Location = new System.Drawing.Point(488, 95);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime2.TabIndex = 45;
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(626, 64);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(85, 15);
            this.metroRadioButton1.TabIndex = 44;
            this.metroRadioButton1.Text = "Poslepodne";
            this.metroRadioButton1.UseSelectable = true;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(488, 64);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(74, 15);
            this.metroRadioButton2.TabIndex = 43;
            this.metroRadioButton2.Text = "Prepodne";
            this.metroRadioButton2.UseSelectable = true;
            // 
            // metroButtonAzurirajLekara
            // 
            this.metroButtonAzurirajLekara.Location = new System.Drawing.Point(0, 194);
            this.metroButtonAzurirajLekara.Name = "metroButtonAzurirajLekara";
            this.metroButtonAzurirajLekara.Size = new System.Drawing.Size(833, 23);
            this.metroButtonAzurirajLekara.TabIndex = 42;
            this.metroButtonAzurirajLekara.Text = "Ažurirajte lekara";
            this.metroButtonAzurirajLekara.UseSelectable = true;
            // 
            // metroTextBox5
            // 
            // 
            // 
            // 
            this.metroTextBox5.CustomButton.Image = null;
            this.metroTextBox5.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.metroTextBox5.CustomButton.Name = "";
            this.metroTextBox5.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox5.CustomButton.TabIndex = 1;
            this.metroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox5.CustomButton.UseSelectable = true;
            this.metroTextBox5.CustomButton.Visible = false;
            this.metroTextBox5.Lines = new string[0];
            this.metroTextBox5.Location = new System.Drawing.Point(81, 120);
            this.metroTextBox5.MaxLength = 32767;
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.PasswordChar = '\0';
            this.metroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox5.SelectedText = "";
            this.metroTextBox5.SelectionLength = 0;
            this.metroTextBox5.SelectionStart = 0;
            this.metroTextBox5.ShortcutsEnabled = true;
            this.metroTextBox5.Size = new System.Drawing.Size(223, 23);
            this.metroTextBox5.TabIndex = 41;
            this.metroTextBox5.UseSelectable = true;
            this.metroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox6
            // 
            // 
            // 
            // 
            this.metroTextBox6.CustomButton.Image = null;
            this.metroTextBox6.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.metroTextBox6.CustomButton.Name = "";
            this.metroTextBox6.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox6.CustomButton.TabIndex = 1;
            this.metroTextBox6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox6.CustomButton.UseSelectable = true;
            this.metroTextBox6.CustomButton.Visible = false;
            this.metroTextBox6.Lines = new string[0];
            this.metroTextBox6.Location = new System.Drawing.Point(81, 88);
            this.metroTextBox6.MaxLength = 32767;
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.PasswordChar = '\0';
            this.metroTextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox6.SelectedText = "";
            this.metroTextBox6.SelectionLength = 0;
            this.metroTextBox6.SelectionStart = 0;
            this.metroTextBox6.ShortcutsEnabled = true;
            this.metroTextBox6.Size = new System.Drawing.Size(223, 23);
            this.metroTextBox6.TabIndex = 40;
            this.metroTextBox6.UseSelectable = true;
            this.metroTextBox6.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox6.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox7
            // 
            // 
            // 
            // 
            this.metroTextBox7.CustomButton.Image = null;
            this.metroTextBox7.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.metroTextBox7.CustomButton.Name = "";
            this.metroTextBox7.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox7.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox7.CustomButton.TabIndex = 1;
            this.metroTextBox7.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox7.CustomButton.UseSelectable = true;
            this.metroTextBox7.CustomButton.Visible = false;
            this.metroTextBox7.Lines = new string[0];
            this.metroTextBox7.Location = new System.Drawing.Point(81, 56);
            this.metroTextBox7.MaxLength = 32767;
            this.metroTextBox7.Name = "metroTextBox7";
            this.metroTextBox7.PasswordChar = '\0';
            this.metroTextBox7.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox7.SelectedText = "";
            this.metroTextBox7.SelectionLength = 0;
            this.metroTextBox7.SelectionStart = 0;
            this.metroTextBox7.ShortcutsEnabled = true;
            this.metroTextBox7.Size = new System.Drawing.Size(223, 23);
            this.metroTextBox7.TabIndex = 39;
            this.metroTextBox7.UseSelectable = true;
            this.metroTextBox7.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox7.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox8
            // 
            // 
            // 
            // 
            this.metroTextBox8.CustomButton.Image = null;
            this.metroTextBox8.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.metroTextBox8.CustomButton.Name = "";
            this.metroTextBox8.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox8.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox8.CustomButton.TabIndex = 1;
            this.metroTextBox8.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox8.CustomButton.UseSelectable = true;
            this.metroTextBox8.CustomButton.Visible = false;
            this.metroTextBox8.Lines = new string[0];
            this.metroTextBox8.Location = new System.Drawing.Point(488, 21);
            this.metroTextBox8.MaxLength = 32767;
            this.metroTextBox8.Name = "metroTextBox8";
            this.metroTextBox8.PasswordChar = '\0';
            this.metroTextBox8.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox8.SelectedText = "";
            this.metroTextBox8.SelectionLength = 0;
            this.metroTextBox8.SelectionStart = 0;
            this.metroTextBox8.ShortcutsEnabled = true;
            this.metroTextBox8.Size = new System.Drawing.Size(223, 23);
            this.metroTextBox8.TabIndex = 38;
            this.metroTextBox8.UseSelectable = true;
            this.metroTextBox8.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox8.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox9
            // 
            // 
            // 
            // 
            this.metroTextBox9.CustomButton.Image = null;
            this.metroTextBox9.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.metroTextBox9.CustomButton.Name = "";
            this.metroTextBox9.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox9.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox9.CustomButton.TabIndex = 1;
            this.metroTextBox9.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox9.CustomButton.UseSelectable = true;
            this.metroTextBox9.CustomButton.Visible = false;
            this.metroTextBox9.Lines = new string[0];
            this.metroTextBox9.Location = new System.Drawing.Point(81, 21);
            this.metroTextBox9.MaxLength = 32767;
            this.metroTextBox9.Name = "metroTextBox9";
            this.metroTextBox9.PasswordChar = '\0';
            this.metroTextBox9.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox9.SelectedText = "";
            this.metroTextBox9.SelectionLength = 0;
            this.metroTextBox9.SelectionStart = 0;
            this.metroTextBox9.ShortcutsEnabled = true;
            this.metroTextBox9.Size = new System.Drawing.Size(223, 23);
            this.metroTextBox9.TabIndex = 37;
            this.metroTextBox9.UseSelectable = true;
            this.metroTextBox9.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox9.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(3, 21);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(43, 19);
            this.metroLabel14.TabIndex = 36;
            this.metroLabel14.Text = "JMBG";
            // 
            // tabOsoblje
            // 
            this.tabOsoblje.HorizontalScrollbarBarColor = true;
            this.tabOsoblje.HorizontalScrollbarHighlightOnWheel = false;
            this.tabOsoblje.HorizontalScrollbarSize = 10;
            this.tabOsoblje.Location = new System.Drawing.Point(4, 38);
            this.tabOsoblje.Name = "tabOsoblje";
            this.tabOsoblje.Size = new System.Drawing.Size(841, 536);
            this.tabOsoblje.TabIndex = 1;
            this.tabOsoblje.Text = "Podaci o osoblju";
            this.tabOsoblje.VerticalScrollbarBarColor = true;
            this.tabOsoblje.VerticalScrollbarHighlightOnWheel = false;
            this.tabOsoblje.VerticalScrollbarSize = 10;
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
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "Text to show";
            this.notifyIcon1.Visible = true;
            // 
            // FormDirektor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 673);
            this.Controls.Add(this.lblImeDomaZ);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "FormDirektor";
            this.Text = "Administrator panel";
            this.metroTabControl1.ResumeLayout(false);
            this.tabLekar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridLekari)).EndInit();
            this.metroTabControl2.ResumeLayout(false);
            this.tabLeakrBrisanje.ResumeLayout(false);
            this.tabLekarUnos.ResumeLayout(false);
            this.tabLekarUnos.PerformLayout();
            this.tabLekarAzuriranje.ResumeLayout(false);
            this.tabLekarAzuriranje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabLekar;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage tabLeakrBrisanje;
        private MetroFramework.Controls.MetroTabPage tabLekarUnos;
        private MetroFramework.Controls.MetroTabPage tabLekarAzuriranje;
        private MetroFramework.Controls.MetroTabPage tabOsoblje;
        private MetroFramework.Controls.MetroLabel lblImeDomaZ;
        private MetroFramework.Controls.MetroGrid metroGridLekari;
        private MetroFramework.Controls.MetroButton metroButtonObrisiLekara;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime metroDateTimeDatumRodjenja;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonSmenaPoslepodne;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonSmenaPrepodne;
        private MetroFramework.Controls.MetroButton metroButtonUnesiteLekara;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLozinka;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPrezime;
        private MetroFramework.Controls.MetroTextBox metroTextBoxIme;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSrednjeSlovo;
        private MetroFramework.Controls.MetroTextBox metroTextBoxJMBG;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroButton metroButtonAzurirajLekara;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroTextBox metroTextBox6;
        private MetroFramework.Controls.MetroTextBox metroTextBox7;
        private MetroFramework.Controls.MetroTextBox metroTextBox8;
        private MetroFramework.Controls.MetroTextBox metroTextBox9;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}