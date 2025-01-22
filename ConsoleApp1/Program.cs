using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("First number:");
        string input1 = Console.ReadLine();
        Console.WriteLine("Second number:");
        string input2 = Console.ReadLine();
        if (int.TryParse(input1, out int number1) && int.TryParse(input2, out int number2))
        {
            int sum = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {sum}.");
        }
        else
        {
            Console.WriteLine("Error.");
        }
    }
}