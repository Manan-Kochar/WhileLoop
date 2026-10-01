using System;
using System.Collections.Generic;
using System.Text;
// finding prime numbers from 1 to 100 using break statement
namespace WhileLoop
{
    internal class Break_Statements
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Prime numbers between 1 and 100 are:");
            for (int i = 2; i <= 100; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break; 
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
