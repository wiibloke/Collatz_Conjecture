using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Collatz
{
    public class Conjecture
    {
        public Conjecture()
        {

        }

        public ConjectureResults Calculate(int Start, int End)
        {
            Start = Start > 0 ? Start : throw new ArgumentException("Parameter Start must be 1 or higher");
            End = (End > Start && End < 100000001) ? End : throw new ArgumentException("Parameter end must be higher than Start and less than 100000000");
            ulong longEnd = (ulong)End;
            int longest = 0;
            uint longestChain = 0;
            //int[] used = new int[End - Start + 2];

            Parallel.For(Start, End, number =>
            {
                uint counter = 0;

                //if (used[number] == 0)
                //{
                    ulong workingN = (ulong)number;
                    while (workingN != 1)
                    {
                        if (workingN % 2 != 0)
                        {
                            workingN = workingN * 3 + 1;
                            //if (workingN < longEnd)
                            //{
                            //    used[workingN] = (int)workingN;
                            //}
                        }
                        else
                        {
                            workingN = workingN / 2;
                        }

                        counter += 1;
                    }
               // }

                if (counter > longestChain)
                {
                    longestChain = counter;
                    longest = number;

                }
            });

            ConjectureResults results = new ConjectureResults()
            {
                ChainNumber = longest,
                ChainLength = (int)longestChain
            };


            return results;
        }
    }
}