using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static FuzzyLogicAct.Class1;

namespace FuzzyLogicAct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSugeno_Click(object sender, EventArgs e)
        {
            double soilMoistureInput = double.Parse(textBoxSoilMoisture.Text);
            double sunlightInput = double.Parse(textBoxSunlight.Text);
            double airTempInput = double.Parse(textBoxAirTemp.Text);

            //SugenoMethod(soilMoistureInput, sunlightInput, airTempInput, this);

            Console.WriteLine("== USER INPUT == ");
            Console.WriteLine($"Soil Moisture: {soilMoistureInput}%");
            Console.WriteLine($"Sunlight: {sunlightInput}");
            Console.WriteLine($"Air Temperature: {airTempInput}°C");

            richTextBoxOuput.Text = $"Soil Moisture: {soilMoistureInput}%\nSunlight: {sunlightInput}\nAir Temperature: {airTempInput}°C\n\n== OUTPUT OF SUGENO METHOD ==\n{SugenoMethod(soilMoistureInput, sunlightInput, airTempInput)}";
        }

        private void btnMamdani_Click(object sender, EventArgs e)
        {
            double soilMoistureInput = double.Parse(textBoxSoilMoisture.Text);
            double sunlightInput = double.Parse(textBoxSunlight.Text);
            double airTempInput = double.Parse(textBoxAirTemp.Text);

            //MamdaniMethod(soilMoistureInput, sunlightInput, airTempInput);

            Console.WriteLine("== USER INPUT == ");
            Console.WriteLine($"Soil Moisture: {soilMoistureInput}%");
            Console.WriteLine($"Sunlight: {sunlightInput}");
            Console.WriteLine($"Air Temperature: {airTempInput}°C");

            richTextBoxOuput.Text = $"Soil Moisture: {soilMoistureInput}%\nSunlight: {sunlightInput}\nAir Temperature: {airTempInput}°C\n\n== OUTPUT OF MAMDANI METHOD ==\n{MamdaniMethod(soilMoistureInput, sunlightInput, airTempInput)}";
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void label1_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void label2_Click(object sender, EventArgs e)
        //{

        //}

        //private void label4_Click(object sender, EventArgs e)
        //{

        //}

        private void textBoxSoilMoisture_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSunlight_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAirTemp_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxOuput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
