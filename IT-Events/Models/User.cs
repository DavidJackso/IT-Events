namespace IT_Events.Models
{
    public class User
    {
        Guid Id { get; }
        string Name { get; set; }
        string Surname { get; set; }
        string Email { get; set; }
        string Password { get; set; }

        public User(Guid id, string name, string surname, string email, string password)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
        }
    }
}
