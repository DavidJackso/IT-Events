
namespace IT_Events.Models
{
    public class Organizator : User
    {
        private string OrganizationName { get; set; }
        private string OrganizationAddress { get; set; }
        private string OrganizationPhone { get; set; }
        private string OrganizationEmail { get; set; }

        public Organizator(Guid id, string name, string surname, string email, string password,
                           string organizationName, string organizationAddress, string organizationPhone, string organizationEmail)
            : base(id, name, surname, email, password)
        {
            OrganizationName = organizationName;
            OrganizationAddress = organizationAddress;
            OrganizationPhone = organizationPhone;
            OrganizationEmail = organizationEmail;
        }
    }
}
