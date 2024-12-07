using AutoMapper;
using WebUI.Core.DTOs.Company;
using WebUI.Core.Entities;

namespace WebUI.Core.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //Company
            CreateMap<CompanyCreateDTO, Company>();
        }
    }
}
