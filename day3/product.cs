class Program
{
    static void Main()
    {
        Console.Write("enter product ID: ");
        string productID = Console.ReadLine();
        Console.WriteLine(" enter product name: ");
        string pname = Console.ReadLine();
        Console.WriteLine("enter unit Price: ");
        decimal unitPrice = decimal.Parse(Console.ReadLine());
        Console.WriteLine(" enter quantity: ");
        int quantity = int.Parse(Console.ReadLine());
        decimal totalAmount = unitPrice * quantity;
        Console.WriteLine($"Total amount before discount: {totalAmount:C}");
        if (totalAmount > 5000)
        {
            totalAmount *= 0.80m;
        }
        else if (totalAmount > 3000)
        {
            totalAmount *= 0.85m;

        }
        else if (totalAmount > 1000)
        {
            totalAmount *= 0.90m;
        }
        Console.WriteLine($"Product ID: {productID}");
        Console.WriteLine($"ProductName: {pname}");
        Console.WriteLine($"Unit Price: {unitPrice:C}");
        Console.WriteLine($"Quantity: {quantity}");
        Console.WriteLine($"Total Amount after Discount:{totalAmount:C}");
    }
}
