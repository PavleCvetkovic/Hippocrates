namespace Hippocrates.SharedForms
{
    partial class Napomena_Form
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
            this.metroTextBoxNapomena = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonOK = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroTextBoxNapomena
            // 
            // 
            // 
            // 
            this.metroTextBoxNapomena.CustomButton.Image = null;
            this.metroTextBoxNapomena.CustomButton.Location = new System.Drawing.Point(201, 2);
            this.metroTextBoxNapomena.CustomButton.Name = "";
            this.metroTextBoxNapomena.CustomButton.Size = new System.Drawing.Size(129, 129);
            this.metroTextBoxNapomena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxNapomena.CustomButton.TabIndex = 1;
            this.metroTextBoxNapomena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxNapomena.CustomButton.UseSelectable = true;
            this.metroTextBoxNapomena.CustomButton.Visible = false;
            this.metroTextBoxNapomena.Lines = new string[] {
        "..."};
            this.metroTextBoxNapomena.Location = new System.Drawing.Point(24, 99);
            this.metroTextBoxNapomena.MaxLength = 32767;
            this.metroTextBoxNapomena.Multiline = true;
            this.metroTextBoxNapomena.Name = "metroTextBoxNapomena";
            this.metroTextBoxNapomena.PasswordChar = '\0';
            this.metroTextBoxNapomena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxNapomena.SelectedText = "";
            this.metroTextBoxNapomena.SelectionLength = 0;
            this.metroTextBoxNapomena.SelectionStart = 0;
            this.metroTextBoxNapomena.ShortcutsEnabled = true;
            this.metroTextBoxNapomena.Size = new System.Drawing.Size(333, 134);
            this.metroTextBoxNapomena.TabIndex = 0;
            this.metroTextBoxNapomena.Text = "...";
            this.metroTextBoxNapomena.UseSelectable = true;
            this.metroTextBoxNapomena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxNapomena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(122, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Dodajte napomenu";
            // 
            // metroButtonOK
            // 
            this.metroButtonOK.Location = new System.Drawing.Point(24, 249);
            this.metroButtonOK.Name = "metroButtonOK";
            this.metroButtonOK.Size = new System.Drawing.Size(333, 23);
            this.metroButtonOK.TabIndex = 2;
            this.metroButtonOK.Text = "OK";
            this.metroButtonOK.UseSelectable = true;
            this.metroButtonOK.Click += new System.EventHandler(this.metroButtonOK_Click);
            // 
            // Napomena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 295);
            this.Controls.Add(this.metroButtonOK);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBoxNapomena);
            this.Name = "Napomena";
            this.Text = "Napomena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBoxNapomena;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButtonOK;
    }
}