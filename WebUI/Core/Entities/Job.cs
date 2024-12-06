using WebUI.Core.Enums;

namespace WebUI.Core.Entities
{
    public class Job : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public JobLevel Level { get; set; }

        //Relations
        public long CompanyId { get; set; }
        public Company Company { get; set; } = new();
        public ICollection<Candidate> Candidates { get; set; } = [];
    }
}