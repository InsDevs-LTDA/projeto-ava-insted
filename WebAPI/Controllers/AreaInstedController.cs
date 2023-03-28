using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{

    [ApiController]
    [Route("user")]

    public class AreaInstedController : ControllerBase
    {

        private AreaInstedContext _context;
        public AreaInstedController(AreaInstedContext context)
        {
            _context = context;
        }

        [HttpGet("get-users")]
        public IEnumerable<TbUser> GetUser([FromQuery] int skip = 0, [FromQuery] int take = 15)

        {
            return (IEnumerable<TbUser>)_context.TbUsers.Skip(skip).Take(take);
        }

        [HttpGet("get-users/{id}")]
        public IActionResult GetUserByID(int id)
        {
            var user = _context.TbUsers.FirstOrDefault(a => a.IdUser == id);

            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpGet("recover-password/{col}/{recoverField}")]
        public async Task<IActionResult> RecoverPassword(string recoverField, string col)
        {
            var properties = new Dictionary<string, string>
            {
            { "ra", "NrRegister" },
            { "cpf", "NrCpf" },
            { "email", "NmEmail" }
        };

            if (!properties.TryGetValue(col, out string propertyName))
            {
                return BadRequest("Coluna inv�lida.");
            }

            var user = await _context.TbUsers.SingleOrDefaultAsync(u => EF.Property<string>(u, propertyName) == recoverField);

            if (user == null)
            {
                return NotFound("Usu�rio n�o encontrado.");
            }
            return Ok(new { user.NmEmail });
        }


    }
}
