using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProblems
{
    public class PerfectNumber
    {
        public void PerfectNum()
        {
            int sum = 0;
            Console.Write("enter the Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < Number; i++)
            {
                if (Number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == Number)
                Console.WriteLine("Entered number is a perfect number");
            else
                Console.WriteLine(" Entered number is not a perfect number");
            Console.ReadKey();
        }
    }
}