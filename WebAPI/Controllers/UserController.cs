using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;
using Microsoft.AspNetCore.Authentication;
using WebAPI.Services;
using Microsoft.Extensions.Configuration;

namespace WebAPI.Controllers
{

    [ApiController]
    [Route("user")]

    public class UserController : ControllerBase
    {
        public class LoginModel
        {
            public string Login { get; set; }
            public string Password { get; set; }
        }

        private AreaInstedContext _context;
        private readonly IConfiguration _configuration;
        private readonly TokenService _tokenService;

        public UserController(AreaInstedContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
            _tokenService = new TokenService(_configuration);
        }

        [HttpPost("create-user")]
        public async Task<IActionResult> CreateUser([FromBody] TbUser user)
        {
            try
            {
                await _context.TbUsers.AddAsync(user);
                await _context.SaveChangesAsync();

                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
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

        [HttpPut("update-user/{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] TbUser user)
        {
            var userToUpdate = await _context.TbUsers.FirstOrDefaultAsync(u => u.IdUser == id);

            if (userToUpdate == null)
            {
                return NotFound();
            }

            try
            {
                userToUpdate.NmUser = user.NmUser;
                userToUpdate.NmEmail = user.NmEmail;
                userToUpdate.NmPassword = user.NmPassword;
                userToUpdate.NrRegister = user.NrRegister;
                userToUpdate.NrCpf = user.NrCpf;

                _context.TbUsers.Update(userToUpdate);
                await _context.SaveChangesAsync();

                return Ok(userToUpdate);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }



        [HttpDelete("delete-user/{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var userToDelete = await _context.TbUsers.FirstOrDefaultAsync(u => u.IdUser == id);

            if (userToDelete == null)
            {
                return NotFound();
            }

            try
            {
                _context.TbUsers.Remove(userToDelete);
                await _context.SaveChangesAsync();

                return Ok(userToDelete);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPost("auth")]
        public async Task<IActionResult> Authenticate([FromBody] LoginModel loginModel)
        {
            try
            {
                var user = await _context.TbUsers.FirstOrDefaultAsync(u =>
                    (u.NrRegister == loginModel.Login || u.NmEmail == loginModel.Login || u.NrCpf == loginModel.Login)
                    && u.NmPassword == loginModel.Password);

                if (user == null)
                {
                    return NotFound(new { message = "Usuário ou senha inválidas." });
                }

                var token = _tokenService.GenerateToken(user);
                user.NmPassword = "";
                return Ok(new
                {
                    success = true,
                    message="Usuário logado com sucesso!",
                    user =  user,
                    token = token
                });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }



    }
}
