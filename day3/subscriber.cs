using System;

class Subscriber
{
    public int SubscriberId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime RegistrationDate { get; set; }
    public decimal CourseFee { get; set; }
    public void CalculateFinalFee()
    {
        const decimal originalFee = 25000m;
        DateTime lastDiscountDate1 = new DateTime(2024, 6, 10);
        DateTime lastDiscountDate2 = new DateTime(2024, 6, 15);
        DateTime lastRegistrationDate = new DateTime(2024, 6, 20);
        if (RegistrationDate <=lastDiscountDate1 )
        {
            CourseFee = originalFee * 0.90m;
        }
        else if (RegistrationDate <= lastDiscountDate2)
        {
            CourseFee = originalFee * 0.85m;
        }
        else if (RegistrationDate  > lastRegistrationDate)
        {
            CourseFee = originalFee * 1.05m;
        }
        else
        {
            CourseFee = originalFee;
        }
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Subscriber Details: ");
        Console.WriteLine($"ID: {SubscriberId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Registration Date: {RegistrationDate.ToString()}");
        Console.WriteLine($"Final Course Fee: {CourseFee: C}");
    }
}

class Program
{
    static void Main()
    {
        Subscriber subscriber = new Subscriber();
        Console.WriteLine(" enter subscriber Id");
        subscriber.SubscriberId = int.Parse(Console.ReadLine());
        Console.WriteLine("enter name: ");
        subscriber.Name = Console.ReadLine();
        Console.WriteLine("enter email: ");
        subscriber.Email = Console.ReadLine();
        Console.WriteLine("enter registration date (yyy-mm-dd): ");
        subscriber.RegistrationDate = DateTime.Parse(Console.ReadLine());
        subscriber.CalculateFinalFee();
        subscriber.DisplayDetails();
    }
}