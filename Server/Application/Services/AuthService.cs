using Microsoft.EntityFrameworkCore;
using Server.Application.DTOs;
using Server.Application.Interface;
using Server.Helpers;
using Server.Infrastructure.Data;
using System.Runtime.CompilerServices;

namespace Server.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _context;
        private readonly jwtTokenHelper _jwtToken;
        
        public AuthService(AppDbContext context, jwtTokenHelper jwtTokenHelper)
        {
            _context = context;
            _jwtToken = jwtTokenHelper;
        }
        public async Task<string> LoginAsync(LoginDTO dto)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == dto.Email);
            if (user == null || !BCrypt.Net.BCrypt.Verify(dto.Password, user.PasswordHash))
                return null!;

            return _jwtToken.GenerateToken(user);
        }
    }
}
