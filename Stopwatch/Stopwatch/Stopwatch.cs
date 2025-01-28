using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    public class Stopwatch
    {
        //public string start;
        private DateTime _startOne;
        private DateTime _startTwo;
        private DateTime _end;
        private DateTime _timeDifference;
        //private TimeOnly timeStart;

        public void StartStopwatch()
        {
                _startOne = DateTime.Now.ToLocalTime();

                Console.WriteLine($"Stopwatch Started. And the value is:   {_startOne}");
            
        }



        public void EndStopwatch() 
        {

            _end = DateTime.Now.ToLocalTime();

            Console.WriteLine($"Stopwatch Ended. And the value is:   {_end}\n");
            //Console.WriteLine(_end.ToString("HH:mm"));

            TimeSpan _timeDifference = _end - _startOne;

            Console.WriteLine($"\nThe 'TimeSpan' is {_timeDifference}");
        }


        public void ClearStopwatch()
        {
            _startOne = DateTime.MinValue;
            _end = DateTime.MinValue;
        }

    }
}
