using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProblems
{
    public class Fibonacci
    {
        public void Fibb(int len)
        {

            int a = 0, b = 1, c;
            Console.WriteLine("{0},{1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.WriteLine("{0}", c);
                a = b;
                b = c;
            }
            Console.ReadKey();
        }
    }
}