using System;
using System.Diagnostics;

namespace CSharp
{
    class Program
    {
        public static long n = 10000000;
        public static Stopwatch watch = new Stopwatch();
        static void Main(string[] args)
        {
            long calculateResult = CalculateSum(n);
            var calcExecutionTime = watch.ElapsedMilliseconds;

            long loopResult = LoopForSum(n);
            var loopExecutionTime = watch.ElapsedMilliseconds;

            Console.WriteLine($"Calculation: {calculateResult} taking {calcExecutionTime} milliseonds.");
            Console.WriteLine($"Loop: {loopResult} taking {loopExecutionTime} milliseconds.");
        }
        
        // O(1)
        public static long CalculateSum(long n)
        {
            watch.Start();
            long calcSum = (n * (n + 1)) / 2;

            watch.Stop();
            return calcSum;
        }

        // O(n)
        public static long LoopForSum(long n)
        {
            watch.Restart();
            long totalSum = 0;
            for(long i = 1; i < n + 1; i++)
            {
                totalSum += i;
            }

            watch.Stop();
            return totalSum;
        }
    }
}
