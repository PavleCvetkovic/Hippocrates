namespace HippocratesDoctor
{
    partial class FormTerapije
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroGridDijagnoze = new MetroFramework.Controls.MetroGrid();
            this.metroDateTimeDatumPocetka = new MetroFramework.Controls.MetroDateTime();
            this.metroButtonDodajTerapiju = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxOpisTerapije = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTimeDatumKraja = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridDijagnoze)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(317, 75);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(312, 19);
            this.metroLabel3.TabIndex = 25;
            this.metroLabel3.Text = "Izaberite dijagnozu za koju želite da dodate terapiju";
            // 
            // metroGridDijagnoze
            // 
            this.metroGridDijagnoze.AllowUserToResizeRows = false;
            this.metroGridDijagnoze.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridDijagnoze.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridDijagnoze.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridDijagnoze.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridDijagnoze.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridDijagnoze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridDijagnoze.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridDijagnoze.EnableHeadersVisualStyles = false;
            this.metroGridDijagnoze.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridDijagnoze.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridDijagnoze.Location = new System.Drawing.Point(317, 109);
            this.metroGridDijagnoze.Name = "metroGridDijagnoze";
            this.metroGridDijagnoze.ReadOnly = true;
            this.metroGridDijagnoze.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridDijagnoze.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridDijagnoze.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridDijagnoze.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridDijagnoze.Size = new System.Drawing.Size(507, 222);
            this.metroGridDijagnoze.TabIndex = 24;
            // 
            // metroDateTimeDatumPocetka
            // 
            this.metroDateTimeDatumPocetka.Location = new System.Drawing.Point(23, 240);
            this.metroDateTimeDatumPocetka.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimeDatumPocetka.Name = "metroDateTimeDatumPocetka";
            this.metroDateTimeDatumPocetka.Size = new System.Drawing.Size(254, 29);
            this.metroDateTimeDatumPocetka.TabIndex = 23;
            // 
            // metroButtonDodajTerapiju
            // 
            this.metroButtonDodajTerapiju.Location = new System.Drawing.Point(23, 362);
            this.metroButtonDodajTerapiju.Name = "metroButtonDodajTerapiju";
            this.metroButtonDodajTerapiju.Size = new System.Drawing.Size(801, 23);
            this.metroButtonDodajTerapiju.TabIndex = 22;
            this.metroButtonDodajTerapiju.Text = "Dodaj terapiju";
            this.metroButtonDodajTerapiju.UseCustomForeColor = true;
            this.metroButtonDodajTerapiju.UseSelectable = true;
            this.metroButtonDodajTerapiju.Click += new System.EventHandler(this.metroButtonDodajTerapiju_Click);
            // 
            // metroTextBoxOpisTerapije
            // 
            // 
            // 
            // 
            this.metroTextBoxOpisTerapije.CustomButton.Image = null;
            this.metroTextBoxOpisTerapije.CustomButton.Location = new System.Drawing.Point(169, 2);
            this.metroTextBoxOpisTerapije.CustomButton.Name = "";
            this.metroTextBoxOpisTerapije.CustomButton.Size = new System.Drawing.Size(81, 81);
            this.metroTextBoxOpisTerapije.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxOpisTerapije.CustomButton.TabIndex = 1;
            this.metroTextBoxOpisTerapije.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxOpisTerapije.CustomButton.UseSelectable = true;
            this.metroTextBoxOpisTerapije.CustomButton.Visible = false;
            this.metroTextBoxOpisTerapije.Lines = new string[] {
        "...Unesite opis terapije"};
            this.metroTextBoxOpisTerapije.Location = new System.Drawing.Point(23, 109);
            this.metroTextBoxOpisTerapije.MaxLength = 32767;
            this.metroTextBoxOpisTerapije.Multiline = true;
            this.metroTextBoxOpisTerapije.Name = "metroTextBoxOpisTerapije";
            this.metroTextBoxOpisTerapije.PasswordChar = '\0';
            this.metroTextBoxOpisTerapije.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxOpisTerapije.SelectedText = "";
            this.metroTextBoxOpisTerapije.SelectionLength = 0;
            this.metroTextBoxOpisTerapije.SelectionStart = 0;
            this.metroTextBoxOpisTerapije.ShortcutsEnabled = true;
            this.metroTextBoxOpisTerapije.Size = new System.Drawing.Size(253, 86);
            this.metroTextBoxOpisTerapije.TabIndex = 21;
            this.metroTextBoxOpisTerapije.Text = "...Unesite opis terapije";
            this.metroTextBoxOpisTerapije.UseSelectable = true;
            this.metroTextBoxOpisTerapije.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxOpisTerapije.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Enabled = false;
            this.metroLabel2.Location = new System.Drawing.Point(24, 208);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(146, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Datum početka terapije";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Enabled = false;
            this.metroLabel5.Location = new System.Drawing.Point(23, 75);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(84, 19);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "Opis terapije";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Enabled = false;
            this.metroLabel1.Location = new System.Drawing.Point(24, 282);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(128, 19);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Datum kraja terapije";
            // 
            // metroDateTimeDatumKraja
            // 
            this.metroDateTimeDatumKraja.Location = new System.Drawing.Point(24, 311);
            this.metroDateTimeDatumKraja.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimeDatumKraja.Name = "metroDateTimeDatumKraja";
            this.metroDateTimeDatumKraja.Size = new System.Drawing.Size(254, 29);
            this.metroDateTimeDatumKraja.TabIndex = 27;
            // 
            // FormTerapije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 409);
            this.Controls.Add(this.metroDateTimeDatumKraja);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroGridDijagnoze);
            this.Controls.Add(this.metroDateTimeDatumPocetka);
            this.Controls.Add(this.metroButtonDodajTerapiju);
            this.Controls.Add(this.metroTextBoxOpisTerapije);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel5);
            this.MinimumSize = new System.Drawing.Size(840, 409);
            this.Name = "FormTerapije";
            this.Text = "FormTerapije";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTerapije_FormClosing);
            this.Load += new System.EventHandler(this.FormTerapije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridDijagnoze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroGrid metroGridDijagnoze;
        private MetroFramework.Controls.MetroDateTime metroDateTimeDatumPocetka;
        private MetroFramework.Controls.MetroButton metroButtonDodajTerapiju;
        private MetroFramework.Controls.MetroTextBox metroTextBoxOpisTerapije;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime metroDateTimeDatumKraja;
    }
}