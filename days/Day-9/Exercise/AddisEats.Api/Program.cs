using AddisEats.Api.Services.MenuItemServices;
using AddisEats.Api.Services.RestaurantServices;
using AddisEats.Api.Services.UserServices;
using AddisEats.Api.Services.OrderServices;
using System.Text.Json;
using System.Text.Json.Serialization;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy =
            System.Text.Json.JsonNamingPolicy.CamelCase;
    });

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
//CUSTOM MIDDLEWARE 1

app.Use(async (context, next) =>
{
    Console.WriteLine("the request is coming in.");

    await next(context);

    Console.WriteLine("the Request is going out.");
});

// CUSTOM MIDDLEWARE 2
app.Use(async (context, next) =>
{
    Console.WriteLine("The request is still comming in .");

    await next(context);

    Console.WriteLine("The request is still comming out.");
});
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("frontend");

app.UseMiddleware<CorrelationIdMiddleware>();

app.UseMiddleware<RequestTimingMiddleware>();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
