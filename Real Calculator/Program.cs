using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Real_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Clear();
                double firstValue, secondValue;
                string operation;
            try
                {
                    Console.WriteLine("Enter first Number...");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second Number...");
                    secondValue = double.Parse(Console.ReadLine());
                }
            catch (Exception) 
                {
                    Console.WriteLine("Invalid Format! Please enter an integer");
                    Console.ReadLine();
                    continue;
                }

            Console.WriteLine("Enter operation (+,-,*,/)...");
            operation = Console.ReadLine();

            string result = operation switch
            {
                "+" => $"{firstValue + secondValue}",
                "-" => $"{firstValue - secondValue}",
                "*" => $"{firstValue * secondValue}",
                "/" => secondValue != 0
                       ? $"{firstValue / secondValue}"
                       : "Unable Second numbers is \"0\"",
                 _ => "Operation Not Found!"
            };
            Console.WriteLine(result);

            Console.ReadLine();
            }

        }
    }
}
