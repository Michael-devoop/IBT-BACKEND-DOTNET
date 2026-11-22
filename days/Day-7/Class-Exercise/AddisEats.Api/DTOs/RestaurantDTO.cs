namespace AddisEats.Api.DTOs;

public record RestaurantDTO
(
	string Name,
	string Address,
	decimal Phone,
	bool IsActive
);