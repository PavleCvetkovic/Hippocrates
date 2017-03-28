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
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabLekar = new MetroFramework.Controls.MetroTabPage();
            this.tabOsoblje = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.tabLeakrBrisanje = new MetroFramework.Controls.MetroTabPage();
            this.tabLekarUnos = new MetroFramework.Controls.MetroTabPage();
            this.tabLekarAzuriranje = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1.SuspendLayout();
            this.tabLekar.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(621, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
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
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.tabLeakrBrisanje);
            this.metroTabControl2.Controls.Add(this.tabLekarUnos);
            this.metroTabControl2.Controls.Add(this.tabLekarAzuriranje);
            this.metroTabControl2.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 0;
            this.metroTabControl2.Size = new System.Drawing.Size(841, 536);
            this.metroTabControl2.TabIndex = 2;
            this.metroTabControl2.UseSelectable = true;
            // 
            // tabLeakrBrisanje
            // 
            this.tabLeakrBrisanje.HorizontalScrollbarBarColor = true;
            this.tabLeakrBrisanje.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLeakrBrisanje.HorizontalScrollbarSize = 10;
            this.tabLeakrBrisanje.Location = new System.Drawing.Point(4, 38);
            this.tabLeakrBrisanje.Name = "tabLeakrBrisanje";
            this.tabLeakrBrisanje.Size = new System.Drawing.Size(833, 494);
            this.tabLeakrBrisanje.TabIndex = 0;
            this.tabLeakrBrisanje.Text = "Brisnje podataka o lekarima";
            this.tabLeakrBrisanje.VerticalScrollbarBarColor = true;
            this.tabLeakrBrisanje.VerticalScrollbarHighlightOnWheel = false;
            this.tabLeakrBrisanje.VerticalScrollbarSize = 10;
            // 
            // tabLekarUnos
            // 
            this.tabLekarUnos.HorizontalScrollbarBarColor = true;
            this.tabLekarUnos.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLekarUnos.HorizontalScrollbarSize = 10;
            this.tabLekarUnos.Location = new System.Drawing.Point(4, 38);
            this.tabLekarUnos.Name = "tabLekarUnos";
            this.tabLekarUnos.Size = new System.Drawing.Size(833, 494);
            this.tabLekarUnos.TabIndex = 1;
            this.tabLekarUnos.Text = "Unosenje podataka o novom lekaru";
            this.tabLekarUnos.VerticalScrollbarBarColor = true;
            this.tabLekarUnos.VerticalScrollbarHighlightOnWheel = false;
            this.tabLekarUnos.VerticalScrollbarSize = 10;
            // 
            // tabLekarAzuriranje
            // 
            this.tabLekarAzuriranje.HorizontalScrollbarBarColor = true;
            this.tabLekarAzuriranje.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLekarAzuriranje.HorizontalScrollbarSize = 10;
            this.tabLekarAzuriranje.Location = new System.Drawing.Point(4, 38);
            this.tabLekarAzuriranje.Name = "tabLekarAzuriranje";
            this.tabLekarAzuriranje.Size = new System.Drawing.Size(833, 494);
            this.tabLekarAzuriranje.TabIndex = 2;
            this.tabLekarAzuriranje.Text = "Azuriranje podataka o lekaru";
            this.tabLekarAzuriranje.VerticalScrollbarBarColor = true;
            this.tabLekarAzuriranje.VerticalScrollbarHighlightOnWheel = false;
            this.tabLekarAzuriranje.VerticalScrollbarSize = 10;
            // 
            // FormDirektor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 673);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.label1);
            this.Name = "FormDirektor";
            this.Text = "Administrator panel";
            this.metroTabControl1.ResumeLayout(false);
            this.tabLekar.ResumeLayout(false);
            this.metroTabControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabLekar;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage tabLeakrBrisanje;
        private MetroFramework.Controls.MetroTabPage tabLekarUnos;
        private MetroFramework.Controls.MetroTabPage tabLekarAzuriranje;
        private MetroFramework.Controls.MetroTabPage tabOsoblje;
    }
}