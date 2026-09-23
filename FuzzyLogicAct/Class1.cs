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

            //SugenoMethod(soilMoisture, sunlightInput, airTempInput);
        }

        public static double SugenoMethod(double soil_moisture, double light_intensity, double air_temp)
        {
            // 1. Fuzzification
            // Soil Moisture (Scale: 0 to 100%)
            double lowMoisture = TriangularMembership(soil_moisture, 0, 0, 40);
            double medMoisture = TriangularMembership(soil_moisture, 30, 55, 75);
            double highMoisture = TriangularMembership(soil_moisture, 65, 100, 100);

            // Light Intensity (Scale: 0 to 100 klx)
            double lowIntensity = TriangularMembership(light_intensity, 0, 0, 30);
            double medIntensity = TriangularMembership(light_intensity, 20, 50, 75);
            double highIntensity = TriangularMembership(light_intensity, 60, 100, 100);

            // Air Temperature (Scale: 20 to 45°C)
            double lowTemp = TriangularMembership(air_temp, 20, 20, 28);
            double medTemp = TriangularMembership(air_temp, 26, 31, 36);
            double highTemp = TriangularMembership(air_temp, 33, 42, 45);

            // 2. rule evaluation for water pump / irrigation

            // Rule 1: Soil is dry -> heavy watering
            double rule1 = lowMoisture;

            // Rule 2: Moderate soil, but high tropical heat/sun -> increase watering
            double rule2 = Math.Min(medMoisture, Math.Max(highTemp, highIntensity));

            // Rule 3: Moderate soil and normal warm daytime -> steady watering
            double rule3 = Math.Min(medMoisture, medTemp);

            // Rule 4: Moderate soil during cool night / overcast dawn -> minimal watering
            double rule4 = Math.Max(medMoisture, Math.Min(lowTemp, lowIntensity));

            // Rule 5: Soil is already saturated -> cutoff to avoid root rot
            double rule5 = highMoisture;


            // 3. defuzzification (weighted average)
            double cFast = 100.0;
            double cMedHi = 75.0;
            double cMed = 50.0;
            double cSlow = 15.0;
            double cStop = 0.0;

            double numerator = (rule1 * cFast) + (rule2 * cMedHi) + (rule3 * cMed) + (rule4 * cSlow) + (rule5 * cStop);
            double denominator = rule1 + rule2 + rule3 + rule4 + rule5;

            double crispOutput = 50.0;
            if (denominator > 0) crispOutput = numerator / denominator;

            //print here results
            Console.WriteLine(" == OUTPUT OF SUGENO METHOD == ");
            Console.WriteLine(crispOutput);
            return crispOutput;
        }

        public static double MamdaniMethod(double soil_moisture, double light_intensity, double air_temp)
        {
            // 1. Fuzzification
            // Soil Moisture (Scale: 0 to 40)
            double lowMoisture = TriangularMembership(soil_moisture, 0, 0, 20);
            double medMoisture = TriangularMembership(soil_moisture, 15, 25, 35);
            double highMoisture = TriangularMembership(soil_moisture, 30, 40, 40);

            // Light Intensity (Scale: 0 to 100)
            double lowIntensity = TriangularMembership(light_intensity, 0, 0, 40);
            double medIntensity = TriangularMembership(light_intensity, 30, 50, 75);
            double highIntensity = TriangularMembership(light_intensity, 60, 100, 100);

            // Air Temperature (Scale: 0 to 50°C)
            double lowTemp = TriangularMembership(air_temp, 0, 10, 25);
            double medTemp = TriangularMembership(air_temp, 20, 28, 36);
            double highTemp = TriangularMembership(air_temp, 30, 50, 50);

            // 2. rule evaluation for water pump / irrigation
            // high demand: if soil moisture is low OR (temp is high AND light is High)
            double rule1_strength = Math.Max(lowMoisture, Math.Min(highTemp, highIntensity));
            // moderate demand: if soil moisture is med and temp medium
            double rule2_strength = Math.Min(medMoisture, medTemp);
            // low demand: is soil moisture is high or (temp is low and light is low)
            double rule3_strength = Math.Max(highMoisture, Math.Min(lowTemp, lowIntensity));

            // 3. Mamdani implication, aggregation, and defuzzification
            // slow: 0% to 40%
            // med: 20%, peak 50%, 70%
            // high: 60%, peak 100%

            double sumNumerator = 0.0;
            double sumDenominator = 0.0;
            double step = 0.5; // Integration step size for accuracy

            for (double y = 0.0; y <= 100.0; y += step)
            {

                // Define output membership functions for Water Pump (Slow, Medium, Fast)
                double outSlow = TriangularMembership(y, 0.0, 0.0, 40.0);
                double outMed = TriangularMembership(y, 20.0, 50.0, 70.0);
                double outFast = TriangularMembership(y, 60.0, 100.0, 100.0);


                // Implication: Clip each output fuzzy set by its rule firing strength using Min
                double clippedSlow = Math.Min(rule3_strength, outSlow);
                double clippedMed = Math.Min(rule2_strength, outMed);
                double clippedFast = Math.Min(rule1_strength, outFast);


                // Aggregation: Combine all clipped output sets using Max (Union operator)
                double aggregatedY = Math.Max(clippedSlow, Math.Max(clippedMed, clippedFast));

                // Accumulate for Center of Gravity (Centroid) calculation:
                // Centroid = Integral(y * u(y)) / Integral(u(y))
                sumNumerator += y * aggregatedY * step;
                sumDenominator += aggregatedY * step;
            }

            double crispOutput = 0.0;
            if (sumDenominator > 0.0) crispOutput = sumNumerator / sumDenominator;

            // print results
            Console.WriteLine(" == OUTPUT OF MAMDANI METHOD == ");
            Console.WriteLine(crispOutput);

            return crispOutput;
        }

        // x = input val, a = left foot, b = peak, c = right foot
        static double TriangularMembership(double x, double a, double b, double c)
        {
            if (a == b && x <= b) return 1.0;              // Left shoulder
            if (b == c && x >= b) return 1.0;              // Right shoulder
            if (x == b) return 1.0;
            if (x <= a || x >= c) return 0.0;
            if (x > a && x < b) return (x - a) / (b - a);

            return (c - x) / (c - b);
        }

    }
}
