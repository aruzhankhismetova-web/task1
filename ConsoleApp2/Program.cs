using System;

class Program
{
    static void Main()
    {
        Console.Write("Coffee Name: ");
        string coffeeName = Console.ReadLine();
        Console.Write("Price per Cup: ");
        double pricePerCup = Convert.ToDouble(Console.ReadLine());
        Console.Write("Number of Cups: ");
        int numberOfCups = int.Parse(Console.ReadLine());
        Console.Write("Sugar Portions: ");
        int sugarPortions = int.Parse(Console.ReadLine());
        Console.Write("Extra Topping Price: ");
        double extraToppingPrice = Convert.ToDouble(Console.ReadLine());
        Console.Write("First Letter of Size: ");
        char sizeLetter = char.Parse(Console.ReadLine());
        Console.Write("Is Takeaway (true/false): ");
        bool isTakeaway = bool.Parse(Console.ReadLine());

        double coffeeCost = pricePerCup * numberOfCups;
        double sugarCost = sugarPortions * 0.2;
        double totalOrderPrice = coffeeCost + sugarCost;
        totalOrderPrice += extraToppingPrice;

        Console.WriteLine("\n--- Order Summary ---");
        Console.WriteLine($"Coffee: {coffeeName}");
        Console.WriteLine($"Price per Cup: {pricePerCup}");
        Console.WriteLine($"Cups: {numberOfCups}");
        Console.WriteLine($"Sugar Portions: {sugarPortions}");
        Console.WriteLine($"Extra Topping: {extraToppingPrice}");
        Console.WriteLine($"Size: {sizeLetter}");
        Console.WriteLine($"Takeaway: {isTakeaway}");
        Console.WriteLine($"Coffee Cost: {coffeeCost}");
        Console.WriteLine($"Sugar Cost: {sugarCost}");
        Console.WriteLine($"Total Price: {totalOrderPrice}");
    }
}

