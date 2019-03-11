using System;
using System.Linq;
using System.Threading.Tasks;

namespace MultiThreading.Task2
{
    public class Program
    {
        private const string FirstTaskInfoString = "Task #1 – Element #{0} is {1}";
        private const string SecondTaskInfoString = "Task #2 – Element #{0} is {1}";
        private const string ThirdTaskInfoString = "Task #3 – Element #{0} is {1}";
        private const string FourthTaskInfoString = "Task #4 – Average is {0}";
        private const int ArraySize = 10;

        private static Random _random = new Random();

        public static void Main(string[] args)
        {
            Task.Factory
                .StartNew(() => FirstTask())
                .ContinueWith((prevTask) => SecondTask(prevTask.Result))
                .ContinueWith((prevTask) => ThirdTask(prevTask.Result))
                .ContinueWith((prevTask) => FourthTask(prevTask.Result));

            Console.ReadLine();
        }

        private static int[] FirstTask()
        {
            var intArray = new int[ArraySize];
            for (var i = 0; i< intArray.Length; i++)
            {
                intArray[i] = _random.Next(1, 10);
                Console.WriteLine(string.Format(FirstTaskInfoString, i, intArray[i]));
            }

            return intArray;
        }

        private static int[] SecondTask(int[] intArray)
        {
            for (var i = 0; i < intArray.Length; i++)
            {
                intArray[i] = intArray[i] + _random.Next(1, 10);
                Console.WriteLine(string.Format(SecondTaskInfoString, i, intArray[i]));
            }
            return intArray;
        }

        private static int[] ThirdTask(int[] intArray)
        {
            intArray = intArray
                .OrderBy(number => number)
                .ToArray();

            for (var i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(string.Format(ThirdTaskInfoString, i, intArray[i]));
            }

            return intArray;
        }

        private static double FourthTask(int[] intArray)
        {
            var average = intArray.Average(x => x);
            Console.WriteLine(string.Format(FourthTaskInfoString, average));
            return average;
        }
    }
}

