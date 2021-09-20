using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForms_CSharp_CTMTestTask
{
    class Graph
    {

        const int grph_pen_line_width = 5;
        const int grph_pen_grid_line_width = 1;

      public  Graph()
        {

        }

        ~Graph()
        {
            pen = null;
            pen2 = null;
            brush = null;
        }

        
        Pen pen = new Pen(Color.Black, grph_pen_line_width);
        Pen pen2 = new Pen(Color.Black, grph_pen_grid_line_width);
        SolidBrush brush = new SolidBrush(Color.Black);

        public void grph_doDots()
        {
            try
            {
                for (int i = 0; i < Program.core.get_lst_dots_x().Count; i++)
                {
                    grph_dots_add(Program.core.get_lst_dots_x()[i], Program.core.get_lst_dots_y()[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при создании точек на плоскости!" + Environment.NewLine + Environment.NewLine + ex.Message);
            }
        }

        public void grph_doConnection()
        {
            try
            {
            if (Program.core.get_lst_dots_x().Count>=2)
            {
            Point p1, p2;
            for (int i = 0; i<Program.core.get_lst_dots_x().Count-1;i++)
            {
                p1 = new Point(Program.core.get_lst_dots_x()[i], Program.core.get_lst_dots_y()[i]);
                p2 = new Point(Program.core.get_lst_dots_x()[i+1], Program.core.get_lst_dots_y()[i+1]);
                Program.main.g.DrawLine(pen, p1, p2);
            }
            p1 = new Point(Program.core.get_lst_dots_x()[Program.core.get_lst_dots_x().Count-1], Program.core.get_lst_dots_y()[Program.core.get_lst_dots_y().Count-1]);
            p2 = new Point(Program.core.get_lst_dots_x()[0], Program.core.get_lst_dots_y()[0]);
            Program.main.g.DrawLine(pen, p1, p2);

            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при создании соединений между точками!" + Environment.NewLine + Environment.NewLine + ex.Message);
            }
        }
        
        public void grph_clear()
        {
            Program.main.g.Dispose();
        }

        public void do_grph_grid()
        {
            if (Program.vm.cbGridEnabler.Checked == true)
            {
                for (int i = 0; i <= 500; i += 5)
                {
                    Point p1 = new Point(0, i);
                    Point p2 = new Point(500, i);
                    Program.main.g.DrawLine(pen2, p1, p2);
                }
                for (int j = 0; j <= 500; j += 5)
                {
                    Point p1 = new Point(j, 0);
                    Point p2 = new Point(j, 500);
                    Program.main.g.DrawLine(pen2, p1, p2);
                }
            }
        }

        void grph_dots_add(int x, int y)
        {
            Program.main.g.FillEllipse(brush, x-5, y-5, grph_pen_line_width+ 10, grph_pen_line_width+10);
        }
    }
}
