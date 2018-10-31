using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_3
{
    public abstract class Guesser
    {
        public int guessCount = 100;
        public int GuessCount { get { return guessCount; } }
        protected string name = "Billy";
        

        public abstract int Guess();

        public void PrintGuesses()
        {
            Console.WriteLine(name + " guessed " + guessCount + " time(s)");
            if (guessCount < 5)
            {
                Console.WriteLine("Wow you're a genius");
            }
            else if (guessCount < 10)
            {
                Console.WriteLine("Pretty solid!");
            }
            else if (guessCount < 20)
            {
                Console.WriteLine("Better luck next time, ya dangus");
            }
            else
            {
                Console.WriteLine("I stopped counting and fell asleep...maybe you shouldn't play this game.");
            }
        }

    }
}
