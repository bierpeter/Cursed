using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursed
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void PasswordVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordVisibleCheckBox.Checked == true)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginTextBox.Text = LoginTextBox.Text.Trim();
            PasswordTextBox.Text = PasswordTextBox.Text.Trim();
            try
            {
                User user = new User(LoginTextBox.Text, PasswordTextBox.Text);
                if (user.UserAutorisation())
                {
                    this.Hide();
                    var formProgram = new FormProgram();
                    formProgram.Closed += (s, args) => this.Close();
                    formProgram.Show();
                }
            }
            catch { }
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            FormRegister FormRegisterDialog = new FormRegister();
            FormRegisterDialog.ShowDialog();
        }
    }
}
