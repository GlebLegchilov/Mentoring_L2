using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.Task1.ByThread
{
    public class Program
    {
        private const string InfoString = "Thread #{0} – Iteration #{1}";
        private const int ArraySize = 100;
        private const int IterationStartNumber = 1;
        private const int IterationEndNumber = 1000;

        // 24 seconds
        public static void Main(string[] args)
        {
            var threadArray = new Thread[ArraySize];
            for (var i = 0; i < threadArray.Length; i++)
            {

                threadArray[i] = new Thread(new ThreadStart(IterateThroughArray));
                threadArray[i].Start();
            }


            Console.ReadLine();
        }

        private static void IterateThroughArray()
        {
            for (var i = IterationStartNumber; i <= IterationEndNumber; i++)
            {
                Console.WriteLine(InfoString, Thread.CurrentThread.ManagedThreadId, i);
            }
        }
    }
}
