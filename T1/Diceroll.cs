using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Diceroll
    {
        private Random rand = new Random();

        public int Heitto()
        {
            // 0-5 +1 muuttuu -> 1-6
            return rand.Next(6) + 1;
        }
    }
}
