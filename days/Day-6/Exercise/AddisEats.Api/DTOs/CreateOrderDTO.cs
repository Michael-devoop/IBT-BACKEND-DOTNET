using AddisEats.Api.Models;

namespace AddisEats.Api.DTOs;

public record CreateOrderDTO
    (
    int RestaurantId,
    int MenuItemId,
    string CustomerName,
    string DeliveryAddress,
    string CustomerPhone,
    int Quantity,
    decimal TotalAmount
    );