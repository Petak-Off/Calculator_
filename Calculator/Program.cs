using System;
using Calculator;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beginning start = new Beginning();
            start.WriteGreeting();

            Parser inputParams = new Parser();
            string[] splitedInputParams = inputParams.GetInputParams(Console.ReadLine());
           

            Calculation calc = new Calculation();
            var res = calc.GetCalculation(splitedInputParams);

            Result result = new Result();
            result.WriteResult(res);
        }
    }
}
