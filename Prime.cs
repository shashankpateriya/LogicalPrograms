using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProblems
{
    public class Prime
    {
        public void PrimeNumber()
        {
            Console.WriteLine("enter number to check its prime or not : ");
            int Num = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for (int i = 2; i <= Num; i++)
            {
                if (Num % i == 0)
                {
                    a = a + 1;
                }
            }
            if (a == 2)
                Console.WriteLine("not a Prime Number" + Num);
            else
                Console.WriteLine(" Prime Number" + Num);
            Console.ReadKey();
        }
    }
}