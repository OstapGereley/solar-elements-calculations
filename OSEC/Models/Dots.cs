using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace OSEC.Models
{
    public class Dots
    {
        public double Voltage { get; set; }
        public double Current { get; set; }
        public double Power { get; set; }

        public Dots()
        {
        }

        public Dots(double voltage, double current)
        {
            Voltage = voltage;
            Current = current;
            Power = current * voltage;
        }
    }
}