using System;
using DLLSharedCalculator;

namespace SharedCalculatorMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");

            Calculation calculator = new Calculation();

            Console.WriteLine("Addition\n" + "Expected 4");
            Console.WriteLine(calculator.Addition(2,2));

            Console.WriteLine("\n" + "Substraction\n" + "Expected 1");
            Console.WriteLine(calculator.Substraction(4,3));

            Console.WriteLine("\n" + "Multiply\n" + "Expected 10");
            Console.WriteLine(calculator.Multiply(5,2));

            Console.WriteLine("\n" + "Divide\n" + "Expected 4");
            Console.WriteLine(calculator.Divide(8,2));

        }
    }
}
