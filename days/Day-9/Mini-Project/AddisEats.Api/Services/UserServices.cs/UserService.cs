using AddisEats.Api.DTOs;
using AddisEats.Api.Models;
using AddisEats.Api.Services.UserServices;
using Microsoft.AspNetCore.Mvc;


public class UserService : IUserService
{

    public readonly List<User> _users = new List<User>
    {
        new User { Id = 1, Name = "User 1", Email = "user1@example.com" },
        new User { Id = 2, Name = "User 2", Email = "user2@example.com" }
    };

    public List<UserDTO> GetAllUsers()
    {
        return _users.Select(u => new UserDTO
        {
            Id = u.Id,
            Name = u.Name,
            Email = u.Email
        }).ToList();
    }

    public UserDTO GetById(int id)
    {
        var user = _users.FirstOrDefault(u => u.Id == id);
        if (user == null) return null;

        return new UserDTO
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email
        };
    }

}