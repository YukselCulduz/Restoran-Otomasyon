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
    public partial class AdminPanel : Form
    {
        private KasiyerForm form1;
        public Button[] buttons;
        public AdminPanel(KasiyerForm form1Instance)
        {
            InitializeComponent();
            form1 = form1Instance;
            InitializeButtons();
        }

        private void InitializeButtons()
        {
            buttons = new Button[24];
            for (int i = 0; i < 24; i++)
            {
                buttons[i] = this.Controls.Find("button" + (i + 1), true)[0] as Button;
                buttons[i].Click += Button_Click;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int buttonIndex = int.Parse(clickedButton.Name.Replace("button", "")) - 1;
            Database db = new Database();
            db.MasaSepetVerisiSil(buttonIndex+1);
            form1.UnlockButton(buttonIndex);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }
    }
}
