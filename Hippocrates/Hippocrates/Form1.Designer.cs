﻿namespace Hippocrates
{
    partial class Form1
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
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.lbl_KorisnickoIme = new System.Windows.Forms.Label();
            this.lbl_Lozinka = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(55, 234);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(146, 78);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(26, 131);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(199, 29);
            this.tb_username.TabIndex = 2;
            // 
            // tb_pass
            // 
            this.tb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pass.Location = new System.Drawing.Point(26, 189);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(199, 29);
            this.tb_pass.TabIndex = 3;
            this.tb_pass.UseSystemPasswordChar = true;
            // 
            // lbl_KorisnickoIme
            // 
            this.lbl_KorisnickoIme.AutoSize = true;
            this.lbl_KorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KorisnickoIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_KorisnickoIme.Location = new System.Drawing.Point(28, 105);
            this.lbl_KorisnickoIme.Name = "lbl_KorisnickoIme";
            this.lbl_KorisnickoIme.Size = new System.Drawing.Size(97, 24);
            this.lbl_KorisnickoIme.TabIndex = 4;
            this.lbl_KorisnickoIme.Text = "Username";
            // 
            // lbl_Lozinka
            // 
            this.lbl_Lozinka.AutoSize = true;
            this.lbl_Lozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lozinka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Lozinka.Location = new System.Drawing.Point(28, 162);
            this.lbl_Lozinka.Name = "lbl_Lozinka";
            this.lbl_Lozinka.Size = new System.Drawing.Size(92, 24);
            this.lbl_Lozinka.TabIndex = 5;
            this.lbl_Lozinka.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(123, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hippocrates";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hippocrates.Properties.Resources.logoHipoDesktopApp;
            this.pictureBox2.Location = new System.Drawing.Point(22, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 78);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hippocrates.Properties.Resources.loginScreenPicture;
            this.pictureBox1.Location = new System.Drawing.Point(244, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 257);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(404, 340);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Lozinka);
            this.Controls.Add(this.lbl_KorisnickoIme);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.btn_login);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label lbl_KorisnickoIme;
        private System.Windows.Forms.Label lbl_Lozinka;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}

