using Calculator.Sevices.Interfaces;
using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();

            double addResult = calculate.Add(5, 7);
            calculate.DispalyResult(addResult);
            Console.ReadLine();
        }
    }
}
