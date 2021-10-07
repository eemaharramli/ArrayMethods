using System;
using System.Linq;
using System.Text;

namespace ArrayMethods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ChangeConsoleColor();
            Console.Write("Please enter the array size: ");
            int size = int.Parse(Console.ReadLine());
            string[] input = new string[size];

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"Please enter the string number {i + 1}: ");
                input[i] = Console.ReadLine();
            }

            Console.Write("Please enter the separator: ");
            string separator = Console.ReadLine();
            Console.Write(CustomJoin(input, separator));
        }

        static void ChangeConsoleColor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        
        static string CustomJoin(string[] input, string separator)
        {
            StringBuilder result = new StringBuilder();
            
            for (int i = 0; i < input.Length; i++)
            {
                result.Append(input[i]);
                if (i == input.Length - 1)
                {
                    break;
                }
                result.Append(separator);
            }
            
            return result.ToString().TrimEnd();
        }
    }
}