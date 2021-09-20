namespace WinForms_CSharp_CTMTestTask
{
    partial class uc_VertexManager
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
            this.b_AddVertex = new System.Windows.Forms.Button();
            this.b_InsertVertex = new System.Windows.Forms.Button();
            this.b_KillVertex = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gb_Info = new System.Windows.Forms.GroupBox();
            this.txtSquare = new System.Windows.Forms.Label();
            this.txtVertexNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.ListBox();
            this.gb_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_AddVertex
            // 
            this.b_AddVertex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.b_AddVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_AddVertex.Location = new System.Drawing.Point(7, 238);
            this.b_AddVertex.Name = "b_AddVertex";
            this.b_AddVertex.Size = new System.Drawing.Size(144, 34);
            this.b_AddVertex.TabIndex = 0;
            this.b_AddVertex.Text = "Добавить точку";
            this.b_AddVertex.UseVisualStyleBackColor = true;
            this.b_AddVertex.Click += new System.EventHandler(this.b_AddVertex_Click);
            // 
            // b_InsertVertex
            // 
            this.b_InsertVertex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.b_InsertVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_InsertVertex.Location = new System.Drawing.Point(7, 313);
            this.b_InsertVertex.Name = "b_InsertVertex";
            this.b_InsertVertex.Size = new System.Drawing.Size(144, 34);
            this.b_InsertVertex.TabIndex = 1;
            this.b_InsertVertex.Text = "Вставить точку";
            this.b_InsertVertex.UseVisualStyleBackColor = true;
            this.b_InsertVertex.Click += new System.EventHandler(this.b_InsertVertex_Click);
            // 
            // b_KillVertex
            // 
            this.b_KillVertex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.b_KillVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_KillVertex.Location = new System.Drawing.Point(7, 353);
            this.b_KillVertex.Name = "b_KillVertex";
            this.b_KillVertex.Size = new System.Drawing.Size(144, 34);
            this.b_KillVertex.TabIndex = 2;
            this.b_KillVertex.Text = "Удалить точку";
            this.b_KillVertex.UseVisualStyleBackColor = true;
            this.b_KillVertex.Click += new System.EventHandler(this.b_KillVertex_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Header.Location = new System.Drawing.Point(3, 12);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(162, 20);
            this.lbl_Header.TabIndex = 3;
            this.lbl_Header.Text = "Окно ввода точек";
            // 
            // gb_Info
            // 
            this.gb_Info.BackColor = System.Drawing.Color.White;
            this.gb_Info.Controls.Add(this.txtSquare);
            this.gb_Info.Controls.Add(this.txtVertexNumber);
            this.gb_Info.Controls.Add(this.label3);
            this.gb_Info.Controls.Add(this.label2);
            this.gb_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_Info.Location = new System.Drawing.Point(6, 405);
            this.gb_Info.Name = "gb_Info";
            this.gb_Info.Size = new System.Drawing.Size(204, 110);
            this.gb_Info.TabIndex = 5;
            this.gb_Info.TabStop = false;
            this.gb_Info.Text = "Сведения";
            // 
            // txtSquare
            // 
            this.txtSquare.AutoSize = true;
            this.txtSquare.Location = new System.Drawing.Point(112, 81);
            this.txtSquare.Name = "txtSquare";
            this.txtSquare.Size = new System.Drawing.Size(18, 20);
            this.txtSquare.TabIndex = 4;
            this.txtSquare.Text = "0";
            // 
            // txtVertexNumber
            // 
            this.txtVertexNumber.AutoSize = true;
            this.txtVertexNumber.Location = new System.Drawing.Point(112, 42);
            this.txtVertexNumber.Name = "txtVertexNumber";
            this.txtVertexNumber.Size = new System.Drawing.Size(18, 20);
            this.txtVertexNumber.TabIndex = 3;
            this.txtVertexNumber.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Площадь:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Количество\r\nвершин:";
            // 
            // lb
            // 
            this.lb.BackColor = System.Drawing.SystemColors.Control;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 20;
            this.lb.Location = new System.Drawing.Point(7, 49);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(188, 184);
            this.lb.TabIndex = 6;
            // 
            // uc_VertexManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lb);
            this.Controls.Add(this.gb_Info);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.b_KillVertex);
            this.Controls.Add(this.b_InsertVertex);
            this.Controls.Add(this.b_AddVertex);
            this.MaximumSize = new System.Drawing.Size(213, 521);
            this.MinimumSize = new System.Drawing.Size(213, 521);
            this.Name = "uc_VertexManager";
            this.Size = new System.Drawing.Size(211, 519);
            this.Load += new System.EventHandler(this.uc_VertexManager_Load);
            this.gb_Info.ResumeLayout(false);
            this.gb_Info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_AddVertex;
        private System.Windows.Forms.Button b_InsertVertex;
        private System.Windows.Forms.Button b_KillVertex;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox gb_Info;
        private System.Windows.Forms.Label txtSquare;
        private System.Windows.Forms.Label txtVertexNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb;
    }
}
