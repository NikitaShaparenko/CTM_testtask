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
            InitializeComponent();
        }

        private void uc_VertexManager_Load(object sender, EventArgs e)
        {

        }

        void push_info()
        {
            txtVertexNumber.Text = Program.prg_core.get_lst_dots_x().Count.ToString();
            txtSquare.Text = Program.prg_core.calc_square().ToString();
        }

        private void b_InsertVertex_Click(object sender, EventArgs e)
        {

        }

        private void b_KillVertex_Click(object sender, EventArgs e)
        {

        }

        private void b_AddVertex_Click(object sender, EventArgs e)
        {

        }
    }
}
