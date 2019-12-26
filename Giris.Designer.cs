namespace SipraişUygulaması
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.butonCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKayitOl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butonMagazaGiris = new System.Windows.Forms.Button();
            this.butonKullaniciGiris = new System.Windows.Forms.Button();
            this.txtKAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.butonCikis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 100);
            this.panel1.TabIndex = 0;
            // 
            // butonCikis
            // 
            this.butonCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butonCikis.BackgroundImage = global::SipraişUygulaması.Properties.Resources.Exit;
            this.butonCikis.FlatAppearance.BorderSize = 0;
            this.butonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butonCikis.Location = new System.Drawing.Point(773, 22);
            this.butonCikis.Name = "butonCikis";
            this.butonCikis.Size = new System.Drawing.Size(49, 49);
            this.butonCikis.TabIndex = 0;
            this.butonCikis.UseVisualStyleBackColor = true;
            this.butonCikis.Click += new System.EventHandler(this.ButonCikis_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(393, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giriş Yap";
            // 
            // labelKayitOl
            // 
            this.labelKayitOl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKayitOl.AutoSize = true;
            this.labelKayitOl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKayitOl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.labelKayitOl.Location = new System.Drawing.Point(398, 373);
            this.labelKayitOl.Name = "labelKayitOl";
            this.labelKayitOl.Size = new System.Drawing.Size(51, 16);
            this.labelKayitOl.TabIndex = 24;
            this.labelKayitOl.Text = "Kayıt Ol";
            this.labelKayitOl.Click += new System.EventHandler(this.LabelKayitOl_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(273, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(273, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Kullancı Adı :";
            // 
            // butonMagazaGiris
            // 
            this.butonMagazaGiris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butonMagazaGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.butonMagazaGiris.FlatAppearance.BorderSize = 0;
            this.butonMagazaGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butonMagazaGiris.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonMagazaGiris.ForeColor = System.Drawing.Color.White;
            this.butonMagazaGiris.Location = new System.Drawing.Point(429, 401);
            this.butonMagazaGiris.Name = "butonMagazaGiris";
            this.butonMagazaGiris.Size = new System.Drawing.Size(140, 40);
            this.butonMagazaGiris.TabIndex = 21;
            this.butonMagazaGiris.Text = "Mağaza Girişi";
            this.butonMagazaGiris.UseVisualStyleBackColor = false;
            this.butonMagazaGiris.Click += new System.EventHandler(this.ButonMagazaGiris_Click);
            // 
            // butonKullaniciGiris
            // 
            this.butonKullaniciGiris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butonKullaniciGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.butonKullaniciGiris.FlatAppearance.BorderSize = 0;
            this.butonKullaniciGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butonKullaniciGiris.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonKullaniciGiris.ForeColor = System.Drawing.Color.White;
            this.butonKullaniciGiris.Location = new System.Drawing.Point(276, 401);
            this.butonKullaniciGiris.Name = "butonKullaniciGiris";
            this.butonKullaniciGiris.Size = new System.Drawing.Size(147, 40);
            this.butonKullaniciGiris.TabIndex = 20;
            this.butonKullaniciGiris.Text = "Kullanıcı Girişi";
            this.butonKullaniciGiris.UseVisualStyleBackColor = false;
            this.butonKullaniciGiris.Click += new System.EventHandler(this.ButonKullaniciGiris_Click);
            // 
            // txtKAdi
            // 
            this.txtKAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKAdi.Location = new System.Drawing.Point(370, 293);
            this.txtKAdi.Name = "txtKAdi";
            this.txtKAdi.Size = new System.Drawing.Size(199, 20);
            this.txtKAdi.TabIndex = 25;
            // 
            // txtSifre
            // 
            this.txtSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSifre.Location = new System.Drawing.Point(370, 337);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(199, 20);
            this.txtSifre.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 664);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKAdi);
            this.Controls.Add(this.labelKayitOl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butonMagazaGiris);
            this.Controls.Add(this.butonKullaniciGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Sayfası";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKayitOl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butonMagazaGiris;
        private System.Windows.Forms.Button butonKullaniciGiris;
        private System.Windows.Forms.TextBox txtKAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button butonCikis;
    }
}

