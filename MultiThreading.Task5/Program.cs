using System;
using System.Threading;

namespace MultiThreading.Task5
{
    class Program
    {
        private static int ThreadCount = 10;
        private static Semaphore Sem = new Semaphore(1, 1);

        public static void Main(string[] args)
        {
            CreateThread(ThreadCount);

            Console.ReadLine();
        }

        private static void CreateThread(object state)
        {
            Sem.WaitOne();
            var number = (int)state;
            number--;
            Console.WriteLine(number);
            if (number > 0)
            {
                var newThread = ThreadPool.QueueUserWorkItem(CreateThread, number);
            }
            Sem.Release();
        }
    }
}

