namespace SipraişUygulaması
{
    partial class UrunEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunEkle));
            this.buttonAddLog = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonDeleteLog = new System.Windows.Forms.Button();
            this.buttonUpdateLog = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddLog
            // 
            this.buttonAddLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.buttonAddLog.FlatAppearance.BorderSize = 0;
            this.buttonAddLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddLog.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAddLog.ForeColor = System.Drawing.Color.White;
            this.buttonAddLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddLog.ImageKey = "ekleme.png";
            this.buttonAddLog.ImageList = this.ımageList1;
            this.buttonAddLog.Location = new System.Drawing.Point(-1, 0);
            this.buttonAddLog.Name = "buttonAddLog";
            this.buttonAddLog.Size = new System.Drawing.Size(132, 68);
            this.buttonAddLog.TabIndex = 5;
            this.buttonAddLog.Text = "     Ekle";
            this.buttonAddLog.UseVisualStyleBackColor = false;
            this.buttonAddLog.Click += new System.EventHandler(this.ButtonAddLog_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ekleme.png");
            this.ımageList1.Images.SetKeyName(1, "güncelle.png");
            this.ımageList1.Images.SetKeyName(2, "sil.png");
            // 
            // buttonDeleteLog
            // 
            this.buttonDeleteLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.buttonDeleteLog.FlatAppearance.BorderSize = 0;
            this.buttonDeleteLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteLog.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDeleteLog.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteLog.ImageKey = "sil.png";
            this.buttonDeleteLog.ImageList = this.ımageList1;
            this.buttonDeleteLog.Location = new System.Drawing.Point(275, 0);
            this.buttonDeleteLog.Name = "buttonDeleteLog";
            this.buttonDeleteLog.Size = new System.Drawing.Size(132, 68);
            this.buttonDeleteLog.TabIndex = 7;
            this.buttonDeleteLog.Text = "    Sil";
            this.buttonDeleteLog.UseVisualStyleBackColor = false;
            this.buttonDeleteLog.Click += new System.EventHandler(this.ButtonDeleteLog_Click);
            // 
            // buttonUpdateLog
            // 
            this.buttonUpdateLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.buttonUpdateLog.FlatAppearance.BorderSize = 0;
            this.buttonUpdateLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateLog.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUpdateLog.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdateLog.ImageKey = "güncelle.png";
            this.buttonUpdateLog.ImageList = this.ımageList1;
            this.buttonUpdateLog.Location = new System.Drawing.Point(137, 0);
            this.buttonUpdateLog.Name = "buttonUpdateLog";
            this.buttonUpdateLog.Size = new System.Drawing.Size(132, 68);
            this.buttonUpdateLog.TabIndex = 6;
            this.buttonUpdateLog.Text = "      Güncelle";
            this.buttonUpdateLog.UseVisualStyleBackColor = false;
            this.buttonUpdateLog.Click += new System.EventHandler(this.ButtonUpdateLog_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.buttonAddLog);
            this.panel1.Controls.Add(this.buttonUpdateLog);
            this.panel1.Controls.Add(this.buttonDeleteLog);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 71);
            this.panel1.TabIndex = 113;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 135);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 93);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(208, 23);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Birim fiyat :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 23);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün adı :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 23);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(878, 453);
            this.dataGridView1.TabIndex = 114;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(877, 666);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UrunEkle";
            this.Text = "UrunEkle";
            this.Load += new System.EventHandler(this.UrunEkle_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddLog;
        private System.Windows.Forms.Button buttonDeleteLog;
        private System.Windows.Forms.Button buttonUpdateLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}