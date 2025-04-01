namespace ContactManagementSystem.Models
{
    public class ContactModel
    {
        public long MobileNumber { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string EmailId { get; set; } = string.Empty;
    }
}
