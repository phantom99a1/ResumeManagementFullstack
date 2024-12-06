namespace WebUI.Core.Entities
{
    public class Candidate : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string CoverLetter { get; set; } = string.Empty;
        public string ResumeURL { get; set; } = string.Empty;

        //Relations
        public long JobId { get; set; }
        public Job Job { get; set; } = new();
    }
}
