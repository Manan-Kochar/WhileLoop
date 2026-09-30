using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
//writing numbers to words using while loop
namespace WholeLoop
{
    internal class WhileLoop4
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                int digit = num % 10;
                if (digit == 0)
                {
                    Console.WriteLine($" {digit} zero");
                }
                else if (digit == 1)
                {
                    Console.WriteLine($" {digit} one");
                }
                else if (digit == 2)
                {
                    Console.WriteLine($" {digit} two");
                }
                else if (digit == 3)
                {
                    Console.WriteLine($" {digit} three");
                }
                else if (digit == 4)
                {
                    Console.WriteLine($" {digit} four");
                }
                else if (digit == 5)
                {
                    Console.WriteLine($" {digit} five");
                }
                else if (digit == 6)
                {
                    Console.WriteLine($" {digit} six");
                }
                else if (digit == 7)
                {
                    Console.WriteLine($" {digit} seven");
                }
                else if (digit == 8)
                {
                    Console.WriteLine($" {digit} eight");
                }
                else if (digit == 9)
                {
                    Console.WriteLine($" {digit} nine");
                }
                
            num /= 10;
            }
        }
    }
}
