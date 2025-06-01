using System.Data;

namespace IT_Events.Models
{
    public class Member:User
    {
        DateTime birtDate { get; set; }
        string phone { get; set; }
        string email { get; set; }
        string education { get; set; }
        string skills { get; set; }
        string experience { get; set; }
        string interests { get; set; }
        string imageUrl { get; set; }
        string status { get; set; }
        DateTime createdAt { get; set; }
        public Member(Guid id, string name, string surname, string email, string password, DateTime birtDate, string phone, string education, string skills, string experience, string interests, string imageUrl, string status)
            : base(id, name, surname, email, password)
        {
            this.birtDate = birtDate;
            this.phone = phone;
            this.email = email;
            this.education = education;
            this.skills = skills;
            this.experience = experience;
            this.interests = interests;
            this.imageUrl = imageUrl;
            this.status = status;
            createdAt = DateTime.UtcNow;
        }

    }
}
