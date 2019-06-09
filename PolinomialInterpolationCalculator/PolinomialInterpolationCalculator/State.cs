using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolinomialInterpolationCalculator
{
    public class State
    {
        public double Up { get; set; }
        public double Down { get; set; }
        public double Value { get; set; }
        public State(double up, double down, double value)
        {
            Up = up;
            Down = down;
            Value = value; 
        }
    }
}
