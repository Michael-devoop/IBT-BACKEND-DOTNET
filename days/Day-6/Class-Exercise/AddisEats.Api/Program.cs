using AddisEats.Api.Services.MenuItemServices;
using AddisEats.Api.Services.RestaurantServices;
using AddisEats.Api.Services.UserServices;
using AddisEats.Api.Services.OrderServices;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMenuItemService, MenuItemService>();
builder .Services.AddScoped<IRestaurantService, RestaurantService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IOrderService, OrderService>();

var thePhoneNumber = builder.Configuration.GetValue<string>("data:Contact:Phone");
Console.WriteLine($"The Phone number is: {thePhoneNumber}");


//ADDING CORS CONFIG
builder.Services.AddCors(option =>
option.AddPolicy("frontend", policy =>
policy.WithOrigins("http://localhost:3000")//React
      .AllowAnyHeader()
      .AllowAnyMethod()
));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("frontend");

app.MapControllers();

app.Run();
