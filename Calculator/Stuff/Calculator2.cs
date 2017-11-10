using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator.Models;

namespace Calculator
{
    public class Calculator2
    {        
        public decimal Caculation(Calcilation calc)
        {

            switch (calc.opration)
            {
                case Opration.Add:
                    {
                        return calc.Value1 + calc.Value2;
                    }
                case Opration.Sub:
                    {
                        return calc.Value1 - calc.Value2;
                    }
                case Opration.Dif:
                    {
                        return calc.Value1/calc.Value2;
                    }
                case Opration.Mul:
                    {
                        return calc.Value1 * calc.Value2;
                    }

                default:
                    {
                        return 0;
                    }
            }
        }
    }
}
