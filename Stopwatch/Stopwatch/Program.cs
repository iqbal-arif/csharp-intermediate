using System.Reflection.Metadata.Ecma335;

namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stopwatchFucntion;

            string lapse = string.Empty;

            bool appRuntime = true;
            Console.WriteLine("Stopwatch Demo!\n");

            // Instanciating Stopwatch
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Welcome to Star Stopwatch\nPlease enter 'b' to 'Start', 'e' to End,\nOR 'q' to quit program\n");

            stopwatchFucntion = Console.ReadLine();

            do
            {

                if (stopwatchFucntion == "b")
                {
                    Console.WriteLine("\nStopwatch 'STARTED'\n");

                    stopwatch.StartStopwatch();


                }
                    Console.ReadLine().ToLower();

                if (stopwatchFucntion == "b")
                {
                    stopwatch.EndStopwatch();
                    Console.WriteLine("\nStopwatch 'STOPPED'\n");
                    Console.WriteLine("Stopwatch 'STARTED Again'\n");
                    stopwatch.StartStopwatch();
                }
                    Console.ReadLine().ToLower();
                
                if (stopwatchFucntion == "b")
                {
                    Console.WriteLine("\n' InvalidOperationException ' Can not 'START' & 'STOP' Twice in a row");
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
                    //Console.WriteLine("\nEnter '0' to Stop Stopwatch\n");


        }
    }
}
