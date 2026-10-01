using System;
using System.Collections.Generic;
using System.Text;

namespace WholeLoop
{
    internal class NumberGuessingGame
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberToGuess = random.Next(1, 101);
            int Guess = 67;
            int attempts = 0;
            Console.WriteLine("Welcome to the Number Guessing Game!");
            while (Guess != numberToGuess)
            {
                Console.Write("Enter your guess: ");
                Guess = Convert.ToInt32(Console.ReadLine());
                attempts++;
                if (Guess < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (Guess > numberToGuess)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You've guessed the number {numberToGuess} in {attempts} attempts.");
                }
            }
        }
    }
}
