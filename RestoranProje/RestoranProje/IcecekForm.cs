using RestoranProje.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranProje.Resources
{
    public partial class IcecekForm : Form
    {
        Button[] buttons = new Button[120];
        public KategoriForm KategoriForm { get; set; }
        public class OnButtonClickDelegateEventOptions
        {
            public int buttonId { get; set; }
            public string buttonText { get; set; }
        }
        public IcecekForm(KategoriForm _f)
        {
            this.KategoriForm = _f;
            InitializeComponent();
            InitializeButtons();
        }
        private void InitializeButtons()
        {
            // Kontrol null değilse ve içinde alt kontrol varsa işlem yap
            if (this != null && this.Controls.Count > 0)
            {
                // Kontrolün altındaki her bir kontrol için işlem yap
                foreach (Control altKontrol in this.Controls)
                {
                    // Eğer kontrol bir butonsa, işlem yap
                    if (altKontrol is Button)
                    {
                        // Butonun özelliklerine erişmek için altKontrol değişkenini Button tipine dönüştür
                        Button buton = (Button)altKontrol;

                        if (buton != null && !buton.Name.Contains("geri"))
                            buton.Click += Button_Click;

                        // Butonun adını veya diğer özelliklerini kullanabilirsiniz
                        Console.WriteLine("Buton Bulundu: " + buton.Name);
                    }

                    // Kontrolün altındaki diğer kontrolle için BulButtonlari metodunu tekrar çağır
                    //BulButtonlari(altKontrol);
                }
            }

        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int yemekId = Convert.ToInt32(clickedButton.Name.Substring("button".Length, (clickedButton.Name.Length - "button".Length)));

            Database db = new Database();
            int masaId = this.KategoriForm.MainForm.buttonIndexToLock + 1;
            Console.WriteLine("MasaId: " + masaId + " - YemekId: " + yemekId);
            db.SepeteEkle(masaId, yemekId, 0);
        }
        private void button_geri_Click(object sender, EventArgs e)
        {
            KategoriForm.Show();
            this.Hide();
        }
    }
}
