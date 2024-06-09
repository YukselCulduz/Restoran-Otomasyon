using RestoranProje.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RestoranProje
{
    public partial class KategoriForm : Form
    {
        public KasiyerForm MainForm { get; set; }
        public KategoriForm(KasiyerForm kf)
        {
            this.MainForm = kf;
            this.MainForm.Hide();
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            this.MainForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IcecekForm icecekler1 = new IcecekForm(this);
            icecekler1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TatliForm tatlilar1 = new TatliForm(this);
            tatlilar1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yemekler kategori = new yemekler(this);
            kategori.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VeganForm vegan1 = new VeganForm(this);
            vegan1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet(this.MainForm, this.MainForm.buttonIndexToLock +1);
            sepet.Show();
            this.Hide();
           
        }


        
    }
}
