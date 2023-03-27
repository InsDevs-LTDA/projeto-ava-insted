using connectionDB.Models;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;

namespace WebAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class AreaInstedController : ControllerBase
    {

        private AreaInstedContext _context;
        public AreaInstedController(AreaInstedContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<TbUser> GetUser([FromQuery] int skip = 0, [FromQuery] int take = 15)

        {
            return _context.TbUsers.Skip(skip).Take(take);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserByID(int id)
        {
            var user = _context.TbUsers.FirstOrDefault(a => a.IdUser == id);

            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }



        [HttpPost]
        public IActionResult AddUser([FromBody] TbUser user)
        {
            try
            {
                _context.TbUsers.Add(user);
                _context.SaveChanges();
                return CreatedAtAction(nameof(GetUserByID), new
                {
                    id =
                    user.IdUser
                },
                    user
                    );

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Erro ao criar usuário. " + ex.Message });

            }
        }

    }
}
