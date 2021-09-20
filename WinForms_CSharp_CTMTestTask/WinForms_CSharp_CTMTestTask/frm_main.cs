using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForms_CSharp_CTMTestTask
{
    public partial class frm_main : Form
    {
        public Graphics g;
        public frm_main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = Program.ga.pnl_area.CreateGraphics();
            pnlAddon.Controls.Clear();
            Program.vm.Location = new Point(1, 1);
            Program.vm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            pnlAddon.Controls.Add(Program.vm);
            
            Program.ga.Location = new Point(1, 1);
            Program.ga.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            pnl.Controls.Add(Program.ga);

            tWelcome.Start();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tWelcome_Tick(object sender, EventArgs e)
        {
            string welcome_msg = "";
            welcome_msg = "Добро пожаловать в программу, реализующую условия тестового задания!" + Environment.NewLine + Environment.NewLine;
            welcome_msg += "Необходимо было выполнить:" + Environment.NewLine;
            welcome_msg += "Вычислить площадь 2D многоугольника, заданного последовательностью 2D точек(x + y)" + Environment.NewLine + Environment.NewLine;
            welcome_msg += "Программа состоит из двух панелей. Левая - графическая визуализация на координатной плоскости, на ней будет отображена фигура, которая строится по заданным точкам:" + Environment.NewLine;
            welcome_msg += "Ограничения координатной плоскости для X и Y точек - ЦЕЛЫЕ ЧИСЛА, ОТ 0 ДО 500 ВКЛЮЧИТЕЛЬНО" + Environment.NewLine;
            welcome_msg += Environment.NewLine + "Заранее благодарю за оценку!" + Environment.NewLine + Environment.NewLine + "Шапаренко Никита";
            tWelcome.Enabled = false;
            tWelcome.Stop();
            MessageBox.Show(welcome_msg);
        }
    }
}
