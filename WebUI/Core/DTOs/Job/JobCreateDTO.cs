using WebUI.Core.Enums;

namespace WebUI.Core.DTOs.Job
{
    public class JobCreateDTO
    {
        public string Title { get; set; } = string.Empty;
        public JobLevel Level { get; set; }
        public long CompanyId { get; set; }
    }
}
