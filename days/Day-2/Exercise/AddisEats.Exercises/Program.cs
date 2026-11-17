Console.WriteLine("My Name is Michael");
Console.WriteLine("Todays Date is: 11/17/2026");
Console.WriteLine("CodeOps Module 4 — .NET track");

/*-------------------------------------*/
int choice = 1;
long phoneNumber = 0911123456;
decimal totalAmount = 1000m;
double bonusAmount = 0.0;
bool IsActive = true;
char gender = 'M';
string RestaurantName = "AddisEats";
DateTime currentDate = DateTime.Now;

/*------------------------------------------*/
decimal subtotal = 1480.5m;
decimal deliveryFee = 60m;

decimal total = subtotal + deliveryFee;

Console.WriteLine("----- Addis Eats Receipt -----");

Console.WriteLine($"Subtotal:      {subtotal,10:N2}");
Console.WriteLine($"Delivery Fee:  {deliveryFee,10:N2}");
Console.WriteLine($"Total:         {total,10:N2}");


/*------------------------------------------*/

int result1 = 7 / 2;
Console.WriteLine($"Integer: {result1}");

decimal result2 = (decimal)7 / 2;
Console.WriteLine($"Decimal: {result2}");

// I would use decimal for splitting delivery fees because it preserves decimal values.


/*------------------------------------------*/

using System.Collections.Generic;

// 1. Integer example

int number1 = 10;
int number2 = number1;

number2 = 20;

Console.WriteLine("Integer values:");
Console.WriteLine(number1);
Console.WriteLine(number2);


// 2. List example

List<string> foods1 = new List<string>();

foods1.Add("Doro Wat");
foods1.Add("Tibs");

List<string> foods2 = foods1;

foods2.Add("Shiro");

Console.WriteLine("Food lists:");
Console.WriteLine(string.Join(", ", foods1));
Console.WriteLine(string.Join(", ", foods2));

/*------------------------------------------*/
string? restaurant = null;

// 1. Using if (null check)
if (restaurant != null)
{
    Console.WriteLine(restaurant.Length);
}
else
{
    Console.WriteLine("Restaurant is null");
}

// 2. Using ?? (null coalescing)
Console.WriteLine(restaurant?.Length ?? 0);

// 3. Using ?. (null conditional)
Console.WriteLine(restaurant?.Length);

/*------------------------------------------*/

Console.Write("Enter amount in ETB: ");

string? input = Console.ReadLine();

bool isValid = decimal(input, out decimal amount);

if (!isValid || amount <= 0)
{
    Console.WriteLine("Invalid amount. Please enter a positive number.");
}
else
{
    Console.WriteLine($"Amount: {amount:N2} ETB");
}