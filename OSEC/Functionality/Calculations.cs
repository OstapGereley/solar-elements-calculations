using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoreLinq;
using OSEC.Models;

namespace OSEC.Functionality
{
    class Calculations
    {
        public Dots MaxPIV;
        public Dots ExtremeI = new Dots();
        public Dots ExtremeV = new Dots();
        
        public List<Dots> inputDots;
        

        public double solarPower;

        public double fillFactor;
        public double convertingPowerEfficiency;

        public void CalcExtremeValues()
        {
            ExtremeI = inputDots.FirstOrDefault(x => x.Voltage > 0);
            ExtremeV = inputDots.LastOrDefault(x => x.Current < 0);
            
        }

        public List<Dots> GetGraphDots()
        {
            var startIndex = inputDots.FindIndex(a => a == ExtremeI);
            var endIndex = inputDots.FindIndex(a => a == ExtremeV);
            return inputDots.GetRange(startIndex, endIndex - startIndex + 1);
        }

        public void GetMaxValues(List<Dots> graphList)
        {
            MaxPIV = graphList.MinBy(x => x.Power);
        }

        public void FillFactor()
        {
            fillFactor = (MaxPIV.Power)/(ExtremeI.Current*ExtremeV.Voltage);
        }

        public void ConvertingPowerEfficiency()
        {
            convertingPowerEfficiency = MaxPIV.Power/solarPower;
        }
    }
}
