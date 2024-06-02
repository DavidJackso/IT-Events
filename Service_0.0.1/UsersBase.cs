using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Runtime.InteropServices.WindowsRuntime;


namespace Service
{
    public class UsersBase
    {
        User ActiveUser;
        static Dictionary<string, User> Users;
        static string pathtobase = "data/bases/users.json";
        public UsersBase(User activeuser)
        {
            ActiveUser = activeuser;
            ReadUsers();
        }
        public UsersBase()
        {
            ReadUsers();
        }

        public void AddUser()
        {
            ActiveUser.Password = HashingPassword(ActiveUser.Password);
            Users.Add(ActiveUser.Username, ActiveUser);
            ReWrite();
            MessageBox.Show("Регистрация прошла успешно!");
        }
        private void ReWrite()
        {
            StreamWriter write = new StreamWriter(pathtobase, false);
            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            serializer.Serialize(write, Users);
            write.Close();
        }
        public void AddPersonalData()
        {
            Users[ActiveUser.Username] = ActiveUser;
            ReWrite();
        }
        private void ReadUsers()
        {
            try
            {
                StreamReader stream = new StreamReader(pathtobase);
                string line = stream.ReadToEnd();
                Users = JsonConvert.DeserializeObject<Dictionary<string, User>>(line);
                if (Users == null) { Users = new Dictionary<string, User>(); }
                stream.Close();
            }
            catch (FileNotFoundException)
            {
                Users = new Dictionary<string, User>();
                File.Create(pathtobase).Close();
            }
        }
        public bool SucessLogin(User loginuser)
        {
            if (Users.ContainsKey(loginuser.Username))
            {
                User user = SearchUser(loginuser);
                if (HashingPassword(loginuser.Password) == user.Password)
                    return true;
            }
            return false;
        }
        public User SearchUser(User needuser)
        {
            if (Users == null)
                Users = new Dictionary<string, User>();
            if (Users.Count == 0)
                return null;

            if (Users.ContainsKey(needuser.Username))
                return Users[needuser.Username];

            return null;
        }
        private string HashingPassword(string password)
        {
            return Convert.ToBase64String(MD5.Create().ComputeHash(ASCIIEncoding.ASCII.GetBytes(password)));
        }
    }
    public class User
    {
        public string Username { get; }
        public string Password { get; set; }
        public string Role { get; }
        public Guid Id { get; }
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

        public PersonalInformation()
        {
        }
    }
}
