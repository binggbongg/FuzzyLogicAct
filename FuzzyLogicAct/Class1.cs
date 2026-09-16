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

            //double temperature = 15.5; // degrees
            //double humidity = 80.0; // percentage

            // SAMPLE VALUES FOR TESTING

            double soilMoisture = 0; 
            double sunlightInput = 0;
            double airTempInput = 0;

            // might transfer this line to after the user presses the button

            Console.WriteLine("== USER INPUT == ");
            Console.WriteLine($"Soil Moisture: {soilMoisture}%");
            Console.WriteLine($"Sunlight: {sunlightInput}");
            Console.WriteLine($"Air Temperature: {airTempInput}°C");

            //SugenoMethod(soilMoisture, sunlightInput, airTempInput);
        }

        public static void SugenoMethod(double temperature, double humidity)
        {
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

            //print here results
            Console.WriteLine(" == OUTPUT OF SUGENO METHOD == ");
            Console.WriteLine(crispOutput);
        }

        public static void MamdaniMethod(double temperature, double humidity)
        {
            // 1. fuzzification
            double tempLow = TriangularMembership(temperature, 10, 15, 20);
            double tempMed = TriangularMembership(temperature, 15, 25, 35);
            double tempHigh = TriangularMembership(temperature, 30, 35, 40);

            double humLow = TriangularMembership(humidity, 0, 25, 50);
            double humHigh = TriangularMembership(humidity, 40, 75, 100);

            double sumNumerator = 0.0;
            double sumDenominator = 0.0;

            // 2. rule eval
            double rule1_strength = Math.Max(tempHigh, humHigh); // OR operation
            double rule2_strength = Math.Min(tempMed, humLow); // AND operation
            double rule3 = tempLow;

            // 3. IMPLICATION, AGGREGATION & DEFUZZIFICATION (Center of Gravity)
            // We evaluate the output universe of discourse (Fan Speed: 0% to 100%) 
            // across discrete integration steps to find the geometric centroid

            double step = 0.5; // Integration step size for accuracy
            for (double y = 0.0; y <= 100.0; y += step)
            {

                // Define output membership functions for Fan Speed (Slow, Medium, Fast)
                double outSlow = TriangularMembership(y, 0.0, 0.0, 50.0);
                double outMed = TriangularMembership(y, 20.0, 50.0, 80.0);
                double outFast = TriangularMembership(y, 50.0, 100.0, 100.0);


                // Implication: Clip each output fuzzy set by its rule firing strength using Min
                double clippedSlow = Math.Min(rule3, outSlow);
                double clippedMed = Math.Min(rule2_strength, outMed);
                double clippedFast = Math.Min(rule1_strength, outFast);


                // Aggregation: Combine all clipped output sets using Max (Union operator)
                double aggregatedY = Math.Max(clippedSlow, Math.Max(clippedMed, clippedFast));

                // Accumulate for Center of Gravity (Centroid) calculation:
                // Centroid = Integral(y * u(y)) / Integral(u(y))sumNumerator += y * aggregatedY * step;

                sumDenominator += aggregatedY * step;

                double crispOutput = 0.0;

                if (sumDenominator > 0.0)
                { 
                    crispOutput = sumNumerator / sumDenominator;
                }

                // print results
                Console.WriteLine(" == OUTPUT OF MAMDANI METHOD == ");
                Console.WriteLine(crispOutput);
            }
        }

        // x = input val, a = left foot, b = peak, c = right foot
        static double TriangularMembership(double x, double a, double b, double c)
        {
            if (x <= a || x >= c) return 0.0;
            if (x == b) return 1.0;
            if (x > a && x < b) return (x - a) / (b - a);

            return (c - x) / (c - b);
        }

    }
}
