using Microsoft.AspNetCore.Mvc;
using AddisEats.Api.Models;
using AddisEats.Api.Services.RestaurantServices;


namespace AddisEats.Api.Services.RestaurantServices;

public class RestaurantService : IRestaurantService
{
    private readonly List<Restaurant> _restaurant = new()
    {
        new Restaurant { Id = 1, Name = "Burger", Description = "A delicious beef burger", Price = 5.99m },
        new  { Id = 2, Name = "Pizza", Description = "A tasty pepperoni pizza", Price = 10.99m },
        new MenuItem { Id = 3, Name = "Pasta", Description = "A classic spaghetti bolognese", Price = 8.99m },
        new MenuItem { Id = 4, Name = "Salad", Description = "A fresh garden salad", Price = 4.99m },
        new MenuItem { Id = 5, Name = "Sushi", Description = "A selection of fresh sushi rolls", Price = 12.99m }
    };


    public class List<Restaurant> GetAll()
    {

    }
}