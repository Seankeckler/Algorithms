using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            do
            {
                Console.Clear();
                bool foundNum = false;

                GuessingGameApp ga = new GuessingGameApp();
                Console.WriteLine("Which program do you want to run?");
                Console.WriteLine("\t1) BruteForce Program\n\t2) Binary Search Program\n\t3) Guess on Guess Crime Program");
                int choice;
                while (!(int.TryParse(Console.ReadLine(), out choice)))
                {
                    Console.WriteLine("Quantity can only be a whole number. \nTry Again ");
                }

                if (choice == 1)
                {
                    Console.WriteLine("Press Any Key To Begin BruteForce Program");
                    Console.ReadKey();
                    Guesser brute = new BruteForce();
                    Console.WriteLine();
                    while (foundNum == false)
                    {
                        int guess = brute.Guess();
                        foundNum = ga.GuessAnswer(guess);
                    }

                    brute.PrintGuesses();
                }
                else if (choice == 2)
                {
                    BinarySearch binary = new BinarySearch();
                    int[] nums = new int[100];
                    Console.WriteLine("Press Any Key To Begin Binary Search");
                    Console.ReadKey();
                    Console.WriteLine();
                    //Console.WriteLine(ga.GetNum);
                    while (foundNum == false)

                    {

                        int guess = binary.Guess(nums, ga.GetNum, 0, nums.Length - 1);

                        foundNum = ga.GuessAnswer(guess);
                    }

                    binary.PrintGuesses();
                }
                else if (choice == 3)
                {
                    Guesser r = new Rando();


                    Console.WriteLine("Press Any Button To Begin The Random Search");
                    Console.ReadKey();
                    while (foundNum == false)
                    {

                        r.guessCount++;
                        int guess = r.Guess();

                        foundNum = ga.GuessAnswer(guess);
                    }
                    r.guessCount = r.guessCount - 100;

                    r.PrintGuesses();

                }
                else
                {
                    Console.WriteLine("I dont think that was a choice...");
                }
            } while (Continue() == true);

        }

        
        
            public static bool Continue()
            {
                bool run;
                Console.WriteLine("Do you want to run again? y/n");
                string answer = Console.ReadLine();
                answer = answer.ToLower();

                if (answer == "y")
                {
                    run = true;
                }
                else if (answer == "n")
                {
                    run = false;
                }
                else
                {
                    Console.WriteLine("Sorry that is not an acceptable answer.");
                    run = Continue();
                }
                return run;

            }

        
    }
}
