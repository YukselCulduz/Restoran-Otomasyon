using RestoranProje.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranProje
{
    public partial class Sepet : Form
    {
        private KasiyerForm mainForm { get; set; }
        public int masaId { get; private set; }

        public Sepet(KasiyerForm mainFormInstance, int masaId)
        {
            InitializeComponent();
            this.mainForm = mainFormInstance;
            this.masaId = masaId;

            InitializeButton();

            this.SepetiYukle();
        }

        private void SepetiYukle()
        {
            Database db = new Database();

            var sepet = db.SepetiGetir(this.masaId);

            dataGridView1.Rows.Clear();

            sepet.ForEach(x => dataGridView1.Rows.Add(x.Sepet_Id, x.Masa_Id, x.Yemek_adi, x.Yemek_fiyat));
        }

        public static void SepeteUrunEkle()
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            this.mainForm.Show();
        }
        private void InitializeButton()
        {
            Button lockButton = this.Controls.Find("lockButton", true)[0] as Button;
            lockButton.Click += LockButton_Click;
        }

        private void LockButton_Click(object sender, EventArgs e)
        {
            this.mainForm.LockButton();
            this.mainForm.Show();
            this.Hide();
        }
    }
}
