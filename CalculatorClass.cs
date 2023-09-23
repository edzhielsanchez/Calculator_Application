using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Application
{
    public delegate T Formula<T>(T arg, T args);
    internal class CalculatorClass
    {
        public Formula<string> formula;
        public Double GetSum(double number1, double number2) 
        { 
            return number1 + number2;
        }
        public Double GetDifference(double number1, double number2) 
        { 
            return number1 - number2;
        }
        public Double GetProduct(double number1, double number2) 
        { 
            return number1 * number2;
        }
        public Double GetQuotient(double number1, double number2) 
        {
            return number1 / number2;
        }
        public event Formula<double> CalculateEvent 
        { 
            add 
            { 
                Console.WriteLine("Added the delegate"); 
            } 
            remove 
            { 
                Console.WriteLine("Remove the Delegate"); 
            }  
        }
    }
}
