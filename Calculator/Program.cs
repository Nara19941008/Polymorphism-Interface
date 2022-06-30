using System;
using calculation;

namespace PolymorphismInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();
            calculation.Calculate(5, 7);
            Console.WriteLine();
        }

    }
}

