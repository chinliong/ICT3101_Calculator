using System;
using ICT3101_Calculator;

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;
        var _calculator = new Calculator();

        Console.WriteLine("Console Calculator in C#");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {
            // 1) First number
            Console.Write("Type a number, and then press Enter: ");
            string numInput1 = Console.ReadLine();
            double cleanNum1;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("This is not valid input. Please enter a numeric value: ");
                numInput1 = Console.ReadLine();
            }

            // 2) Menu
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add (needs two numbers)");
            Console.WriteLine("\ts - Subtract (needs two numbers)");
            Console.WriteLine("\tm - Multiply (needs two numbers)");
            Console.WriteLine("\td - Divide (needs two numbers)");
            Console.WriteLine("\tf - Factorial of the FIRST number only");
            Console.WriteLine("\tt - Area of triangle (height = first, length = second)");
            Console.WriteLine("\tc - Area of circle (radius = first number only)");
            Console.Write("Your option? ");
            string op = (Console.ReadLine() ?? "").Trim().ToLowerInvariant();

            // 3) Ask for second number only if needed
            double cleanNum2 = 0;
            bool needsSecond =
                op == "a" || op == "s" || op == "m" || op == "d" || op == "t";

            if (needsSecond)
            {
                Console.Write("Type another number, and then press Enter: ");
                string numInput2 = Console.ReadLine();
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter a numeric value: ");
                    numInput2 = Console.ReadLine();
                }
            }

            try
            {
                double result = _calculator.DoOperation(cleanNum1, cleanNum2, op);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("This operation is not recognized.\n");
                }
                else
                {
                    Console.WriteLine("Your result: {0:0.##}\n", result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Oh no! An exception occurred trying math.");
                Console.WriteLine($" - Details: {e.Message}\n");
            }

            Console.WriteLine("------------------------\n");
            Console.Write("Press 'q' + Enter to quit, or any other key + Enter to continue: ");
            if ((Console.ReadLine() ?? "") == "q") endApp = true;
            Console.WriteLine();
        }
    }
}
