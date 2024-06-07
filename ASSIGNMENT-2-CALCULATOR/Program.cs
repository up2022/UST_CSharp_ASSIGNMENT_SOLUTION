using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace ASSIGNMENT_2_CALCULATOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1,number2;
            Console.WriteLine("Welcome to Calculator world!!");
            Console.WriteLine("You can perform the below oprations :\n1) Addition\n2) Subtraction\n3) Multiplication\n4) Division");
            while (true)
            {
                Console.WriteLine("Please enter your choise (Number) :)");
                string choise=Console.ReadLine();
                Console.WriteLine("Enter two numbers :");
                number1 = Convert.ToInt32(Console.ReadLine());
                number2 = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case "1":
                        Console.WriteLine($"Sum of {number1} and {number2} is {number1 + number2}");
                        break;

                    case "2":
                        Console.WriteLine($"Subtraction of {number1} and {number2} is {number1 - number2}");
                        break;

                    case "3":
                        Console.WriteLine($"Multiplication of {number1} and {number2} is {number1 * number2}");
                        break;

                    case "4":
                        Console.WriteLine($"Devision of {number1} and {number2} is {number1 / number2}");
                        break;
                    default: Console.WriteLine("Invalid input :(");
                        break;
                }
                Console.WriteLine("Do you want to continue?(y/n) ");
                if(Console.ReadLine().ToLower() == "n")
                {
                    break;
                }
                Console.WriteLine();
            }

        }
    }
}
