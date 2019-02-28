using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.Task6
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
            var firstTask = Task.Factory.StartNew(() => FirstTask());
            var secondTask = Task.Factory.StartNew(() => SecondTask());

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
            for (var i = 0; i< collection.Length; i++)
            {
                sync.WaitOne();
                Console.WriteLine(OutputInfoString);
                Console.WriteLine(collection[i]);
                sync.ReleaseMutex();
            }
        }
    }
}
