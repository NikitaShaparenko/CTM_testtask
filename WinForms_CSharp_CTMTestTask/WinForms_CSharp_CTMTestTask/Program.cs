using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinForms_CSharp_CTMTestTask
{
    static class Program
    {
        
        public static frm_Console console;
        public static uc_VertexManager vm;
        public static Core core;
        public static Graph graph;
        public static frm_main main;

        [STAThread]
        static void Main()
        {
            vm = new uc_VertexManager();
            console = new frm_Console();
            main = new frm_main();
            core = new Core();

            IntPtr dm1 = console.Handle;
            IntPtr dm2 = vm.Handle;
            IntPtr dm3 = main.Handle;


            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(main);
           

        }
    }
}
