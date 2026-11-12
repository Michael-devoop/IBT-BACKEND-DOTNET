using AddisEats.Models;
List<MenuItem> myMenuItems = new List<MenuItem>
{
    new MenuItem(1, "Burger", "Food", 10.5m),
    new MenuItem(2, "Pizza", "Food", 15.0m),
    new MenuItem(3, "Coke", "Drink", 2.5m),
    new MenuItem(4, "Water", "Drink", 1.0m),
    new MenuItem(5, "Salad", "Food", 8.0m),
    new MenuItem(6, "Fries", "Food", 3.5m),
    new MenuItem(7, "Ice Cream", "Dessert", 4.0m)
};
//Console.WriteLine("Welcome to AddisEats Mobile Topup Service!");
//Console.WriteLine("Enter your name:");
//string userName = Console.ReadLine();

//Console.WriteLine("-------Choose a Mobile network provider------");
//Console.WriteLine("1. Ethiotelecom");
//Console.WriteLine("2. Safaricom");


//int choice = int.Parse(Console.ReadLine());
//decimal topupAmount= 0;
//decimal bounusAmount = 0;
//Console.WriteLine("Please enter your phone number:");
//int phoneNumber = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter Topup Amount:");
//while (topupAmount <= 0 || topupAmount > 5000)
//{
//    if (decimal.TryParse(Console.ReadLine(), out topupAmount))
//    {
//        if (topupAmount <= 0)
//        {
//            Console.WriteLine("Topup amount must be greater than zero.");
//        }
//        else if (topupAmount > 5000)
//        {
//            Console.WriteLine("Topup amount exceeds the maximum limit of 5000.");
//        }
//        else if (topupAmount > 1000)
//         {
//          bounusAmount += 20;
//        }
//    }

////}

//switch (choice)
//{
//    case 1:
//        bounusAmount = topupAmount * 5 /100;
//        break;
//    case 2:
//        bounusAmount = topupAmount * 3 /100;
//        break;
//    default:
//        bounusAmount = 0;
//        break;
//}
//Console.Clear();
//Console.WriteLine("\n");
//Console.WriteLine(" ******Thank you for using AddisEats Mobile Topup Service!******");
//Console.WriteLine($"*Name: {userName}");
//Console.WriteLine($"*Topup Amount: {topupAmount:N2} ETB");
//Console.WriteLine($"*Bonus Amount: {bounusAmount:N2} ETB");
//Console.WriteLine($"*Total Amount: {topupAmount + bounusAmount:N2} ETB");
//Console.WriteLine($"*Phone Number: {phoneNumber}");
//Console.WriteLine("****************************************************************");
