namespace HippocratesDoctor
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.mTabLogin = new MetroFramework.Controls.MetroTabControl();
            this.mTabDirektor = new MetroFramework.Controls.MetroTabPage();
            this.mbtnDirektorSubmit = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.mtbxDirektorSifra = new MetroFramework.Controls.MetroTextBox();
            this.mtbxDirektorJMBG = new MetroFramework.Controls.MetroTextBox();
            this.mTabLekar = new MetroFramework.Controls.MetroTabPage();
            this.mbtnLekarSubmit = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtbxLekarSifra = new MetroFramework.Controls.MetroTextBox();
            this.mtbxLekarJMBG = new MetroFramework.Controls.MetroTextBox();
            this.mTabOsoblje = new MetroFramework.Controls.MetroTabPage();
            this.mbtnOsobljeSubmit = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mtbxOsobljeSifra = new MetroFramework.Controls.MetroTextBox();
            this.mtbxOsobljeJMBG = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.mTabLogin.SuspendLayout();
            this.mTabDirektor.SuspendLayout();
            this.mTabLekar.SuspendLayout();
            this.mTabOsoblje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // mTabLogin
            // 
            this.mTabLogin.Controls.Add(this.mTabDirektor);
            this.mTabLogin.Controls.Add(this.mTabLekar);
            this.mTabLogin.Controls.Add(this.mTabOsoblje);
            this.mTabLogin.Location = new System.Drawing.Point(23, 55);
            this.mTabLogin.Name = "mTabLogin";
            this.mTabLogin.SelectedIndex = 1;
            this.mTabLogin.Size = new System.Drawing.Size(467, 396);
            this.mTabLogin.TabIndex = 0;
            this.mTabLogin.UseSelectable = true;
            // 
            // mTabDirektor
            // 
            this.mTabDirektor.Controls.Add(this.pictureBox1);
            this.mTabDirektor.Controls.Add(this.mbtnDirektorSubmit);
            this.mTabDirektor.Controls.Add(this.metroLabel5);
            this.mTabDirektor.Controls.Add(this.metroLabel6);
            this.mTabDirektor.Controls.Add(this.mtbxDirektorSifra);
            this.mTabDirektor.Controls.Add(this.mtbxDirektorJMBG);
            this.mTabDirektor.HorizontalScrollbarBarColor = true;
            this.mTabDirektor.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabDirektor.HorizontalScrollbarSize = 10;
            this.mTabDirektor.Location = new System.Drawing.Point(4, 38);
            this.mTabDirektor.Name = "mTabDirektor";
            this.mTabDirektor.Size = new System.Drawing.Size(459, 354);
            this.mTabDirektor.TabIndex = 2;
            this.mTabDirektor.Text = "Administrator";
            this.mTabDirektor.VerticalScrollbarBarColor = true;
            this.mTabDirektor.VerticalScrollbarHighlightOnWheel = false;
            this.mTabDirektor.VerticalScrollbarSize = 10;
            // 
            // mbtnDirektorSubmit
            // 
            this.mbtnDirektorSubmit.Location = new System.Drawing.Point(299, 223);
            this.mbtnDirektorSubmit.Name = "mbtnDirektorSubmit";
            this.mbtnDirektorSubmit.Size = new System.Drawing.Size(75, 23);
            this.mbtnDirektorSubmit.TabIndex = 10;
            this.mbtnDirektorSubmit.Text = "Uloguj se";
            this.mbtnDirektorSubmit.UseSelectable = true;
            this.mbtnDirektorSubmit.Click += new System.EventHandler(this.mbtnDirektorSubmit_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel5.Location = new System.Drawing.Point(313, 139);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(52, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Lozinka";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(313, 46);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(43, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "JMBG";
            // 
            // mtbxDirektorSifra
            // 
            // 
            // 
            // 
            this.mtbxDirektorSifra.CustomButton.Image = null;
            this.mtbxDirektorSifra.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.mtbxDirektorSifra.CustomButton.Name = "";
            this.mtbxDirektorSifra.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbxDirektorSifra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbxDirektorSifra.CustomButton.TabIndex = 1;
            this.mtbxDirektorSifra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbxDirektorSifra.CustomButton.UseSelectable = true;
            this.mtbxDirektorSifra.CustomButton.Visible = false;
            this.mtbxDirektorSifra.Lines = new string[] {
        "12345"};
            this.mtbxDirektorSifra.Location = new System.Drawing.Point(254, 180);
            this.mtbxDirektorSifra.MaxLength = 32767;
            this.mtbxDirektorSifra.Name = "mtbxDirektorSifra";
            this.mtbxDirektorSifra.PasswordChar = '●';
            this.mtbxDirektorSifra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbxDirektorSifra.SelectedText = "";
            this.mtbxDirektorSifra.SelectionLength = 0;
            this.mtbxDirektorSifra.SelectionStart = 0;
            this.mtbxDirektorSifra.ShortcutsEnabled = true;
            this.mtbxDirektorSifra.Size = new System.Drawing.Size(166, 23);
            this.mtbxDirektorSifra.TabIndex = 7;
            this.mtbxDirektorSifra.Text = "12345";
            this.mtbxDirektorSifra.UseSelectable = true;
            this.mtbxDirektorSifra.UseSystemPasswordChar = true;
            this.mtbxDirektorSifra.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbxDirektorSifra.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbxDirektorJMBG
            // 
            // 
            // 
            // 
            this.mtbxDirektorJMBG.CustomButton.Image = null;
            this.mtbxDirektorJMBG.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.mtbxDirektorJMBG.CustomButton.Name = "";
            this.mtbxDirektorJMBG.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbxDirektorJMBG.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbxDirektorJMBG.CustomButton.TabIndex = 1;
            this.mtbxDirektorJMBG.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbxDirektorJMBG.CustomButton.UseSelectable = true;
            this.mtbxDirektorJMBG.CustomButton.Visible = false;
            this.mtbxDirektorJMBG.Lines = new string[] {
        "1236549877899"};
            this.mtbxDirektorJMBG.Location = new System.Drawing.Point(254, 90);
            this.mtbxDirektorJMBG.MaxLength = 32767;
            this.mtbxDirektorJMBG.Name = "mtbxDirektorJMBG";
            this.mtbxDirektorJMBG.PasswordChar = '\0';
            this.mtbxDirektorJMBG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbxDirektorJMBG.SelectedText = "";
            this.mtbxDirektorJMBG.SelectionLength = 0;
            this.mtbxDirektorJMBG.SelectionStart = 0;
            this.mtbxDirektorJMBG.ShortcutsEnabled = true;
            this.mtbxDirektorJMBG.Size = new System.Drawing.Size(166, 23);
            this.mtbxDirektorJMBG.TabIndex = 6;
            this.mtbxDirektorJMBG.Text = "1236549877899";
            this.mtbxDirektorJMBG.UseSelectable = true;
            this.mtbxDirektorJMBG.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbxDirektorJMBG.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTabLekar
            // 
            this.mTabLekar.Controls.Add(this.mtbxLekarJMBG);
            this.mTabLekar.Controls.Add(this.mtbxLekarSifra);
            this.mTabLekar.Controls.Add(this.mbtnLekarSubmit);
            this.mTabLekar.Controls.Add(this.metroLabel2);
            this.mTabLekar.Controls.Add(this.metroLabel1);
            this.mTabLekar.Controls.Add(this.pictureBox2);
            this.mTabLekar.HorizontalScrollbarBarColor = true;
            this.mTabLekar.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabLekar.HorizontalScrollbarSize = 10;
            this.mTabLekar.Location = new System.Drawing.Point(4, 38);
            this.mTabLekar.Name = "mTabLekar";
            this.mTabLekar.Size = new System.Drawing.Size(459, 354);
            this.mTabLekar.TabIndex = 0;
            this.mTabLekar.Text = "Lekar";
            this.mTabLekar.VerticalScrollbarBarColor = true;
            this.mTabLekar.VerticalScrollbarHighlightOnWheel = false;
            this.mTabLekar.VerticalScrollbarSize = 10;
            // 
            // mbtnLekarSubmit
            // 
            this.mbtnLekarSubmit.Location = new System.Drawing.Point(299, 223);
            this.mbtnLekarSubmit.Name = "mbtnLekarSubmit";
            this.mbtnLekarSubmit.Size = new System.Drawing.Size(75, 23);
            this.mbtnLekarSubmit.TabIndex = 6;
            this.mbtnLekarSubmit.Text = "Uloguj se";
            this.mbtnLekarSubmit.UseSelectable = true;
            this.mbtnLekarSubmit.Click += new System.EventHandler(this.mbtnLekarSubmit_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel2.Location = new System.Drawing.Point(313, 139);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Lozinka";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(313, 46);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "JMBG";
            // 
            // mtbxLekarSifra
            // 
            // 
            // 
            // 
            this.mtbxLekarSifra.CustomButton.Image = null;
            this.mtbxLekarSifra.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.mtbxLekarSifra.CustomButton.Name = "";
            this.mtbxLekarSifra.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbxLekarSifra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbxLekarSifra.CustomButton.TabIndex = 1;
            this.mtbxLekarSifra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbxLekarSifra.CustomButton.UseSelectable = true;
            this.mtbxLekarSifra.CustomButton.Visible = false;
            this.mtbxLekarSifra.Lines = new string[] {
        "12345"};
            this.mtbxLekarSifra.Location = new System.Drawing.Point(254, 180);
            this.mtbxLekarSifra.MaxLength = 32767;
            this.mtbxLekarSifra.Name = "mtbxLekarSifra";
            this.mtbxLekarSifra.PasswordChar = '●';
            this.mtbxLekarSifra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbxLekarSifra.SelectedText = "";
            this.mtbxLekarSifra.SelectionLength = 0;
            this.mtbxLekarSifra.SelectionStart = 0;
            this.mtbxLekarSifra.ShortcutsEnabled = true;
            this.mtbxLekarSifra.Size = new System.Drawing.Size(166, 23);
            this.mtbxLekarSifra.TabIndex = 3;
            this.mtbxLekarSifra.Text = "12345";
            this.mtbxLekarSifra.UseSelectable = true;
            this.mtbxLekarSifra.UseSystemPasswordChar = true;
            this.mtbxLekarSifra.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbxLekarSifra.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbxLekarJMBG
            // 
            // 
            // 
            // 
            this.mtbxLekarJMBG.CustomButton.Image = null;
            this.mtbxLekarJMBG.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.mtbxLekarJMBG.CustomButton.Name = "";
            this.mtbxLekarJMBG.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbxLekarJMBG.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbxLekarJMBG.CustomButton.TabIndex = 1;
            this.mtbxLekarJMBG.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbxLekarJMBG.CustomButton.UseSelectable = true;
            this.mtbxLekarJMBG.CustomButton.Visible = false;
            this.mtbxLekarJMBG.Lines = new string[] {
        "0112955445023"};
            this.mtbxLekarJMBG.Location = new System.Drawing.Point(254, 90);
            this.mtbxLekarJMBG.MaxLength = 32767;
            this.mtbxLekarJMBG.Name = "mtbxLekarJMBG";
            this.mtbxLekarJMBG.PasswordChar = '\0';
            this.mtbxLekarJMBG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbxLekarJMBG.SelectedText = "";
            this.mtbxLekarJMBG.SelectionLength = 0;
            this.mtbxLekarJMBG.SelectionStart = 0;
            this.mtbxLekarJMBG.ShortcutsEnabled = true;
            this.mtbxLekarJMBG.Size = new System.Drawing.Size(166, 23);
            this.mtbxLekarJMBG.TabIndex = 2;
            this.mtbxLekarJMBG.Text = "0112955445023";
            this.mtbxLekarJMBG.UseSelectable = true;
            this.mtbxLekarJMBG.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbxLekarJMBG.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTabOsoblje
            // 
            this.mTabOsoblje.Controls.Add(this.pictureBox3);
            this.mTabOsoblje.Controls.Add(this.mbtnOsobljeSubmit);
            this.mTabOsoblje.Controls.Add(this.metroLabel3);
            this.mTabOsoblje.Controls.Add(this.metroLabel4);
            this.mTabOsoblje.Controls.Add(this.mtbxOsobljeSifra);
            this.mTabOsoblje.Controls.Add(this.mtbxOsobljeJMBG);
            this.mTabOsoblje.HorizontalScrollbarBarColor = true;
            this.mTabOsoblje.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabOsoblje.HorizontalScrollbarSize = 10;
            this.mTabOsoblje.Location = new System.Drawing.Point(4, 38);
            this.mTabOsoblje.Name = "mTabOsoblje";
            this.mTabOsoblje.Size = new System.Drawing.Size(459, 354);
            this.mTabOsoblje.TabIndex = 1;
            this.mTabOsoblje.Text = "Medicinsko osoblje";
            this.mTabOsoblje.VerticalScrollbarBarColor = true;
            this.mTabOsoblje.VerticalScrollbarHighlightOnWheel = false;
            this.mTabOsoblje.VerticalScrollbarSize = 10;
            // 
            // mbtnOsobljeSubmit
            // 
            this.mbtnOsobljeSubmit.Location = new System.Drawing.Point(299, 224);
            this.mbtnOsobljeSubmit.Name = "mbtnOsobljeSubmit";
            this.mbtnOsobljeSubmit.Size = new System.Drawing.Size(75, 23);
            this.mbtnOsobljeSubmit.TabIndex = 10;
            this.mbtnOsobljeSubmit.Text = "Uloguj se";
            this.mbtnOsobljeSubmit.UseSelectable = true;
            this.mbtnOsobljeSubmit.Click += new System.EventHandler(this.mbtnOsobljeSubmit_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel3.Location = new System.Drawing.Point(313, 140);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Lozinka";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(313, 47);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "JMBG";
            // 
            // mtbxOsobljeSifra
            // 
            // 
            // 
            // 
            this.mtbxOsobljeSifra.CustomButton.Image = null;
            this.mtbxOsobljeSifra.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.mtbxOsobljeSifra.CustomButton.Name = "";
            this.mtbxOsobljeSifra.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbxOsobljeSifra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbxOsobljeSifra.CustomButton.TabIndex = 1;
            this.mtbxOsobljeSifra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbxOsobljeSifra.CustomButton.UseSelectable = true;
            this.mtbxOsobljeSifra.CustomButton.Visible = false;
            this.mtbxOsobljeSifra.Lines = new string[] {
        "12345"};
            this.mtbxOsobljeSifra.Location = new System.Drawing.Point(254, 181);
            this.mtbxOsobljeSifra.MaxLength = 32767;
            this.mtbxOsobljeSifra.Name = "mtbxOsobljeSifra";
            this.mtbxOsobljeSifra.PasswordChar = '●';
            this.mtbxOsobljeSifra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbxOsobljeSifra.SelectedText = "";
            this.mtbxOsobljeSifra.SelectionLength = 0;
            this.mtbxOsobljeSifra.SelectionStart = 0;
            this.mtbxOsobljeSifra.ShortcutsEnabled = true;
            this.mtbxOsobljeSifra.Size = new System.Drawing.Size(166, 23);
            this.mtbxOsobljeSifra.TabIndex = 7;
            this.mtbxOsobljeSifra.Text = "12345";
            this.mtbxOsobljeSifra.UseSelectable = true;
            this.mtbxOsobljeSifra.UseSystemPasswordChar = true;
            this.mtbxOsobljeSifra.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbxOsobljeSifra.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbxOsobljeJMBG
            // 
            // 
            // 
            // 
            this.mtbxOsobljeJMBG.CustomButton.Image = null;
            this.mtbxOsobljeJMBG.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.mtbxOsobljeJMBG.CustomButton.Name = "";
            this.mtbxOsobljeJMBG.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbxOsobljeJMBG.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbxOsobljeJMBG.CustomButton.TabIndex = 1;
            this.mtbxOsobljeJMBG.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbxOsobljeJMBG.CustomButton.UseSelectable = true;
            this.mtbxOsobljeJMBG.CustomButton.Visible = false;
            this.mtbxOsobljeJMBG.Lines = new string[] {
        "1234567891231"};
            this.mtbxOsobljeJMBG.Location = new System.Drawing.Point(254, 91);
            this.mtbxOsobljeJMBG.MaxLength = 32767;
            this.mtbxOsobljeJMBG.Name = "mtbxOsobljeJMBG";
            this.mtbxOsobljeJMBG.PasswordChar = '\0';
            this.mtbxOsobljeJMBG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbxOsobljeJMBG.SelectedText = "";
            this.mtbxOsobljeJMBG.SelectionLength = 0;
            this.mtbxOsobljeJMBG.SelectionStart = 0;
            this.mtbxOsobljeJMBG.ShortcutsEnabled = true;
            this.mtbxOsobljeJMBG.Size = new System.Drawing.Size(166, 23);
            this.mtbxOsobljeJMBG.TabIndex = 6;
            this.mtbxOsobljeJMBG.Text = "1234567891231";
            this.mtbxOsobljeJMBG.UseSelectable = true;
            this.mtbxOsobljeJMBG.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbxOsobljeJMBG.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::HippocratesDoctor.Properties.Resources.database;
            this.pictureBox1.Location = new System.Drawing.Point(-27, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 383);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-4, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(282, 358);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::HippocratesDoctor.Properties.Resources.nurse;
            this.pictureBox3.Location = new System.Drawing.Point(17, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(220, 355);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 460);
            this.Controls.Add(this.mTabLogin);
            this.Name = "FormLogin";
            this.Text = "Hippocrates";
            this.mTabLogin.ResumeLayout(false);
            this.mTabDirektor.ResumeLayout(false);
            this.mTabDirektor.PerformLayout();
            this.mTabLekar.ResumeLayout(false);
            this.mTabLekar.PerformLayout();
            this.mTabOsoblje.ResumeLayout(false);
            this.mTabOsoblje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mTabLogin;
        private MetroFramework.Controls.MetroTabPage mTabLekar;
        private MetroFramework.Controls.MetroTabPage mTabOsoblje;
        private MetroFramework.Controls.MetroTabPage mTabDirektor;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mtbxLekarSifra;
        private MetroFramework.Controls.MetroTextBox mtbxLekarJMBG;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox mtbxOsobljeSifra;
        private MetroFramework.Controls.MetroTextBox mtbxOsobljeJMBG;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox mtbxDirektorSifra;
        private MetroFramework.Controls.MetroTextBox mtbxDirektorJMBG;
        private MetroFramework.Controls.MetroButton mbtnLekarSubmit;
        private MetroFramework.Controls.MetroButton mbtnOsobljeSubmit;
        private MetroFramework.Controls.MetroButton mbtnDirektorSubmit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

