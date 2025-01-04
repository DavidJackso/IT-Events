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
            if (string.IsNullOrWhiteSpace(password))
                return ShowError("Введите пароль.\n");
            if (password.Length < 8)
                return ShowError("Символов в пароле должно быть больше 8.\n");
            if (Regex.IsMatch(password, @"\s"))
                return ShowError("Нельзя использовать пробелы или табуляцию.\n");
            if (!Regex.IsMatch(password, @"\d"))
                return ShowError("Пароль должен содержать хотя бы одну цифру.\n");
            if (Regex.IsMatch(password, @"[а-я]"))
                return ShowError("Пароль не должен содержать кириллицу.\n");
            if (!Regex.IsMatch(password, @"\W"))
                return ShowError("Пароль должен содержать спецсимволы ('@', '#', '%', ...).\n");
            if (password != repeatPassword)
                return ShowError("Пароли не совпадают.\n");

            return true;
        }

        private bool ValidateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return ShowError("Введите имя пользователя.\n");
            if (username.Length < 3)
                return ShowError("Символов в логине должно быть больше 3.\n");
            if (Regex.IsMatch(username, @"[а-я]"))
                return ShowError("Логин не должен содержать кириллицу.\n");
            if (Regex.IsMatch(username, @"\W"))
                return ShowError("Логин не должен содержать спецсимволы ('@', '#', '%', ...).\n");
            if (Regex.IsMatch(username, @"\s"))
                return ShowError("Нельзя использовать пробелы или табуляцию.\n");

            if (!(new UsersBase().GetUser(new User(username, null, null, Guid.Empty)) is null))
                return ShowError("Данный логин уже занят.\n");

            return true;
        }

        private bool ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка валидации");
            return false;
        }
    }
}
