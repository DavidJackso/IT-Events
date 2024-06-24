using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace Service
{
    public class UsersDateBase
    {
        User ActiveUser;
        static Dictionary<string, User> Users;
        static string pathtobase = "data/bases/users.json";
        static Server server = new Server();
        public UsersDateBase(User activeuser)
        {
            ActiveUser = activeuser;
            ReadUsers();
        }
        public UsersDateBase()
        {
            ReadUsers();
        }

        public void AddUser()
        {
            server.DownloadBases();
            ActiveUser.Password = HashingPassword(ActiveUser.Password);
            Users.Add(ActiveUser.Username, ActiveUser);
            ReWrite();
            MessageBox.Show("Регистрация прошла успешно!");
            server.UpdateBases();
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
            server.DownloadBases();
            Users[ActiveUser.Username] = ActiveUser;
            ReWrite();
            server.UpdateBases();
        }
        private void ReadUsers()
        {
            if (File.Exists(pathtobase))
            {
                StreamReader stream = new StreamReader(pathtobase);
                Users = JsonConvert.DeserializeObject<Dictionary<string, User>>(stream.ReadToEnd());
                stream.Close();
            }
            else
            {
                Users = new Dictionary<string, User>();
                MessageBox.Show("Файл с данными пользователей не найден");
            }
        }
        public bool SucessLogin(User loginuser)
        {
            if (Users.ContainsKey(loginuser.Username))
            {
                User user = GetUser(loginuser);
                if (HashingPassword(loginuser.Password) == user.Password)
                    return true;
            }
            return false;
        }
        public User GetUser(User needuser)
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
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(password);
            byte[] hashBytes = md5.ComputeHash(inputBytes);
            return Convert.ToBase64String(hashBytes);
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

        public PersonalInformation()
        {
        }
    }
}
