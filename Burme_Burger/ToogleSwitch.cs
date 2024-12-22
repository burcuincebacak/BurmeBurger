using System;
using System.Drawing;
using System.Windows.Forms;

namespace Burme.Burger
{
    public class ToggleSwitch : Control
    {
        private bool isToggled = false; // Toggle durumu
        private Color onColor = Color.LimeGreen; // Açık durum rengi
        private Color offColor = Color.LightGray; // Kapalı durum rengi

        private Button toggleButton; // Toggle butonu

        public event EventHandler Toggled;

        public ToggleSwitch()
        {
            // İlk ayarlar
            this.Size = new Size(60, 30);
            this.BackColor = offColor;

            // Toggle butonunu oluştur
            toggleButton = new Button
            {
                BackColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(Height - 4, Height - 4),
                Location = new Point(2, 2)
            };
            toggleButton.FlatAppearance.BorderSize = 0;
            toggleButton.Click += (s, e) => Toggle();

            this.Controls.Add(toggleButton); // Butonu kontrol içerisine ekle
            UpdateSwitch();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (toggleButton == null) return; // Null kontrolü

            // Boyutu yeniden hesapla
            int buttonSize = Math.Min(Height - 4, Width / 2 - 4);
            toggleButton.Size = new Size(buttonSize, buttonSize);
            UpdateSwitch();
        }

        private void Toggle()
        {
            isToggled = !isToggled; // Toggle durumu değiştir
            UpdateSwitch(); // Konum ve rengi güncelle
            Toggled?.Invoke(this, EventArgs.Empty); // Olay tetikle
        }

        private void UpdateSwitch()
        {
            if (toggleButton == null) return;

            // Arka plan rengini güncelle
            this.BackColor = isToggled ? onColor : offColor;

            // Toggle butonunun konumunu güncelle
            int buttonX = isToggled
                ? this.Width - toggleButton.Width - 2 // Sağda
                : 2; // Solda
            toggleButton.Location = new Point(buttonX, (this.Height - toggleButton.Height) / 2);
        }
    }
}
