using AddisEats.Api.Models;

namespace AddisEats.Api.DTOs;

public class UserDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}