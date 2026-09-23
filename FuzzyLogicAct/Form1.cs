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

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateSoilDisplay();
            UpdateSunlightDisplay();
            UpdateAirTempDisplay();
            LoadSunflowerImage();
        }

        private void LoadSunflowerImage()
        {
            try
            {
                // Look for Sunflower2009HD.png in app directory or project directory
                string appDir = AppDomain.CurrentDomain.BaseDirectory;
                string imgPath = System.IO.Path.Combine(appDir, "Sunflower2009HD.png");

                if (!System.IO.File.Exists(imgPath))
                {
                    // Fallback to project root directory
                    string projectDir = System.IO.Path.GetFullPath(System.IO.Path.Combine(appDir, @"..\.."));
                    imgPath = System.IO.Path.Combine(projectDir, "Sunflower2009HD.png");
                }

                if (System.IO.File.Exists(imgPath))
                {
                    pictureBoxSunflower.Image = Image.FromFile(imgPath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not load sunflower image: " + ex.Message);
            }
        }

        private void trackBarSoilMoisture_Scroll(object sender, EventArgs e)
        {
            UpdateSoilDisplay();
        }

        private void trackBarSunlight_Scroll(object sender, EventArgs e)
        {
            UpdateSunlightDisplay();
        }

        private void trackBarAirTemp_Scroll(object sender, EventArgs e)
        {
            UpdateAirTempDisplay();
        }

        private void UpdateSoilDisplay()
        {
            int val = trackBarSoilMoisture.Value;
            lblSoilVal.Text = $"{val} %";

            // Classifications based on Soil Moisture (0 to 40)
            // Low [0, 0, 20], Med [15, 25, 35], High [30, 40, 40]
            if (val <= 18)
            {
                lblSoilClass.Text = "[Low / Dry]";
                lblSoilClass.ForeColor = Color.Firebrick;
            }
            else if (val <= 32)
            {
                lblSoilClass.Text = "[Medium / Optimal]";
                lblSoilClass.ForeColor = Color.DarkGreen;
            }
            else
            {
                lblSoilClass.Text = "[High / Wet]";
                lblSoilClass.ForeColor = Color.SteelBlue;
            }
        }

        private void UpdateSunlightDisplay()
        {
            int val = trackBarSunlight.Value;
            lblSunVal.Text = $"{val} lx";

            // Classifications based on Light Intensity (0 to 100)
            // Low [0, 0, 40], Med [30, 50, 75], High [60, 100, 100]
            if (val <= 35)
            {
                lblSunClass.Text = "[Low / Dim]";
                lblSunClass.ForeColor = Color.DimGray;
            }
            else if (val <= 65)
            {
                lblSunClass.Text = "[Medium / Moderate]";
                lblSunClass.ForeColor = Color.Goldenrod;
            }
            else
            {
                lblSunClass.Text = "[High / Bright]";
                lblSunClass.ForeColor = Color.DarkOrange;
            }
        }

        private void UpdateAirTempDisplay()
        {
            int val = trackBarAirTemp.Value;
            lblTempVal.Text = $"{val} °C";

            // Classifications based on Air Temp (0 to 50°C)
            // Low [0, 10, 25], Med [20, 28, 36], High [30, 50, 50]
            if (val <= 18)
            {
                lblTempClass.Text = "[Low / Cool]";
                lblTempClass.ForeColor = Color.DodgerBlue;
            }
            else if (val <= 32)
            {
                lblTempClass.Text = "[Medium / Normal]";
                lblTempClass.ForeColor = Color.DarkGreen;
            }
            else
            {
                lblTempClass.Text = "[High / Hot]";
                lblTempClass.ForeColor = Color.Crimson;
            }
        }

        private void btnSugeno_Click(object sender, EventArgs e)
        {
            double soilMoistureInput = trackBarSoilMoisture.Value;
            double sunlightInput = trackBarSunlight.Value;
            double airTempInput = trackBarAirTemp.Value;

            double result = SugenoMethod(soilMoistureInput, sunlightInput, airTempInput);
            UpdateOutputDisplay("Sugeno Method", soilMoistureInput, sunlightInput, airTempInput, result);
        }

        private void btnMamdani_Click(object sender, EventArgs e)
        {
            double soilMoistureInput = trackBarSoilMoisture.Value;
            double sunlightInput = trackBarSunlight.Value;
            double airTempInput = trackBarAirTemp.Value;

            double result = MamdaniMethod(soilMoistureInput, sunlightInput, airTempInput);
            UpdateOutputDisplay("Mamdani Method", soilMoistureInput, sunlightInput, airTempInput, result);
        }

        private void UpdateOutputDisplay(string methodName, double soil, double sun, double temp, double outputVal)
        {
            // Update Watering Indicator (Slow, Medium, High)
            string wateringStatus;
            Color statusColor;

            if (outputVal < 35.0)
            {
                wateringStatus = "SLOW (Gentle Watering)";
                statusColor = Color.DarkSeaGreen;
            }
            else if (outputVal <= 65.0)
            {
                wateringStatus = "MEDIUM (Standard Watering)";
                statusColor = Color.DarkOrange;
            }
            else
            {
                wateringStatus = "HIGH (Heavy Watering)";
                statusColor = Color.Firebrick;
            }

            lblWateringStatus.Text = wateringStatus;
            lblWateringStatus.ForeColor = statusColor;
            lblCrispVal.Text = $"Irrigation Output: {outputVal:F2} %";

            // Update Progress Bar
            int progressVal = (int)Math.Round(Math.Max(0.0, Math.Min(100.0, outputVal)));
            progressBarWatering.Value = progressVal;

            // Update Text Details
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"=== {methodName.ToUpper()} RESULTS ===");
            sb.AppendLine($"Timestamp: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            sb.AppendLine();
            sb.AppendLine("INPUT SENSORS:");
            sb.AppendLine($" • Soil Moisture  : {soil:F1}% -> {lblSoilClass.Text}");
            sb.AppendLine($" • Sunlight       : {sun:F1} lx -> {lblSunClass.Text}");
            sb.AppendLine($" • Air Temperature: {temp:F1} °C -> {lblTempClass.Text}");
            sb.AppendLine();
            sb.AppendLine("OUTPUT RECOMMENDATION:");
            sb.AppendLine($" • Plant Watering : {wateringStatus}");
            sb.AppendLine($" • Crisp Output   : {outputVal:F2}%");
            sb.AppendLine("========================================");

            richTextBoxOuput.Text = sb.ToString();
        }
    }
}
