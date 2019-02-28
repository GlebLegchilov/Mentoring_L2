using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreading.Sample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // проверим наличие контекста синхронизации
            var context = SynchronizationContext.Current;
            if (context == null)
                MessageBox.Show("No context for this thread");
            else
                MessageBox.Show("We got a context");

            // создадим форму
            Form1 form = new Form1();

            // проверим наличие контекста синхронизации еще раз
            context = SynchronizationContext.Current;

            if (context == null)
                MessageBox.Show("No context for this thread");
            else
                MessageBox.Show("We got a context");

            if (context == null)
                MessageBox.Show("No context for this thread");

            Application.Run(new Form1());
        }
    }
}
