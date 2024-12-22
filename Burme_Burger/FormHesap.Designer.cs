namespace Burme_Burger
{
    partial class FormHesap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHesap));
            this.btn_ana1 = new System.Windows.Forms.Button();
            this.colorChangeTimer = new System.Windows.Forms.Timer(this.components);
            this.transparentRoundedPanel3 = new TransparentRoundedPanel();
            this.btn_kkayit = new System.Windows.Forms.Button();
            this.maskedTextBox_kart = new System.Windows.Forms.MaskedTextBox();
            this.btn_kartekle = new System.Windows.Forms.Button();
            this.listBox_kartlarim = new System.Windows.Forms.ListBox();
            this.lbl_kartlarim = new System.Windows.Forms.Label();
            this.transparentRoundedPanel2 = new TransparentRoundedPanel();
            this.btn_akayit = new System.Windows.Forms.Button();
            this.richTextBox_adresekle = new System.Windows.Forms.RichTextBox();
            this.listBox_adreslerim = new System.Windows.Forms.ListBox();
            this.btn_adresekle = new System.Windows.Forms.Button();
            this.lbl_adreslerim = new System.Windows.Forms.Label();
            this.transparentRoundedPanel1 = new TransparentRoundedPanel();
            this.lbl_slogan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.transparentRoundedPanel4 = new TransparentRoundedPanel();
            this.lbl_siparisver = new System.Windows.Forms.LinkLabel();
            this.lbl_aktif = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_hosgeldin = new System.Windows.Forms.Label();
            this.transparentRoundedPanel3.SuspendLayout();
            this.transparentRoundedPanel2.SuspendLayout();
            this.transparentRoundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.transparentRoundedPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ana1
            // 
            this.btn_ana1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(153)))), ((int)(((byte)(117)))));
            this.btn_ana1.FlatAppearance.BorderSize = 0;
            this.btn_ana1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ana1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.btn_ana1.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ana1.Location = new System.Drawing.Point(-15, 21);
            this.btn_ana1.Name = "btn_ana1";
            this.btn_ana1.Size = new System.Drawing.Size(142, 132);
            this.btn_ana1.TabIndex = 3;
            this.btn_ana1.Text = "  Anasayfaya Dön";
            this.btn_ana1.UseVisualStyleBackColor = false;
            this.btn_ana1.Click += new System.EventHandler(this.btn_ana_Click);
            // 
            // colorChangeTimer
            // 
            this.colorChangeTimer.Tick += new System.EventHandler(this.colorChangeTimer_Tick_1);
            // 
            // transparentRoundedPanel3
            // 
            this.transparentRoundedPanel3.Alpha = 200;
            this.transparentRoundedPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(187)))), ((int)(((byte)(159)))));
            this.transparentRoundedPanel3.Controls.Add(this.btn_kkayit);
            this.transparentRoundedPanel3.Controls.Add(this.maskedTextBox_kart);
            this.transparentRoundedPanel3.Controls.Add(this.btn_kartekle);
            this.transparentRoundedPanel3.Controls.Add(this.listBox_kartlarim);
            this.transparentRoundedPanel3.Controls.Add(this.lbl_kartlarim);
            this.transparentRoundedPanel3.CornerRadius = 50;
            this.transparentRoundedPanel3.Location = new System.Drawing.Point(560, 320);
            this.transparentRoundedPanel3.Name = "transparentRoundedPanel3";
            this.transparentRoundedPanel3.Size = new System.Drawing.Size(432, 311);
            this.transparentRoundedPanel3.TabIndex = 2;
            // 
            // btn_kkayit
            // 
            this.btn_kkayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(39)))), ((int)(((byte)(36)))));
            this.btn_kkayit.FlatAppearance.BorderSize = 0;
            this.btn_kkayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kkayit.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kkayit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_kkayit.Location = new System.Drawing.Point(245, 257);
            this.btn_kkayit.Name = "btn_kkayit";
            this.btn_kkayit.Size = new System.Drawing.Size(116, 44);
            this.btn_kkayit.TabIndex = 4;
            this.btn_kkayit.Text = "Kaydet";
            this.btn_kkayit.UseVisualStyleBackColor = false;
            this.btn_kkayit.Click += new System.EventHandler(this.btn_kkayit_Click);
            // 
            // maskedTextBox_kart
            // 
            this.maskedTextBox_kart.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox_kart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.maskedTextBox_kart.Location = new System.Drawing.Point(202, 200);
            this.maskedTextBox_kart.Mask = "0000 0000 0000 0000";
            this.maskedTextBox_kart.Name = "maskedTextBox_kart";
            this.maskedTextBox_kart.Size = new System.Drawing.Size(183, 39);
            this.maskedTextBox_kart.TabIndex = 3;
            // 
            // btn_kartekle
            // 
            this.btn_kartekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(39)))), ((int)(((byte)(36)))));
            this.btn_kartekle.FlatAppearance.BorderSize = 0;
            this.btn_kartekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kartekle.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kartekle.ForeColor = System.Drawing.Color.Transparent;
            this.btn_kartekle.Location = new System.Drawing.Point(11, 200);
            this.btn_kartekle.Name = "btn_kartekle";
            this.btn_kartekle.Size = new System.Drawing.Size(164, 36);
            this.btn_kartekle.TabIndex = 2;
            this.btn_kartekle.Text = "Yeni Kart Ekle";
            this.btn_kartekle.UseVisualStyleBackColor = false;
            this.btn_kartekle.Click += new System.EventHandler(this.btn_kartekle_Click);
            // 
            // listBox_kartlarim
            // 
            this.listBox_kartlarim.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox_kartlarim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listBox_kartlarim.FormattingEnabled = true;
            this.listBox_kartlarim.HorizontalScrollbar = true;
            this.listBox_kartlarim.ItemHeight = 35;
            this.listBox_kartlarim.Location = new System.Drawing.Point(11, 48);
            this.listBox_kartlarim.Name = "listBox_kartlarim";
            this.listBox_kartlarim.Size = new System.Drawing.Size(414, 109);
            this.listBox_kartlarim.TabIndex = 1;
            // 
            // lbl_kartlarim
            // 
            this.lbl_kartlarim.AutoSize = true;
            this.lbl_kartlarim.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_kartlarim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(153)))), ((int)(((byte)(117)))));
            this.lbl_kartlarim.Location = new System.Drawing.Point(11, 11);
            this.lbl_kartlarim.Name = "lbl_kartlarim";
            this.lbl_kartlarim.Size = new System.Drawing.Size(273, 50);
            this.lbl_kartlarim.TabIndex = 0;
            this.lbl_kartlarim.Text = "Ödeme Bilgilerim:";
            // 
            // transparentRoundedPanel2
            // 
            this.transparentRoundedPanel2.Alpha = 200;
            this.transparentRoundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(187)))), ((int)(((byte)(159)))));
            this.transparentRoundedPanel2.Controls.Add(this.btn_akayit);
            this.transparentRoundedPanel2.Controls.Add(this.richTextBox_adresekle);
            this.transparentRoundedPanel2.Controls.Add(this.listBox_adreslerim);
            this.transparentRoundedPanel2.Controls.Add(this.btn_adresekle);
            this.transparentRoundedPanel2.Controls.Add(this.lbl_adreslerim);
            this.transparentRoundedPanel2.CornerRadius = 50;
            this.transparentRoundedPanel2.Location = new System.Drawing.Point(123, 320);
            this.transparentRoundedPanel2.Name = "transparentRoundedPanel2";
            this.transparentRoundedPanel2.Size = new System.Drawing.Size(432, 311);
            this.transparentRoundedPanel2.TabIndex = 1;
            // 
            // btn_akayit
            // 
            this.btn_akayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(39)))), ((int)(((byte)(36)))));
            this.btn_akayit.FlatAppearance.BorderSize = 0;
            this.btn_akayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_akayit.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_akayit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_akayit.Location = new System.Drawing.Point(259, 257);
            this.btn_akayit.Name = "btn_akayit";
            this.btn_akayit.Size = new System.Drawing.Size(116, 44);
            this.btn_akayit.TabIndex = 4;
            this.btn_akayit.Text = "Kaydet";
            this.btn_akayit.UseVisualStyleBackColor = false;
            this.btn_akayit.Click += new System.EventHandler(this.btn_akayit_Click);
            // 
            // richTextBox_adresekle
            // 
            this.richTextBox_adresekle.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox_adresekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.richTextBox_adresekle.Location = new System.Drawing.Point(189, 185);
            this.richTextBox_adresekle.Name = "richTextBox_adresekle";
            this.richTextBox_adresekle.Size = new System.Drawing.Size(232, 64);
            this.richTextBox_adresekle.TabIndex = 3;
            this.richTextBox_adresekle.Text = "";
            // 
            // listBox_adreslerim
            // 
            this.listBox_adreslerim.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox_adreslerim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listBox_adreslerim.FormattingEnabled = true;
            this.listBox_adreslerim.HorizontalScrollbar = true;
            this.listBox_adreslerim.ItemHeight = 35;
            this.listBox_adreslerim.Location = new System.Drawing.Point(7, 48);
            this.listBox_adreslerim.Name = "listBox_adreslerim";
            this.listBox_adreslerim.Size = new System.Drawing.Size(418, 109);
            this.listBox_adreslerim.TabIndex = 2;
            // 
            // btn_adresekle
            // 
            this.btn_adresekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(39)))), ((int)(((byte)(36)))));
            this.btn_adresekle.FlatAppearance.BorderSize = 0;
            this.btn_adresekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adresekle.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.btn_adresekle.ForeColor = System.Drawing.Color.Transparent;
            this.btn_adresekle.Location = new System.Drawing.Point(7, 200);
            this.btn_adresekle.Name = "btn_adresekle";
            this.btn_adresekle.Size = new System.Drawing.Size(176, 36);
            this.btn_adresekle.TabIndex = 1;
            this.btn_adresekle.Text = " Yeni Adres Ekle";
            this.btn_adresekle.UseVisualStyleBackColor = false;
            this.btn_adresekle.Click += new System.EventHandler(this.btn_adresekle_Click);
            // 
            // lbl_adreslerim
            // 
            this.lbl_adreslerim.AutoSize = true;
            this.lbl_adreslerim.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_adreslerim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(153)))), ((int)(((byte)(117)))));
            this.lbl_adreslerim.Location = new System.Drawing.Point(13, 11);
            this.lbl_adreslerim.Name = "lbl_adreslerim";
            this.lbl_adreslerim.Size = new System.Drawing.Size(184, 50);
            this.lbl_adreslerim.TabIndex = 0;
            this.lbl_adreslerim.Text = "Adreslerim:";
            // 
            // transparentRoundedPanel1
            // 
            this.transparentRoundedPanel1.Alpha = 200;
            this.transparentRoundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(39)))), ((int)(((byte)(36)))));
            this.transparentRoundedPanel1.Controls.Add(this.lbl_slogan);
            this.transparentRoundedPanel1.Controls.Add(this.pictureBox1);
            this.transparentRoundedPanel1.Controls.Add(this.transparentRoundedPanel4);
            this.transparentRoundedPanel1.Controls.Add(this.lbl_hosgeldin);
            this.transparentRoundedPanel1.CornerRadius = 50;
            this.transparentRoundedPanel1.Location = new System.Drawing.Point(123, 12);
            this.transparentRoundedPanel1.Name = "transparentRoundedPanel1";
            this.transparentRoundedPanel1.Size = new System.Drawing.Size(862, 295);
            this.transparentRoundedPanel1.TabIndex = 0;
            // 
            // lbl_slogan
            // 
            this.lbl_slogan.AutoSize = true;
            this.lbl_slogan.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_slogan.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_slogan.Location = new System.Drawing.Point(22, 246);
            this.lbl_slogan.Name = "lbl_slogan";
            this.lbl_slogan.Size = new System.Drawing.Size(562, 64);
            this.lbl_slogan.TabIndex = 2;
            this.lbl_slogan.Text = "VAR MI BURME\'DEN ÖTESİ !";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 260);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // transparentRoundedPanel4
            // 
            this.transparentRoundedPanel4.Alpha = 200;
            this.transparentRoundedPanel4.Controls.Add(this.lbl_siparisver);
            this.transparentRoundedPanel4.Controls.Add(this.lbl_aktif);
            this.transparentRoundedPanel4.Controls.Add(this.pictureBox2);
            this.transparentRoundedPanel4.CornerRadius = 50;
            this.transparentRoundedPanel4.ForeColor = System.Drawing.Color.Transparent;
            this.transparentRoundedPanel4.Location = new System.Drawing.Point(415, 61);
            this.transparentRoundedPanel4.Name = "transparentRoundedPanel4";
            this.transparentRoundedPanel4.Size = new System.Drawing.Size(444, 231);
            this.transparentRoundedPanel4.TabIndex = 3;
            // 
            // lbl_siparisver
            // 
            this.lbl_siparisver.ActiveLinkColor = System.Drawing.Color.SeaShell;
            this.lbl_siparisver.AutoSize = true;
            this.lbl_siparisver.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.lbl_siparisver.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbl_siparisver.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(142)))), ((int)(((byte)(111)))));
            this.lbl_siparisver.Location = new System.Drawing.Point(63, 185);
            this.lbl_siparisver.Name = "lbl_siparisver";
            this.lbl_siparisver.Size = new System.Drawing.Size(243, 30);
            this.lbl_siparisver.TabIndex = 2;
            this.lbl_siparisver.TabStop = true;
            this.lbl_siparisver.Text = "Hemen Sipariş Ver !";
            this.lbl_siparisver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_siparisver_LinkClicked);
            // 
            // lbl_aktif
            // 
            this.lbl_aktif.AutoSize = true;
            this.lbl_aktif.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_aktif.Location = new System.Drawing.Point(3, 139);
            this.lbl_aktif.Name = "lbl_aktif";
            this.lbl_aktif.Size = new System.Drawing.Size(462, 50);
            this.lbl_aktif.TabIndex = 1;
            this.lbl_aktif.Text = "Aktif Siparişiniz Bulunmuyor... ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 124);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_hosgeldin
            // 
            this.lbl_hosgeldin.AutoSize = true;
            this.lbl_hosgeldin.Font = new System.Drawing.Font("Segoe Print", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hosgeldin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(153)))), ((int)(((byte)(117)))));
            this.lbl_hosgeldin.Location = new System.Drawing.Point(410, -3);
            this.lbl_hosgeldin.Name = "lbl_hosgeldin";
            this.lbl_hosgeldin.Size = new System.Drawing.Size(539, 98);
            this.lbl_hosgeldin.TabIndex = 1;
            this.lbl_hosgeldin.Text = "HOŞGELDİNİZZ...";
            // 
            // FormHesap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(142)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(1070, 635);
            this.Controls.Add(this.btn_ana1);
            this.Controls.Add(this.transparentRoundedPanel3);
            this.Controls.Add(this.transparentRoundedPanel2);
            this.Controls.Add(this.transparentRoundedPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHesap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Hesabım";
            this.Load += new System.EventHandler(this.FormHesap_Load);
            this.transparentRoundedPanel3.ResumeLayout(false);
            this.transparentRoundedPanel3.PerformLayout();
            this.transparentRoundedPanel2.ResumeLayout(false);
            this.transparentRoundedPanel2.PerformLayout();
            this.transparentRoundedPanel1.ResumeLayout(false);
            this.transparentRoundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.transparentRoundedPanel4.ResumeLayout(false);
            this.transparentRoundedPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TransparentRoundedPanel transparentRoundedPanel1;
        private TransparentRoundedPanel transparentRoundedPanel2;
        private TransparentRoundedPanel transparentRoundedPanel3;
        private System.Windows.Forms.Label lbl_hosgeldin;
        private TransparentRoundedPanel transparentRoundedPanel4;
        private System.Windows.Forms.Label lbl_slogan;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_aktif;
        private System.Windows.Forms.ListBox listBox_adreslerim;
        private System.Windows.Forms.Button btn_adresekle;
        private System.Windows.Forms.Label lbl_adreslerim;
        private System.Windows.Forms.Button btn_kartekle;
        private System.Windows.Forms.ListBox listBox_kartlarim;
        private System.Windows.Forms.Label lbl_kartlarim;
        private System.Windows.Forms.RichTextBox richTextBox_adresekle;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_kart;
        private System.Windows.Forms.Button btn_akayit;
        private System.Windows.Forms.Button btn_kkayit;
        private System.Windows.Forms.Button btn_ana1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lbl_siparisver;
        private System.Windows.Forms.Timer colorChangeTimer;
    }
}