using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using OparinReact.Backend.Models;

namespace OparinReact.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Project>>> GetProjects()
        {
            return await _context.Project
                .Include(p => p.EmployeeProject)
                .ThenInclude(ep => ep.Employee)
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Project>> GetProject(int id)
        {
            var project = await _context.Project
                .Include(p => p.EmployeeProject)
                .ThenInclude(ep => ep.Employee)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (project == null) return NotFound();

            return project;
        }
    }
}
