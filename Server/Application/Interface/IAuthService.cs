using Server.Application.DTOs;

namespace Server.Application.Interface
{
    public interface IAuthService
    {
        Task<string> LoginAsync(LoginDTO dto);
    }
}
