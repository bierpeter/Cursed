namespace Cursed
{
    partial class FormProgram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProgram));
            this.MouseButton = new System.Windows.Forms.Button();
            this.VertexButton = new System.Windows.Forms.Button();
            this.EdgeButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstTextBox = new System.Windows.Forms.TextBox();
            this.SecondTextBox = new System.Windows.Forms.TextBox();
            this.ResultButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.WayButton = new System.Windows.Forms.Button();
            this.WayTextBox = new System.Windows.Forms.TextBox();
            this.InfoButton = new System.Windows.Forms.Button();
            this.SaveGraphButton = new System.Windows.Forms.Button();
            this.SaveResultButton = new System.Windows.Forms.Button();
            this.sheet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).BeginInit();
            this.SuspendLayout();
            // 
            // MouseButton
            // 
            this.MouseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MouseButton.Location = new System.Drawing.Point(12, 12);
            this.MouseButton.Name = "MouseButton";
            this.MouseButton.Size = new System.Drawing.Size(94, 30);
            this.MouseButton.TabIndex = 0;
            this.MouseButton.TabStop = false;
            this.MouseButton.Text = "Курсор";
            this.MouseButton.UseVisualStyleBackColor = true;
            this.MouseButton.Click += new System.EventHandler(this.MouseButton_Click);
            // 
            // VertexButton
            // 
            this.VertexButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VertexButton.Location = new System.Drawing.Point(112, 12);
            this.VertexButton.Name = "VertexButton";
            this.VertexButton.Size = new System.Drawing.Size(94, 30);
            this.VertexButton.TabIndex = 1;
            this.VertexButton.TabStop = false;
            this.VertexButton.Text = "Вершина";
            this.VertexButton.UseVisualStyleBackColor = true;
            this.VertexButton.Click += new System.EventHandler(this.VertexButton_Click);
            // 
            // EdgeButton
            // 
            this.EdgeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EdgeButton.Location = new System.Drawing.Point(212, 12);
            this.EdgeButton.Name = "EdgeButton";
            this.EdgeButton.Size = new System.Drawing.Size(94, 30);
            this.EdgeButton.TabIndex = 2;
            this.EdgeButton.TabStop = false;
            this.EdgeButton.Text = "Ребро";
            this.EdgeButton.UseVisualStyleBackColor = true;
            this.EdgeButton.Click += new System.EventHandler(this.EdgeButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(312, 12);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(94, 30);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(412, 12);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(94, 30);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.TabStop = false;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(532, 73);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(241, 24);
            this.label.TabIndex = 8;
            this.label.Text = "Введите номера городов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(532, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Город 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(532, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Город 2:";
            // 
            // FirstTextBox
            // 
            this.FirstTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstTextBox.Location = new System.Drawing.Point(639, 108);
            this.FirstTextBox.Name = "FirstTextBox";
            this.FirstTextBox.Size = new System.Drawing.Size(50, 29);
            this.FirstTextBox.TabIndex = 1;
            // 
            // SecondTextBox
            // 
            this.SecondTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondTextBox.Location = new System.Drawing.Point(639, 143);
            this.SecondTextBox.Name = "SecondTextBox";
            this.SecondTextBox.Size = new System.Drawing.Size(50, 29);
            this.SecondTextBox.TabIndex = 2;
            // 
            // ResultButton
            // 
            this.ResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultButton.Location = new System.Drawing.Point(536, 178);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(237, 31);
            this.ResultButton.TabIndex = 3;
            this.ResultButton.Text = "Найти кратчайшее расстояние";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTextBox.Location = new System.Drawing.Point(536, 215);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(237, 29);
            this.ResultTextBox.TabIndex = 14;
            this.ResultTextBox.TabStop = false;
            // 
            // WayButton
            // 
            this.WayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WayButton.Location = new System.Drawing.Point(536, 250);
            this.WayButton.Name = "WayButton";
            this.WayButton.Size = new System.Drawing.Size(237, 31);
            this.WayButton.TabIndex = 15;
            this.WayButton.Text = "Проложить кратчайший путь";
            this.WayButton.UseVisualStyleBackColor = true;
            this.WayButton.Click += new System.EventHandler(this.WayButton_Click);
            // 
            // WayTextBox
            // 
            this.WayTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.WayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WayTextBox.HideSelection = false;
            this.WayTextBox.Location = new System.Drawing.Point(536, 287);
            this.WayTextBox.Name = "WayTextBox";
            this.WayTextBox.ReadOnly = true;
            this.WayTextBox.Size = new System.Drawing.Size(237, 29);
            this.WayTextBox.TabIndex = 16;
            this.WayTextBox.TabStop = false;
            // 
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(677, 12);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(111, 30);
            this.InfoButton.TabIndex = 17;
            this.InfoButton.TabStop = false;
            this.InfoButton.Text = "О программе";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // SaveGraphButton
            // 
            this.SaveGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveGraphButton.Location = new System.Drawing.Point(536, 370);
            this.SaveGraphButton.Name = "SaveGraphButton";
            this.SaveGraphButton.Size = new System.Drawing.Size(237, 31);
            this.SaveGraphButton.TabIndex = 18;
            this.SaveGraphButton.Text = "Сохранить изображение графа";
            this.SaveGraphButton.UseVisualStyleBackColor = true;
            this.SaveGraphButton.Click += new System.EventHandler(this.SaveGraphButton_Click);
            // 
            // SaveResultButton
            // 
            this.SaveResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveResultButton.Location = new System.Drawing.Point(536, 407);
            this.SaveResultButton.Name = "SaveResultButton";
            this.SaveResultButton.Size = new System.Drawing.Size(237, 31);
            this.SaveResultButton.TabIndex = 19;
            this.SaveResultButton.Text = "Сохранить результат работы";
            this.SaveResultButton.UseVisualStyleBackColor = true;
            this.SaveResultButton.Click += new System.EventHandler(this.SaveResultButton_Click);
            // 
            // sheet
            // 
            this.sheet.BackColor = System.Drawing.SystemColors.Control;
            this.sheet.Location = new System.Drawing.Point(12, 53);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(494, 385);
            this.sheet.TabIndex = 5;
            this.sheet.TabStop = false;
            this.sheet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sheet_MouseClick);
            // 
            // FormProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveResultButton);
            this.Controls.Add(this.SaveGraphButton);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.WayTextBox);
            this.Controls.Add(this.WayButton);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.SecondTextBox);
            this.Controls.Add(this.FirstTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.sheet);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EdgeButton);
            this.Controls.Add(this.VertexButton);
            this.Controls.Add(this.MouseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormProgram";
            this.Text = "Алгоритм Флойда-Уоршелла";
            this.Load += new System.EventHandler(this.FormProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MouseButton;
        private System.Windows.Forms.Button VertexButton;
        private System.Windows.Forms.Button EdgeButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.PictureBox sheet;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstTextBox;
        private System.Windows.Forms.TextBox SecondTextBox;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button WayButton;
        private System.Windows.Forms.TextBox WayTextBox;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button SaveGraphButton;
        private System.Windows.Forms.Button SaveResultButton;
    }
}