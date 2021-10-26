using System;

namespace SelectionStatementExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("Can you guess my favorite number?");
            Console.WriteLine("What is the upper limit for the range of the number?");

            var userResponse = Console.ReadLine();
            var upperLimit = int.Parse(userResponse);

            var random = new Random();
            var number = random.Next(1, upperLimit);


            Console.WriteLine("Input your guess:");
            var guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Your guess was too high! Sorry");
            }
            else if (guess < number)
            {
                Console.WriteLine("Your guess was too low! Sorry");
            }
            else 
            { Console.WriteLine("Correct!"); }

            Console.ReadKey();
            
            
            Console.Clear();



            //Exercise 2

            Console.WriteLine("What is your favorite Subject in School");

            var subject = Console.ReadLine(); //evaluate to a string

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math is hard.");
                    break;
                case "Science":
                    Console.WriteLine("Science is cool.");
                    break;
                case "English":
                    Console.WriteLine("English is weird.");
                    break;
                default:
                    Console.WriteLine("I havent taken that before. {Subject} sounds fun!");
                    break;
            }
        }
    }
}
