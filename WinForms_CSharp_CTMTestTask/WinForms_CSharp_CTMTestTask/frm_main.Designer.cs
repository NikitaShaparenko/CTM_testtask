namespace WinForms_CSharp_CTMTestTask
{
    partial class frm_main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.pnlAddon = new System.Windows.Forms.Panel();
            this.main_tlp = new System.Windows.Forms.TableLayoutPanel();
            this.pnl = new System.Windows.Forms.Panel();
            this.tWelcome = new System.Windows.Forms.Timer(this.components);
            this.main_tlp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddon
            // 
            this.pnlAddon.Location = new System.Drawing.Point(603, 3);
            this.pnlAddon.Name = "pnlAddon";
            this.pnlAddon.Size = new System.Drawing.Size(207, 521);
            this.pnlAddon.TabIndex = 0;
            // 
            // main_tlp
            // 
            this.main_tlp.BackColor = System.Drawing.Color.Transparent;
            this.main_tlp.ColumnCount = 2;
            this.main_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.main_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.main_tlp.Controls.Add(this.pnlAddon, 1, 0);
            this.main_tlp.Controls.Add(this.pnl, 0, 0);
            this.main_tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_tlp.Location = new System.Drawing.Point(0, 0);
            this.main_tlp.Name = "main_tlp";
            this.main_tlp.RowCount = 1;
            this.main_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.main_tlp.Size = new System.Drawing.Size(800, 617);
            this.main_tlp.TabIndex = 1;
            this.main_tlp.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pnl
            // 
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(3, 3);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(594, 611);
            this.pnl.TabIndex = 1;
            // 
            // tWelcome
            // 
            this.tWelcome.Enabled = true;
            this.tWelcome.Interval = 200;
            this.tWelcome.Tick += new System.EventHandler(this.tWelcome_Tick);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.main_tlp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 656);
            this.MinimumSize = new System.Drawing.Size(816, 656);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестовое задание";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.main_tlp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlAddon;
        private System.Windows.Forms.TableLayoutPanel main_tlp;
        public System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Timer tWelcome;
    }
}

