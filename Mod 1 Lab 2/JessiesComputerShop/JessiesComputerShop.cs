using System;

class JessiesComputerShop
{
    static void Main(string[] args)
    {
        // Intro statement
        Console.WriteLine("Welcome to Jessie's Computer Shop Profit Calculator!");
        Console.WriteLine("This program helps determine how much each computer should be sold for to achieve a 20% net profit. \n");

        // Variable declartions
        double merchandiseCost, salaryCost, rentCost, electricityMothlyCost;
        const int computersPerYear = 5200;
        const double desiredProfitMargin = 0.20;

        // Get user input
        Console.Write("Enter the total yearly cost of merchandies: $");
        merchandiseCost = double.Parse(Console.ReadLine());

        Console.Write("Enter the total yearly salary for employees: $");
        salaryCost = double.Parse(Console.ReadLine());

        Console.Write("Enter the total yearly rent for the store: $");
        rentCost = double.Parse(Console.ReadLine());

        Console.Write("Enter the estimated monthly electricity cost: $");
        electricityMothlyCost = double.Parse(Console.ReadLine());

        // Calculate total yearly expenses
        double totalExpenses = merchandiseCost + salaryCost + rentCost + (electricityMothlyCost * 12);

        // Calculate revenue needed to achieve 20% profit
        double targetRevenue = totalExpenses * (1 + desiredProfitMargin);

        // Calculate markup price per computer
        double pricePerComputer = targetRevenue / computersPerYear;

        // Output
        Console.WriteLine("\nTo achieve a 20% net profit, each computer should be sold for: ${0:F2}", pricePerComputer);
    }
}