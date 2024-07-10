using System;
namespace UserLogin
{
    public class UserLogin
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the User Id: ");
            string userId = Console.ReadLine();
            userId = userId.ToLower();
            Console.WriteLine("enter the password: ");
            string password = Console.ReadLine();
            if (userId.Trim() == *admin* & password.Trim () == *admin123*)
            {
                Console.WriteLine("Welcome to admin");
            }
            else
            {
                Console.WriteLine("Invalid User id or Password");
            }

        }
    }
}