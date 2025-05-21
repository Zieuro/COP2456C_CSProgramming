using System;

class Program
{
    static void Main(string[] args)
    {
        // Intro statement
        Console.WriteLine("Welcome to the Event Ticket Sales Calculator!");
        Console.WriteLine("This program calculates the total sales based on the ticket type and quantity. \n");

        // Variable declarations
        string ticketType;
        int ticketCount;
        int ticketPrice = 0;

        // Ask for input
        Console.Write("Enter the type of ticket (Orchestra, Floor, tier 1, tier 2, tier 3): ");
        ticketType = Console.ReadLine().ToLower();

        Console.Write("Enter the number of tickets sold: ");
        ticketCount = int.Parse(Console.ReadLine());

        // Determine ticket price based on type
        switch (ticketType)
        {
            case "orchestra":
                ticketPrice = 100;
                break;
            case "floor":
                ticketPrice = 75;
                break;
            case "tier 1":
                ticketPrice = 50;
                break;
            case "tier 2":
                ticketPrice = 40;
                break;
            case "tier 3":
                ticketPrice = 35;
                break;
            default:
                Console.WriteLine("Invalid ticket type entered.");
                return;
        }

        // Calculate total cost
        int totalCost = ticketPrice * ticketCount;

        // Display output like the table
        Console.WriteLine("\nTicket Type\tTicket Price\tTickets Sold\tTotal Cost");
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine($"{ticketType.ToUpper()}\t\t${ticketPrice}\t\t{ticketCount}\t\t${totalCost}");
        Console.WriteLine("-------------------------------------------------------------");

    }
}