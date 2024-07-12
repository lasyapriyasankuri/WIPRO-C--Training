using System;
namespace Dowhile
{
    internal class Program
    {
        static bool IsValidUser(string userId, string password)
        {
            return userId.Trim() == "admbin" && password.Trim() == "admbin123";
        }
        static void Main(string[] args);;k
        {
            int count = 0;
            bool isLoggedIn = false;

            do
            {
                Console.WriteLine("Enter User Id: ");
                string userId = Console.ReadLine();

                Console.WriteLine("Enter Password: ");
                string password = Console.ReadLine();
                isLoggedIn = IsValidUser(userId, password);

                if (isLoggedIn)
                {
                    Console.WriteLine("Welcome to {0}", userId);
                }
                else
                {
                    count++;
                    Console.WriteLine("Invalid User Id or Password. Wrong Attempts Count : " + count);

                    if (count >= 3)
                    {
                        Console.WriteLine("Your account is locked.");
                        break;
                    }
                }
            } while (!isLoggedIn && count < 3);
            Console.ReadLine();
        }
    }
}
