﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebUI.Core.Context;
using WebUI.Core.DTOs.Company;
using WebUI.Core.Entities;

namespace WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private ApplicationDbContext _context { get; }
        private IMapper _mapper { get; }
        public CompanyController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //CRUD

        //Create
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateCompany([FromBody] CompanyCreateDTO dto)
        {
            var newCompany = _mapper.Map<Company>(dto);
            await _context.Companies.AddAsync(newCompany);
            await _context.SaveChangesAsync();
            return Ok("Company Created Successfully!");
        }

        //Read
        [HttpGet]
        [Route("Get")]
        public async Task<ActionResult<IEnumerable<CompanyGetDTO>>> GetCompanies()
        {
            var companies = await _context.Companies.OrderByDescending(m => m.CreatedAt).ToListAsync();
            var convertedCompanies = _mapper.Map<IEnumerable<CompanyGetDTO>>(companies);
            return Ok(convertedCompanies);
        } 
    }
}
