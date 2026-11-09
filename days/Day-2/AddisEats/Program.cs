Console.WriteLine("-------Choose a Mobile network provider------");
Console.WriteLine("1. Ethiotelecom");
Console.WriteLine("2. Safaricom");


int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("------You have selected Ethiotelecom.------");
        Console.WriteLine("Please enter your phone number:");
        int phoneNumberETH = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Topup Amount:");
        decimal topupAmountETH = 0;
        while (topupAmountETH <= 0 || topupAmountETH > 5000)
        {
            if (decimal.TryParse(Console.ReadLine(), out topupAmountETH))
            {
                if (topupAmountETH <= 0)
                {
                    Console.WriteLine("Topup amount must be greater than zero.");
                }
                else if (topupAmountETH > 5000)
                {
                    Console.WriteLine("Topup amount exceeds the maximum limit of 5000.");
                }

            }

        }
          decimal bounusAmountETH= topupAmountETH * 5/ 100;


        Console.WriteLine($"You have successfully topped up {topupAmountETH+bounusAmountETH} to the phone number {phoneNumberETH}. Thank you for using AddisEats!");


        break;
    case 2:
        Console.WriteLine("------You have selected Safaricom.------");
        Console.WriteLine("Please enter your phone number:");
        int phoneNumberSAF = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Topup Amount:");
        decimal topupAmountSAF = 0;
        while (topupAmountSAF <= 0 || topupAmountSAF > 5000)
        {
            if (decimal.TryParse(Console.ReadLine(), out topupAmountSAF))
            {
                if (topupAmountSAF <= 0)
                {
                    Console.WriteLine("Topup amount must be greater than zero.");
                }
                else if (topupAmountSAF > 5000)
                {
                    Console.WriteLine("Topup amount exceeds the maximum limit of 5000.");
                }

            }

        }
        decimal bounusAmountSAF = topupAmountSAF * 3 / 100;

        Console.WriteLine($"You have successfully topped up {topupAmountSAF+bounusAmountSAF} to the phone number {phoneNumberSAF}. Thank you for using AddisEats!");

        break;
    default:
        Console.WriteLine("Invalid choice. Please select a valid option.");
        break;
}


