﻿using System;

namespace CalculatorParamns
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 3, 4);

            int a = 10;
            int triple;

            Calculator.Triple(ref a);
            Calculator.TripleOut(a, out triple);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
