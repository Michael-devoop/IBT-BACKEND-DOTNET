
decimal DeliveryFee(string area, bool isVip = false)
{
    if (isVip)
    {
        return 0m;
    }

    return area switch
    {
        "Bole" => 60m,
        "Piassa" => 80m,
        "Megenagna" => 50m,
        "Kazanchis" => 40m,
        _ => 100m
    };
}

// 1. Positional argument
decimal fee1 = DeliveryFee("Bole");

// 2. Named argument
decimal fee2 = DeliveryFee("Piassa", isVip: true);

// 3. Using the default value (isVip = false)
decimal fee3 = DeliveryFee("Megenagna");

Console.WriteLine($"Bole delivery fee: {fee1} ETB");
Console.WriteLine($"Piassa VIP delivery fee: {fee2} ETB");
Console.WriteLine($"Megenagna delivery fee: {fee3} ETB");