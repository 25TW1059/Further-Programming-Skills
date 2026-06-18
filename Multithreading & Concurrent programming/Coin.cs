using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading___Concurrent_programming
{
    internal class Coin
    {
        public double x;
        public double y;

        public Coin(Random rng)
        {
            // Random value between -1 and 1
            x = (rng.NextDouble() * 2) - 1;
            y = (rng.NextDouble() * 2) - 1;
        }
    }
}
