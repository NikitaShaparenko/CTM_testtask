using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForms_CSharp_CTMTestTask
{
    public partial class uc_VertexManager : UserControl //Менеджер вершин
    {
        public uc_VertexManager() //Конструктор
        {
            CheckForIllegalCrossThreadCalls = false; //Послабления в контроле нелегальных межпоточных вызовов
            InitializeComponent();
        }

        private void uc_VertexManager_Load(object sender, EventArgs e) //Загрузка контрола
        {
            lb.Items.Clear(); //Очистка листбокса с точками

            //Центрирование расположения кнопок
            b_AddVertex.Location = new Point(this.Width / 2 - b_AddVertex.Width / 2, b_AddVertex.Location.Y);
            b_InsertVertex.Location = new Point(this.Width / 2 - b_InsertVertex.Width / 2, b_InsertVertex.Location.Y);
            b_KillVertex.Location = new Point(this.Width / 2 - b_KillVertex.Width / 2, b_KillVertex.Location.Y);

        }

        void lv_loadData() //Загрузка данных в листбокс
        {
            lb.Items.Clear();
            for (int i = 0; i<Program.core.get_lst_dots_x().Count;i++)
            {
                lb.Items.Add("Точка №" + (i + 1).ToString() + " --- [" + Program.core.get_lst_dots_x()[i].ToString() + " ; " + Program.core.get_lst_dots_y()[i].ToString() + "]");
            }
        }

        void push_info() //Функция обновления информации о вершинах
        {
            try
            {
            lv_loadData();
                Program.ga.pnl_area.Refresh(); //Очистка графического поля
            Program.graph.grph_doDots(); //Построение точек (вершин)
            Program.graph.grph_doConnection();  //Построение отрезков
            Program.graph.do_grph_grid(); //Потсроение сетки
            txtVertexNumber.Text = Program.core.get_lst_dots_x().Count.ToString(); //Подсчёт количества вершин
            txtSquare.Text = Program.core.calc_square().ToString(); //Подсчёт площади
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при обновлении значений!" + Environment.NewLine + Environment.NewLine + ex.Message);
            }
            }

        private void b_InsertVertex_Click(object sender, EventArgs e) //Нажата кнопка "Вставить вершину"
        {
            if (lb.SelectedItems.Count < 1) //Ничего не выбрано в листбоксе
            {
                MessageBox.Show("Выберите вершину, перед которой хотите вставить другую!");
            }
            else
            {
                frm_VertexInfo frmv = new frm_VertexInfo(); //Создания экземпляра окна свойств точки
                frmv.ShowDialog(); //Вызов и ожидание закрытия окна свойств точки
                if (Program.core.callback_status == true) //Если изменения применены успешно
                {
                    Program.core.lst_insert(lb.SelectedIndex,Program.core.callback_x, Program.core.callback_y); //Вставить точку в список перед обозначенной
                }
                push_info(); //Обновление информации
            }
        }

        private void b_KillVertex_Click(object sender, EventArgs e) //Нажата кнопка удаления вершины
        {
            if (lb.SelectedItems.Count < 1) ///Проверка выбрана ли строка или нет. 
            {
                MessageBox.Show("Выберите вершину, которую хотите удалить!");
            }
            else
            {
               Program.core.lst_kill(lb.SelectedIndex); //Удаление вершины
               push_info(); //Обновление информации
            }
        }

        private void b_AddVertex_Click(object sender, EventArgs e) //Нажата кнопка "Добавиь вершину"
        {
            frm_VertexInfo frmv = new frm_VertexInfo(); //Создание экземлпяра и вызов окна для ввода данных о координатах
            frmv.ShowDialog();
            if (Program.core.callback_status == true)
            {
                Program.core.lst_add_dot(Program.core.callback_x, Program.core.callback_y);
            }
            push_info();
        }

        private void cbGridEnabler_CheckedChanged(object sender, EventArgs e)
        {
            Program.vm.push_info(); //При включении/выключении линии, происходит обновленеи всей текущей информации о точках
        }
    }
}
