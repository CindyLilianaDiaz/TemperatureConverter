namespace TemperatureConverter
{
    partial class temperatureConverterForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(temperatureConverterForm));
            this.inputTemperatureGroupBox = new System.Windows.Forms.GroupBox();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.degreesLabel1 = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.converToGoupBox = new System.Windows.Forms.GroupBox();
            this.fahrenheitRadioButton = new System.Windows.Forms.RadioButton();
            this.celsiusRadioButton = new System.Windows.Forms.RadioButton();
            this.outputTemperatureGroupBox = new System.Windows.Forms.GroupBox();
            this.temperatureFahrenheitTextBox = new System.Windows.Forms.TextBox();
            this.temperatureCelsiusTextBox = new System.Windows.Forms.TextBox();
            this.degreesLabel3 = new System.Windows.Forms.Label();
            this.degreesLabel2 = new System.Windows.Forms.Label();
            this.temperatureFahrenheitLabel = new System.Windows.Forms.Label();
            this.temperatureCelsiusLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.messageToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.inputTemperatureGroupBox.SuspendLayout();
            this.converToGoupBox.SuspendLayout();
            this.outputTemperatureGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTemperatureGroupBox
            // 
            this.inputTemperatureGroupBox.Controls.Add(this.temperatureTextBox);
            this.inputTemperatureGroupBox.Controls.Add(this.degreesLabel1);
            this.inputTemperatureGroupBox.Controls.Add(this.temperatureLabel);
            this.inputTemperatureGroupBox.Location = new System.Drawing.Point(61, 53);
            this.inputTemperatureGroupBox.Name = "inputTemperatureGroupBox";
            this.inputTemperatureGroupBox.Size = new System.Drawing.Size(512, 100);
            this.inputTemperatureGroupBox.TabIndex = 0;
            this.inputTemperatureGroupBox.TabStop = false;
            this.inputTemperatureGroupBox.Text = "Input Temperature";
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.Location = new System.Drawing.Point(183, 39);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(242, 20);
            this.temperatureTextBox.TabIndex = 0;
            this.temperatureTextBox.Text = "0";
            this.messageToolTip.SetToolTip(this.temperatureTextBox, "Please enter the temperature value you wan to convert");
            // 
            // degreesLabel1
            // 
            this.degreesLabel1.AutoSize = true;
            this.degreesLabel1.Location = new System.Drawing.Point(445, 46);
            this.degreesLabel1.Name = "degreesLabel1";
            this.degreesLabel1.Size = new System.Drawing.Size(45, 13);
            this.degreesLabel1.TabIndex = 0;
            this.degreesLabel1.Text = "degrees";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(29, 46);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(70, 13);
            this.temperatureLabel.TabIndex = 0;
            this.temperatureLabel.Text = "Temperature:";
            // 
            // converToGoupBox
            // 
            this.converToGoupBox.Controls.Add(this.fahrenheitRadioButton);
            this.converToGoupBox.Controls.Add(this.celsiusRadioButton);
            this.converToGoupBox.Location = new System.Drawing.Point(61, 205);
            this.converToGoupBox.Name = "converToGoupBox";
            this.converToGoupBox.Size = new System.Drawing.Size(512, 125);
            this.converToGoupBox.TabIndex = 1;
            this.converToGoupBox.TabStop = false;
            this.converToGoupBox.Text = "Conver To";
            // 
            // fahrenheitRadioButton
            // 
            this.fahrenheitRadioButton.AutoSize = true;
            this.fahrenheitRadioButton.Location = new System.Drawing.Point(32, 92);
            this.fahrenheitRadioButton.Name = "fahrenheitRadioButton";
            this.fahrenheitRadioButton.Size = new System.Drawing.Size(75, 17);
            this.fahrenheitRadioButton.TabIndex = 1;
            this.fahrenheitRadioButton.TabStop = true;
            this.fahrenheitRadioButton.Text = "Fahrenheit";
            this.messageToolTip.SetToolTip(this.fahrenheitRadioButton, "Check to convert to Fahrenheit");
            this.fahrenheitRadioButton.UseVisualStyleBackColor = true;
            // 
            // celsiusRadioButton
            // 
            this.celsiusRadioButton.AutoSize = true;
            this.celsiusRadioButton.Location = new System.Drawing.Point(32, 46);
            this.celsiusRadioButton.Name = "celsiusRadioButton";
            this.celsiusRadioButton.Size = new System.Drawing.Size(58, 17);
            this.celsiusRadioButton.TabIndex = 0;
            this.celsiusRadioButton.TabStop = true;
            this.celsiusRadioButton.Text = "Celsius";
            this.messageToolTip.SetToolTip(this.celsiusRadioButton, "Check to convert to celsius");
            this.celsiusRadioButton.UseVisualStyleBackColor = true;
            // 
            // outputTemperatureGroupBox
            // 
            this.outputTemperatureGroupBox.Controls.Add(this.temperatureFahrenheitTextBox);
            this.outputTemperatureGroupBox.Controls.Add(this.temperatureCelsiusTextBox);
            this.outputTemperatureGroupBox.Controls.Add(this.degreesLabel3);
            this.outputTemperatureGroupBox.Controls.Add(this.degreesLabel2);
            this.outputTemperatureGroupBox.Controls.Add(this.temperatureFahrenheitLabel);
            this.outputTemperatureGroupBox.Controls.Add(this.temperatureCelsiusLabel);
            this.outputTemperatureGroupBox.Location = new System.Drawing.Point(61, 376);
            this.outputTemperatureGroupBox.Name = "outputTemperatureGroupBox";
            this.outputTemperatureGroupBox.Size = new System.Drawing.Size(512, 123);
            this.outputTemperatureGroupBox.TabIndex = 2;
            this.outputTemperatureGroupBox.TabStop = false;
            this.outputTemperatureGroupBox.Text = "Output Temperature";
            // 
            // temperatureFahrenheitTextBox
            // 
            this.temperatureFahrenheitTextBox.Enabled = false;
            this.temperatureFahrenheitTextBox.Location = new System.Drawing.Point(183, 86);
            this.temperatureFahrenheitTextBox.Name = "temperatureFahrenheitTextBox";
            this.temperatureFahrenheitTextBox.ReadOnly = true;
            this.temperatureFahrenheitTextBox.Size = new System.Drawing.Size(242, 20);
            this.temperatureFahrenheitTextBox.TabIndex = 1;
            this.temperatureFahrenheitTextBox.TabStop = false;
            // 
            // temperatureCelsiusTextBox
            // 
            this.temperatureCelsiusTextBox.Enabled = false;
            this.temperatureCelsiusTextBox.Location = new System.Drawing.Point(183, 49);
            this.temperatureCelsiusTextBox.Name = "temperatureCelsiusTextBox";
            this.temperatureCelsiusTextBox.ReadOnly = true;
            this.temperatureCelsiusTextBox.Size = new System.Drawing.Size(242, 20);
            this.temperatureCelsiusTextBox.TabIndex = 0;
            this.temperatureCelsiusTextBox.TabStop = false;
            // 
            // degreesLabel3
            // 
            this.degreesLabel3.AutoSize = true;
            this.degreesLabel3.Location = new System.Drawing.Point(445, 93);
            this.degreesLabel3.Name = "degreesLabel3";
            this.degreesLabel3.Size = new System.Drawing.Size(45, 13);
            this.degreesLabel3.TabIndex = 0;
            this.degreesLabel3.Text = "degrees";
            // 
            // degreesLabel2
            // 
            this.degreesLabel2.AutoSize = true;
            this.degreesLabel2.Location = new System.Drawing.Point(445, 52);
            this.degreesLabel2.Name = "degreesLabel2";
            this.degreesLabel2.Size = new System.Drawing.Size(45, 13);
            this.degreesLabel2.TabIndex = 0;
            this.degreesLabel2.Text = "degrees";
            // 
            // temperatureFahrenheitLabel
            // 
            this.temperatureFahrenheitLabel.AutoSize = true;
            this.temperatureFahrenheitLabel.Location = new System.Drawing.Point(29, 93);
            this.temperatureFahrenheitLabel.Name = "temperatureFahrenheitLabel";
            this.temperatureFahrenheitLabel.Size = new System.Drawing.Size(134, 13);
            this.temperatureFahrenheitLabel.TabIndex = 0;
            this.temperatureFahrenheitLabel.Text = "Temperature in Fahrenheit:";
            // 
            // temperatureCelsiusLabel
            // 
            this.temperatureCelsiusLabel.AutoSize = true;
            this.temperatureCelsiusLabel.Location = new System.Drawing.Point(29, 52);
            this.temperatureCelsiusLabel.Name = "temperatureCelsiusLabel";
            this.temperatureCelsiusLabel.Size = new System.Drawing.Size(117, 13);
            this.temperatureCelsiusLabel.TabIndex = 0;
            this.temperatureCelsiusLabel.Text = "Temperature in Celsius:";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(61, 542);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "&Convert";
            this.messageToolTip.SetToolTip(this.convertButton, "Click to convert temperature");
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetButton.Location = new System.Drawing.Point(284, 542);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "&Reset";
            this.messageToolTip.SetToolTip(this.resetButton, "Click to clear all the form and return it to its default state");
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(498, 542);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "&Exit";
            this.messageToolTip.SetToolTip(this.exitButton, "Click to exit Temperature Converter application");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // temperatureConverterForm
            // 
            this.AcceptButton = this.convertButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.resetButton;
            this.ClientSize = new System.Drawing.Size(643, 587);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputTemperatureGroupBox);
            this.Controls.Add(this.converToGoupBox);
            this.Controls.Add(this.inputTemperatureGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "temperatureConverterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Converter";
            this.inputTemperatureGroupBox.ResumeLayout(false);
            this.inputTemperatureGroupBox.PerformLayout();
            this.converToGoupBox.ResumeLayout(false);
            this.converToGoupBox.PerformLayout();
            this.outputTemperatureGroupBox.ResumeLayout(false);
            this.outputTemperatureGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputTemperatureGroupBox;
        private System.Windows.Forms.Label degreesLabel1;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.GroupBox converToGoupBox;
        private System.Windows.Forms.GroupBox outputTemperatureGroupBox;
        private System.Windows.Forms.Label temperatureFahrenheitLabel;
        private System.Windows.Forms.Label temperatureCelsiusLabel;
        private System.Windows.Forms.Label degreesLabel3;
        private System.Windows.Forms.Label degreesLabel2;
        private System.Windows.Forms.RadioButton fahrenheitRadioButton;
        private System.Windows.Forms.RadioButton celsiusRadioButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox temperatureTextBox;
        private System.Windows.Forms.TextBox temperatureFahrenheitTextBox;
        private System.Windows.Forms.TextBox temperatureCelsiusTextBox;
        private System.Windows.Forms.ToolTip messageToolTip;
    }
}

