using connectionDB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace connectionDB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class AreaInstedController : ControllerBase
    {
        private readonly AreaInstedContext _context;

        public AreaInstedController(AreaInstedContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbUser>>> GetUserASync()
        {
            return await _context.TbUsers.ToListAsync();
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<TbUser>> GetUserByIdASync(int userId)
        {
            TbUser? user = await _context.TbUsers.FindAsync(userId);

            if (user == null)
                return NotFound();

            return user;
        }

        [HttpPost]
        public async Task<ActionResult<TbUser>> CreateUserASync(TbUser user)
        {
            await _context.TbUsers.AddAsync(user);
            await _context.SaveChangesAsync();

            return Ok();

        }

        [HttpPut]
        public async Task<ActionResult> UpdateUserASync(TbUser user)
        {
            _context.TbUsers.Update(user ?? throw new Exception("User not found"));
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{userId}")]
        public async Task<ActionResult> DeleteUserASync(int userId)
        {
            TbUser? user = await _context.TbUsers.FindAsync(userId); ;
            _context.Remove(user ?? throw new Exception("User not found"));
            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}