using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudenAdminPortal.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudenAdminPortal.API.Controllers
{
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IStudentRepo repo;
        private readonly IMapper mapper;

        public StudentController(IStudentRepo repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllStudentsAsync()
        {
            var stds=mapper.Map<List<DomainModels.Student>>(await repo.GetStudentsAsync());
            return Ok(stds);
        }
    }
}
