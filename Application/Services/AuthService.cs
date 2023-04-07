using System.ComponentModel.DataAnnotations;
using Application.Shared.DTO;
using Application.Shared.Model;

namespace Application.Services;

public class AuthService : IAuthService
{
    private IList<User> Users;
    public Task<User> GetUser(string username, string password)
    {
        User? existingUser = Users.FirstOrDefault(u => 
            u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
        
        if (existingUser == null)
        {
            throw new Exception("User not found");
        }

        if (!existingUser.Password.Equals(password))
        {
            throw new Exception("Password mismatch");
        }

        return Task.FromResult(existingUser);
    }

    public Task RegisterUser(RegisterDTO userRegisterDto)
    {
        if (string.IsNullOrEmpty(userRegisterDto.UserName))
        {
            throw new ValidationException("Username cannot be null");
        }

        if (string.IsNullOrEmpty(userRegisterDto.Password))
        {
            throw new ValidationException("Password cannot be null");
        }

        var newUser = new User
        {
            Username = userRegisterDto.UserName,
            Password = userRegisterDto.Password,
            Age = userRegisterDto.Age,
            Email = userRegisterDto.Email,
            Name = userRegisterDto.Name
        };
        
        Users.Add(newUser);
        
        return Task.CompletedTask;
    }
    
}