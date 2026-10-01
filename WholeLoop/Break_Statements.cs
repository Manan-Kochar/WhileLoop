using System;
using System.Collections.Generic;
using System.Text;
// finding prime numbers using break statement
namespace WhileLoop
{
    internal class Break_Statements
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;  
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }
    }
}
