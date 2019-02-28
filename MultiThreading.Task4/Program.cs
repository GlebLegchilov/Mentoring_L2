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
            var newThread = new Thread(new ParameterizedThreadStart(CreateThread));
            var number = (int)state;
            number--;
            Console.WriteLine(number);
            if (number > 0)
            {
                newThread.Start(number);
                newThread.Join();
            }
        }
    }
}

