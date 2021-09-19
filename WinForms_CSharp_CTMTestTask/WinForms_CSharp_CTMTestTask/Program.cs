using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinForms_CSharp_CTMTestTask
{
    static class Program
    {
        public static frm_main main = new frm_main();
        public static frm_Console console = new frm_Console();
        public static uc_VertexManager vm = new uc_VertexManager();
        public static Core prg_core = new Core();

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(main);
        }
    }
}
