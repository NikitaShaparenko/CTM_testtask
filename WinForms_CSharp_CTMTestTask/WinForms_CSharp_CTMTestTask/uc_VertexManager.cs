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
    public partial class uc_VertexManager : UserControl
    {
        public uc_VertexManager()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void uc_VertexManager_Load(object sender, EventArgs e)
        {

        }

        void lv_loadData()
        {
            lv_Vertexes.Clear();
            for (int i = 0; i<Program.core.get_lst_dots_x().Count;i++)
            {
                lv_Vertexes.Items.Add("Точка №" + (i + 1).ToString() + " --- [" + Program.core.get_lst_dots_x()[i].ToString() + " ; " + Program.core.get_lst_dots_y()[i].ToString() + "]");
            }
        }

        void push_info()
        {
            lv_loadData();
            txtVertexNumber.Text = Program.core.get_lst_dots_x().Count.ToString();
            txtSquare.Text = Program.core.calc_square().ToString();
        }

        private void b_InsertVertex_Click(object sender, EventArgs e)
        {
            if (lv_Vertexes.SelectedItems.Count < 1)
            {
                MessageBox.Show("Выберите вершину, перед которой хотите вставить другую!");
            }
            else
            {
                frm_VertexInfo frmv = new frm_VertexInfo();
                frmv.Show();
                while (frmv.IsDisposed == false) { };
                if (Program.core.callback_status == true)
                {
                    Program.core.lst_insert(lv_Vertexes.SelectedItems[0].Index,Program.core.callback_x, Program.core.callback_y);
                }
                push_info();
            }
        }

        private void b_KillVertex_Click(object sender, EventArgs e)
        {
            if (lv_Vertexes.SelectedItems.Count < 1)
            {
                MessageBox.Show("Выберите вершину, которую хотите удалить!");
            }
            else
            {
               Program.core.lst_kill(lv_Vertexes.SelectedItems[0].Index);
               push_info();
            }
        }

        private void b_AddVertex_Click(object sender, EventArgs e)
        {
            frm_VertexInfo frmv = new frm_VertexInfo();
            frmv.Show();
            while (frmv.IsDisposed == false){};
            if (Program.core.callback_status == true)
            {
                Program.core.lst_add_dot(Program.core.callback_x, Program.core.callback_y);
            }
            push_info();
        }
    }
}
