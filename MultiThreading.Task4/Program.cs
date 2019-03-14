using System;
using System.Threading;

namespace MultiThreading.Task4
{
    public class Program
    {
        private static int ThreadCount = 10;

        public static void Main(string[] args)
        {
            CreateThread(ThreadCount);

            Console.ReadLine();
        }

        private static void CreateThread(object state)
        {
            Console.WriteLine("Thread #{0}", Thread.CurrentThread.ManagedThreadId);
            var number = (int)state;
            number--;
            Console.WriteLine(number);
            if (number > 0)
            {
                var newThread = new Thread(new ParameterizedThreadStart(CreateThread));
                Console.WriteLine("New Thread #{0}", newThread.ManagedThreadId);
                newThread.Start(number);
                newThread.Join();
            }
        }
    }
}

