using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogicAct
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            // Sophia add the print stuff plz

            double temperature = 15.5; // degrees
            double humidity = 80.0; // percentage

            double tempLow = TriangularMembership(temperature, 10, 15, 20);
            double tempMid = TriangularMembership(temperature, 15, 25, 35);
            double tempHigh = TriangularMembership(temperature, 30, 35, 40);

            double humLow = TriangularMembership(humidity, 0, 25, 50);
            double humHigh = TriangularMembership(humidity, 40, 75, 100);

            // 2. rule evaluation for the fan speed
            double rule1_strength = Math.Max(tempHigh, humHigh); // OR operation
            double rule2_strength = Math.Min(tempMid, humLow); // AND operation
            double rule3 = tempLow;

            // 3. defuzzification (weighted average / centroid approximation)
            double cSlow = 20.0;
            double cMed = 60.0;
            double cFast = 100.0;

            double numerator = (rule3 * cSlow) + (rule2_strength * cMed) + (rule1_strength * cFast);
            double denominator = rule3 + rule2_strength + rule1_strength;

            double crispOutput = 0.0;
            if (denominator > 0) crispOutput = numerator / denominator;

        }

        // x = input val, a = left foot, b = peak, c = right foot
        static double TriangularMembership(double x, double a, double b, double c)
        {
            if (x <= a && x >= c) return 0.0;
            if (x == b) return 1.0;
            if (x > a && x < b) return (x - a) / (b - a);

            return (c - x) / (c - b);
        }

    }
}
