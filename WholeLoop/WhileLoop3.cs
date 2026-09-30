//using System;
//using System.Collections.Generic;
//using System.Text;
////Finding armstrong number using while loop
//namespace WholeLoop
//{
//    internal class WhileLoop3
//    {
//        static void Main(string[] args)
//        {
//            int num, originalNum, sumofcubes = 0;
//            Console.WriteLine("Enter a number: ");
//            num = Convert.ToInt32(Console.ReadLine());
//            originalNum = num;
//            while (num > 0)
//            {
//                int digit = num % 10;
//                sumofcubes += digit * digit * digit;
//                num /= 10;
//            }
//            if (sumofcubes == originalNum)
//            {
//                Console.WriteLine(originalNum + " is an Armstrong number.");
//            }
//            else
//            {
//                Console.WriteLine(originalNum + " is not an Armstrong number.");
//            }
//        }
//    }
//}
