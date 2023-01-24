using System.Windows.Forms;

namespace Cursed
{
    class User
    {
        private string UserName;
        private string UserPassword;
        private string PasswordConfirm;
        Database database = new Database();
        public User(string username, string password, string passwordconfirm = null)
        {
            UserName = username;
            UserPassword = password;
            PasswordConfirm = passwordconfirm;
        }
        // Проверяет правильность введенных данных в форме входа
        public bool CorrectEntered()
        {
            if (UserName == "" || UserName == null)
            {
                MessageBox.Show("Введите имя пользователя.");
                return false;
            }
            if (UserPassword == "" || UserPassword == null)
            {
                MessageBox.Show("Введите пароль.");
                return false;
            }

            if (UserName.Length < 6)
            {
                MessageBox.Show("Имя пользователя меньше 6 симоволов.");
                return false;
            }
            if (UserPassword.Length < 8)
            {
                MessageBox.Show("Пароль должен быть не меньше 8 символов.");
                return false;
            }

            if (UserPassword != PasswordConfirm)
            {
                MessageBox.Show("Пароль и повторение пароля не совпадают.");
                return false;
            }
            return true;
        }
        //создание пользователя
        public void CreateUser()
        {
            database.CreateUser(UserName, UserPassword);
        }

        public bool UsernameCheck()
        {
            bool Check = database.UsernameCheck(UserName);
            if (!Check)
            {
                MessageBox.Show("Пользователь с таким именем уже существует.");
            }
            return Check;
        }
        public bool UserAutorisation()
        {
            bool Check = database.Autorisation(UserName, UserPassword);
            if (!Check)
            {
                MessageBox.Show("Неверное имя пользователя или пароль.");
            }
            return Check;
        }
    }
}
