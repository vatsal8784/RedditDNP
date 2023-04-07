using Application.Shared.DTO;
using Application.Shared.Model;

namespace Application.Services;

public interface IAuthService
{
    Task<User> GetUser(string username, string password);
    Task RegisterUser(RegisterDTO userRegisterDto);
    
}