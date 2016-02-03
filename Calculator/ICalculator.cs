using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    interface ICalculator
    {
        int Add(int number1, int number2);
        int Multiple(int number1, int number2);
    }
}
