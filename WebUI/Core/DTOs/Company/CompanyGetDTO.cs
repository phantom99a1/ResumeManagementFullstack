using WebUI.Core.Enums;

namespace WebUI.Core.DTOs.Company
{
    public class CompanyGetDTO
    {
        public long ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public CompanySize Size { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
