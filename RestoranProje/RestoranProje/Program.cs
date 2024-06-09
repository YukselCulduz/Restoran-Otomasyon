using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranProje
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            KasiyerForm form1 = new KasiyerForm();
            AdminPanel adminPanel = new AdminPanel(form1);

            form1.Show();
            adminPanel.Show();

            Application.Run();

        }
    }
}
