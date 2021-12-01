using System;
using System.Threading;

namespace Publications.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var timer_tread = new Thread(() => TimerTread());
            timer_tread.Start();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            
            __TimerTreadCanWork = false;
            if (timer_tread.Join(200))
            {
                Console.WriteLine("Поток таймера закрыт");
            }
            else
            {
                Console.WriteLine("Поток таймера не закрыт");
            }
        }
        private static bool __TimerTreadCanWork = true;
        private static void TimerTread()
        {
            while (__TimerTreadCanWork)
            {
                var time = DateTime.Now.ToString("HH:mm:ss:ffff");
                Console.WriteLine(time);
                Thread.Sleep(10);
                Console.Clear();
            }
        }
    }
}
