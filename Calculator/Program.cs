﻿using Calculator.Sevices.Interfaces;
using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();

            // Add comment - test
            double addResult = calculate.Add(5, 7);
            calculate.DispalyResult(addResult);

            double substractionResult = calculate.Substraction(33, 11);
            calculate.DispalyResult(substractionResult);    

            double multipilactionResult = calculate.Multiplication(5, 7);
            calculate.DispalyResult(multipilactionResult);
            Console.ReadLine();
        }
    }
}
