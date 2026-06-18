using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading___Concurrent_programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * This program uses a Monte Carlo simulation to approximate the
             * value of pi, with both a single and multi-threaded solution.
             * Both solutions run the same number of trials, and can both
             * calculate the value of pi to an accuracy of roughly 0.005%,
             * given more than 1,000,000 trials. When running 1,000,000,000
             * trials, the single threaded solution takes 30 seconds to execute,
             * and the multi-threaded solution takes 5.
            */

            // https://en.wikipedia.org/wiki/Approximations_of_pi#Summing_a_circle's_area

            DateTime t1 = DateTime.Now;
            double pi_single = CalculatePiSingleThreaded(1_000);
            DateTime t2 = DateTime.Now;
            double pi_multi = CalculatePiMultiThreaded(1_000);
            DateTime t3 = DateTime.Now;

            Console.WriteLine("Single-threaded stats:\n");
            Console.WriteLine($"Execution time: {Math.Round((t2 - t1).TotalSeconds),2}s");
            Console.WriteLine($"Calculated value: {pi_single}");
            Console.WriteLine($"Error: {Math.Round(Math.Abs((pi_single - Math.PI) / Math.PI) * 100, 5)}%\n\n");

            Console.WriteLine("Multi-threaded stats:\n");
            Console.WriteLine($"Execution time: {Math.Round((t3 - t2).TotalSeconds, 2)}s");
            Console.WriteLine($"Calculated value: {pi_multi}");
            Console.WriteLine($"Error: {Math.Round(Math.Abs((pi_multi - Math.PI) / Math.PI) * 100, 5)}%\n\n");
        }

        static double CalculatePiSingleThreaded(long n)
        {
            /*
             * Imagine a square inscribed outside a unit circle, and then
             * distribute points randomly within that square. The ratio of
             * points that land inside the circle to to points that land
             * outside the circle is approximately equal to pi / 4.
            */

            int coinsInside = 0;
            int coinsThrown = 0;

            for (int i = 0; i < n; i++)
            {
                ResolveCoin(ref coinsInside, ref coinsThrown);
            }

            return 4 * ((double)coinsInside / coinsThrown);
        }

        static double CalculatePiMultiThreaded(long n)
        {
            /*
             * Imagine a square inscribed outside a unit circle, and then
             * distribute points randomly within that square. The ratio of
             * points that land inside the circle to to points that land
             * outside the circle is approximately equal to pi / 4.
            */

            int coinsInside = 0;
            int coinsThrown = 0;

            List<Task> tasks = new List<Task>();

            for (int i = 0; i < n; i++)
            {
                tasks.Add(new Task(() => ResolveCoin(ref coinsInside, ref coinsThrown)));
                tasks[i].Start();
            }

            Task.WaitAll(tasks.ToArray());

            return 4 * ((double)coinsInside / coinsThrown);
        }

        static void ResolveCoin(ref int coinsInside, ref int coinsThrown)
        {
            /*
             * Each coin is assigned a random x and y coordinate between -1
             * and 1, and the distance of that point from the centre is
             * calculated. If that distance is greater than 1, then the point
             * is outside the circle, so only the thrown counter is incremented,
             * otherwise the point is inside the circle, and both counters are incremented.
            */

            Random rng = new Random();

            // Temporary local counter to eliminate race conditions, and
            // reduce the number of atomic operations that need to take place
            int localThrown = 0;
            int localInside = 0;

            for (int i = 0; i < 1_000_000; i++)
            {
                Coin coin = new Coin(rng);

                double x = coin.x;
                double y = coin.y;

                double distance = Math.Sqrt(x * x + y * y);

                if (distance < 1)
                {
                    localInside++;
                }
                localThrown++;
            }

            // Thread-safe method of adding two numbers
            System.Threading.Interlocked.Add(ref coinsInside, localInside);
            System.Threading.Interlocked.Add(ref coinsThrown, localThrown);
        }
    }
}
