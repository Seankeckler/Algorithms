using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_3
{
    class Rando : Guesser
    {
        Random r = new Random();
        public int num  { get; set; }

        public override int Guess()
        {
            num = r.Next(1, 101);
            return num;
        }
    }
}
