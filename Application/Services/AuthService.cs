using Application.Shared.Model;

namespace Application.Services;

public class AuthService : IAuthService
{
    private IList<User> Users = new List<User>();


    public Task<User> GetUser(string username, string password)
    {
        throw new NotImplementedException();
    }

    public Task RegisterUser(User user)
    {
        throw new NotImplementedException();
    }
}