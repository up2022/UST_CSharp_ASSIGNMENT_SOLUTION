namespace ASSIGNMENT_4_PALINDROME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a string!!");
                string _string = Console.ReadLine();
                int flag = 1;
                for (int i = 0; i < (_string.Length / 2); i++)
                {
                    if (_string[i] != _string[_string.Length - 1 - i])
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                {
                    Console.WriteLine($"{_string} is a Palindrome:)");
                }
                else
                {
                    Console.WriteLine($"{_string} is not a Palindrome:)");
                }
                Console.WriteLine("Do you want to check another string?(y/n)");
                if(Console.ReadLine().ToLower() == "n")
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
