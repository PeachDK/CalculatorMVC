using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public enum Opration { Add, Sub, Dif, Mul}


    public class Calcilation
    {
        public decimal Value1 { get; set; }
        public Opration opration { get; set; }
        public decimal Value2 { get; set; }

        public Calcilation()
        {

        }
        
    }
}
