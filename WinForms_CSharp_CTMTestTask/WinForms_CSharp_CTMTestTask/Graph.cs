using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WinForms_CSharp_CTMTestTask
{
    class Graph
    {
        const int grph_pen_line_width = 5;

        Pen pen = new Pen(Color.Black, grph_pen_line_width);
        SolidBrush brush = new SolidBrush(Color.Black);

        public void grph_doDots()
        {
            for (int i = 0; i < Program.core.get_lst_dots_x().Count; i++)
            {
                grph_dots_add(Program.core.get_lst_dots_x()[i], Program.core.get_lst_dots_y()[i]);
            }
        }

        public void grph_doConnection()
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
        
        public void grph_clear()
        {
            Program.main.g.Dispose();
        }

        void grph_dots_add(int x, int y)
        {
            Program.main.g.FillEllipse(brush, x-5, y-5, grph_pen_line_width+ 10, grph_pen_line_width+10);
        }
    }
}
