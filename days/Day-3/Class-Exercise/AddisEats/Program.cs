// LINQ Queries

1.WHERE Clause

var foodItems = myMenuItems.Where(i => i.Category == "Food");

foreach (var item in foodItems)
{
    Console.WriteLine($"Food Item Name: {item.Name}");
}

2.SELECT Clause
var prices = myMenuItems.Select(i => i.Price).ToList();

foreach (var price in prices)
{
    Console.WriteLine($"Price: {price:C}");
}

// 3. ANY Clause
bool hasExpensiveItems = myMenuItems.Any(i => i.Price > 10.0m);
Console.WriteLine($"Has expensive items: {hasExpensiveItems}");

// 4. ALL Clause
bool allItemsAreExpensive = myMenuItems.All(i => i.Price > 10.0m);
Console.WriteLine($"All items are expensive: {allItemsAreExpensive}");

5.FIRST and FIRSTORDEFAULT Clause 

var d = myMenuItems.FirstOrDefault(i => i.Price > 20.0m);
        ??
        throw new InvalidOperationException("No item found with price greater than 10.0");

if (d != null)
{
    Console.WriteLine($"First item with price greater than 20.0: {d.Name}");
}
else
{
    Console.WriteLine("No item found with price greater than 20.0");
}


// 6. ORDERBY and ORDERBYDESCENDING Clause
var orderedByPrice = myMenuItems.OrderBy(i => i.Price).ToList();

foreach (var item in orderedByPrice)
{
    Console.WriteLine($"Ordered by Price: {item.Name} - {item.Price:C}");
}

Console.WriteLine("--------------------------------------------------");

var orderedByDesPrice = myMenuItems.OrderByDescending(i => i.Price).ToList();

foreach (var item in orderedByDesPrice)
{
    Console.WriteLine($"Ordered by Price: {item.Name} - {item.Price:C}");
}

//7.SKIP and TAKE

var theLast4Items = myMenuItems.Skip(3).Take(4).ToList();
Console.WriteLine(theLast4Items.Count);

8.SUM and AVERAGE Clause
var sumOfPrices = myMenuItems.Sum(i => i.Price);
var averageOfPrices = myMenuItems.Average(i => i.Price);

Console.WriteLine($"Sum of Prices: {sumOfPrices:C}, Average of Prices: {averageOfPrices:C}");
