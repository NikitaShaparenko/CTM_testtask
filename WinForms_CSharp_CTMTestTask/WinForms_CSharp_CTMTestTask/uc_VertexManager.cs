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
            lb.Items.Clear();
            b_AddVertex.Location = new Point(this.Width / 2 - b_AddVertex.Width / 2, b_AddVertex.Location.Y);
            b_InsertVertex.Location = new Point(this.Width / 2 - b_InsertVertex.Width / 2, b_InsertVertex.Location.Y);
            b_KillVertex.Location = new Point(this.Width / 2 - b_KillVertex.Width / 2, b_KillVertex.Location.Y);

        }

        void lv_loadData()
        {
            lb.Items.Clear();
            for (int i = 0; i<Program.core.get_lst_dots_x().Count;i++)
            {
                lb.Items.Add("Точка №" + (i + 1).ToString() + " --- [" + Program.core.get_lst_dots_x()[i].ToString() + " ; " + Program.core.get_lst_dots_y()[i].ToString() + "]");
            }
        }

        void push_info()
        {
            lv_loadData();
            Program.main.pnl.Refresh();
            Program.graph.grph_doDots();
            Program.graph.grph_doConnection();
            txtVertexNumber.Text = Program.core.get_lst_dots_x().Count.ToString();
            txtSquare.Text = Program.core.calc_square().ToString();
        }

        private void b_InsertVertex_Click(object sender, EventArgs e)
        {
            if (lb.SelectedItems.Count < 1)
            {
                MessageBox.Show("Выберите вершину, перед которой хотите вставить другую!");
            }
            else
            {
                frm_VertexInfo frmv = new frm_VertexInfo();
                frmv.ShowDialog();
                if (Program.core.callback_status == true)
                {
                    Program.core.lst_insert(lb.SelectedIndex,Program.core.callback_x, Program.core.callback_y);
                }
                push_info();
            }
        }

        private void b_KillVertex_Click(object sender, EventArgs e)
        {
            if (lb.SelectedItems.Count < 1)
            {
                MessageBox.Show("Выберите вершину, которую хотите удалить!");
            }
            else
            {
               Program.core.lst_kill(lb.SelectedIndex);
               push_info();
            }
        }

        private void b_AddVertex_Click(object sender, EventArgs e)
        {
            frm_VertexInfo frmv = new frm_VertexInfo();
            frmv.ShowDialog();
            if (Program.core.callback_status == true)
            {
                Program.core.lst_add_dot(Program.core.callback_x, Program.core.callback_y);
            }
            push_info();
        }
    }
}
