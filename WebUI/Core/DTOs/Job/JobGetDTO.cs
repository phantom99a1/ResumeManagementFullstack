using WebUI.Core.Enums;

namespace WebUI.Core.DTOs.Job
{
    public class JobGetDTO
    {
        public long ID { get; set; }
        public string Title { get; set; } = string.Empty;
        public JobLevel Level { get; set; }
        public long CompanyId { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
