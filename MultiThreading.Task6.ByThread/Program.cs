using System;
using System.Threading;

namespace MultiThreading.Task6.ByThread
{
    public class Program
    {
        private const int CollectionSize = 10;
        private const string IntputInfoString = "Input phase";
        private const string OutputInfoString = "Output phase";

        private static Mutex sync = new Mutex();
        private static int[] collection = new int[CollectionSize];

        public static void Main(string[] args)
        {
            var firstThread = new Thread(new ThreadStart(FirstTask));
            var secondThread = new Thread(new ThreadStart(SecondTask));

            firstThread.Start();
            secondThread.Start();

            Console.ReadLine();
        }

        private static void FirstTask()
        {
            for (var i = 0; i < collection.Length; i++)
            {
                sync.WaitOne();
                Console.WriteLine(IntputInfoString);
                collection[i] = i;
                sync.ReleaseMutex();
            }
        }

        private static void SecondTask()
        {
            for (var i = 0; i < collection.Length; i++)
            {
                sync.WaitOne();
                Console.WriteLine(OutputInfoString);
                Console.WriteLine(collection[i]);
                sync.ReleaseMutex();
            }
        }
    }
}

