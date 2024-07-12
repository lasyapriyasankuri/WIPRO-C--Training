using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to find its factorial: ");
        int number = int.Parse(Console.ReadLine());
        long factorial = FindFactorial(number);
        Console.WriteLine($"The factorial of {number} is {factorial}");

        Console.WriteLine("\nEnter a string: ");
        string inputString = Console.ReadLine();
        PrintWordsInNewLines(inputString);

        Console.WriteLine("\n Enter a 5-digit number to find the sum of alternate digits: ");
        int fiveDigitNumber = int.Parse(Console.ReadLine());
        int sumOfAlternateDigits = SumOfAlternateDigits(fiveDigitNumber);
        Console.WriteLine($"The sum of alternate digits of {fiveDigitNumber} is {sumOfAlternateDigits}");

        Console.WriteLine("\nEnter two numbers to find their GCD: ");
        Console.WriteLine("First number: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Second number: ");
        int b = int.Parse(Console.ReadLine());
        int gcd = FindGCD(a, b);
        Console.WriteLine($"The GCD of {a} and {b} is {gcd}");
    }
    static long FindFactorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Factorial is not defined for negative numbers");
        }
        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
        static void PrintWordsInNewLines(string input)
        {
            string[] words = input.Split(' ');
            foreach (string word in words)
            {
            Console.WriteLine(word);
            }
        }
        static int  SumOfAlternateDigits(int number)
        {
            int sum = 0;
            string numberString = number.ToString();
        for (int i = 0; i < numberString.Length; i += 2) 
            {
            sum += numberString[i] - '0';
            }
            return sum;
        }
        static int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;

            }
            return a;
        }
    
}