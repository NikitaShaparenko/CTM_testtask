using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinForms_CSharp_CTMTestTask
{
    static class Program //Самый главный и пусковой класс программы
    {
        //Статическая декларация всех меню программы
        public static uc_VertexManager vm;
        public static uc_grapharea ga;
        public static Core core;
        public static Graph graph;
        public static frm_main main;

        [STAThread]
        static void Main()
        {
            //Инициализация всех меню программы
            vm = new uc_VertexManager();
            ga = new uc_grapharea();
            main = new frm_main();
            core = new Core();
            graph = new Graph();
            
            //Удержание от ошибки и нестабильной работы
            IntPtr dm1 = vm.Handle;
            IntPtr dm2 = ga.Handle;
            IntPtr dm3 = main.Handle;

            //Запук центрального окна
            Application.Run(main);

            //=====Последующий код исполнится после закрытия главного окна:
            //Высвобождение ресурсов
            vm.Dispose();
            ga.Dispose();
            main.Dispose();
        }
    }
}
