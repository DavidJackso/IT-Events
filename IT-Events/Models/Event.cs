namespace IT_Events.Models
{
    public class Event
    {
        Guid Id { get; }
        string Name { get; set; }
        string Description { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        string Location { get; set; }
        string Organizer { get; set; }
        string ContactEmail { get; set; }
        string ContactPhone { get; set; }
        string ImageUrl { get; set; }
        string EventType { get; set; }
        string Status { get; set; }
        DateTime CreatedAt { get; set; }
        
    public Event(Guid id, string name, string description, DateTime startDate, DateTime endDate, string location, string organizer, string contactEmail, string contactPhone, string imageUrl, string eventType, string status)
        {
            Id = id;
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Location = location;
            Organizer = organizer;
            ContactEmail = contactEmail;
            ContactPhone = contactPhone;
            ImageUrl = imageUrl;
            EventType = eventType;
            Status = status;
            CreatedAt = DateTime.UtcNow; // Set the creation time to the current UTC time
        }
    }
}
