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
using Microsoft.Data.Sqlite;


namespace RestoranProje
{


    public partial class KasiyerForm : Form
    {
        public Button[] buttons;
        private KategoriForm Kategori;
        public int buttonIndexToLock;


        public class OnButtonClickDelegateEventOptions
        {
            public int buttonId { get;set; }
            public string buttonText { get; set; }
        }


        public event EventHandler<OnButtonClickDelegateEventOptions> OnButtonClick;
        public event EventHandler<EventArgs> OnButtonClick2;

        private void OnButtonPressedP(object sender, OnButtonClickDelegateEventOptions _button)
        {
            if(!Kategori.IsAccessible)
                this.Kategori = new KategoriForm(this);

            this.Kategori.Name = _button.buttonText;
            this.Kategori.MainForm = this;
            this.Kategori.Show();
        }

        public void BasePreter(object sender, EventArgs e)
        {
            Button _cb = sender as Button;
            OnButtonClickDelegateEventOptions _bo = new OnButtonClickDelegateEventOptions();
            _bo.buttonText = _cb.Text;

            // Burayı arkadaşın için bok gibi yazdım. Yani nabayım amk.
            {
                // Buttondan "Button" kadar stringi atlayop. toplam uzunluğundan kalan kısmı alıp inte çevirdik. bu saydece sonraki button(31) parantez içindeki kısmı elde ettik. Ve 32 inte çevirdik.
                _bo.buttonId = Convert.ToInt32(_cb.Name.Substring("button".Length, (_cb.Name.Length - "button".Length)));
            }

            OnButtonClick?.Invoke(null, _bo);
        }

        public KasiyerForm()
        {
            InitializeComponent();
            InitializeButtons();
            Kategori = new KategoriForm(this);
            Kategori.MainForm = this;



            this.OnButtonClick += this.OnButtonPressedP;


            this.button1.Click += this.BasePreter;
            this.button2.Click += this.BasePreter;
            this.button3.Click += this.BasePreter;
            this.button4.Click += this.BasePreter;
            this.button5.Click += this.BasePreter;
            this.button6.Click += this.BasePreter;
            this.button7.Click += this.BasePreter;
            this.button8.Click += this.BasePreter;
            this.button9.Click += this.BasePreter;
            this.button10.Click += this.BasePreter;
            this.button11.Click += this.BasePreter;
            this.button12.Click += this.BasePreter;
            this.button13.Click += this.BasePreter;
            this.button14.Click += this.BasePreter;
            this.button15.Click += this.BasePreter;
            this.button16.Click += this.BasePreter;
            this.button17.Click += this.BasePreter;
            this.button18.Click += this.BasePreter;
            this.button19.Click += this.BasePreter;
            this.button20.Click += this.BasePreter;
            this.button21.Click += this.BasePreter;
            this.button22.Click += this.BasePreter;
            this.button23.Click += this.BasePreter;
            this.button24.Click += this.BasePreter;
        }

        private void InitializeButtons()
        {
            buttons = new Button[24];
            for (int i = 0; i < 24; i++)
            {
                buttons[i] = this.Controls.Find("button" + (i + 1), true)[0] as Button;
                buttons[i].BackColor = System.Drawing.Color.Green;  // Başlangıçta yeşil renk atma komutu
                buttons[i].Click += Button_Click;
            }
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            buttonIndexToLock = int.Parse(clickedButton.Name.Replace("button", "")) - 1;
            //Kategori.Show();
            //this.Close();
            
        }

        public void LockButton()
        {
            buttons[buttonIndexToLock].Enabled = false;
            buttons[buttonIndexToLock].BackColor = System.Drawing.Color.Red;  // Kilitlendiğinde kırmızı renk
        }

        public void UnlockButton(int index)
        {
            buttons[index].Enabled = true;
            buttons[index].BackColor = System.Drawing.Color.Green;  // Açıldığında yeşil renk
        }

        private void button_21_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            System.Environment.Exit(0);
        }
    }
}
