using System;
class Program
{
    static void Main()
    {
        int intMaxValue1 = int.MaxValue;
        int intMaxValue2 = int.MaxValue;
        try
        {
            int result = checked(intMaxValue1 + intMaxValue2);
            Console.WriteLine("Sum of two max integers: " + result);
        }

        catch(OverflowException)
        {
            Console.WriteLine("Overflow occured ! Handling it with appropriate data type.");
            long safeResult = (long)intMaxValue1 + intMaxValue2;
            Console.WriteLine("Safe sum of two max integers: " + safeResult);
        }
    }
}