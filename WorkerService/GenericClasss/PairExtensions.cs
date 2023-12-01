using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService.GenericClasss
{
    public static class PairExtensions
    {
        public static void DisplayPair<T1, T2>(this Pair<T1, T2> pair)
        {
            Console.WriteLine($"({pair.First}, {pair.Second})");
        }

        public static Pair<T2, T1> Swap<T1, T2>(this Pair<T1, T2> pair)
        {
            return new Pair<T2, T1>(pair.Second, pair.First);
        }

        public static Pair<T1, T2> Swap<T1, T2>(this Pair<T2, T1> pair)
        {
            return new Pair<T1, T2>(pair.Second, pair.First);
        }

    }
}
