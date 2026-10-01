//using System;
//using System.Collections.Generic;
//using System.Text;
////using do while loop
//namespace WhileLoop
//{
//    internal class DO_WhileLoop
//    {
//            static void Main()
//            {
//                int n1, n2, r, choice;

//                do
//                {
//                    Console.WriteLine("1. Sum");
//                    Console.WriteLine("2. Product");
//                    Console.WriteLine("3. Division");
//                    Console.WriteLine("4. Modulus");
//                    Console.WriteLine("5. Exit");
//                    Console.Write("Enter your choice: ");
//                    choice = Convert.ToInt32(Console.ReadLine());

//                    if (choice >= 1 && choice <= 4)
//                    {
//                        Console.Write("Enter n1: ");
//                        n1 = Convert.ToInt32(Console.ReadLine());

//                        Console.Write("Enter n2: ");
//                        n2 = Convert.ToInt32(Console.ReadLine());

//                        if (choice == 1)
//                        {
//                            r = n1 + n2;
//                            Console.WriteLine($"The sum of {n1} and {n2} is: {r}");
//                        }
//                        else if (choice == 2)
//                        {
//                            r = n1 * n2;
//                            Console.WriteLine($"The product of {n1} and {n2} is: {r}");
//                        }
//                        else if (choice == 3)
//                        {
//                            if (n2 != 0)
//                            {
//                                Console.WriteLine($"The division of {n1} by {n2} is: {(double)n1 / n2}");
//                            }
//                            else
//                            {
//                                Console.WriteLine("Error: Division by zero is not allowed.");
//                            }
//                        }
//                        else if (choice == 4)
//                        {
//                            if (n2 != 0)
//                            {
//                                r = n1 % n2;
//                                Console.WriteLine($"The modulus of {n1} % {n2} is: {r}");
//                            }
//                            else
//                            {
//                                Console.WriteLine("Error: Modulus by zero is not allowed.");
//                            }
//                        }
//                    }
//                    else if (choice == 5)
//                    {
//                        Console.WriteLine("Exiting program...");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Invalid choice. Please try again.");
//                    }

//                } while (choice != 5);
//            }
//        }
//    }

