namespace Calculator.Sevices.Interfaces
{
    internal interface ICalculate
    {
        void DispalyResult(double result);

        double Add(double firstNumber, double secondNumber);

        double Multiplication(double firstNumber, double secondNumber);
    }
}
