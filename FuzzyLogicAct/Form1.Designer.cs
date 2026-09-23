namespace FuzzyLogicAct
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxInputs = new System.Windows.Forms.GroupBox();
            this.labelSoilTitle = new System.Windows.Forms.Label();
            this.trackBarSoilMoisture = new System.Windows.Forms.TrackBar();
            this.lblSoilVal = new System.Windows.Forms.Label();
            this.lblSoilClass = new System.Windows.Forms.Label();
            this.labelSunTitle = new System.Windows.Forms.Label();
            this.trackBarSunlight = new System.Windows.Forms.TrackBar();
            this.lblSunVal = new System.Windows.Forms.Label();
            this.lblSunClass = new System.Windows.Forms.Label();
            this.labelTempTitle = new System.Windows.Forms.Label();
            this.trackBarAirTemp = new System.Windows.Forms.TrackBar();
            this.lblTempVal = new System.Windows.Forms.Label();
            this.lblTempClass = new System.Windows.Forms.Label();
            this.groupBoxMethod = new System.Windows.Forms.GroupBox();
            this.btnSugeno = new System.Windows.Forms.Button();
            this.btnMamdani = new System.Windows.Forms.Button();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.labelIndicatorHeader = new System.Windows.Forms.Label();
            this.lblWateringStatus = new System.Windows.Forms.Label();
            this.lblCrispVal = new System.Windows.Forms.Label();
            this.progressBarWatering = new System.Windows.Forms.ProgressBar();
            this.labelLog = new System.Windows.Forms.Label();
            this.richTextBoxOuput = new System.Windows.Forms.RichTextBox();
            this.pictureBoxSunflower = new System.Windows.Forms.PictureBox();
            this.groupBoxInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSoilMoisture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSunlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAirTemp)).BeginInit();
            this.groupBoxMethod.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSunflower)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInputs
            // 
            this.groupBoxInputs.Controls.Add(this.labelSoilTitle);
            this.groupBoxInputs.Controls.Add(this.trackBarSoilMoisture);
            this.groupBoxInputs.Controls.Add(this.lblSoilVal);
            this.groupBoxInputs.Controls.Add(this.lblSoilClass);
            this.groupBoxInputs.Controls.Add(this.labelSunTitle);
            this.groupBoxInputs.Controls.Add(this.trackBarSunlight);
            this.groupBoxInputs.Controls.Add(this.lblSunVal);
            this.groupBoxInputs.Controls.Add(this.lblSunClass);
            this.groupBoxInputs.Controls.Add(this.labelTempTitle);
            this.groupBoxInputs.Controls.Add(this.trackBarAirTemp);
            this.groupBoxInputs.Controls.Add(this.lblTempVal);
            this.groupBoxInputs.Controls.Add(this.lblTempClass);
            this.groupBoxInputs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInputs.Location = new System.Drawing.Point(16, 16);
            this.groupBoxInputs.Name = "groupBoxInputs";
            this.groupBoxInputs.Size = new System.Drawing.Size(380, 310);
            this.groupBoxInputs.TabIndex = 0;
            this.groupBoxInputs.TabStop = false;
            this.groupBoxInputs.Text = "Environmental Sensor Inputs";
            // 
            // labelSoilTitle
            // 
            this.labelSoilTitle.AutoSize = true;
            this.labelSoilTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoilTitle.Location = new System.Drawing.Point(15, 30);
            this.labelSoilTitle.Name = "labelSoilTitle";
            this.labelSoilTitle.Size = new System.Drawing.Size(126, 15);
            this.labelSoilTitle.TabIndex = 0;
            this.labelSoilTitle.Text = "Soil Moisture (0 - 40%)";
            // 
            // trackBarSoilMoisture
            // 
            this.trackBarSoilMoisture.Location = new System.Drawing.Point(15, 50);
            this.trackBarSoilMoisture.Maximum = 40;
            this.trackBarSoilMoisture.Name = "trackBarSoilMoisture";
            this.trackBarSoilMoisture.Size = new System.Drawing.Size(250, 45);
            this.trackBarSoilMoisture.TabIndex = 1;
            this.trackBarSoilMoisture.TickFrequency = 5;
            this.trackBarSoilMoisture.Value = 20;
            this.trackBarSoilMoisture.Scroll += new System.EventHandler(this.trackBarSoilMoisture_Scroll);
            // 
            // lblSoilVal
            // 
            this.lblSoilVal.AutoSize = true;
            this.lblSoilVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoilVal.Location = new System.Drawing.Point(275, 52);
            this.lblSoilVal.Name = "lblSoilVal";
            this.lblSoilVal.Size = new System.Drawing.Size(34, 15);
            this.lblSoilVal.TabIndex = 2;
            this.lblSoilVal.Text = "20 %";
            // 
            // lblSoilClass
            // 
            this.lblSoilClass.AutoSize = true;
            this.lblSoilClass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoilClass.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSoilClass.Location = new System.Drawing.Point(275, 72);
            this.lblSoilClass.Name = "lblSoilClass";
            this.lblSoilClass.Size = new System.Drawing.Size(95, 13);
            this.lblSoilClass.TabIndex = 3;
            this.lblSoilClass.Text = "[Medium / Optimal]";
            // 
            // labelSunTitle
            // 
            this.labelSunTitle.AutoSize = true;
            this.labelSunTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunTitle.Location = new System.Drawing.Point(15, 115);
            this.labelSunTitle.Name = "labelSunTitle";
            this.labelSunTitle.Size = new System.Drawing.Size(161, 15);
            this.labelSunTitle.TabIndex = 4;
            this.labelSunTitle.Text = "Sunlight Intensity (0 - 100 lx)";
            // 
            // trackBarSunlight
            // 
            this.trackBarSunlight.Location = new System.Drawing.Point(15, 135);
            this.trackBarSunlight.Maximum = 100;
            this.trackBarSunlight.Name = "trackBarSunlight";
            this.trackBarSunlight.Size = new System.Drawing.Size(250, 45);
            this.trackBarSunlight.TabIndex = 5;
            this.trackBarSunlight.TickFrequency = 10;
            this.trackBarSunlight.Value = 50;
            this.trackBarSunlight.Scroll += new System.EventHandler(this.trackBarSunlight_Scroll);
            // 
            // lblSunVal
            // 
            this.lblSunVal.AutoSize = true;
            this.lblSunVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunVal.Location = new System.Drawing.Point(275, 137);
            this.lblSunVal.Name = "lblSunVal";
            this.lblSunVal.Size = new System.Drawing.Size(21, 15);
            this.lblSunVal.TabIndex = 6;
            this.lblSunVal.Text = "50";
            // 
            // lblSunClass
            // 
            this.lblSunClass.AutoSize = true;
            this.lblSunClass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunClass.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblSunClass.Location = new System.Drawing.Point(275, 157);
            this.lblSunClass.Name = "lblSunClass";
            this.lblSunClass.Size = new System.Drawing.Size(102, 13);
            this.lblSunClass.TabIndex = 7;
            this.lblSunClass.Text = "[Medium / Moderate]";
            // 
            // labelTempTitle
            // 
            this.labelTempTitle.AutoSize = true;
            this.labelTempTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempTitle.Location = new System.Drawing.Point(15, 205);
            this.labelTempTitle.Name = "labelTempTitle";
            this.labelTempTitle.Size = new System.Drawing.Size(155, 15);
            this.labelTempTitle.TabIndex = 8;
            this.labelTempTitle.Text = "Air Temperature (0 - 50 °C)";
            // 
            // trackBarAirTemp
            // 
            this.trackBarAirTemp.Location = new System.Drawing.Point(15, 225);
            this.trackBarAirTemp.Maximum = 50;
            this.trackBarAirTemp.Name = "trackBarAirTemp";
            this.trackBarAirTemp.Size = new System.Drawing.Size(250, 45);
            this.trackBarAirTemp.TabIndex = 9;
            this.trackBarAirTemp.TickFrequency = 5;
            this.trackBarAirTemp.Value = 25;
            this.trackBarAirTemp.Scroll += new System.EventHandler(this.trackBarAirTemp_Scroll);
            // 
            // lblTempVal
            // 
            this.lblTempVal.AutoSize = true;
            this.lblTempVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempVal.Location = new System.Drawing.Point(275, 227);
            this.lblTempVal.Name = "lblTempVal";
            this.lblTempVal.Size = new System.Drawing.Size(37, 15);
            this.lblTempVal.TabIndex = 10;
            this.lblTempVal.Text = "25 °C";
            // 
            // lblTempClass
            // 
            this.lblTempClass.AutoSize = true;
            this.lblTempClass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempClass.ForeColor = System.Drawing.Color.Teal;
            this.lblTempClass.Location = new System.Drawing.Point(275, 247);
            this.lblTempClass.Name = "lblTempClass";
            this.lblTempClass.Size = new System.Drawing.Size(91, 13);
            this.lblTempClass.TabIndex = 11;
            this.lblTempClass.Text = "[Medium / Normal]";
            // 
            // groupBoxMethod
            // 
            this.groupBoxMethod.Controls.Add(this.btnSugeno);
            //this.groupBoxMethod.Controls.Add(this.btnMamdani);
            this.groupBoxMethod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMethod.Location = new System.Drawing.Point(16, 335);
            this.groupBoxMethod.Name = "groupBoxMethod";
            this.groupBoxMethod.Size = new System.Drawing.Size(380, 85);
            this.groupBoxMethod.TabIndex = 1;
            this.groupBoxMethod.TabStop = false;
            this.groupBoxMethod.Text = "Fuzzy Inference Method";
            // 
            // btnSugeno
            // 
            this.btnSugeno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSugeno.Location = new System.Drawing.Point(25, 28);
            this.btnSugeno.Name = "btnSugeno";
            this.btnSugeno.Size = new System.Drawing.Size(145, 38);
            this.btnSugeno.TabIndex = 0;
            this.btnSugeno.Text = "Calculate Sugeno";
            this.btnSugeno.UseVisualStyleBackColor = true;
            this.btnSugeno.Click += new System.EventHandler(this.btnSugeno_Click);
            // 
            // btnMamdani
            // 
            this.btnMamdani.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMamdani.Location = new System.Drawing.Point(205, 28);
            this.btnMamdani.Name = "btnMamdani";
            this.btnMamdani.Size = new System.Drawing.Size(145, 38);
            this.btnMamdani.TabIndex = 1;
            this.btnMamdani.Text = "Calculate Mamdani";
            this.btnMamdani.UseVisualStyleBackColor = true;
            this.btnMamdani.Click += new System.EventHandler(this.btnMamdani_Click);
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.labelIndicatorHeader);
            this.groupBoxOutput.Controls.Add(this.lblWateringStatus);
            this.groupBoxOutput.Controls.Add(this.lblCrispVal);
            this.groupBoxOutput.Controls.Add(this.progressBarWatering);
            this.groupBoxOutput.Controls.Add(this.labelLog);
            this.groupBoxOutput.Controls.Add(this.richTextBoxOuput);
            this.groupBoxOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOutput.Location = new System.Drawing.Point(415, 16);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(395, 404);
            this.groupBoxOutput.TabIndex = 2;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Irrigation System Output";
            // 
            // labelIndicatorHeader
            // 
            this.labelIndicatorHeader.AutoSize = true;
            this.labelIndicatorHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndicatorHeader.Location = new System.Drawing.Point(15, 28);
            this.labelIndicatorHeader.Name = "labelIndicatorHeader";
            this.labelIndicatorHeader.Size = new System.Drawing.Size(142, 15);
            this.labelIndicatorHeader.TabIndex = 0;
            this.labelIndicatorHeader.Text = "Watering Recommendation:";
            // 
            // lblWateringStatus
            // 
            this.lblWateringStatus.AutoSize = true;
            this.lblWateringStatus.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWateringStatus.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblWateringStatus.Location = new System.Drawing.Point(15, 48);
            this.lblWateringStatus.Name = "lblWateringStatus";
            this.lblWateringStatus.Size = new System.Drawing.Size(155, 25);
            this.lblWateringStatus.TabIndex = 1;
            this.lblWateringStatus.Text = "Awaiting input...";
            // 
            // lblCrispVal
            // 
            this.lblCrispVal.AutoSize = true;
            this.lblCrispVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrispVal.Location = new System.Drawing.Point(15, 82);
            this.lblCrispVal.Name = "lblCrispVal";
            this.lblCrispVal.Size = new System.Drawing.Size(142, 15);
            this.lblCrispVal.TabIndex = 2;
            this.lblCrispVal.Text = "Irrigation Output: 0.00 %";
            // 
            // progressBarWatering
            // 
            this.progressBarWatering.Location = new System.Drawing.Point(18, 103);
            this.progressBarWatering.Name = "progressBarWatering";
            this.progressBarWatering.Size = new System.Drawing.Size(360, 22);
            this.progressBarWatering.TabIndex = 3;
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLog.Location = new System.Drawing.Point(15, 137);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(94, 15);
            this.labelLog.TabIndex = 4;
            this.labelLog.Text = "Inference Details:";
            // 
            // richTextBoxOuput
            // 
            this.richTextBoxOuput.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxOuput.Font = new System.Drawing.Font("Consolas", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxOuput.Location = new System.Drawing.Point(18, 158);
            this.richTextBoxOuput.Name = "richTextBoxOuput";
            this.richTextBoxOuput.ReadOnly = true;
            this.richTextBoxOuput.Size = new System.Drawing.Size(360, 230);
            this.richTextBoxOuput.TabIndex = 5;
            this.richTextBoxOuput.Text = "";
            // 
            // pictureBoxSunflower
            // 
            this.pictureBoxSunflower.Location = new System.Drawing.Point(825, 290);
            this.pictureBoxSunflower.Name = "pictureBoxSunflower";
            this.pictureBoxSunflower.Size = new System.Drawing.Size(130, 130);
            this.pictureBoxSunflower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSunflower.TabIndex = 3;
            this.pictureBoxSunflower.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 436);
            this.Controls.Add(this.pictureBoxSunflower);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxMethod);
            this.Controls.Add(this.groupBoxInputs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automated Greenhouse Irrigation System - Fuzzy Logic Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxInputs.ResumeLayout(false);
            this.groupBoxInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSoilMoisture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSunlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAirTemp)).EndInit();
            this.groupBoxMethod.ResumeLayout(false);
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSunflower)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInputs;
        private System.Windows.Forms.Label labelSoilTitle;
        private System.Windows.Forms.TrackBar trackBarSoilMoisture;
        private System.Windows.Forms.Label lblSoilVal;
        private System.Windows.Forms.Label lblSoilClass;

        private System.Windows.Forms.Label labelSunTitle;
        private System.Windows.Forms.TrackBar trackBarSunlight;
        private System.Windows.Forms.Label lblSunVal;
        private System.Windows.Forms.Label lblSunClass;

        private System.Windows.Forms.Label labelTempTitle;
        private System.Windows.Forms.TrackBar trackBarAirTemp;
        private System.Windows.Forms.Label lblTempVal;
        private System.Windows.Forms.Label lblTempClass;

        private System.Windows.Forms.GroupBox groupBoxMethod;
        private System.Windows.Forms.Button btnSugeno;
        private System.Windows.Forms.Button btnMamdani;

        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Label labelIndicatorHeader;
        private System.Windows.Forms.Label lblWateringStatus;
        private System.Windows.Forms.Label lblCrispVal;
        private System.Windows.Forms.ProgressBar progressBarWatering;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.RichTextBox richTextBoxOuput;
        private System.Windows.Forms.PictureBox pictureBoxSunflower;
    }
}

