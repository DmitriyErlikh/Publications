using System;
using System.Collections.Generic;
using System.Threading;

namespace Publications.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            var auto_event = new AutoResetEvent(false);
            var threads = new Thread[10];
            for (var i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(() =>
               {
                   var thread_id = Thread.CurrentThread.ManagedThreadId;
                   auto_event.WaitOne();
                   list.Add(thread_id);
                   Console.WriteLine(thread_id);
               });
                threads[i].Start();
            }
            Console.ReadKey();
            for (int i = 0; i < 3; i++)
            {
                auto_event.Set();
            }
            Console.ReadKey();
        }
    }
}
