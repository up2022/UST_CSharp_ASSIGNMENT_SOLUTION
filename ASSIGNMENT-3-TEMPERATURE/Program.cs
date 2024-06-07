namespace ASSIGNMENT_3_TEMPERATURE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the current temperature: ");
                if (double.TryParse(Console.ReadLine(), out double temperature))
                {
                    Console.WriteLine("Select a choice for conversion:");
                    Console.WriteLine("1. Convert to Celsius");
                    Console.WriteLine("2. Convert to Fahrenheit");
                    Console.Write("Enter your choice (1 or 2): ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            double fahrenheitToCelsius = (temperature - 32) * 5 / 9;
                            Console.WriteLine($"The temperature in Celsius is: {fahrenheitToCelsius:F2}");
                            break;
                        case "2":
                            double celsiusToFahrenheit = (temperature * 9 / 5) + 32;
                            Console.WriteLine($"The temperature in Fahrenheit is: {celsiusToFahrenheit:F2}");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select either 1 or 2.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value for the temperature.");
                }

                Console.WriteLine("Do you want to perform another conversion? (y/n): ");
                if (Console.ReadLine().ToLower() == "n")
                {
                    break;
                }
            }
            Console.WriteLine("Thank you for using the temperature converter. Goodbye!");
        }
    }
}
