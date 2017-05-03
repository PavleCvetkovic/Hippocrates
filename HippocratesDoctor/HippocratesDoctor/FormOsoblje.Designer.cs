namespace HippocratesDoctor
{
    partial class FormOsoblje
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tab_pregledi = new MetroFramework.Controls.MetroTabPage();
            this.btn_zakazivanje = new MetroFramework.Controls.MetroButton();
            this.lblSmena = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mBC_pacijenti_nacinPretrage = new MetroFramework.Controls.MetroComboBox();
            this.lblPrezimePacijenta = new System.Windows.Forms.Label();
            this.lblImePacijenta = new System.Windows.Forms.Label();
            this.mB_nadjiPacijenta = new MetroFramework.Controls.MetroButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_pretraga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_pretraga_doktora = new System.Windows.Forms.Panel();
            this.lblPrezimeLekara = new System.Windows.Forms.Label();
            this.lblImeLekara = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tab_pac_infor = new MetroFramework.Controls.MetroTabPage();
            this.lblPravoDaZakPacInformacije = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lB_terapije = new System.Windows.Forms.ListBox();
            this.lB_dijagnoze = new System.Windows.Forms.ListBox();
            this.lB_vakcine = new System.Windows.Forms.ListBox();
            this.lblVaziDoPacInformacije = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTelefonPacInformacije = new System.Windows.Forms.Label();
            this.lblEmailPacInformacije = new System.Windows.Forms.Label();
            this.lblLboPacInformacije = new System.Windows.Forms.Label();
            this.lblOpstinaPacInformacije = new System.Windows.Forms.Label();
            this.lblDatumRodjenjaPacInformacije = new System.Windows.Forms.Label();
            this.lblSrednjeSlovoPacInfromacije = new System.Windows.Forms.Label();
            this.lblPrezimePacInformacije = new System.Windows.Forms.Label();
            this.lblImePacInformacije = new System.Windows.Forms.Label();
            this.lblJmbgPacInformacije = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDomZdravlja = new System.Windows.Forms.Label();
            this.metroTabControl1.SuspendLayout();
            this.tab_pregledi.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_pretraga_doktora.SuspendLayout();
            this.tab_pac_infor.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tab_pregledi);
            this.metroTabControl1.Controls.Add(this.tab_pac_infor);
            this.metroTabControl1.Location = new System.Drawing.Point(9, 64);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(824, 448);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tab_pregledi
            // 
            this.tab_pregledi.Controls.Add(this.btn_zakazivanje);
            this.tab_pregledi.Controls.Add(this.lblSmena);
            this.tab_pregledi.Controls.Add(this.panel1);
            this.tab_pregledi.Controls.Add(this.pnl_pretraga_doktora);
            this.tab_pregledi.HorizontalScrollbarBarColor = true;
            this.tab_pregledi.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_pregledi.HorizontalScrollbarSize = 10;
            this.tab_pregledi.Location = new System.Drawing.Point(4, 38);
            this.tab_pregledi.Name = "tab_pregledi";
            this.tab_pregledi.Size = new System.Drawing.Size(816, 406);
            this.tab_pregledi.TabIndex = 0;
            this.tab_pregledi.Text = "Raspored pregleda";
            this.tab_pregledi.VerticalScrollbarBarColor = true;
            this.tab_pregledi.VerticalScrollbarHighlightOnWheel = false;
            this.tab_pregledi.VerticalScrollbarSize = 10;
            // 
            // btn_zakazivanje
            // 
            this.btn_zakazivanje.Location = new System.Drawing.Point(13, 204);
            this.btn_zakazivanje.Name = "btn_zakazivanje";
            this.btn_zakazivanje.Size = new System.Drawing.Size(220, 44);
            this.btn_zakazivanje.TabIndex = 18;
            this.btn_zakazivanje.Text = "Zakazi termin";
            this.btn_zakazivanje.UseSelectable = true;
            this.btn_zakazivanje.Click += new System.EventHandler(this.btn_zakazivanje_Click);
            // 
            // lblSmena
            // 
            this.lblSmena.AutoSize = true;
            this.lblSmena.BackColor = System.Drawing.Color.White;
            this.lblSmena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmena.Location = new System.Drawing.Point(10, 173);
            this.lblSmena.Name = "lblSmena";
            this.lblSmena.Size = new System.Drawing.Size(47, 15);
            this.lblSmena.TabIndex = 16;
            this.lblSmena.Text = "label6";
            this.lblSmena.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.mBC_pacijenti_nacinPretrage);
            this.panel1.Controls.Add(this.lblPrezimePacijenta);
            this.panel1.Controls.Add(this.lblImePacijenta);
            this.panel1.Controls.Add(this.mB_nadjiPacijenta);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tB_pretraga);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(10, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 148);
            this.panel1.TabIndex = 14;
            // 
            // mBC_pacijenti_nacinPretrage
            // 
            this.mBC_pacijenti_nacinPretrage.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.mBC_pacijenti_nacinPretrage.FormattingEnabled = true;
            this.mBC_pacijenti_nacinPretrage.ItemHeight = 19;
            this.mBC_pacijenti_nacinPretrage.Items.AddRange(new object[] {
            "Jmbg",
            "Lbo"});
            this.mBC_pacijenti_nacinPretrage.Location = new System.Drawing.Point(15, 54);
            this.mBC_pacijenti_nacinPretrage.Name = "mBC_pacijenti_nacinPretrage";
            this.mBC_pacijenti_nacinPretrage.Size = new System.Drawing.Size(179, 25);
            this.mBC_pacijenti_nacinPretrage.TabIndex = 16;
            this.mBC_pacijenti_nacinPretrage.UseSelectable = true;
            // 
            // lblPrezimePacijenta
            // 
            this.lblPrezimePacijenta.AutoSize = true;
            this.lblPrezimePacijenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezimePacijenta.Location = new System.Drawing.Point(103, 114);
            this.lblPrezimePacijenta.Name = "lblPrezimePacijenta";
            this.lblPrezimePacijenta.Size = new System.Drawing.Size(45, 16);
            this.lblPrezimePacijenta.TabIndex = 17;
            this.lblPrezimePacijenta.Text = "label6";
            this.lblPrezimePacijenta.Visible = false;
            // 
            // lblImePacijenta
            // 
            this.lblImePacijenta.AutoSize = true;
            this.lblImePacijenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImePacijenta.Location = new System.Drawing.Point(12, 114);
            this.lblImePacijenta.Name = "lblImePacijenta";
            this.lblImePacijenta.Size = new System.Drawing.Size(45, 16);
            this.lblImePacijenta.TabIndex = 16;
            this.lblImePacijenta.Text = "label5";
            this.lblImePacijenta.Visible = false;
            // 
            // mB_nadjiPacijenta
            // 
            this.mB_nadjiPacijenta.Location = new System.Drawing.Point(273, 85);
            this.mB_nadjiPacijenta.Name = "mB_nadjiPacijenta";
            this.mB_nadjiPacijenta.Size = new System.Drawing.Size(110, 26);
            this.mB_nadjiPacijenta.TabIndex = 16;
            this.mB_nadjiPacijenta.Text = "Izaberi pacijenta";
            this.mB_nadjiPacijenta.UseSelectable = true;
            this.mB_nadjiPacijenta.Click += new System.EventHandler(this.mB_nadjiPacijenta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Izaberite nacin pretrage";
            // 
            // tB_pretraga
            // 
            this.tB_pretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_pretraga.Location = new System.Drawing.Point(201, 55);
            this.tB_pretraga.Name = "tB_pretraga";
            this.tB_pretraga.Size = new System.Drawing.Size(182, 22);
            this.tB_pretraga.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pretraga pacijenta";
            // 
            // pnl_pretraga_doktora
            // 
            this.pnl_pretraga_doktora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnl_pretraga_doktora.Controls.Add(this.lblPrezimeLekara);
            this.pnl_pretraga_doktora.Controls.Add(this.lblImeLekara);
            this.pnl_pretraga_doktora.Controls.Add(this.label3);
            this.pnl_pretraga_doktora.Location = new System.Drawing.Point(413, 12);
            this.pnl_pretraga_doktora.Name = "pnl_pretraga_doktora";
            this.pnl_pretraga_doktora.Size = new System.Drawing.Size(397, 148);
            this.pnl_pretraga_doktora.TabIndex = 13;
            // 
            // lblPrezimeLekara
            // 
            this.lblPrezimeLekara.AutoSize = true;
            this.lblPrezimeLekara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezimeLekara.Location = new System.Drawing.Point(12, 95);
            this.lblPrezimeLekara.Name = "lblPrezimeLekara";
            this.lblPrezimeLekara.Size = new System.Drawing.Size(47, 15);
            this.lblPrezimeLekara.TabIndex = 15;
            this.lblPrezimeLekara.Text = "label6";
            this.lblPrezimeLekara.Visible = false;
            // 
            // lblImeLekara
            // 
            this.lblImeLekara.AutoSize = true;
            this.lblImeLekara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeLekara.Location = new System.Drawing.Point(12, 54);
            this.lblImeLekara.Name = "lblImeLekara";
            this.lblImeLekara.Size = new System.Drawing.Size(47, 15);
            this.lblImeLekara.TabIndex = 14;
            this.lblImeLekara.Text = "label5";
            this.lblImeLekara.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Izabrani lekar pacijenta";
            // 
            // tab_pac_infor
            // 
            this.tab_pac_infor.Controls.Add(this.lblPravoDaZakPacInformacije);
            this.tab_pac_infor.Controls.Add(this.label17);
            this.tab_pac_infor.Controls.Add(this.lB_terapije);
            this.tab_pac_infor.Controls.Add(this.lB_dijagnoze);
            this.tab_pac_infor.Controls.Add(this.lB_vakcine);
            this.tab_pac_infor.Controls.Add(this.lblVaziDoPacInformacije);
            this.tab_pac_infor.Controls.Add(this.label16);
            this.tab_pac_infor.Controls.Add(this.lblTelefonPacInformacije);
            this.tab_pac_infor.Controls.Add(this.lblEmailPacInformacije);
            this.tab_pac_infor.Controls.Add(this.lblLboPacInformacije);
            this.tab_pac_infor.Controls.Add(this.lblOpstinaPacInformacije);
            this.tab_pac_infor.Controls.Add(this.lblDatumRodjenjaPacInformacije);
            this.tab_pac_infor.Controls.Add(this.lblSrednjeSlovoPacInfromacije);
            this.tab_pac_infor.Controls.Add(this.lblPrezimePacInformacije);
            this.tab_pac_infor.Controls.Add(this.lblImePacInformacije);
            this.tab_pac_infor.Controls.Add(this.lblJmbgPacInformacije);
            this.tab_pac_infor.Controls.Add(this.label15);
            this.tab_pac_infor.Controls.Add(this.label14);
            this.tab_pac_infor.Controls.Add(this.label13);
            this.tab_pac_infor.Controls.Add(this.label12);
            this.tab_pac_infor.Controls.Add(this.label11);
            this.tab_pac_infor.Controls.Add(this.label10);
            this.tab_pac_infor.Controls.Add(this.label9);
            this.tab_pac_infor.Controls.Add(this.label8);
            this.tab_pac_infor.Controls.Add(this.label7);
            this.tab_pac_infor.Controls.Add(this.label6);
            this.tab_pac_infor.Controls.Add(this.label2);
            this.tab_pac_infor.Controls.Add(this.label1);
            this.tab_pac_infor.HorizontalScrollbarBarColor = true;
            this.tab_pac_infor.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_pac_infor.HorizontalScrollbarSize = 10;
            this.tab_pac_infor.Location = new System.Drawing.Point(4, 38);
            this.tab_pac_infor.Name = "tab_pac_infor";
            this.tab_pac_infor.Size = new System.Drawing.Size(816, 406);
            this.tab_pac_infor.TabIndex = 1;
            this.tab_pac_infor.Text = "Informacije pacijenta";
            this.tab_pac_infor.VerticalScrollbarBarColor = true;
            this.tab_pac_infor.VerticalScrollbarHighlightOnWheel = false;
            this.tab_pac_infor.VerticalScrollbarSize = 10;
            // 
            // lblPravoDaZakPacInformacije
            // 
            this.lblPravoDaZakPacInformacije.AutoSize = true;
            this.lblPravoDaZakPacInformacije.BackColor = System.Drawing.Color.White;
            this.lblPravoDaZakPacInformacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPravoDaZakPacInformacije.Location = new System.Drawing.Point(137, 332);
            this.lblPravoDaZakPacInformacije.Name = "lblPravoDaZakPacInformacije";
            this.lblPravoDaZakPacInformacije.Size = new System.Drawing.Size(52, 16);
            this.lblPravoDaZakPacInformacije.TabIndex = 29;
            this.lblPravoDaZakPacInformacije.Text = "label16";
            this.lblPravoDaZakPacInformacije.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 332);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 16);
            this.label17.TabIndex = 28;
            this.label17.Text = "Pravo da zakaze:";
            // 
            // lB_terapije
            // 
            this.lB_terapije.FormattingEnabled = true;
            this.lB_terapije.Location = new System.Drawing.Point(311, 266);
            this.lB_terapije.Name = "lB_terapije";
            this.lB_terapije.Size = new System.Drawing.Size(404, 82);
            this.lB_terapije.TabIndex = 27;
            // 
            // lB_dijagnoze
            // 
            this.lB_dijagnoze.FormattingEnabled = true;
            this.lB_dijagnoze.Location = new System.Drawing.Point(311, 162);
            this.lB_dijagnoze.Name = "lB_dijagnoze";
            this.lB_dijagnoze.Size = new System.Drawing.Size(404, 82);
            this.lB_dijagnoze.TabIndex = 26;
            // 
            // lB_vakcine
            // 
            this.lB_vakcine.FormattingEnabled = true;
            this.lB_vakcine.Location = new System.Drawing.Point(311, 44);
            this.lB_vakcine.Name = "lB_vakcine";
            this.lB_vakcine.Size = new System.Drawing.Size(404, 82);
            this.lB_vakcine.TabIndex = 25;
            // 
            // lblVaziDoPacInformacije
            // 
            this.lblVaziDoPacInformacije.AutoSize = true;
            this.lblVaziDoPacInformacije.BackColor = System.Drawing.Color.White;
            this.lblVaziDoPacInformacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaziDoPacInformacije.Location = new System.Drawing.Point(137, 303);
            this.lblVaziDoPacInformacije.Name = "lblVaziDoPacInformacije";
            this.lblVaziDoPacInformacije.Size = new System.Drawing.Size(52, 16);
            this.lblVaziDoPacInformacije.TabIndex = 24;
            this.lblVaziDoPacInformacije.Text = "label16";
            this.lblVaziDoPacInformacije.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(68, 303);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 16);
            this.label16.TabIndex = 23;
            this.label16.Text = "Važi do:";
            // 
            // lblTelefonPacInformacije
            // 
            this.lblTelefonPacInformacije.AutoSize = true;
            this.lblTelefonPacInformacije.BackColor = System.Drawing.Color.White;
            this.lblTelefonPacInformacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonPacInformacije.Location = new System.Drawing.Point(137, 275);
            this.lblTelefonPacInformacije.Name = "lblTelefonPacInformacije";
            this.lblTelefonPacInformacije.Size = new System.Drawing.Size(52, 16);
            this.lblTelefonPacInformacije.TabIndex = 22;
            this.lblTelefonPacInformacije.Text = "label16";
            this.lblTelefonPacInformacije.Visible = false;
            // 
            // lblEmailPacInformacije
            // 
            this.lblEmailPacInformacije.AutoSize = true;
            this.lblEmailPacInformacije.BackColor = System.Drawing.Color.White;
            this.lblEmailPacInformacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailPacInformacije.Location = new System.Drawing.Point(137, 247);
            this.lblEmailPacInformacije.Name = "lblEmailPacInformacije";
            this.lblEmailPacInformacije.Size = new System.Drawing.Size(52, 16);
            this.lblEmailPacInformacije.TabIndex = 21;
            this.lblEmailPacInformacije.Text = "label16";
            this.lblEmailPacInformacije.Visible = false;
            // 
            // lblLboPacInformacije
            // 
            this.lblLboPacInformacije.AutoSize = true;
            this.lblLboPacInformacije.BackColor = System.Drawing.Color.White;
            this.lblLboPacInformacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLboPacInformacije.Location = new System.Drawing.Point(137, 220);
            this.lblLboPacInformacije.Name = "lblLboPacInformacije";
            this.lblLboPacInformacije.Size = new System.Drawing.Size(52, 16);
            this.lblLboPacInformacije.TabIndex = 20;
            this.lblLboPacInformacije.Text = "label16";
            this.lblLboPacInformacije.Visible = false;
            // 
            // lblOpstinaPacInformacije
            // 
            this.lblOpstinaPacInformacije.AutoSize = true;
            this.lblOpstinaPacInformacije.BackColor = System.Drawing.Color.White;
            this.lblOpstinaPacInformacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpstinaPacInformacije.Location = new System.Drawing.Point(137, 195);
            this.lblOpstinaPacInformacije.Name = "lblOpstinaPacInformacije";
            this.lblOpstinaPacInformacije.Size = new System.Drawing.Size(52, 16);
            this.lblOpstinaPacInformacije.TabIndex = 19;
            this.lblOpstinaPacInformacije.Text = "label16";
            this.lblOpstinaPacInformacije.Visible = false;
            // 
            // lblDatumRodjenjaPacInformacije
            // 
            this.lblDatumRodjenjaPacInformacije.AutoSize = true;
            this.lblDatumRodjenjaPacInformacije.BackColor = System.Drawing.Color.White;
            this.lblDatumRodjenjaPacInformacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumRodjenjaPacInformacije.Location = new System.Drawing.Point(137, 165);
            this.lblDatumRodjenjaPacInformacije.Name = "lblDatumRodjenjaPacInformacije";
            this.lblDatumRodjenjaPacInformacije.Size = new System.Drawing.Size(52, 16);
            this.lblDatumRodjenjaPacInformacije.TabIndex = 18;
            this.lblDatumRodjenjaPacInformacije.Text = "label16";
            this.lblDatumRodjenjaPacInformacije.Visible = false;
            // 
            // lblSrednjeSlovoPacInfromacije
            // 
            this.lblSrednjeSlovoPacInfromacije.AutoSize = true;
            this.lblSrednjeSlovoPacInfromacije.BackColor = System.Drawing.Color.White;
            this.lblSrednjeSlovoPacInfromacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrednjeSlovoPacInfromacije.Location = new System.Drawing.Point(137, 135);
            this.lblSrednjeSlovoPacInfromacije.Name = "lblSrednjeSlovoPacInfromacije";
            this.lblSrednjeSlovoPacInfromacije.Size = new System.Drawing.Size(52, 16);
            this.lblSrednjeSlovoPacInfromacije.TabIndex = 17;
            this.lblSrednjeSlovoPacInfromacije.Text = "label16";
            this.lblSrednjeSlovoPacInfromacije.Visible = false;
            // 
            // lblPrezimePacInformacije
            // 
            this.lblPrezimePacInformacije.AutoSize = true;
            this.lblPrezimePacInformacije.BackColor = System.Drawing.Color.White;
            this.lblPrezimePacInformacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezimePacInformacije.Location = new System.Drawing.Point(137, 110);
            this.lblPrezimePacInformacije.Name = "lblPrezimePacInformacije";
            this.lblPrezimePacInformacije.Size = new System.Drawing.Size(52, 16);
            this.lblPrezimePacInformacije.TabIndex = 16;
            this.lblPrezimePacInformacije.Text = "label16";
            this.lblPrezimePacInformacije.Visible = false;
            // 
            // lblImePacInformacije
            // 
            this.lblImePacInformacije.AutoSize = true;
            this.lblImePacInformacije.BackColor = System.Drawing.Color.White;
            this.lblImePacInformacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImePacInformacije.Location = new System.Drawing.Point(137, 80);
            this.lblImePacInformacije.Name = "lblImePacInformacije";
            this.lblImePacInformacije.Size = new System.Drawing.Size(52, 16);
            this.lblImePacInformacije.TabIndex = 15;
            this.lblImePacInformacije.Text = "label16";
            this.lblImePacInformacije.Visible = false;
            // 
            // lblJmbgPacInformacije
            // 
            this.lblJmbgPacInformacije.AutoSize = true;
            this.lblJmbgPacInformacije.BackColor = System.Drawing.Color.White;
            this.lblJmbgPacInformacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJmbgPacInformacije.Location = new System.Drawing.Point(137, 55);
            this.lblJmbgPacInformacije.Name = "lblJmbgPacInformacije";
            this.lblJmbgPacInformacije.Size = new System.Drawing.Size(52, 16);
            this.lblJmbgPacInformacije.TabIndex = 14;
            this.lblJmbgPacInformacije.Text = "label16";
            this.lblJmbgPacInformacije.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(308, 247);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 16);
            this.label15.TabIndex = 13;
            this.label15.Text = "Terapije";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(308, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "Dijagnoze";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(308, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "Vakcine";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(67, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Telefon:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(80, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Email:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(93, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Lbo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(66, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Opština:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Datum rođenja:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Srednje Slovo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jmbg:";
            // 
            // lblDomZdravlja
            // 
            this.lblDomZdravlja.AutoSize = true;
            this.lblDomZdravlja.BackColor = System.Drawing.Color.White;
            this.lblDomZdravlja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomZdravlja.Location = new System.Drawing.Point(600, 45);
            this.lblDomZdravlja.Name = "lblDomZdravlja";
            this.lblDomZdravlja.Size = new System.Drawing.Size(95, 20);
            this.lblDomZdravlja.TabIndex = 16;
            this.lblDomZdravlja.Text = "#imeDoma#";
            // 
            // FormOsoblje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 524);
            this.Controls.Add(this.lblDomZdravlja);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "FormOsoblje";
            this.Text = "Medicinsko osoblje";
            this.metroTabControl1.ResumeLayout(false);
            this.tab_pregledi.ResumeLayout(false);
            this.tab_pregledi.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_pretraga_doktora.ResumeLayout(false);
            this.pnl_pretraga_doktora.PerformLayout();
            this.tab_pac_infor.ResumeLayout(false);
            this.tab_pac_infor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tab_pregledi;
        private MetroFramework.Controls.MetroTabPage tab_pac_infor;
        private System.Windows.Forms.Panel pnl_pretraga_doktora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrezimeLekara;
        private System.Windows.Forms.Label lblImeLekara;
        private System.Windows.Forms.TextBox tB_pretraga;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton mB_nadjiPacijenta;
        private System.Windows.Forms.Label lblPrezimePacijenta;
        private System.Windows.Forms.Label lblImePacijenta;
        private MetroFramework.Controls.MetroComboBox mBC_pacijenti_nacinPretrage;
        private System.Windows.Forms.Label lblDomZdravlja;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblJmbgPacInformacije;
        private System.Windows.Forms.Label lblTelefonPacInformacije;
        private System.Windows.Forms.Label lblEmailPacInformacije;
        private System.Windows.Forms.Label lblLboPacInformacije;
        private System.Windows.Forms.Label lblOpstinaPacInformacije;
        private System.Windows.Forms.Label lblDatumRodjenjaPacInformacije;
        private System.Windows.Forms.Label lblSrednjeSlovoPacInfromacije;
        private System.Windows.Forms.Label lblPrezimePacInformacije;
        private System.Windows.Forms.Label lblImePacInformacije;
        private System.Windows.Forms.Label lblVaziDoPacInformacije;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox lB_terapije;
        private System.Windows.Forms.ListBox lB_dijagnoze;
        private System.Windows.Forms.ListBox lB_vakcine;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblPravoDaZakPacInformacije;
        private System.Windows.Forms.Label lblSmena;
        private MetroFramework.Controls.MetroButton btn_zakazivanje;
    }
}