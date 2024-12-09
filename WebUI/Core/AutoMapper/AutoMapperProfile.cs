using AutoMapper;
using WebUI.Core.DTOs.Candidate;
using WebUI.Core.DTOs.Company;
using WebUI.Core.DTOs.Job;
using WebUI.Core.Entities;

namespace WebUI.Core.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //Company
            CreateMap<CompanyCreateDTO, Company>();
            CreateMap<Company, CompanyGetDTO>();

            //Job
            CreateMap<JobCreateDTO, Job>();
            CreateMap<Job, JobGetDTO>()
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Company.Name));

            //Candidate
            CreateMap<CandidateCreateDTO, Candidate>();
            CreateMap<Candidate, CandidateGetDTO>();
        }
    }
}
