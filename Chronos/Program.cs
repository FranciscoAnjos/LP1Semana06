using System;
using System.Threading;


namespace Chronos
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch chrono1 = new Stopwatch();
            Stopwatch chrono2 = new Stopwatch();

            chrono1.Start();
            Thread.Sleep(500); 

            chrono2.Start();
            Thread.Sleep(250);

            chrono1.Stop();
            chrono2.Stop();
            
            double totSeconds0 = chrono1.Elapsed.TotalSeconds;
            double totSeconds1 = chrono2.Elapsed.TotalSeconds;
                        
            Console.WriteLine($"{totSeconds0:f4}");
            Console.WriteLine($"{totSeconds1:f4}");

        }
    }
}
