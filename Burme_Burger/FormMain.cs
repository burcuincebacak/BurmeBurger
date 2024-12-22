using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burme_Burger
{
    public partial class FormMain : Form
    {
        private static string connectionString = "Data Source=burmeburgerDB.db;Version=3;";

        private List<(string Name, int Quantity, decimal Price)> sepetListesi = new List<(string, int, decimal)>();
        private decimal toplamTutar = 0; // Toplam tutar

        public FormMain()
        {
            InitializeComponent();
        }

        private string activeCategory = "";


        private string[] messages = {
          "OSMAN'I DA BİZ DOYURDUK!!!",
          "Her Masada BİZ Varız.",
          "2 Alana 1 Bedava Fırsatını Kaçırma!",
          "1022'den Beri Değişmeyen Lezzet...",
          "Yılbaşı keyfine BurmeBurger eşlik etsin!"

};
        private int currentIndex = 0;



        private void FormMain_Load(object sender, EventArgs e)
        {
            transparentRoundedPanel4.Visible = false;
            transparentRoundedPanel5.Visible = false;
            transparentRoundedPanel8.Visible = false;
            transparentRoundedPanel10.Visible = false;
            dolufoto.Visible = false;
            dolufoto2.Visible = false;
            bosfoto.Visible = true;
            bosfoto2.Visible = true;


            pictureBox4.Size = new Size(180, 180); // Boyut
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage; // Görüntüleme modu
            pictureBox5.Size = new Size(180, 180); // Boyut
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage; // Görüntüleme modu
            pictureBox6.Size = new Size(180, 180); // Boyut
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage; // Görüntüleme modu
            pictureBox7.Size = new Size(180, 180); // Boyut
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage; // Görüntüleme modu

            timer_label.Start();
            timerMarquee.Start();
            // Label'ı başlangıçta sağdan başlat
            lblMarquee.Left = this.panelMarquee.Width;
            lblMarquee.Text = messages[currentIndex];
        }

        private void timerMarquee_Tick_1(object sender, EventArgs e)
        {
            lblMarquee.Left -= 5;
            if (lblMarquee.Right < 0)
            {
                lblMarquee.Left = this.panelMarquee.Width;
                currentIndex = (currentIndex + 1) % messages.Length;
                lblMarquee.Text = messages[currentIndex];
            }


        }

        private void timer_label_Tick(object sender, EventArgs e)
        {
            label1.Left -= 5;
            if (label1.Right < 0)
            {
                label1.Left = this.transparentRoundedPanel4.Width;
            }

            label2.Left -= 5;
            if (label2.Right < 0)
            {
                label2.Left = this.transparentRoundedPanel5.Width;
            }

            label3.Left -= 5;
            if (label3.Right < 0)
            {
                label3.Left = this.transparentRoundedPanel6.Width;
            }

            label4.Left -= 5;
            if (label4.Right < 0)
            {
                label4.Left = this.transparentRoundedPanel7.Width;
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            bosfoto.Visible = false;
            bosfoto2.Visible = false;
            dolufoto.Visible = true;
            dolufoto2.Visible = true;
            transparentRoundedPanel4.Visible = true;
            transparentRoundedPanel5.Visible = true;
            transparentRoundedPanel8.Visible = true;
            transparentRoundedPanel10.Visible = true;

            activeCategory = "menu"; // Aktif kategori Menüler
            pictureBox4.Image?.Dispose();
            pictureBox4.Image = Properties.Resources.Malazgirt_Sofrasi;
            pictureBox4.Refresh();

            pictureBox5.Image?.Dispose();
            pictureBox5.Image = Properties.Resources.Lezzet_i_Hurriyet;
            pictureBox5.Refresh();

            pictureBox6.Image?.Dispose();
            pictureBox6.Image = Properties.Resources.ciftteKilicMenü;
            pictureBox6.Refresh();

            pictureBox7.Image?.Dispose();
            pictureBox7.Image = Properties.Resources.Metropolitan;
            pictureBox7.Refresh();
            label1.Text = "MALAZGİRT SOFRASI";
            label1.Refresh(); // Ekranda hemen görünmesi için

            label2.Text = "LEZZETİ-HÜRRİYET";
            label2.Refresh(); // Ekranda hemen görünmesi için

            label3.Text = "ÇİFTE KILIÇ";
            label3.Refresh(); // Ekranda hemen görünmesi için

            label4.Text = "METROPOLİTAN";
            label4.Refresh(); // Ekranda hemen görünmesi için

        }

        private void btn_citir_Click(object sender, EventArgs e)
        {
            bosfoto.Visible = false;
            bosfoto2.Visible = false;
            dolufoto.Visible = true;
            dolufoto2.Visible = true;
            transparentRoundedPanel4.Visible = true;
            transparentRoundedPanel5.Visible = true;
            transparentRoundedPanel8.Visible = true;
            transparentRoundedPanel10.Visible = true;

            activeCategory = "citir"; // Aktif kategori Çıtır Lezzetler
            pictureBox4.Image?.Dispose();
            pictureBox4.Image = Properties.Resources.gurmenugget;
            pictureBox4.Refresh();

            pictureBox5.Image?.Dispose();
            pictureBox5.Image = Properties.Resources.sogankizartma;
            pictureBox5.Refresh();

            pictureBox6.Image?.Dispose();
            pictureBox6.Image = Properties.Resources.hataysoslucitirtavuk;
            pictureBox6.Refresh();

            pictureBox7.Image?.Dispose();
            pictureBox7.Image = Properties.Resources.citirhellim;
            pictureBox7.Refresh();

            label1.Text = "GURME NUGGET";
            label1.Refresh(); // Ekranda hemen görünmesi için

            label2.Text = "SOĞAN KIZARTMASI";
            label2.Refresh(); // Ekranda hemen görünmesi için

            label3.Text = "HATAY SOSLU ÇITIR TAVUK";
            label3.Refresh(); // Ekranda hemen görünmesi için

            label4.Text = "ÇITIR HELLİM";
            label4.Refresh(); // Ekranda hemen görünmesi için
        }

        private void btn_tatli_Click(object sender, EventArgs e)
        {
            bosfoto.Visible = false;
            bosfoto2.Visible = false;
            dolufoto.Visible = true;
            dolufoto2.Visible = true;
            transparentRoundedPanel4.Visible = true;
            transparentRoundedPanel5.Visible = true;
            transparentRoundedPanel8.Visible = true;
            transparentRoundedPanel10.Visible = true;

            activeCategory = "tatli"; // Aktif kategori Soslar
            pictureBox4.Image?.Dispose();
            pictureBox4.Image = Properties.Resources.saraysarmasi;
            pictureBox4.Refresh();

            pictureBox5.Image?.Dispose();
            pictureBox5.Image = Properties.Resources.kemalpasa;
            pictureBox5.Refresh();

            pictureBox6.Image?.Dispose();
            pictureBox6.Image = Properties.Resources.antepbaklava;
            pictureBox6.Refresh();

            pictureBox7.Image?.Dispose();
            pictureBox7.Image = Properties.Resources.keskulfukara;
            pictureBox7.Refresh();

            
            label1.Text = "SARAY SARMASI";
            label1.Refresh(); // Ekranda hemen görünmesi için

            label2.Text = "KEMALPAŞA";
            label2.Refresh(); // Ekranda hemen görünmesi için


            label3.Text = "FISTIKLI SARMA";
            label3.Refresh(); // Ekranda hemen görünmesi için

            label4.Text = "KEŞKÜL-Ü FUKARA";
            label4.Refresh(); // Ekranda hemen görünmesi için
        }

        private void btn_sos_Click(object sender, EventArgs e)
        {
            bosfoto.Visible = false;
            bosfoto2.Visible = false;
            dolufoto.Visible = true;
            dolufoto2.Visible = true;
            transparentRoundedPanel4.Visible = true;
            transparentRoundedPanel5.Visible = true;
            transparentRoundedPanel8.Visible = true;
            transparentRoundedPanel10.Visible = true;

            activeCategory = "sos"; // Aktif kategori Soslar
            pictureBox4.Image?.Dispose();
            pictureBox4.Image = Properties.Resources.ketçap__2___1_;
            pictureBox4.Refresh();

            pictureBox5.Image?.Dispose();
            pictureBox5.Image = Properties.Resources.sarımsaklıyeni;
            pictureBox5.Refresh();

            pictureBox6.Image?.Dispose();
            pictureBox6.Image = Properties.Resources.mandayeni;
            pictureBox6.Refresh();

            pictureBox7.Image?.Dispose();
            pictureBox7.Image = Properties.Resources.mangalyeni;
            pictureBox7.Refresh();

            label1.Text = "AŞK ACISI SOS";
            label1.Refresh(); // Ekranda hemen görünmesi için

            label2.Text = "SARIMSAKLI MAYONEZ";
            label2.Refresh(); // Ekranda hemen görünmesi için

            label3.Text = "MANDA SOS";
            label3.Refresh(); // Ekranda hemen görünmesi için

            label4.Text = "MANGAL SOS";
            label4.Refresh(); // Ekranda hemen görünmesi için
        }

        private void pictureBox_4_Click(object sender, EventArgs e)
        {
            AddToCart(label1.Text);
        }

        private void pictureBox_5_Click(object sender, EventArgs e)
        {
            AddToCart(label2.Text);
        }

        private void pictureBox_6_Click(object sender, EventArgs e)
        {
            AddToCart(label3.Text);
        }

        private void pictureBox_7_Click(object sender, EventArgs e)
        {
            AddToCart(label4.Text);
        }

        private void AddToCart(string productName)
        {
            if (string.IsNullOrEmpty(activeCategory))
            {
                MessageBox.Show("Lütfen bir kategori seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal productPrice = GetProductPrice(productName);

            // Sepette ürün var mı kontrol et
            var existingItem = sepetListesi.FirstOrDefault(item => item.Name == productName);

            if (existingItem != default)
            {
                // Ürün varsa miktarı artır
                sepetListesi.Remove(existingItem);
                sepetListesi.Add((productName, existingItem.Quantity + 1, productPrice));
            }
            else
            {
                // Ürün yoksa ekle
                sepetListesi.Add((productName, 1, productPrice));
            }

            toplamTutar += productPrice;

            // Global sepete güncelle
            GlobalData.SepetListesi = sepetListesi;
            GlobalData.ToplamTutar = toplamTutar;

            MessageBox.Show($"{productName} ürünü sepete eklendi! Fiyat: {productPrice:C2}", "Sepet Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        public void UpdateCart(List<(string Name, int Quantity, decimal Price)> updatedList, decimal updatedTotal)
        {
            sepetListesi = updatedList;
            toplamTutar = updatedTotal;
        }


        // Ürün fiyatlarını belirleyen metod
        private decimal GetProductPrice(string productName)
        {
            // Örnek ürün fiyatları
            switch (productName)
            {
                // Menüler
                case "MALAZGİRT SOFRASI": return 230.00m;
                case "LEZZETİ-HÜRRİYET": return 270.00m;
                case "ÇİFTE KILIÇ": return 220.00m;
                case "METROPOLİTAN": return 250.00m;

                // Çıtır Lezzetler
                case "GURME NUGGET": return 120.00m;
                case "SOĞAN KIZARTMASI": return 100.00m;
                case "HATAY SOSLU ÇITIR TAVUK": return 130.00m;
                case "ÇITIR HELLİM": return 110.00m;

                // Soslar
                case "AŞK ACISI SOS": return 15.00m;
                case "SARIMSAKLI MAYONEZ": return 15.00m;
                case "MANDA SOS": return 15.00m;
                case "MANGAL SOS": return 15.00m;

                // Tatlılar
                case "SARAY SARMASI": return 150.00m;
                case "KEMALPAŞA": return 120.00m;
                case "FISTIKLI SARMA": return 250.00m;
                case "KEŞKÜL-Ü FUKARA": return 210.00m;


                default: return 0.00m; // Tanımsız ürün
            }
        }

        private void btn_sepet_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSepet form_sepet = new FormSepet(sepetListesi, toplamTutar);
            form_sepet.ShowDialog();
        }

        private void btn_hesap_Click(object sender, EventArgs e)
        {
            // Hesabım formunun bir örneğini oluştur
            FormHesap form_hesap = new FormHesap();

            // Hesabım formunu göster
            form_hesap.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // LoginForm'u gizler.
            FormGrafik form_grafik = new FormGrafik();
            form_grafik.Show(); // RegisterForm'u açar.
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            GlobalData.Reset();
            this.Hide(); // Mevcut formu gizle
            FormLogin form_login = new FormLogin();
            form_login.Show();
        }


      
    }
}
