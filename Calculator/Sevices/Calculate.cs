using System;

namespace Calculator.Sevices.Interfaces
{
    internal class Calculate : ICalculate
    {
        public double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public void DispalyResult(double result)
        {
            Console.WriteLine($"Result: {result}");
        }

        public double Substraction(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
