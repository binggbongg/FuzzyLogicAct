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
            this.richTextBoxOuput = new System.Windows.Forms.RichTextBox();
            this.btnSugeno = new System.Windows.Forms.Button();
            this.btnMamdani = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSoilMoisture = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSunlight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAirTemp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBoxOuput
            // 
            this.richTextBoxOuput.Enabled = false;
            this.richTextBoxOuput.Location = new System.Drawing.Point(454, 80);
            this.richTextBoxOuput.Name = "richTextBoxOuput";
            this.richTextBoxOuput.Size = new System.Drawing.Size(330, 180);
            this.richTextBoxOuput.TabIndex = 0;
            this.richTextBoxOuput.Text = "";
            this.richTextBoxOuput.TextChanged += new System.EventHandler(this.richTextBoxOuput_TextChanged);
            // 
            // btnSugeno
            // 
            this.btnSugeno.Location = new System.Drawing.Point(14, 220);
            this.btnSugeno.Name = "btnSugeno";
            this.btnSugeno.Size = new System.Drawing.Size(98, 40);
            this.btnSugeno.TabIndex = 1;
            this.btnSugeno.Text = "SUGENO";
            this.btnSugeno.UseVisualStyleBackColor = true;
            this.btnSugeno.Click += new System.EventHandler(this.btnSugeno_Click);
            // 
            // btnMamdani
            // 
            this.btnMamdani.Location = new System.Drawing.Point(171, 220);
            this.btnMamdani.Name = "btnMamdani";
            this.btnMamdani.Size = new System.Drawing.Size(98, 40);
            this.btnMamdani.TabIndex = 2;
            this.btnMamdani.Text = "MAMDANI";
            this.btnMamdani.UseVisualStyleBackColor = true;
            this.btnMamdani.Click += new System.EventHandler(this.btnMamdani_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(585, 50);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(76, 18);
            this.labelOutput.TabIndex = 3;
            this.labelOutput.Text = "OUTPUT";
            this.labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "INPUT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSoilMoisture
            // 
            this.textBoxSoilMoisture.Location = new System.Drawing.Point(118, 80);
            this.textBoxSoilMoisture.Name = "textBoxSoilMoisture";
            this.textBoxSoilMoisture.Size = new System.Drawing.Size(151, 20);
            this.textBoxSoilMoisture.TabIndex = 5;
            this.textBoxSoilMoisture.TextChanged += new System.EventHandler(this.textBoxSoilMoisture_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soil Moisture";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sunlight";
            // 
            // textBoxSunlight
            // 
            this.textBoxSunlight.Location = new System.Drawing.Point(118, 106);
            this.textBoxSunlight.Name = "textBoxSunlight";
            this.textBoxSunlight.Size = new System.Drawing.Size(151, 20);
            this.textBoxSunlight.TabIndex = 8;
            this.textBoxSunlight.TextChanged += new System.EventHandler(this.textBoxSunlight_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "FUZZY LOGIC TYPE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Air Temperature";
            // 
            // textBoxAirTemp
            // 
            this.textBoxAirTemp.Location = new System.Drawing.Point(118, 133);
            this.textBoxAirTemp.Name = "textBoxAirTemp";
            this.textBoxAirTemp.Size = new System.Drawing.Size(151, 20);
            this.textBoxAirTemp.TabIndex = 11;
            this.textBoxAirTemp.TextChanged += new System.EventHandler(this.textBoxAirTemp_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAirTemp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSunlight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSoilMoisture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.btnMamdani);
            this.Controls.Add(this.btnSugeno);
            this.Controls.Add(this.richTextBoxOuput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxOuput;
        private System.Windows.Forms.Button btnSugeno;
        private System.Windows.Forms.Button btnMamdani;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSoilMoisture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSunlight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAirTemp;
    }
}

