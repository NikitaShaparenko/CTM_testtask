namespace WinForms_CSharp_CTMTestTask
{
    partial class uc_grapharea
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_grapharea));
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_area = new System.Windows.Forms.Panel();
            this.pnl_bg = new System.Windows.Forms.Panel();
            this.pnl_bg.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Координатная сетка: (500 x 500 пикселей)";
            // 
            // pnl_area
            // 
            this.pnl_area.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_area.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_area.Location = new System.Drawing.Point(74, 72);
            this.pnl_area.Name = "pnl_area";
            this.pnl_area.Size = new System.Drawing.Size(500, 500);
            this.pnl_area.TabIndex = 1;
            // 
            // pnl_bg
            // 
            this.pnl_bg.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_bg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_bg.BackgroundImage")));
            this.pnl_bg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_bg.Controls.Add(this.label1);
            this.pnl_bg.Controls.Add(this.pnl_area);
            this.pnl_bg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_bg.Location = new System.Drawing.Point(0, 0);
            this.pnl_bg.Name = "pnl_bg";
            this.pnl_bg.Size = new System.Drawing.Size(600, 600);
            this.pnl_bg.TabIndex = 2;
            this.pnl_bg.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_bg_Paint);
            // 
            // uc_grapharea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_bg);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uc_grapharea";
            this.Size = new System.Drawing.Size(600, 600);
            this.pnl_bg.ResumeLayout(false);
            this.pnl_bg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_bg;
        public System.Windows.Forms.Panel pnl_area;
    }
}
