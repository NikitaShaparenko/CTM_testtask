using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForms_CSharp_CTMTestTask
{
    class Graph //Класс по работе с 2D графикой
    {

        const int grph_pen_line_width = 5; //Константа - ширина пера соединяющих вершины линий
        const int grph_pen_grid_line_width = 1; //Константа - ширина пера линий сетки 

      public  Graph()
        {

        }

        ~Graph() //Деструктор с обнулениями
        {
            pen = null;
            pen2 = null;
            brush = null;
        }

        //Выбор ручек и пера
        Pen pen = new Pen(Color.Black, grph_pen_line_width);
        Pen pen2 = new Pen(Color.Black, grph_pen_grid_line_width);
        SolidBrush brush = new SolidBrush(Color.Black);

        public void grph_doDots() //Функция для отрисоки 2Д точек
        {
            try //Обработчик ошибок
            {
                for (int i = 0; i < Program.core.get_lst_dots_x().Count; i++) //По всем точкам в списке проходимся
                {
                    grph_dots_add(Program.core.get_lst_dots_x()[i], Program.core.get_lst_dots_y()[i]); //Нанесение точек на координатную плоскость
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при создании точек на плоскости!" + Environment.NewLine + Environment.NewLine + ex.Message);
            }
        }

        public void grph_doConnection() //Функция отрисовки линий, соединяющих точки (вершины)
        {
            try //Обработчик ошибок
            {
            if (Program.core.get_lst_dots_x().Count>=2) //Пока точек меньше 2, соединять нечего
            {
            Point p1, p2;
            for (int i = 0; i<Program.core.get_lst_dots_x().Count-1;i++)
            {
                p1 = new Point(Program.core.get_lst_dots_x()[i], Program.core.get_lst_dots_y()[i]);
                p2 = new Point(Program.core.get_lst_dots_x()[i+1], Program.core.get_lst_dots_y()[i+1]);
                Program.main.g.DrawLine(pen, p1, p2);
            }

            //Замыкание фигуры - последняя точка соединяется с первой
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
            //Высвобождение ресурсов
            Program.main.g.Dispose();
        }

        public void do_grph_grid() //Функция создания сетки на координатной плоскости
        {
            if (Program.vm.cbGridEnabler.Checked == true) //Если установлена галочка на "включить сетку", то:
            {
                for (int i = 0; i <= 500; i += 5) //Отрисовываем горизонтальные линии
                {
                    Point p1 = new Point(0, i);
                    Point p2 = new Point(500, i);
                    Program.main.g.DrawLine(pen2, p1, p2);
                }
                for (int j = 0; j <= 500; j += 5) //А сейчас отрисовываем вертикальные линии
                {
                    Point p1 = new Point(j, 0);
                    Point p2 = new Point(j, 500);
                    Program.main.g.DrawLine(pen2, p1, p2);
                }
            }
        }

        void grph_dots_add(int x, int y) //функция добавления точки на график
        {
            Program.main.g.FillEllipse(brush, x-5, y-5, grph_pen_line_width+ 10, grph_pen_line_width+10);
        }
    }
}
