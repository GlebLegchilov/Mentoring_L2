using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait.Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int maxBorder;
            var cancelTokenSource = new CancellationTokenSource();
            while (true)
            {
                var consoleString = Console.ReadLine();
                if (int.TryParse(consoleString, out maxBorder))
                {
                    cancelTokenSource.Cancel();
                    cancelTokenSource = new CancellationTokenSource();
                    CalculateSumAsync(maxBorder, cancelTokenSource.Token);
                }
            }
        }

        private static async void CalculateSumAsync(int maxBorder, CancellationToken token)
        {
            var sum = await Task.Run(() => CalculateSum(maxBorder), token);
            if (!token.IsCancellationRequested)
            {
                Console.WriteLine(sum);
            }
        }

        private static int CalculateSum(int maxBorder)
        {
            var sum = 0;
            for (int i = 0; i <= maxBorder; i++)
            {
                sum = sum + i;
            }
            Thread.Sleep(5000);
            return sum;
        }
    }
}

