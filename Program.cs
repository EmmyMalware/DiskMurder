using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DiskMurder
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (MessageBox.Show("This program is malware, so don't go off running it", "DiskMurder", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
        }
    }
}
