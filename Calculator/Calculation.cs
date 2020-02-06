using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculation
    {
      
        public string GetCalculation(string[] splitedInputParams)
        {
            string res;
            var par1 = Convert.ToDouble(splitedInputParams[0]);
            var symbol = Convert.ToChar(splitedInputParams[1]);
            var par2 = Convert.ToDouble(splitedInputParams[2]);
            switch (symbol)
            {
                case '+':
                    res = (par1 + par2).ToString();
                    break;
                case '-':
                    res = (par1 - par2).ToString();
                    break;
                case '*':
                    res =(par1 * par2).ToString("0.##");
                    break;
                case '/':
                    if (par2 == 0)
                        res = "Делить на ноль нельзя";
                    else
                        res = (par1 / par2).ToString("0.##");
                    break;
                default:
                    res = "Неверные параметры";
                    break;
            }
            return res; 
        }
    }
}
