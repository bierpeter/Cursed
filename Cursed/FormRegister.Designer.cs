namespace Cursed
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.gradientPanel1 = new Cursed.GradientPanel();
            this.RegisterCancelButton = new Cursed.CustomButton();
            this.RegisterButton = new Cursed.CustomButton();
            this.RegisterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.RegisterPasswordDoubleTextBox = new System.Windows.Forms.TextBox();
            this.RegisterLoginTextBox = new System.Windows.Forms.TextBox();
            this.RegistrationPasswordDoubleLabel = new System.Windows.Forms.Label();
            this.RegistrationPasswordLabel = new System.Windows.Forms.Label();
            this.RegistrationAccountNameLabel = new System.Windows.Forms.Label();
            this.RegistrationLineLabel = new System.Windows.Forms.Label();
            this.RegistrationTextSecondLabel = new System.Windows.Forms.Label();
            this.RegistrationTextFirstLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorFirst = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.gradientPanel1.ColorSecond = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.gradientPanel1.Controls.Add(this.checkBox1);
            this.gradientPanel1.Controls.Add(this.RegisterCancelButton);
            this.gradientPanel1.Controls.Add(this.RegisterButton);
            this.gradientPanel1.Controls.Add(this.RegisterPasswordTextBox);
            this.gradientPanel1.Controls.Add(this.RegisterPasswordDoubleTextBox);
            this.gradientPanel1.Controls.Add(this.RegisterLoginTextBox);
            this.gradientPanel1.Controls.Add(this.RegistrationPasswordDoubleLabel);
            this.gradientPanel1.Controls.Add(this.RegistrationPasswordLabel);
            this.gradientPanel1.Controls.Add(this.RegistrationAccountNameLabel);
            this.gradientPanel1.Controls.Add(this.RegistrationLineLabel);
            this.gradientPanel1.Controls.Add(this.RegistrationTextSecondLabel);
            this.gradientPanel1.Controls.Add(this.RegistrationTextFirstLabel);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.GradientRotate = 75F;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(284, 356);
            this.gradientPanel1.TabIndex = 0;
            // 
            // RegisterCancelButton
            // 
            this.RegisterCancelButton.BackColor = System.Drawing.Color.Transparent;
            this.RegisterCancelButton.ColorFirst = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            this.RegisterCancelButton.ColorSecond = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.RegisterCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RegisterCancelButton.ForeColor = System.Drawing.SystemColors.Control;
            this.RegisterCancelButton.GradientRotate = 80F;
            this.RegisterCancelButton.Location = new System.Drawing.Point(178, 283);
            this.RegisterCancelButton.MousetTransp = 30;
            this.RegisterCancelButton.Name = "RegisterCancelButton";
            this.RegisterCancelButton.Size = new System.Drawing.Size(84, 30);
            this.RegisterCancelButton.TabIndex = 10;
            this.RegisterCancelButton.Text = "Отмена";
            this.RegisterCancelButton.Click += new System.EventHandler(this.RegisterCancelButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.Transparent;
            this.RegisterButton.ColorFirst = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            this.RegisterButton.ColorSecond = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RegisterButton.ForeColor = System.Drawing.SystemColors.Control;
            this.RegisterButton.GradientRotate = 80F;
            this.RegisterButton.Location = new System.Drawing.Point(31, 283);
            this.RegisterButton.MousetTransp = 30;
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(141, 30);
            this.RegisterButton.TabIndex = 9;
            this.RegisterButton.Text = "Регистрация";
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterPasswordTextBox
            // 
            this.RegisterPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.RegisterPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegisterPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RegisterPasswordTextBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.RegisterPasswordTextBox.Location = new System.Drawing.Point(31, 160);
            this.RegisterPasswordTextBox.Name = "RegisterPasswordTextBox";
            this.RegisterPasswordTextBox.Size = new System.Drawing.Size(231, 23);
            this.RegisterPasswordTextBox.TabIndex = 7;
            this.RegisterPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // RegisterPasswordDoubleTextBox
            // 
            this.RegisterPasswordDoubleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.RegisterPasswordDoubleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegisterPasswordDoubleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RegisterPasswordDoubleTextBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.RegisterPasswordDoubleTextBox.Location = new System.Drawing.Point(31, 221);
            this.RegisterPasswordDoubleTextBox.Name = "RegisterPasswordDoubleTextBox";
            this.RegisterPasswordDoubleTextBox.Size = new System.Drawing.Size(231, 23);
            this.RegisterPasswordDoubleTextBox.TabIndex = 8;
            this.RegisterPasswordDoubleTextBox.UseSystemPasswordChar = true;
            // 
            // RegisterLoginTextBox
            // 
            this.RegisterLoginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.RegisterLoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegisterLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RegisterLoginTextBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.RegisterLoginTextBox.Location = new System.Drawing.Point(31, 101);
            this.RegisterLoginTextBox.Name = "RegisterLoginTextBox";
            this.RegisterLoginTextBox.Size = new System.Drawing.Size(231, 23);
            this.RegisterLoginTextBox.TabIndex = 6;
            // 
            // RegistrationPasswordDoubleLabel
            // 
            this.RegistrationPasswordDoubleLabel.AutoSize = true;
            this.RegistrationPasswordDoubleLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegistrationPasswordDoubleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RegistrationPasswordDoubleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.RegistrationPasswordDoubleLabel.Location = new System.Drawing.Point(27, 198);
            this.RegistrationPasswordDoubleLabel.Name = "RegistrationPasswordDoubleLabel";
            this.RegistrationPasswordDoubleLabel.Size = new System.Drawing.Size(152, 20);
            this.RegistrationPasswordDoubleLabel.TabIndex = 5;
            this.RegistrationPasswordDoubleLabel.Text = "Повторите пароль";
            // 
            // RegistrationPasswordLabel
            // 
            this.RegistrationPasswordLabel.AutoSize = true;
            this.RegistrationPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegistrationPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RegistrationPasswordLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.RegistrationPasswordLabel.Location = new System.Drawing.Point(27, 137);
            this.RegistrationPasswordLabel.Name = "RegistrationPasswordLabel";
            this.RegistrationPasswordLabel.Size = new System.Drawing.Size(67, 20);
            this.RegistrationPasswordLabel.TabIndex = 4;
            this.RegistrationPasswordLabel.Text = "Пароль";
            // 
            // RegistrationAccountNameLabel
            // 
            this.RegistrationAccountNameLabel.AutoSize = true;
            this.RegistrationAccountNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegistrationAccountNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RegistrationAccountNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.RegistrationAccountNameLabel.Location = new System.Drawing.Point(27, 78);
            this.RegistrationAccountNameLabel.Name = "RegistrationAccountNameLabel";
            this.RegistrationAccountNameLabel.Size = new System.Drawing.Size(112, 20);
            this.RegistrationAccountNameLabel.TabIndex = 3;
            this.RegistrationAccountNameLabel.Text = "Имя аккаунта";
            // 
            // RegistrationLineLabel
            // 
            this.RegistrationLineLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegistrationLineLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegistrationLineLabel.Location = new System.Drawing.Point(12, 53);
            this.RegistrationLineLabel.Name = "RegistrationLineLabel";
            this.RegistrationLineLabel.Size = new System.Drawing.Size(265, 2);
            this.RegistrationLineLabel.TabIndex = 2;
            // 
            // RegistrationTextSecondLabel
            // 
            this.RegistrationTextSecondLabel.AutoSize = true;
            this.RegistrationTextSecondLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegistrationTextSecondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RegistrationTextSecondLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.RegistrationTextSecondLabel.Location = new System.Drawing.Point(3, 26);
            this.RegistrationTextSecondLabel.Name = "RegistrationTextSecondLabel";
            this.RegistrationTextSecondLabel.Size = new System.Drawing.Size(278, 17);
            this.RegistrationTextSecondLabel.TabIndex = 1;
            this.RegistrationTextSecondLabel.Text = "Пароль должен быть больше 8 символов";
            // 
            // RegistrationTextFirstLabel
            // 
            this.RegistrationTextFirstLabel.AutoSize = true;
            this.RegistrationTextFirstLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegistrationTextFirstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RegistrationTextFirstLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.RegistrationTextFirstLabel.Location = new System.Drawing.Point(21, 9);
            this.RegistrationTextFirstLabel.Name = "RegistrationTextFirstLabel";
            this.RegistrationTextFirstLabel.Size = new System.Drawing.Size(241, 17);
            this.RegistrationTextFirstLabel.TabIndex = 0;
            this.RegistrationTextFirstLabel.Text = "Установите имя аккаунта и пароль";
            this.RegistrationTextFirstLabel.Click += new System.EventHandler(this.RegistrationTextFirstLabel_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.ForeColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(31, 250);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 20);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Показать пароль";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 356);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegister";
            this.Text = "Регистрация";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label RegistrationTextFirstLabel;
        private System.Windows.Forms.Label RegistrationTextSecondLabel;
        private System.Windows.Forms.Label RegistrationLineLabel;
        private System.Windows.Forms.Label RegistrationPasswordDoubleLabel;
        private System.Windows.Forms.Label RegistrationPasswordLabel;
        private System.Windows.Forms.Label RegistrationAccountNameLabel;
        private System.Windows.Forms.TextBox RegisterPasswordTextBox;
        private System.Windows.Forms.TextBox RegisterPasswordDoubleTextBox;
        private System.Windows.Forms.TextBox RegisterLoginTextBox;
        private CustomButton RegisterCancelButton;
        private CustomButton RegisterButton;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}