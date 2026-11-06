Console.WriteLine("-------Choose a Mobile network provider------");
Console.WriteLine("1. Ethiotelecom");
Console.WriteLine("2. Safaricom");


int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("------You have selected Ethiotelecom.------");
        Console.WriteLine("Please enter your phone number:");
        break;
    case 2:
        Console.WriteLine("------You have selected Safaricom.------");
        Console.WriteLine("Please enter your phone number:");
        break;
    default:
        Console.WriteLine("Invalid choice. Please select a valid option.");
        break;
}

int phoneNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Topup Amount:");
decimal topupAmount = 0;
while (topupAmount <= 0 || topupAmount > 5000)
{
    if (decimal.TryParse(Console.ReadLine(), out topupAmount))
    {
        if (topupAmount <= 0)
        {
            Console.WriteLine("Topup amount must be greater than zero.");
        }
        else if (topupAmount > 5000)
        {
            Console.WriteLine("Topup amount exceeds the maximum limit of 5000.");
        }

    }
    
}

Console.WriteLine($"You have successfully topped up {topupAmount} to the phone number {phoneNumber}. Thank you for using AddisEats!");

