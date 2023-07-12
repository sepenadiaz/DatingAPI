using DatingAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DomainContext _context;

        public UsersController(DomainContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> Get()
        {
            return await _context.AppUsers.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetById(int id)
        {
            return await _context.AppUsers.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
