using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread");
            Method();
            Console.ReadLine();
        }

        public async static  void Method()
        {
            Task task = new Task(LongTask);
            task.Start();
            Console.WriteLine("Another Function execution Finished");
            await task;
            Console.WriteLine("Task Completed");

        }
        public static void LongTask()
        {
            Console.WriteLine(DateTime.Now);
            Thread.Sleep(5000);
            Console.WriteLine(DateTime.Now);

        }
    }
}
