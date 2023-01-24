namespace Cursed
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.gradientPanel1 = new Cursed.GradientPanel();
            this.CreateAccountButton = new Cursed.CustomButton();
            this.KirieshkiLabel = new System.Windows.Forms.Label();
            this.CancelButton = new Cursed.CustomButton();
            this.LineLabel = new System.Windows.Forms.Label();
            this.LoginButton = new Cursed.CustomButton();
            this.PasswordVisibleCheckBox = new System.Windows.Forms.CheckBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.AccountPasswordLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.AccountNameLabel = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorFirst = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.gradientPanel1.ColorSecond = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.gradientPanel1.Controls.Add(this.CreateAccountButton);
            this.gradientPanel1.Controls.Add(this.KirieshkiLabel);
            this.gradientPanel1.Controls.Add(this.CancelButton);
            this.gradientPanel1.Controls.Add(this.LineLabel);
            this.gradientPanel1.Controls.Add(this.LoginButton);
            this.gradientPanel1.Controls.Add(this.PasswordVisibleCheckBox);
            this.gradientPanel1.Controls.Add(this.PasswordTextBox);
            this.gradientPanel1.Controls.Add(this.AccountPasswordLabel);
            this.gradientPanel1.Controls.Add(this.LoginTextBox);
            this.gradientPanel1.Controls.Add(this.AccountNameLabel);
            this.gradientPanel1.Controls.Add(this.Logo);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gradientPanel1.ForeColor = System.Drawing.SystemColors.Control;
            this.gradientPanel1.GradientRotate = 75F;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(634, 361);
            this.gradientPanel1.TabIndex = 0;
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateAccountButton.ColorFirst = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            this.CreateAccountButton.ColorSecond = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.CreateAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CreateAccountButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CreateAccountButton.GradientRotate = 90F;
            this.CreateAccountButton.Location = new System.Drawing.Point(308, 291);
            this.CreateAccountButton.MousetTransp = 30;
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(206, 20);
            this.CreateAccountButton.TabIndex = 10;
            this.CreateAccountButton.TabStop = false;
            this.CreateAccountButton.Text = "Создать аккаунт";
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // KirieshkiLabel
            // 
            this.KirieshkiLabel.AutoSize = true;
            this.KirieshkiLabel.BackColor = System.Drawing.Color.Transparent;
            this.KirieshkiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.KirieshkiLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.KirieshkiLabel.Location = new System.Drawing.Point(134, 291);
            this.KirieshkiLabel.Name = "KirieshkiLabel";
            this.KirieshkiLabel.Size = new System.Drawing.Size(160, 20);
            this.KirieshkiLabel.TabIndex = 9;
            this.KirieshkiLabel.Text = "Нет аккаунта FWA?";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.ColorFirst = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            this.CancelButton.ColorSecond = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.CancelButton.GradientRotate = 90F;
            this.CancelButton.Location = new System.Drawing.Point(343, 215);
            this.CancelButton.MousetTransp = 30;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(171, 26);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.TabStop = false;
            this.CancelButton.Text = "Закрыть";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // LineLabel
            // 
            this.LineLabel.BackColor = System.Drawing.Color.Transparent;
            this.LineLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LineLabel.Location = new System.Drawing.Point(24, 263);
            this.LineLabel.Name = "LineLabel";
            this.LineLabel.Size = new System.Drawing.Size(590, 2);
            this.LineLabel.TabIndex = 7;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.ColorFirst = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(70)))), ((int)(((byte)(81)))));
            this.LoginButton.ColorSecond = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.LoginButton.GradientRotate = 90F;
            this.LoginButton.Location = new System.Drawing.Point(138, 215);
            this.LoginButton.MousetTransp = 30;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(199, 26);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.TabStop = false;
            this.LoginButton.Text = "Авторизация";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordVisibleCheckBox
            // 
            this.PasswordVisibleCheckBox.AutoSize = true;
            this.PasswordVisibleCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.PasswordVisibleCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PasswordVisibleCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.PasswordVisibleCheckBox.Location = new System.Drawing.Point(138, 184);
            this.PasswordVisibleCheckBox.Name = "PasswordVisibleCheckBox";
            this.PasswordVisibleCheckBox.Size = new System.Drawing.Size(140, 21);
            this.PasswordVisibleCheckBox.TabIndex = 5;
            this.PasswordVisibleCheckBox.TabStop = false;
            this.PasswordVisibleCheckBox.Text = "Показать пароль";
            this.PasswordVisibleCheckBox.UseVisualStyleBackColor = false;
            this.PasswordVisibleCheckBox.CheckedChanged += new System.EventHandler(this.PasswordVisibleCheckBox_CheckedChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.PasswordTextBox.Location = new System.Drawing.Point(138, 152);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(376, 26);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // AccountPasswordLabel
            // 
            this.AccountPasswordLabel.AutoSize = true;
            this.AccountPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.AccountPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AccountPasswordLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AccountPasswordLabel.Location = new System.Drawing.Point(54, 154);
            this.AccountPasswordLabel.Name = "AccountPasswordLabel";
            this.AccountPasswordLabel.Size = new System.Drawing.Size(67, 20);
            this.AccountPasswordLabel.TabIndex = 3;
            this.AccountPasswordLabel.Text = "Пароль";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoginTextBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.LoginTextBox.Location = new System.Drawing.Point(138, 107);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(376, 26);
            this.LoginTextBox.TabIndex = 2;
            // 
            // AccountNameLabel
            // 
            this.AccountNameLabel.AutoSize = true;
            this.AccountNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.AccountNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AccountNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AccountNameLabel.Location = new System.Drawing.Point(20, 109);
            this.AccountNameLabel.Name = "AccountNameLabel";
            this.AccountNameLabel.Size = new System.Drawing.Size(112, 20);
            this.AccountNameLabel.TabIndex = 1;
            this.AccountNameLabel.Text = "Имя аккаунта";
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(350, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(284, 101);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label AccountNameLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label AccountPasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.CheckBox PasswordVisibleCheckBox;
        private CustomButton LoginButton;
        private System.Windows.Forms.Label LineLabel;
        private CustomButton CreateAccountButton;
        private System.Windows.Forms.Label KirieshkiLabel;
        private CustomButton CancelButton;
    }
}