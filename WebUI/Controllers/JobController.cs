using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebUI.Core.Context;
using WebUI.Core.DTOs.Job;
using WebUI.Core.Entities;

namespace WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private ApplicationDbContext _context { get; }
        private IMapper _mapper { get; }
        public JobController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //CRUD

        //Create
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateJob([FromBody] JobCreateDTO dto)
        {
            var newJob = _mapper.Map<Job>(dto);
            await _context.Jobs.AddAsync(newJob);
            await _context.SaveChangesAsync();

            return Ok("Job Created Successfully!");
        }

        // Read
        [HttpGet]
        [Route("Get")]
        public async Task<ActionResult<IEnumerable<JobGetDTO>>> GetJobs()
        {
            var jobs = await _context.Jobs.Include(job => job.Company).OrderByDescending(q => q.CreatedAt).ToListAsync();
            var convertdJobs = _mapper.Map<IEnumerable<JobGetDTO>>(jobs);

            return Ok(convertdJobs);
        }
    }
}
