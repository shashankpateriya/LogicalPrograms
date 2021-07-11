using System;

namespace LogicalProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logic programs");
            Console.WriteLine("Press 1. for Fibonacci.");
            Console.WriteLine("Press 2. for PerfectNumber.");
            Console.WriteLine("Press 3. for ReverseNumber.");
            Console.WriteLine("Press 4. for PrimeNumber.");
            Console.WriteLine("Enter a choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.Fibb(9);
                    break;
                case 2:
                    PerfectNumber perfectnumber = new PerfectNumber();
                    perfectnumber.PerfectNum();
                    break;
                case 3:
                    Reverse reverse = new Reverse();
                    reverse.Rev();
                    break;
                case 4:
                    Prime prime = new Prime();
                    prime.PrimeNumber();
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }

        }
    }
}
