using System.Reflection.Metadata.Ecma335;

namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stopwatchFucntion;

            bool appRuntime = true;
            Console.WriteLine("Stopwatch Demo!\n");

            // Instanciating Stopwatch
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Welcome to STAR-STOPWATCH\nPlease enter 's' to 'Start', 'e' to End,\nOR 'q' to quit program\n");

            stopwatchFucntion = Console.ReadLine();

            do
            {

                if (stopwatchFucntion == "s")
                {
                    Console.WriteLine("\nStopwatch 'STARTED'\n");

                    stopwatch.StartStopwatch();


                }
                    Console.ReadLine().ToLower();

                if (stopwatchFucntion == "s")
                {
                    stopwatch.EndStopwatch();
                    Console.WriteLine("\nStopwatch 'STOPPED'\n");

                    stopwatch.ClearStopwatch();

                    Console.WriteLine("Stopwatch 'STARTED Again'\n");
                    stopwatch.StartStopwatch();
                }
                    Console.ReadLine().ToLower();
                
                if (stopwatchFucntion == "s")
                {
                    Console.WriteLine("\n' InvalidOperationException ' Cannot 'START' & 'STOP' Twice in a row");
                    stopwatch.EndStopwatch();
                    appRuntime = false;
                }
                    Console.ReadLine().ToLower();

                if(stopwatchFucntion == "e")
                {
                    Console.WriteLine("\nStopwatch 'STOPPED'\n");
                    stopwatch.EndStopwatch();
                }
                    Console.ReadLine().ToLower();

                if(stopwatchFucntion == "q" || stopwatchFucntion != "e")
                {
                    Console.WriteLine("\nProgram Terminated\n");
                    appRuntime = false;
                    return;
                }            
            }
            while (appRuntime);

        }
    }
}
