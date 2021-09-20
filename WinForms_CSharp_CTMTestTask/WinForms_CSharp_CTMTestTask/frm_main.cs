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
    public partial class frm_main : Form
    {
        public Graphics g;
        public frm_main()
        {
            g = pnl.CreateGraphics();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnl.Controls.Clear();
            Program.vm.Location = new Point(1, 1);
            Program.vm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            pnl.Controls.Add(Program.vm);
        }

    }
}
