using System;

namespace Calculator
{
    public class Parser
    {
        public string[] GetInputParams(string inputParams)
        {
            var separator = new[] { ' ' };
            return inputParams.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
