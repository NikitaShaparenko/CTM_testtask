using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForms_CSharp_CTMTestTask
{
    class Core //Класс движка программы
    {
        public Core() //Конструктор по умолчанию
        {

        }
        ~Core() //Деструктор по умолчанию и высвобождение динамической памяти
        {
            callback_status = false;
            callback_x = 0;
            callback_y = 0;
            lst_dots_x.Clear();
            lst_dots_y.Clear();
        }

        List<int> lst_dots_x = new List<int>(); //Создаём список под все значения абсцисс точек
        List<int> lst_dots_y = new List<int>(); //и под все значения ординат

        //Блок переменных, используемых для обратного сохранения введёных пользователем данных в созданном окошке VertexInfo
        public int callback_x = 0; //Введёный пользователем Х точки
        public int callback_y = 0; //Введённый пользователем Y точки
        public bool callback_status = false; //Контроль успеха операции

        public List<int> get_lst_dots_x() //Геттер для списка с координатами асбисс
        {
            return lst_dots_x;
        }

        public List<int> get_lst_dots_y() //Геттер для списка с координатами ординат
        {
            return lst_dots_y;
        }

        public void lst_add_dot(int x, int y) //Функция добавления точек
        {
            lst_dots_x.Add(x); //Дописываем к двум спискам ещё одну точку. В списки абсцисс и ординат по одному значению
            lst_dots_y.Add(y);
        }

        public void lst_kill(int pos) //Функция удаления точки по заданной позиции
        {
            lst_dots_x.RemoveAt(pos); //Удаляем значение точки одновременно из списка абсцисс
            lst_dots_y.RemoveAt(pos); //и ординат
        }

        public void lst_killall() //Функция полной очистки списков точек
        {
            lst_dots_x.Clear();
            lst_dots_y.Clear();
        }

        public void lst_insert(int pos, int item_x, int item_y) //Функция вставки значений координат точки перед выбранным в списке
        {
            lst_dots_x.Insert(pos, item_x);
            lst_dots_y.Insert(pos, item_y);
        }

        public double calc_square() //Функция вычисления площади многоугольника
        {

            try //Обработчик ошибок
            {
                int n = lst_dots_x.Count(); //Считаем количество вершин фигуры
                if (n > 2)
                {


                    int sum1 = 0, sum2 = 0;

                    for (int i = 0; i < n - 1; i++)
                    {
                        //Умножаем значение координаты «х» первой вершины на значение координаты «у» второй вершины (и так далее)
                        //А после сложим результаты
                        sum1 += lst_dots_x[i] * lst_dots_y[i + 1];

                        //Умножаем значение координаты «у» первый вершины на значение координаты «х» второй вершины(и так далее).
                        //А после сложим результаты
                        sum2 += lst_dots_y[i] * lst_dots_x[i + 1];
                    }
                    //Последний шаг - вычитание сумм и деление на 2, взяв модуль.
                    return Math.Abs((sum1 - sum2) / (double)2);
                }
                else return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при вычислении площади фигуры!" + Environment.NewLine + Environment.NewLine + ex.Message);
                return 0;
            }
            return 0;
        }
    }
}
