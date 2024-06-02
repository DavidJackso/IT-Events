using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Service
{
    public class ValidData
    {
        public ValidData() 
        {

        }
        public bool PersonalInfoisValid()
        {
            return true;
        }

        public bool RegestrationDataisValid(string username, string password, string repeatpassword, string role)
        {
            if (UsernameisVlaid(username) && PasswordisValid(password,repeatpassword) && RoleisValid(role))
                return true;

            return false;
        }
        public bool EventDataisValid(string name,string type,string eventloacation,string organizator,string description) 
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(type) || string.IsNullOrEmpty(eventloacation) || string.IsNullOrEmpty(organizator) || string.IsNullOrEmpty(description))  
            {
                MessageBox.Show("Заполните все данные мероприятия", "Неверно введены данные");
                return false; 
            }
            return true;
        }
        private bool RoleisValid(string Role) 
        {
            if (Role == null)
            {
                MessageBox.Show("Укажите свою роль");
                return false;
            }
            return true;
        }
        private bool PasswordisValid(string Password,string RepeatPassword) 
        {
            Regex regex = new Regex("");

            if (Password == null)
                MessageBox.Show("Введите пароль.");

            string result = "";
            if (Password.Length < 8)
                result += "Символов в пароле должно быть больше 8\n";

            regex = new Regex(@"\s");
            if (regex.Matches(Password).Count != 0)
                result += "Нельзя использовать символы табуляции\n";

            regex = new Regex(@"\d");
            if (regex.Matches(Password).Count == 0 )
                result += "Пароль должен содержать цифры\n";

            regex = new Regex(@"[а-я]");
            if (regex.Matches(Password).Count != 0)
                result += "Пароль не должен содержать килирицу\n";

            regex = new Regex(@"\W");              
            if (regex.Matches(Password).Count == 0)
                result += "Пароль должен содержать спец символы:('@' '#' '%' ...)\n";

            if (Password != RepeatPassword)
                result += "Пароли не совпадают";

            if (result == "")
                return true;
            else
                MessageBox.Show(result, "Не соблюдены правила записания пароля!");
            return false;
        }
        private bool UsernameisVlaid(string Username)
        {
            Regex regex = new Regex("");

            if (Username == null)
                MessageBox.Show("Введите имя пользователя.");

            string result = "";
            if (Username.Length < 3)
                result += "Символов в логине должно быть больше 3\n";

            regex = new Regex(@"[а-я]");
            if (regex.Matches(Username).Count > 0)
                result += "Логин не должен содержать килирицу\n\n";
            
            regex = new Regex(@"\W");
            if (regex.Matches(Username).Count > 0)
                result += "Логин не должен содержать спец символы:('@' '#' '%' ...)\n";

            regex = new Regex(@"\s");
            if (regex.Matches(Username).Count != 0)
                result += "Нельзя использовать символы табуляции\n";
           
            if (!(new UsersBase().SearchUser(new User(Username,null,null,Guid.Empty))is null))
                result += "Данный логин уже занят";

            if (result == "")
                return true;
            else
                MessageBox.Show(result, "Не соблюдены правила записания пароля!");
            return false;
        }
    }
}
