using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForms_CSharp_CTMTestTask
{
    public partial class frm_VertexInfo : Form
    {
        public frm_VertexInfo()
        {
            InitializeComponent();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            int x, y;

            x = int.Parse(nud_X.Value.ToString());
            y = int.Parse(nud_Y.Value.ToString());

            Program.core.callback_x = x;
            Program.core.callback_y = y;
            Program.core.callback_status = true;
            this.Close();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Program.core.callback_status = false;
            this.Close();
        }

        private void frm_VertexInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bSave_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                bClose_Click(sender, e);
            }
        }
    }
}
