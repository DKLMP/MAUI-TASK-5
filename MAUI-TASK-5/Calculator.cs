﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_TASK_5
{
    public static class Calculator
    {
        public static double Calculate(double value1, double value2,string mathOperator)
        {
            double result = 0;
            switch (mathOperator)
            {
                case "/":
                    result = value1 / value2;
                    break;
                case "-":
                    result = value2 - value1; 
                    break;
                case "*":
                    result = value2 * value1;
                    break;
                case "+":
                    result = value2 + value1;
                    break;


            }
            return result;
        }
    }
}
