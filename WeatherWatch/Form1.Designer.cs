namespace WeatherWatch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            locationText = new TextBox();
            locationLabel = new Label();
            confirmLocationEntry = new Button();
            temperature = new Label();
            currentLocation = new Label();
            weather = new Label();
            weatherDesc = new Label();
            weatherImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)weatherImage).BeginInit();
            SuspendLayout();
            // 
            // locationText
            // 
            locationText.Location = new Point(111, 26);
            locationText.Name = "locationText";
            locationText.Size = new Size(100, 23);
            locationText.TabIndex = 0;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new Point(24, 29);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(86, 15);
            locationLabel.TabIndex = 1;
            locationLabel.Text = "Enter Location:";
            // 
            // confirmLocationEntry
            // 
            confirmLocationEntry.Location = new Point(217, 25);
            confirmLocationEntry.Name = "confirmLocationEntry";
            confirmLocationEntry.Size = new Size(75, 23);
            confirmLocationEntry.TabIndex = 2;
            confirmLocationEntry.Text = "Go!";
            confirmLocationEntry.UseVisualStyleBackColor = true;
            confirmLocationEntry.Click += confirmLocationEntry_Click;
            // 
            // temperature
            // 
            temperature.AutoSize = true;
            temperature.Location = new Point(24, 109);
            temperature.Name = "temperature";
            temperature.Size = new Size(79, 15);
            temperature.TabIndex = 3;
            temperature.Text = "Temperature: ";
            // 
            // currentLocation
            // 
            currentLocation.AutoSize = true;
            currentLocation.Location = new Point(24, 79);
            currentLocation.Name = "currentLocation";
            currentLocation.Size = new Size(102, 15);
            currentLocation.TabIndex = 4;
            currentLocation.Text = "Current Location: ";
            // 
            // weather
            // 
            weather.AutoSize = true;
            weather.Location = new Point(24, 140);
            weather.Name = "weather";
            weather.Size = new Size(54, 15);
            weather.TabIndex = 5;
            weather.Text = "Weather:";
            // 
            // weatherDesc
            // 
            weatherDesc.AutoSize = true;
            weatherDesc.Location = new Point(24, 170);
            weatherDesc.Name = "weatherDesc";
            weatherDesc.Size = new Size(70, 15);
            weatherDesc.TabIndex = 6;
            weatherDesc.Text = "Description:";
            // 
            // weatherImage
            // 
            weatherImage.BackColor = SystemColors.ActiveBorder;
            weatherImage.BorderStyle = BorderStyle.Fixed3D;
            weatherImage.Location = new Point(242, 79);
            weatherImage.Name = "weatherImage";
            weatherImage.Size = new Size(106, 106);
            weatherImage.TabIndex = 7;
            weatherImage.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 217);
            Controls.Add(weatherImage);
            Controls.Add(weatherDesc);
            Controls.Add(weather);
            Controls.Add(currentLocation);
            Controls.Add(temperature);
            Controls.Add(confirmLocationEntry);
            Controls.Add(locationLabel);
            Controls.Add(locationText);
            Name = "Form1";
            Text = "WeatherWatch";
            ((System.ComponentModel.ISupportInitialize)weatherImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox locationText;
        private Label locationLabel;
        private Button confirmLocationEntry;
        private Label temperature;
        private Label currentLocation;
        private Label weather;
        private Label weatherDesc;
        private PictureBox weatherImage;
    }
}
