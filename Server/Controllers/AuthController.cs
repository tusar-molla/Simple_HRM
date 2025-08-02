using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.Application.DTOs;
using Server.Application.Interface;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO dto)
        {
            try
            {
                if(!ModelState.IsValid)
                    return BadRequest(ModelState);

                var token = await _authService.LoginAsync(dto);
                if (token == null) return Unauthorized("Invalid Credentials.");
                return Ok(new { token });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    Message = "Internal Server error",
                    Error = ex.Message,
                    Inner = ex.InnerException?.Message
                });
                }
            }
        }
    }
