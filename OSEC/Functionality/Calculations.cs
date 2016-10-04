using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSEC.Models;

namespace OSEC.Functionality
{
    class Calculations
    {
        public double maxI;
        public double maxV;
        public double maxP;
        public Dots ExtremeI;
        public Dots ExtremeV;
        public List<Dots> inputDots;

        public double solarPower;

        public double fillFactor;
        public double convertingPowerEfficiency;

        public void CalcExtremeValues()
        {
            ExtremeI.Current = inputDots[0].Current;
            ExtremeV.Voltage = inputDots[0].Voltage;

            foreach (var el in inputDots)
            {
                if (el.Current < ExtremeV.Current)
                {
                    ExtremeV.Voltage = el.Voltage;
                    ExtremeV.Current = el.Current;
                }

                if (el.Voltage < ExtremeI.Voltage)
                {
                    ExtremeI.Current = el.Current;
                    ExtremeI.Voltage = el.Voltage;
                }
            }
        }

        public List<Dots> GetGraphDots()
        {
            var startIndex = inputDots.FindIndex(a => a == ExtremeI);
            var endIndex = inputDots.FindIndex(a => a == ExtremeV);
            return inputDots.GetRange(startIndex, inputDots.Count - (endIndex - startIndex));
        }

        public void GetMaxValues(List<Dots> graphList)
        {
            maxI = graphList.Max(s => s.Current);
            maxV = graphList.Max(s => s.Voltage);
            maxP = maxI * maxV;
        }

        public void FillFactor()
        {
            fillFactor = (maxI*maxV)/(ExtremeI.Current*ExtremeV.Voltage);
        }

        public void ConvertingPowerEfficiency()
        {
            convertingPowerEfficiency = maxI*maxV/solarPower;
        }
    }
}
