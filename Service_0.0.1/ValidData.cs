using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Service
{
    public class ValidData
    {
        public bool RegestrationDataisValid(string username, string password, string repeatPassword, string role)
        { 
            return ValidateUsername(username) && ValidatePassword(password, repeatPassword) && ValidateRole(role);
        }

        public bool EventDataisValid(string name, string type, string location, string organizer, string description, DateTime date)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(type) || string.IsNullOrWhiteSpace(location) ||
                string.IsNullOrWhiteSpace(organizer) || string.IsNullOrWhiteSpace(description))
                return ShowError("Заполните все данные мероприятия");

            if (date <= DateTime.Now)
                return ShowError("Неверно указана дата проведения");

            return true;
        }

        private bool ValidateRole(string role)
        {
            return !string.IsNullOrEmpty(role) || ShowError("Укажите свою роль");
        }

        private bool ValidatePassword(string password, string repeatPassword)
        {
            string errors = "";

            if (string.IsNullOrWhiteSpace(password)) errors += "Введите пароль.\n";
            if (password.Length < 8) errors += "Символов в пароле должно быть больше 8.\n";
            if (Regex.IsMatch(password, @"\s")) errors += "Нельзя использовать пробелы или табуляцию.\n";
            if (!Regex.IsMatch(password, @"\d")) errors += "Пароль должен содержать хотя бы одну цифру.\n";
            if (Regex.IsMatch(password, @"[а-я]")) errors += "Пароль не должен содержать кириллицу.\n";
            if (!Regex.IsMatch(password, @"\W")) errors += "Пароль должен содержать спецсимволы ('@', '#', '%', ...).\n";
            if (password != repeatPassword) errors += "Пароли не совпадают.\n";

            return string.IsNullOrEmpty(errors) || ShowError(errors);
        }

        private bool ValidateUsername(string username)
        {
            string errors = "";

            if (string.IsNullOrWhiteSpace(username)) errors += "Введите имя пользователя.\n";
            if (username.Length < 3) errors += "Символов в логине должно быть больше 3.\n";
            if (Regex.IsMatch(username, @"[а-я]")) errors += "Логин не должен содержать кириллицу.\n";
            if (Regex.IsMatch(username, @"\W")) errors += "Логин не должен содержать спецсимволы ('@', '#', '%', ...).\n";
            if (Regex.IsMatch(username, @"\s")) errors += "Нельзя использовать пробелы или табуляцию.\n";

            if (!(new UsersBase().GetUser(new User(username, null, null, Guid.Empty)) is null))
                errors += "Данный логин уже занят.\n";

            return string.IsNullOrEmpty(errors) || ShowError(errors);
        }

        private bool ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка валидации");
            return false;
        }
    }
}
