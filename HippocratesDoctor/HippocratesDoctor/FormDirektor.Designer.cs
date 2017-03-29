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
            this.lblImeDomaZ = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabLekar = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.tabLeakrBrisanje = new MetroFramework.Controls.MetroTabPage();
            this.btn_lekar_brisanje = new System.Windows.Forms.Button();
            this.dGV_lekar_brisanje = new System.Windows.Forms.DataGridView();
            this.tabLekarUnos = new MetroFramework.Controls.MetroTabPage();
            this.cB_smena_lekar_unos_dva = new System.Windows.Forms.CheckBox();
            this.cB_smena_lekar_unos_jeadn = new System.Windows.Forms.CheckBox();
            this.dTP_lekar_unos = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_unos_lekar_srednjeS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_unos_lekar_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_unos_lekar_prezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_unos_lekar_ime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_unos_lekar_jmbg = new System.Windows.Forms.TextBox();
            this.btn_unosenje_lekara = new System.Windows.Forms.Button();
            this.dGV_lekar_unos = new System.Windows.Forms.DataGridView();
            this.tabLekarAzuriranje = new MetroFramework.Controls.MetroTabPage();
            this.btn_azuriranje_lekara = new System.Windows.Forms.Button();
            this.dGV_lekar_azuriranje = new System.Windows.Forms.DataGridView();
            this.cB_lekar_azurirnje_smena_dva = new System.Windows.Forms.CheckBox();
            this.cB_lekar_azurirnje_smena_jedan = new System.Windows.Forms.CheckBox();
            this.dTP_lekar_azuriranje = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_azuriranje_lekar_srednjeS = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_azuriranje_lekar_password = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_azuriranje_lekar_prezime = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_azuriranje_lekar_ime = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_azuriranje_lekar_jmbg = new System.Windows.Forms.TextBox();
            this.tabOsoblje = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1.SuspendLayout();
            this.tabLekar.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.tabLeakrBrisanje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_lekar_brisanje)).BeginInit();
            this.tabLekarUnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_lekar_unos)).BeginInit();
            this.tabLekarAzuriranje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_lekar_azuriranje)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImeDomaZ
            // 
            this.lblImeDomaZ.AutoSize = true;
            this.lblImeDomaZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeDomaZ.Location = new System.Drawing.Point(621, 40);
            this.lblImeDomaZ.Name = "lblImeDomaZ";
            this.lblImeDomaZ.Size = new System.Drawing.Size(57, 20);
            this.lblImeDomaZ.TabIndex = 2;
            this.lblImeDomaZ.Text = "label1";
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
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.tabLeakrBrisanje);
            this.metroTabControl2.Controls.Add(this.tabLekarUnos);
            this.metroTabControl2.Controls.Add(this.tabLekarAzuriranje);
            this.metroTabControl2.Location = new System.Drawing.Point(1, 1);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 1;
            this.metroTabControl2.Size = new System.Drawing.Size(841, 535);
            this.metroTabControl2.TabIndex = 2;
            this.metroTabControl2.UseSelectable = true;
            // 
            // tabLeakrBrisanje
            // 
            this.tabLeakrBrisanje.Controls.Add(this.btn_lekar_brisanje);
            this.tabLeakrBrisanje.Controls.Add(this.dGV_lekar_brisanje);
            this.tabLeakrBrisanje.HorizontalScrollbarBarColor = true;
            this.tabLeakrBrisanje.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLeakrBrisanje.HorizontalScrollbarSize = 10;
            this.tabLeakrBrisanje.Location = new System.Drawing.Point(4, 38);
            this.tabLeakrBrisanje.Name = "tabLeakrBrisanje";
            this.tabLeakrBrisanje.Size = new System.Drawing.Size(833, 493);
            this.tabLeakrBrisanje.TabIndex = 0;
            this.tabLeakrBrisanje.Text = "Brisnje podataka o lekarima";
            this.tabLeakrBrisanje.VerticalScrollbarBarColor = true;
            this.tabLeakrBrisanje.VerticalScrollbarHighlightOnWheel = false;
            this.tabLeakrBrisanje.VerticalScrollbarSize = 10;
            // 
            // btn_lekar_brisanje
            // 
            this.btn_lekar_brisanje.Location = new System.Drawing.Point(640, 443);
            this.btn_lekar_brisanje.Name = "btn_lekar_brisanje";
            this.btn_lekar_brisanje.Size = new System.Drawing.Size(190, 48);
            this.btn_lekar_brisanje.TabIndex = 3;
            this.btn_lekar_brisanje.Text = "Obrisi podatke o lekaru";
            this.btn_lekar_brisanje.UseVisualStyleBackColor = true;
            this.btn_lekar_brisanje.Click += new System.EventHandler(this.btn_lekar_brisanje_Click);
            // 
            // dGV_lekar_brisanje
            // 
            this.dGV_lekar_brisanje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_lekar_brisanje.Location = new System.Drawing.Point(0, 0);
            this.dGV_lekar_brisanje.Name = "dGV_lekar_brisanje";
            this.dGV_lekar_brisanje.Size = new System.Drawing.Size(833, 437);
            this.dGV_lekar_brisanje.TabIndex = 2;
            // 
            // tabLekarUnos
            // 
            this.tabLekarUnos.Controls.Add(this.cB_smena_lekar_unos_dva);
            this.tabLekarUnos.Controls.Add(this.cB_smena_lekar_unos_jeadn);
            this.tabLekarUnos.Controls.Add(this.dTP_lekar_unos);
            this.tabLekarUnos.Controls.Add(this.label8);
            this.tabLekarUnos.Controls.Add(this.label7);
            this.tabLekarUnos.Controls.Add(this.label6);
            this.tabLekarUnos.Controls.Add(this.tb_unos_lekar_srednjeS);
            this.tabLekarUnos.Controls.Add(this.label5);
            this.tabLekarUnos.Controls.Add(this.tb_unos_lekar_password);
            this.tabLekarUnos.Controls.Add(this.label4);
            this.tabLekarUnos.Controls.Add(this.tb_unos_lekar_prezime);
            this.tabLekarUnos.Controls.Add(this.label3);
            this.tabLekarUnos.Controls.Add(this.tb_unos_lekar_ime);
            this.tabLekarUnos.Controls.Add(this.label2);
            this.tabLekarUnos.Controls.Add(this.tb_unos_lekar_jmbg);
            this.tabLekarUnos.Controls.Add(this.btn_unosenje_lekara);
            this.tabLekarUnos.Controls.Add(this.dGV_lekar_unos);
            this.tabLekarUnos.HorizontalScrollbarBarColor = true;
            this.tabLekarUnos.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLekarUnos.HorizontalScrollbarSize = 10;
            this.tabLekarUnos.Location = new System.Drawing.Point(4, 38);
            this.tabLekarUnos.Name = "tabLekarUnos";
            this.tabLekarUnos.Size = new System.Drawing.Size(833, 493);
            this.tabLekarUnos.TabIndex = 1;
            this.tabLekarUnos.Text = "Unosenje podataka o novom lekaru";
            this.tabLekarUnos.VerticalScrollbarBarColor = true;
            this.tabLekarUnos.VerticalScrollbarHighlightOnWheel = false;
            this.tabLekarUnos.VerticalScrollbarSize = 10;
            // 
            // cB_smena_lekar_unos_dva
            // 
            this.cB_smena_lekar_unos_dva.AutoSize = true;
            this.cB_smena_lekar_unos_dva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_smena_lekar_unos_dva.Location = new System.Drawing.Point(616, 55);
            this.cB_smena_lekar_unos_dva.Name = "cB_smena_lekar_unos_dva";
            this.cB_smena_lekar_unos_dva.Size = new System.Drawing.Size(37, 24);
            this.cB_smena_lekar_unos_dva.TabIndex = 19;
            this.cB_smena_lekar_unos_dva.Text = "2";
            this.cB_smena_lekar_unos_dva.UseVisualStyleBackColor = true;
            // 
            // cB_smena_lekar_unos_jeadn
            // 
            this.cB_smena_lekar_unos_jeadn.AutoSize = true;
            this.cB_smena_lekar_unos_jeadn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_smena_lekar_unos_jeadn.Location = new System.Drawing.Point(575, 55);
            this.cB_smena_lekar_unos_jeadn.Name = "cB_smena_lekar_unos_jeadn";
            this.cB_smena_lekar_unos_jeadn.Size = new System.Drawing.Size(37, 24);
            this.cB_smena_lekar_unos_jeadn.TabIndex = 18;
            this.cB_smena_lekar_unos_jeadn.Text = "1";
            this.cB_smena_lekar_unos_jeadn.UseVisualStyleBackColor = true;
            // 
            // dTP_lekar_unos
            // 
            this.dTP_lekar_unos.Location = new System.Drawing.Point(571, 88);
            this.dTP_lekar_unos.Name = "dTP_lekar_unos";
            this.dTP_lekar_unos.Size = new System.Drawing.Size(200, 20);
            this.dTP_lekar_unos.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(448, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Datum rodjenja";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(492, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Smena";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(448, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Srednje slovo";
            // 
            // tb_unos_lekar_srednjeS
            // 
            this.tb_unos_lekar_srednjeS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_unos_lekar_srednjeS.Location = new System.Drawing.Point(572, 21);
            this.tb_unos_lekar_srednjeS.MaxLength = 2;
            this.tb_unos_lekar_srednjeS.Name = "tb_unos_lekar_srednjeS";
            this.tb_unos_lekar_srednjeS.Size = new System.Drawing.Size(42, 26);
            this.tb_unos_lekar_srednjeS.TabIndex = 12;
            this.tb_unos_lekar_srednjeS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_unos_lekar_srednjeS_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password";
            // 
            // tb_unos_lekar_password
            // 
            this.tb_unos_lekar_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_unos_lekar_password.Location = new System.Drawing.Point(213, 117);
            this.tb_unos_lekar_password.Name = "tb_unos_lekar_password";
            this.tb_unos_lekar_password.Size = new System.Drawing.Size(225, 26);
            this.tb_unos_lekar_password.TabIndex = 10;
            this.tb_unos_lekar_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_unos_lekar_password_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Prezime";
            // 
            // tb_unos_lekar_prezime
            // 
            this.tb_unos_lekar_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_unos_lekar_prezime.Location = new System.Drawing.Point(213, 85);
            this.tb_unos_lekar_prezime.Name = "tb_unos_lekar_prezime";
            this.tb_unos_lekar_prezime.Size = new System.Drawing.Size(225, 26);
            this.tb_unos_lekar_prezime.TabIndex = 8;
            this.tb_unos_lekar_prezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_unos_lekar_prezime_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ime";
            // 
            // tb_unos_lekar_ime
            // 
            this.tb_unos_lekar_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_unos_lekar_ime.Location = new System.Drawing.Point(213, 53);
            this.tb_unos_lekar_ime.Name = "tb_unos_lekar_ime";
            this.tb_unos_lekar_ime.Size = new System.Drawing.Size(225, 26);
            this.tb_unos_lekar_ime.TabIndex = 6;
            this.tb_unos_lekar_ime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_unos_lekar_ime_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "JMBG";
            // 
            // tb_unos_lekar_jmbg
            // 
            this.tb_unos_lekar_jmbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_unos_lekar_jmbg.Location = new System.Drawing.Point(213, 21);
            this.tb_unos_lekar_jmbg.Name = "tb_unos_lekar_jmbg";
            this.tb_unos_lekar_jmbg.Size = new System.Drawing.Size(225, 26);
            this.tb_unos_lekar_jmbg.TabIndex = 4;
            this.tb_unos_lekar_jmbg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_unos_lekar_jmbg_KeyPress);
            // 
            // btn_unosenje_lekara
            // 
            this.btn_unosenje_lekara.Location = new System.Drawing.Point(617, 193);
            this.btn_unosenje_lekara.Name = "btn_unosenje_lekara";
            this.btn_unosenje_lekara.Size = new System.Drawing.Size(213, 34);
            this.btn_unosenje_lekara.TabIndex = 3;
            this.btn_unosenje_lekara.Text = "Unesite novog lekara";
            this.btn_unosenje_lekara.UseVisualStyleBackColor = true;
            // 
            // dGV_lekar_unos
            // 
            this.dGV_lekar_unos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_lekar_unos.Location = new System.Drawing.Point(0, 233);
            this.dGV_lekar_unos.Name = "dGV_lekar_unos";
            this.dGV_lekar_unos.Size = new System.Drawing.Size(833, 257);
            this.dGV_lekar_unos.TabIndex = 2;
            // 
            // tabLekarAzuriranje
            // 
            this.tabLekarAzuriranje.Controls.Add(this.btn_azuriranje_lekara);
            this.tabLekarAzuriranje.Controls.Add(this.dGV_lekar_azuriranje);
            this.tabLekarAzuriranje.Controls.Add(this.cB_lekar_azurirnje_smena_dva);
            this.tabLekarAzuriranje.Controls.Add(this.cB_lekar_azurirnje_smena_jedan);
            this.tabLekarAzuriranje.Controls.Add(this.dTP_lekar_azuriranje);
            this.tabLekarAzuriranje.Controls.Add(this.label9);
            this.tabLekarAzuriranje.Controls.Add(this.label10);
            this.tabLekarAzuriranje.Controls.Add(this.label11);
            this.tabLekarAzuriranje.Controls.Add(this.tb_azuriranje_lekar_srednjeS);
            this.tabLekarAzuriranje.Controls.Add(this.label12);
            this.tabLekarAzuriranje.Controls.Add(this.tb_azuriranje_lekar_password);
            this.tabLekarAzuriranje.Controls.Add(this.label13);
            this.tabLekarAzuriranje.Controls.Add(this.tb_azuriranje_lekar_prezime);
            this.tabLekarAzuriranje.Controls.Add(this.label14);
            this.tabLekarAzuriranje.Controls.Add(this.tb_azuriranje_lekar_ime);
            this.tabLekarAzuriranje.Controls.Add(this.label15);
            this.tabLekarAzuriranje.Controls.Add(this.tb_azuriranje_lekar_jmbg);
            this.tabLekarAzuriranje.HorizontalScrollbarBarColor = true;
            this.tabLekarAzuriranje.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLekarAzuriranje.HorizontalScrollbarSize = 10;
            this.tabLekarAzuriranje.Location = new System.Drawing.Point(4, 38);
            this.tabLekarAzuriranje.Name = "tabLekarAzuriranje";
            this.tabLekarAzuriranje.Size = new System.Drawing.Size(833, 493);
            this.tabLekarAzuriranje.TabIndex = 2;
            this.tabLekarAzuriranje.Text = "Azuriranje podataka o lekaru";
            this.tabLekarAzuriranje.VerticalScrollbarBarColor = true;
            this.tabLekarAzuriranje.VerticalScrollbarHighlightOnWheel = false;
            this.tabLekarAzuriranje.VerticalScrollbarSize = 10;
            // 
            // btn_azuriranje_lekara
            // 
            this.btn_azuriranje_lekara.Location = new System.Drawing.Point(617, 193);
            this.btn_azuriranje_lekara.Name = "btn_azuriranje_lekara";
            this.btn_azuriranje_lekara.Size = new System.Drawing.Size(213, 34);
            this.btn_azuriranje_lekara.TabIndex = 36;
            this.btn_azuriranje_lekara.Text = "Azurirajte lekara";
            this.btn_azuriranje_lekara.UseVisualStyleBackColor = true;
            this.btn_azuriranje_lekara.Click += new System.EventHandler(this.btn_azuriranje_lekara_Click);
            // 
            // dGV_lekar_azuriranje
            // 
            this.dGV_lekar_azuriranje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_lekar_azuriranje.Location = new System.Drawing.Point(0, 233);
            this.dGV_lekar_azuriranje.Name = "dGV_lekar_azuriranje";
            this.dGV_lekar_azuriranje.Size = new System.Drawing.Size(833, 257);
            this.dGV_lekar_azuriranje.TabIndex = 35;
            // 
            // cB_lekar_azurirnje_smena_dva
            // 
            this.cB_lekar_azurirnje_smena_dva.AutoSize = true;
            this.cB_lekar_azurirnje_smena_dva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_lekar_azurirnje_smena_dva.Location = new System.Drawing.Point(616, 55);
            this.cB_lekar_azurirnje_smena_dva.Name = "cB_lekar_azurirnje_smena_dva";
            this.cB_lekar_azurirnje_smena_dva.Size = new System.Drawing.Size(37, 24);
            this.cB_lekar_azurirnje_smena_dva.TabIndex = 34;
            this.cB_lekar_azurirnje_smena_dva.Text = "2";
            this.cB_lekar_azurirnje_smena_dva.UseVisualStyleBackColor = true;
            // 
            // cB_lekar_azurirnje_smena_jedan
            // 
            this.cB_lekar_azurirnje_smena_jedan.AutoSize = true;
            this.cB_lekar_azurirnje_smena_jedan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_lekar_azurirnje_smena_jedan.Location = new System.Drawing.Point(575, 55);
            this.cB_lekar_azurirnje_smena_jedan.Name = "cB_lekar_azurirnje_smena_jedan";
            this.cB_lekar_azurirnje_smena_jedan.Size = new System.Drawing.Size(37, 24);
            this.cB_lekar_azurirnje_smena_jedan.TabIndex = 33;
            this.cB_lekar_azurirnje_smena_jedan.Text = "1";
            this.cB_lekar_azurirnje_smena_jedan.UseVisualStyleBackColor = true;
            // 
            // dTP_lekar_azuriranje
            // 
            this.dTP_lekar_azuriranje.Location = new System.Drawing.Point(571, 88);
            this.dTP_lekar_azuriranje.Name = "dTP_lekar_azuriranje";
            this.dTP_lekar_azuriranje.Size = new System.Drawing.Size(200, 20);
            this.dTP_lekar_azuriranje.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(448, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Datum rodjenja";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(492, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Smena";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(448, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Srednje slovo";
            // 
            // tb_azuriranje_lekar_srednjeS
            // 
            this.tb_azuriranje_lekar_srednjeS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_azuriranje_lekar_srednjeS.Location = new System.Drawing.Point(572, 21);
            this.tb_azuriranje_lekar_srednjeS.MaxLength = 2;
            this.tb_azuriranje_lekar_srednjeS.Name = "tb_azuriranje_lekar_srednjeS";
            this.tb_azuriranje_lekar_srednjeS.Size = new System.Drawing.Size(42, 26);
            this.tb_azuriranje_lekar_srednjeS.TabIndex = 28;
            this.tb_azuriranje_lekar_srednjeS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_azuriranje_lekar_srednjeS_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(120, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Password";
            // 
            // tb_azuriranje_lekar_password
            // 
            this.tb_azuriranje_lekar_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_azuriranje_lekar_password.Location = new System.Drawing.Point(213, 117);
            this.tb_azuriranje_lekar_password.Name = "tb_azuriranje_lekar_password";
            this.tb_azuriranje_lekar_password.Size = new System.Drawing.Size(225, 26);
            this.tb_azuriranje_lekar_password.TabIndex = 26;
            this.tb_azuriranje_lekar_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_azuriranje_lekar_password_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(132, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Prezime";
            // 
            // tb_azuriranje_lekar_prezime
            // 
            this.tb_azuriranje_lekar_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_azuriranje_lekar_prezime.Location = new System.Drawing.Point(213, 85);
            this.tb_azuriranje_lekar_prezime.Name = "tb_azuriranje_lekar_prezime";
            this.tb_azuriranje_lekar_prezime.Size = new System.Drawing.Size(225, 26);
            this.tb_azuriranje_lekar_prezime.TabIndex = 24;
            this.tb_azuriranje_lekar_prezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_azuriranje_lekar_prezime_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(162, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "Ime";
            // 
            // tb_azuriranje_lekar_ime
            // 
            this.tb_azuriranje_lekar_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_azuriranje_lekar_ime.Location = new System.Drawing.Point(213, 53);
            this.tb_azuriranje_lekar_ime.Name = "tb_azuriranje_lekar_ime";
            this.tb_azuriranje_lekar_ime.Size = new System.Drawing.Size(225, 26);
            this.tb_azuriranje_lekar_ime.TabIndex = 22;
            this.tb_azuriranje_lekar_ime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_azuriranje_lekar_ime_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(144, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "JMBG";
            // 
            // tb_azuriranje_lekar_jmbg
            // 
            this.tb_azuriranje_lekar_jmbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_azuriranje_lekar_jmbg.Location = new System.Drawing.Point(213, 21);
            this.tb_azuriranje_lekar_jmbg.Name = "tb_azuriranje_lekar_jmbg";
            this.tb_azuriranje_lekar_jmbg.Size = new System.Drawing.Size(225, 26);
            this.tb_azuriranje_lekar_jmbg.TabIndex = 20;
            this.tb_azuriranje_lekar_jmbg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_azuriranje_lekar_jmbg_KeyPress);
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
            // FormDirektor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 673);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.lblImeDomaZ);
            this.Name = "FormDirektor";
            this.Text = "Administrator panel";
            this.metroTabControl1.ResumeLayout(false);
            this.tabLekar.ResumeLayout(false);
            this.metroTabControl2.ResumeLayout(false);
            this.tabLeakrBrisanje.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_lekar_brisanje)).EndInit();
            this.tabLekarUnos.ResumeLayout(false);
            this.tabLekarUnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_lekar_unos)).EndInit();
            this.tabLekarAzuriranje.ResumeLayout(false);
            this.tabLekarAzuriranje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_lekar_azuriranje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblImeDomaZ;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabLekar;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage tabLeakrBrisanje;
        private MetroFramework.Controls.MetroTabPage tabLekarUnos;
        private MetroFramework.Controls.MetroTabPage tabLekarAzuriranje;
        private MetroFramework.Controls.MetroTabPage tabOsoblje;
        private System.Windows.Forms.DataGridView dGV_lekar_brisanje;
        private System.Windows.Forms.Button btn_lekar_brisanje;
        private System.Windows.Forms.DataGridView dGV_lekar_unos;
        private System.Windows.Forms.Button btn_unosenje_lekara;
        private System.Windows.Forms.TextBox tb_unos_lekar_jmbg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_unos_lekar_srednjeS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_unos_lekar_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_unos_lekar_prezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_unos_lekar_ime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dTP_lekar_unos;
        private System.Windows.Forms.CheckBox cB_smena_lekar_unos_jeadn;
        private System.Windows.Forms.CheckBox cB_smena_lekar_unos_dva;
        private System.Windows.Forms.CheckBox cB_lekar_azurirnje_smena_dva;
        private System.Windows.Forms.CheckBox cB_lekar_azurirnje_smena_jedan;
        private System.Windows.Forms.DateTimePicker dTP_lekar_azuriranje;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_azuriranje_lekar_srednjeS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_azuriranje_lekar_password;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_azuriranje_lekar_prezime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_azuriranje_lekar_ime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_azuriranje_lekar_jmbg;
        private System.Windows.Forms.DataGridView dGV_lekar_azuriranje;
        private System.Windows.Forms.Button btn_azuriranje_lekara;
    }
}