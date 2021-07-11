using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProblems
{
    public class StopWatch
    {
        public static void SWatch()
        {
            int start = DateTime.Now.Second;
            Console.WriteLine("Timer started, Press Enter to stop");
            Console.ReadLine();
            int stop = DateTime.Now.Second;
            Console.WriteLine("elapsed time is " + (stop - start) + " seconds");
            Console.ReadKey();
        }
    }
}
