namespace Sınav_Hatırlatıcı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.txt_Sınav_adı = new System.Windows.Forms.ComboBox();
            this.txt_tarih = new System.Windows.Forms.DateTimePicker();
            this.btn_yaklaşan_sınavlar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_saat = new System.Windows.Forms.TextBox();
            this.txt_dakika = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.ForeColor = System.Drawing.Color.Bisque;
            this.btn_kaydet.Location = new System.Drawing.Point(29, 136);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(147, 37);
            this.btn_kaydet.TabIndex = 0;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txt_Sınav_adı
            // 
            this.txt_Sınav_adı.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Sınav_adı.FormattingEnabled = true;
            this.txt_Sınav_adı.Items.AddRange(new object[] {
            "Matematik",
            "Dil Bilgisi",
            "Edebiyat",
            "Resim",
            "Müzik"});
            this.txt_Sınav_adı.Location = new System.Drawing.Point(29, 15);
            this.txt_Sınav_adı.Name = "txt_Sınav_adı";
            this.txt_Sınav_adı.Size = new System.Drawing.Size(183, 33);
            this.txt_Sınav_adı.TabIndex = 1;
            // 
            // txt_tarih
            // 
            this.txt_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tarih.Location = new System.Drawing.Point(29, 62);
            this.txt_tarih.Name = "txt_tarih";
            this.txt_tarih.Size = new System.Drawing.Size(300, 30);
            this.txt_tarih.TabIndex = 2;
            // 
            // btn_yaklaşan_sınavlar
            // 
            this.btn_yaklaşan_sınavlar.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_yaklaşan_sınavlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yaklaşan_sınavlar.ForeColor = System.Drawing.Color.Bisque;
            this.btn_yaklaşan_sınavlar.Location = new System.Drawing.Point(182, 136);
            this.btn_yaklaşan_sınavlar.Name = "btn_yaklaşan_sınavlar";
            this.btn_yaklaşan_sınavlar.Size = new System.Drawing.Size(147, 37);
            this.btn_yaklaşan_sınavlar.TabIndex = 0;
            this.btn_yaklaşan_sınavlar.Text = "Yaklaşan Sınavlar";
            this.btn_yaklaşan_sınavlar.UseVisualStyleBackColor = false;
            this.btn_yaklaşan_sınavlar.Click += new System.EventHandler(this.btn_yaklaşan_sınavlar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 235);
            this.dataGridView1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(382, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.Bisque;
            this.btn_sil.Location = new System.Drawing.Point(29, 179);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(147, 37);
            this.btn_sil.TabIndex = 0;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_güncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_güncelle.ForeColor = System.Drawing.Color.Bisque;
            this.btn_güncelle.Location = new System.Drawing.Point(182, 179);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(147, 37);
            this.btn_güncelle.TabIndex = 0;
            this.btn_güncelle.Text = "Güncelle";
            this.btn_güncelle.UseVisualStyleBackColor = false;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID:";
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ID.Location = new System.Drawing.Point(248, 18);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(81, 30);
            this.txt_ID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "(Silmek için ID giriniz!)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "(Güncellemek için ID giriniz!)";
            // 
            // txt_saat
            // 
            this.txt_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_saat.Location = new System.Drawing.Point(79, 98);
            this.txt_saat.Name = "txt_saat";
            this.txt_saat.Size = new System.Drawing.Size(38, 30);
            this.txt_saat.TabIndex = 9;
            // 
            // txt_dakika
            // 
            this.txt_dakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_dakika.Location = new System.Drawing.Point(184, 100);
            this.txt_dakika.Name = "txt_dakika";
            this.txt_dakika.Size = new System.Drawing.Size(38, 30);
            this.txt_dakika.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "SAAT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "DAKİKA:";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(228, 98);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(101, 32);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(745, 474);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_dakika);
            this.Controls.Add(this.txt_saat);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_tarih);
            this.Controls.Add(this.txt_Sınav_adı);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.btn_yaklaşan_sınavlar);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_kaydet);
            this.Name = "Form1";
            this.Text = "Sınavlar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.ComboBox txt_Sınav_adı;
        private System.Windows.Forms.DateTimePicker txt_tarih;
        private System.Windows.Forms.Button btn_yaklaşan_sınavlar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TextBox txt_saat;
        private System.Windows.Forms.TextBox txt_dakika;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

