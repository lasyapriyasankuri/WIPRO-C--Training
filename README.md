using System;

class Program
{
    static void Main()
    {
        const double PizzaPrice = 300;
        const double PuffsPrice = 50;
        const double PepsiPrice = 130;

        Console.WriteLine("Enter number of pizzas:");
        int numPizzas = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number of puffs:");
        int numPuffs = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number of pepsis:");
        int numPepsis = int.Parse(Console.ReadLine());

        double totalPizzaCost = numPizzas * PizzaPrice;
        double totalPuffsCost = numPuffs * PuffsPrice;
        double totalPepsiCost = numPepsis * PepsiPrice;

        double subtotal = totalPizzaCost + totalPuffsCost + totalPepsiCost;

        double gst = 0.09 * subtotal;
        double cess = 0.09 * subtotal;

        double grandTotal = subtotal + gst + cess;

        Console.WriteLine("\nBill Details:");
        Console.WriteLine("Total Cost of Pizzas: Rs." + totalPizzaCost);
        Console.WriteLine("Total Cost of Puffs: Rs." + totalPuffsCost);
        Console.WriteLine("Total Cost of Pepsis: Rs." + totalPepsiCost);
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Subtotal: Rs." + subtotal);
        Console.WriteLine("GST (9%): Rs." + gst);
        Console.WriteLine("CESS (9%): Rs." + cess);
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Grand Total: Rs." + grandTotal);
        Console.ReadLine();
    }
