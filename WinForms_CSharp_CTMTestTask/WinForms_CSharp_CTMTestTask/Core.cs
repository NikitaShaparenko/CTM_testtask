using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinForms_CSharp_CTMTestTask
{
    class Core
    {
        public Core()
        {
            //lst_dots_x.Clear();
            //lst_dots_y.Clear();
        }
        List<int> lst_dots_x = new List<int>();
        List<int> lst_dots_y = new List<int>();

        public int callback_x = 0;
        public int callback_y = 0;
        public bool callback_status = false;

        public List<int> get_lst_dots_x()
        {
            return lst_dots_x;
        }

        public List<int> get_lst_dots_y()
        {
            return lst_dots_y;
        }

        public void lst_add_dot(int x, int y)
        {
            lst_dots_x.Add(x);
            lst_dots_y.Add(y);
        }

        public void lst_kill(int pos)
        {
            lst_dots_x.Remove(pos);
            lst_dots_y.Remove(pos);
        }

        public void lst_killall()
        {
            lst_dots_x.Clear();
            lst_dots_y.Clear();

            //for (int i = lst_dots_x.Count; i>0;i--)
            //{
            //    lst_dots_x.Remove(i);
            //    lst_dots_y.Remove(i);
            //}
        }

        public void lst_insert(int pos,int item_x, int item_y)
        {
            lst_dots_x.Insert(pos, item_x);
            lst_dots_y.Insert(pos, item_y);
        }

        public double calc_square()
        {
            int n = lst_dots_x.Count();
            int sum1 = 0, sum2 = 0;

            for (int i = 0; i < n - 1; i++)
            {
                sum1 += lst_dots_x[i] * lst_dots_y[i + 1];
                sum2 += lst_dots_y[i] * lst_dots_x[i + 1];
            }

            return Math.Abs((sum1 - sum2) / (double)2);
        }
    }
}
