namespace Calculator.Sevices.Interfaces
{
    internal interface ICalculate
    {
        void DispalyResult(double result);

        double Add(double firstNumber, double secondNumber);

        double Substraction(double firstNumber, double secondNumber);
    }
}
