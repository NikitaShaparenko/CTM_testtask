using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinForms_CSharp_CTMTestTask
{
    static class Program
    {
        public static frm_main main;
        public static frm_Console console;
        public static uc_VertexManager vm;
        public static Core core;

        [STAThread]
        static void Main()
        {
            main = new frm_main();
            console = new frm_Console();
            vm = new uc_VertexManager();
            core = new Core();

            IntPtr dm1 = main.Handle;
            IntPtr dm2 = console.Handle;
            IntPtr dm3 = vm.Handle;

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
           Application.Run(main);
        }
    }
}
