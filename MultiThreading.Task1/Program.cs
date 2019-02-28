using System;
using System.Threading.Tasks;

namespace MultiThreading.Task1
{
    public class Program
    {
        private const string InfoString = "Task #{0} – Iteration #{1}";
        private const int ArraySize = 100;
        private const int IterationStartNumber = 1;
        private const int IterationEndNumber = 1000;

        public static void Main(string[] args)
        {
            var tasksArray = new Task[ArraySize];
            for(var i = 0; i< tasksArray.Length; i++)
            {
                tasksArray[i] = Task.Factory.StartNew(() => IterateThroughArray());
            }

            Task.WaitAll(tasksArray);

            Console.ReadLine();
        }

        private static void IterateThroughArray()
        {
            for(var i = IterationStartNumber; i<= IterationEndNumber; i++)
            {
                Console.WriteLine(string.Format(InfoString, Task.CurrentId, i));
            }
        }
    }
}
