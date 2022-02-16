using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
namespace CalculatorProgram
{
    public class CalculatorLibrary
    {
        //constructor that logs date/time when the calculator was used in a text file
        /*public CalculatorLibrary()
        {
            StreamWriter calculatorLog = File.CreateText("calculator.log");
            Trace.Listeners.Add(new TextWriterTraceListener(calculatorLog));
            Trace.AutoFlush = true; //REMINDER: look up what autoFlush does!!
            Trace.WriteLine("Starting Calculator Log");
            Trace.WriteLine(String.Format("Started {0}", System.DateTime.Now.ToString()));
        }
        */
        //returns a result based on 2 user inputted? variables and a user inputted? operation
        public double CalculateValue(double firstNumber, double secondNumber, string operation)
        {
            {
                return operation switch
                {
                    "a" => firstNumber + secondNumber,  //=> Trace.WriteLine(String.Format("{0} / {1} = {2}", num1, num2, result)); ,
                    "d" => firstNumber - secondNumber,
                    "m" => firstNumber * secondNumber,
                    "e" => firstNumber / secondNumber,
                    _ => double.NaN
                };

            }
        }
    }
}