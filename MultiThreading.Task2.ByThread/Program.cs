using System;
using System.Linq;
using System.Threading;

namespace MultiThreading.Task2.ByThread
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
            var firstTaskThread = new Thread(new ThreadStart(FirstTask));
            firstTaskThread.Start();

            Console.ReadLine();
        }

        private static void FirstTask()
        {
            var intArray = new int[ArraySize];
            for (var i = 0; i < intArray.Length; i++)
            {
                intArray[i] = _random.Next(1, 10);
                Console.WriteLine(string.Format(FirstTaskInfoString, i, intArray[i]));
            }

            var secondTaskThread = new Thread(new ParameterizedThreadStart(SecondTask));
            secondTaskThread.Start(intArray);
        }

        private static void SecondTask(object intArrayObject)
        {
            var intArray = (int[])intArrayObject;
            for (var i = 0; i < intArray.Length; i++)
            {
                intArray[i] = intArray[i] + _random.Next(1, 10);
                Console.WriteLine(string.Format(SecondTaskInfoString, i, intArray[i]));
            }

            var thirdTaskThread = new Thread(new ParameterizedThreadStart(ThirdTask));
            thirdTaskThread.Start(intArray);
        }

        private static void ThirdTask(object intArrayObject)
        {
            var intArray = (int[])intArrayObject;
            intArray = intArray
                .OrderBy(number => number)
                .ToArray();

            for (var i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(string.Format(ThirdTaskInfoString, i, intArray[i]));
            }

            var fourthTaskThread = new Thread(new ParameterizedThreadStart(FourthTask));
            fourthTaskThread.Start(intArray);
        }

        private static void FourthTask(object intArrayObject)
        {
            var intArray = (int[])intArrayObject;
            var average = intArray.Average(x => x);
            Console.WriteLine(string.Format(FourthTaskInfoString, average));
        }
    }
}
