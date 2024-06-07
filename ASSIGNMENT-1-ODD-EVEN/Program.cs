using System;
namespace ASSIGNMENT_1_ODD_EVEN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to ODD-EVEN Game!!");
                Console.WriteLine("Which numbers do you want to print?\n1) Even\n2) Odd");
                string option = Console.ReadLine();
                Console.WriteLine("Please enter the range :)");
                int range=Convert.ToInt32(Console.ReadLine());
                if (option.ToLower() == "even")
                {
                    Console.WriteLine($"Even number till the range {range} :");
                    for(int i = 0; i <= range; i+=2)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    Console.WriteLine($"Odd number till the range {range} :");
                    for (int i = 1; i <= range; i += 2)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("Do you want to continue the game?(y/n)");
                if(Console.ReadLine().ToLower() == "n")
                {
                    break;
                }
            }

        }
    }
}
