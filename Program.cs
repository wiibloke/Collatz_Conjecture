using System;
using System.Diagnostics;

namespace Collatz
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNum = 1;
            int maxNum = 100000000;

            Conjecture conj = new Conjecture();

            Stopwatch watch = new Stopwatch();
            watch.Start();
            ConjectureResults results = conj.Calculate(minNum, maxNum);
            watch.Stop();

            Console.WriteLine("Execution time {0}", watch.ElapsedMilliseconds);
            Console.WriteLine("The longest chain was {0} cycles for the number {1}", results.ChainLength, results.ChainNumber);
        }
    }
}
