using System;
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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterLoginTextBox.Text = RegisterLoginTextBox.Text.Trim();
            RegisterPasswordTextBox.Text = RegisterPasswordTextBox.Text.Trim();
            RegisterPasswordDoubleTextBox.Text = RegisterPasswordDoubleTextBox.Text.Trim();

            User user = new User(RegisterLoginTextBox.Text, RegisterPasswordTextBox.Text, RegisterPasswordDoubleTextBox.Text);
            bool CorrectEnteredBool = user.CorrectEntered();
            bool CorrectUsername = user.UsernameCheck();
            if (CorrectEnteredBool && CorrectUsername)
            {
                user.CreateUser();
                MessageBox.Show("Пользователь успешно создан");
                this.Close();
            }
        }

        private void RegistrationTextFirstLabel_Click(object sender, EventArgs e)
        {

        }

        private void RegisterCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                RegisterPasswordTextBox.UseSystemPasswordChar = false;
                RegisterPasswordDoubleTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                RegisterPasswordTextBox.UseSystemPasswordChar = true;
                RegisterPasswordDoubleTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
