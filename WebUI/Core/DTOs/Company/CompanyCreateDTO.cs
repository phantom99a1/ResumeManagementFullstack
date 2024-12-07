using WebUI.Core.Enums;

namespace WebUI.Core.DTOs.Company
{
    public class CompanyCreateDTO
    {
        public string Name { get; set; } = string.Empty;
        public CompanySize Size { get; set; }
    }
}
