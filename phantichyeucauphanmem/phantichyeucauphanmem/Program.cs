using phantichyeucauphanmem.GUI;
using System;
using System.Windows.Forms;

namespace phantichyeucauphanmem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmInraction());
            //Application.Run(new frmChamDiemLuanVan());
            Application.Run(new frmLogin());
            //Application.Run(new frmChangePass());
          
        }
    }
}
