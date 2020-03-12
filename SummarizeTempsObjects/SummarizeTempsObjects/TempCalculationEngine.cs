using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }

        public int AverageTemperature()
        {
            int sum = 0;
            // add logic to calculate the average
            foreach (int sumtemp in _temperatures)
            {
                sum += sumtemp;
            }
                       
            return sum / _temperatures.Count; // <-- Replace this with the actual average
        }

        public int TempsAboveThreshold(int threshold)
        {
            int abvt = 0;
            // add logic to calculate temps above the threshold
            foreach (int abovetemp in _temperatures)
            {
                if (abovetemp>threshold)
                {
                    abvt++;
                }
            }
            return abvt; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            int blt = 0;
            // add logic to calculate and return temps below the threshold
            foreach (int belowtemp in _temperatures)
            {
                if (belowtemp<threshold)
                {
                    blt++;
                }
            }

            return blt; // <-- Replace this with the number
        }

        public int TempsAtThreshold(int threshold)
        {
            int att = 0;
            // add logic to calculate and return temps at the threshold
            foreach (int atemp in _temperatures)
            {
                if (atemp==threshold)
                {
                    att++;
                }
            }
            return att; // <-- Replace this with the number
        }

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings
            return _temperatures.Count; // <-- Replace this with the number
        }
    }
}
