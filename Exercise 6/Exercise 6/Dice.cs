using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Dice
    {
        private Random random;
        private int sidesCount;

        public Dice(int aSidesCount)
        {
            sidesCount = aSidesCount;
            random = new Random();
        }

        public int GetSidesCount()
        {
            return sidesCount;
        }
        public int Roll()
        {
            return random.Next(1, sidesCount + 1);
        }
    }
}
