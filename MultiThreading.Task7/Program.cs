using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.Task7
{
    public class Program
    {
        private const string ParentTaskInfoString = "Parent task: IsThreadPoolThread - {0}, ManagedThreadId - {1}";
        private const string FirstTaskInfoString = "First task: IsThreadPoolThread - {0}, ManagedThreadId - {1}";
        private const string SecondTaskInfoString = "Second task: IsThreadPoolThread - {0}, ManagedThreadId - {1}";
        private const string ThirdTaskInfoString = "Third task: IsThreadPoolThread - {0}, ManagedThreadId - {1}";
        private const string FourthTaskInfoString = "Fourth task: IsThreadPoolThread - {0}, ManagedThreadId - {1}";

        public static void Main(string[] args)
        {
            var cancelTokenSource = new CancellationTokenSource();
            var factory = new TaskFactory(cancelTokenSource.Token);

            var parentTask = factory.StartNew(() => ParentTask(cancelTokenSource.Token));
            
            // uncomment this to reach Fourth Task
            // cancelTokenSource.Cancel();

            parentTask.ContinueWith((prev) => FirstConditionTask());

            parentTask.ContinueWith(
                (prev) => SecondConditionTask(),
                TaskContinuationOptions.OnlyOnFaulted);

            parentTask.ContinueWith(
                (prev) => ThirdConditionTask(),
                (int)TaskContinuationOptions.OnlyOnFaulted + TaskContinuationOptions.AttachedToParent);

            try
            {
                parentTask.Wait();
            }
            catch { }

            if (parentTask.IsCanceled)
            {
                var newThread = new Thread(new ThreadStart(FourthConditionTask));
                newThread.Start();
            }

            Console.ReadLine();
        }

        private static void ParentTask(CancellationToken token)
        {
            Console.WriteLine(string.Format(
                ParentTaskInfoString,
                Thread.CurrentThread.IsThreadPoolThread,
                Thread.CurrentThread.ManagedThreadId));
            
            if (!token.IsCancellationRequested) {
                throw new Exception();
            }
        }

        private static void FirstConditionTask()
        {
            Console.WriteLine(string.Format(
                FirstTaskInfoString,
                Thread.CurrentThread.IsThreadPoolThread,
                Thread.CurrentThread.ManagedThreadId));
        }

        private static void SecondConditionTask()
        {
            Console.WriteLine(string.Format(
                SecondTaskInfoString,
                Thread.CurrentThread.IsThreadPoolThread,
                Thread.CurrentThread.ManagedThreadId));
        }

        private static void ThirdConditionTask()
        {
            Console.WriteLine(string.Format(
                ThirdTaskInfoString,
                Thread.CurrentThread.IsThreadPoolThread,
                Thread.CurrentThread.ManagedThreadId));
        }

        private static void FourthConditionTask()
        {
            Console.WriteLine(string.Format(
                FourthTaskInfoString,
                Thread.CurrentThread.IsThreadPoolThread,
                Thread.CurrentThread.ManagedThreadId));
        }
    }
}
