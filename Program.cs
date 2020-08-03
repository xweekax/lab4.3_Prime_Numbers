using System;

namespace lab4._3_Prime_Numbers
{
    public class Program
    {

        static void Main(string[] args)
        {
            int number1 = 1;
            int count = 0;
            string keepGoing = "y";

            while (keepGoing == "y")
            {
                Console.WriteLine("Which Prime number are you looking for?: ");
                int primeChoice = int.Parse(Console.ReadLine());

                while (true)
                {
                    number1++;
                    if (PrimeNumbers.getPrime(number1))
                    {
                        count++;
                    }
                    if (count == primeChoice)
                    {
                        Console.WriteLine($"The {primeChoice}(st/th) prime number is {number1}");
                        break;
                    }
                }
                Console.WriteLine("Would you like to go again? (y/n): ");
                keepGoing = Console.ReadLine().ToLower();
                if (keepGoing =="n")
                {
                    Console.WriteLine("Thanks for playing - Bye!");
                }
                else
                {
                    keepGoing = "y";
                }
            }
        }
    }
}
