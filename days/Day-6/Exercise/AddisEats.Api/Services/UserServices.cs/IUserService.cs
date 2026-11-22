using AddisEats.Api.Models;
using AddisEats.Api.DTOs;

namespace AddisEats.Api.Services.UserServices;

public interface IUserService
{
    List<UserDTO> GetAllUsers();
    UserDTO GetById(int id);
}