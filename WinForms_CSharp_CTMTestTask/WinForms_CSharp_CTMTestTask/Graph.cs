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

        List<int> lst_dots_x = new List<int>();
        List<int> lst_dots_y = new List<int>();

        public void grph_doConnection()
        {
            Point p1, p2;
            for (int i = 0; i<lst_dots_x.Count-1;i++)
            {
                p1 = new Point(lst_dots_x[i], lst_dots_y[i]);
                p2 = new Point(lst_dots_x[i+1], lst_dots_y[i+1]);
                Program.main.g.DrawLine(pen, p1, p2);
            }
            p1 = new Point(lst_dots_x[lst_dots_x.Count], lst_dots_y[lst_dots_y.Count]);
            p2 = new Point(lst_dots_x[0], lst_dots_y[0]);
            Program.main.g.DrawLine(pen, p1, p2);
        }
        
        public void grph_clear()
        {
            Program.main.g.Dispose();
        }

        public void grph_dots_add(int x, int y)
        {
            Program.main.g.FillRectangle(brush, x, y, 1, 1);
        }

        public void lst_loader()
        {
            lst_dots_x = Program.core.get_lst_dots_x();
            lst_dots_y = Program.core.get_lst_dots_y();
        }
    }
}
