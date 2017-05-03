namespace HippocratesDoctor
{
    partial class FormVakcine
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxImeVakcine = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonDodajVakcinu = new MetroFramework.Controls.MetroButton();
            this.metroDateTimeDatumVakcine = new MetroFramework.Controls.MetroDateTime();
            this.metroGridVakcine = new MetroFramework.Controls.MetroGrid();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxOpisVakcine = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridVakcine)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Enabled = false;
            this.metroLabel1.Location = new System.Drawing.Point(23, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Ime vakcine";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Enabled = false;
            this.metroLabel2.Location = new System.Drawing.Point(23, 145);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(94, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Datum vakcine";
            // 
            // metroTextBoxImeVakcine
            // 
            // 
            // 
            // 
            this.metroTextBoxImeVakcine.CustomButton.Image = null;
            this.metroTextBoxImeVakcine.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.metroTextBoxImeVakcine.CustomButton.Name = "";
            this.metroTextBoxImeVakcine.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxImeVakcine.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxImeVakcine.CustomButton.TabIndex = 1;
            this.metroTextBoxImeVakcine.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxImeVakcine.CustomButton.UseSelectable = true;
            this.metroTextBoxImeVakcine.CustomButton.Visible = false;
            this.metroTextBoxImeVakcine.Enabled = false;
            this.metroTextBoxImeVakcine.Lines = new string[0];
            this.metroTextBoxImeVakcine.Location = new System.Drawing.Point(23, 106);
            this.metroTextBoxImeVakcine.MaxLength = 32767;
            this.metroTextBoxImeVakcine.Name = "metroTextBoxImeVakcine";
            this.metroTextBoxImeVakcine.PasswordChar = '\0';
            this.metroTextBoxImeVakcine.ReadOnly = true;
            this.metroTextBoxImeVakcine.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxImeVakcine.SelectedText = "";
            this.metroTextBoxImeVakcine.SelectionLength = 0;
            this.metroTextBoxImeVakcine.SelectionStart = 0;
            this.metroTextBoxImeVakcine.ShortcutsEnabled = true;
            this.metroTextBoxImeVakcine.Size = new System.Drawing.Size(253, 23);
            this.metroTextBoxImeVakcine.TabIndex = 2;
            this.metroTextBoxImeVakcine.UseSelectable = true;
            this.metroTextBoxImeVakcine.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxImeVakcine.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonDodajVakcinu
            // 
            this.metroButtonDodajVakcinu.Location = new System.Drawing.Point(23, 348);
            this.metroButtonDodajVakcinu.Name = "metroButtonDodajVakcinu";
            this.metroButtonDodajVakcinu.Size = new System.Drawing.Size(801, 23);
            this.metroButtonDodajVakcinu.TabIndex = 4;
            this.metroButtonDodajVakcinu.Text = "Dodaj vakcinu";
            this.metroButtonDodajVakcinu.UseSelectable = true;
            this.metroButtonDodajVakcinu.Click += new System.EventHandler(this.metroButtonDodajVakcinu_Click);
            // 
            // metroDateTimeDatumVakcine
            // 
            this.metroDateTimeDatumVakcine.Location = new System.Drawing.Point(23, 176);
            this.metroDateTimeDatumVakcine.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTimeDatumVakcine.Name = "metroDateTimeDatumVakcine";
            this.metroDateTimeDatumVakcine.Size = new System.Drawing.Size(254, 29);
            this.metroDateTimeDatumVakcine.TabIndex = 5;
            // 
            // metroGridVakcine
            // 
            this.metroGridVakcine.AllowUserToResizeRows = false;
            this.metroGridVakcine.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridVakcine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridVakcine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridVakcine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridVakcine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGridVakcine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridVakcine.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGridVakcine.EnableHeadersVisualStyles = false;
            this.metroGridVakcine.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridVakcine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridVakcine.Location = new System.Drawing.Point(317, 106);
            this.metroGridVakcine.Name = "metroGridVakcine";
            this.metroGridVakcine.ReadOnly = true;
            this.metroGridVakcine.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridVakcine.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGridVakcine.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridVakcine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridVakcine.Size = new System.Drawing.Size(507, 211);
            this.metroGridVakcine.TabIndex = 6;
            this.metroGridVakcine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridVakcine_CellContentClick);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(317, 73);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Sve vakcine";
            // 
            // metroTextBoxOpisVakcine
            // 
            // 
            // 
            // 
            this.metroTextBoxOpisVakcine.CustomButton.Image = null;
            this.metroTextBoxOpisVakcine.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.metroTextBoxOpisVakcine.CustomButton.Name = "";
            this.metroTextBoxOpisVakcine.CustomButton.Size = new System.Drawing.Size(57, 57);
            this.metroTextBoxOpisVakcine.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxOpisVakcine.CustomButton.TabIndex = 1;
            this.metroTextBoxOpisVakcine.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxOpisVakcine.CustomButton.UseSelectable = true;
            this.metroTextBoxOpisVakcine.CustomButton.Visible = false;
            this.metroTextBoxOpisVakcine.Enabled = false;
            this.metroTextBoxOpisVakcine.Lines = new string[0];
            this.metroTextBoxOpisVakcine.Location = new System.Drawing.Point(23, 258);
            this.metroTextBoxOpisVakcine.MaxLength = 32767;
            this.metroTextBoxOpisVakcine.Multiline = true;
            this.metroTextBoxOpisVakcine.Name = "metroTextBoxOpisVakcine";
            this.metroTextBoxOpisVakcine.PasswordChar = '\0';
            this.metroTextBoxOpisVakcine.ReadOnly = true;
            this.metroTextBoxOpisVakcine.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxOpisVakcine.SelectedText = "";
            this.metroTextBoxOpisVakcine.SelectionLength = 0;
            this.metroTextBoxOpisVakcine.SelectionStart = 0;
            this.metroTextBoxOpisVakcine.ShortcutsEnabled = true;
            this.metroTextBoxOpisVakcine.Size = new System.Drawing.Size(253, 59);
            this.metroTextBoxOpisVakcine.TabIndex = 8;
            this.metroTextBoxOpisVakcine.UseSelectable = true;
            this.metroTextBoxOpisVakcine.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxOpisVakcine.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Enabled = false;
            this.metroLabel4.Location = new System.Drawing.Point(23, 219);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Opis vakcine";
            // 
            // FormVakcine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 402);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTextBoxOpisVakcine);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroGridVakcine);
            this.Controls.Add(this.metroDateTimeDatumVakcine);
            this.Controls.Add(this.metroButtonDodajVakcinu);
            this.Controls.Add(this.metroTextBoxImeVakcine);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FormVakcine";
            this.Text = "FormVakcine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVakcine_FormClosing);
            this.Load += new System.EventHandler(this.FormVakcine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridVakcine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxImeVakcine;
        private MetroFramework.Controls.MetroButton metroButtonDodajVakcinu;
        private MetroFramework.Controls.MetroDateTime metroDateTimeDatumVakcine;
        private MetroFramework.Controls.MetroGrid metroGridVakcine;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBoxOpisVakcine;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}