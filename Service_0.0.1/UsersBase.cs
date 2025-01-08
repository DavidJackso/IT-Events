using Newtonsoft.Json;
using Service_0._0._1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace Service
{
    public class UsersBase:IDB
    {
        readonly User ActiveUser;
        private static Dictionary<string, User> Users;
        private static readonly string pathtobase = "data/bases/users.json";

        public UsersBase(User activeuser)
        {
            ActiveUser = activeuser;
            Deserileze();
        }

        public UsersBase()
        {
            Deserileze();
        }

        public void AddUser()
        {
            ActiveUser.Password = HashPassword(ActiveUser.Password);
            Users[ActiveUser.Username] = ActiveUser;
            Serileze();
            MessageBox.Show("Регистрация прошла успешно!");
        }

        public void AddPersonalData()
        {
            Users[ActiveUser.Username] = ActiveUser;
            Serileze();
        }

        public bool SucessLogin(User loginuser)
        {
            if (Users.TryGetValue(loginuser.Username, out var user))
            {
                return HashPassword(loginuser.Password) == user.Password;
            }
            return false;
        }

        public User GetUser(User needuser)
        {
            if (Users == null)
            {
                Users = new Dictionary<string, User>();
            }
            return Users.TryGetValue(needuser.Username, out User user) ? user : null;
        }

        public void Deserileze()
        {
            if (File.Exists(pathtobase))
            {
                using (var stream = new StreamReader(pathtobase))
                {
                    Users = JsonConvert.DeserializeObject<Dictionary<string, User>>(stream.ReadToEnd());
                }
            }
            else
            {
                Users = new Dictionary<string, User>();
                MessageBox.Show("Файл с данными пользователей не найден.");
            }
        }

        public void Serileze()
        {
            using (var write = new StreamWriter(pathtobase, false))
            {
                var serializer = new JsonSerializer { Formatting = Formatting.Indented };
                serializer.Serialize(write, Users);
            }
        }

        private string HashPassword(string password)
        {
            using (var md5 = MD5.Create())
            {
                var inputBytes = Encoding.ASCII.GetBytes(password);
                var hashBytes = md5.ComputeHash(inputBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
    public class User
    {
        public readonly string Username;
        public string Password;
        public readonly string Role;
        public readonly Guid Id;
        public PersonalInformation PersonalInfo { get; set; }

        public User(string username, string password, string role, Guid id, PersonalInformation personal = null)
        {
            Username = username;
            Password = password;
            Role = role;
            PersonalInfo = personal;
            Id = id;
        }
    }
    public class PersonalInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string Organization { get; set; }
    }
}
