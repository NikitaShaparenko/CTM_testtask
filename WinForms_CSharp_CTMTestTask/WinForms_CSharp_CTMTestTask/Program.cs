using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinForms_CSharp_CTMTestTask
{
    static class Program
    {
        public static uc_VertexManager vm;
        public static uc_grapharea ga;
        public static Core core;
        public static Graph graph;
        public static frm_main main;

        [STAThread]
        static void Main()
        {
            vm = new uc_VertexManager();
            ga = new uc_grapharea();
            main = new frm_main();
            core = new Core();
            graph = new Graph();
            
            IntPtr dm1 = vm.Handle;
            IntPtr dm2 = ga.Handle;
            IntPtr dm3 = main.Handle;

            Application.Run(main);

            vm.Dispose();
            ga.Dispose();
            main.Dispose();
        }
    }
}
