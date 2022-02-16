using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProgram
{
    public class CalculatorLibrary
    {
        public static double CalculateValue(double firstNumber, double secondNumber, string operation)
        {
            {
                return operation switch
                {
                    "a" => firstNumber + secondNumber,
                    "d" => firstNumber - secondNumber,
                    "m" => firstNumber * secondNumber,
                    "e" => firstNumber / secondNumber,
                    _ => double.NaN
                };

            }
        }
    }
}