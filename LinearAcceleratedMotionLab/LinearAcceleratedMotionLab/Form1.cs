using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LinearAcceleratedMotionLab
{
    public partial class Form1 : Form
    {
        private double acceleration = -9.8f;
        //timer to control how often we're doing FEM
        private double height;
        private double velocity;
        public double deltaT;
        public double time;
        public bool wind = false;
        private StringBuilder csvInput;
        private string csvPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            csvInput = new StringBuilder();
        }

        private void InitTimer()
        {
            timer2 = new Timer();
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Interval = (int)(deltaT * 1000); // in miliseconds
            timer2.Start();
        }

        private void WriteCSV()
        {
            File.AppendAllText(csvPath, csvInput.ToString());
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            //make the button unclickable so the computer can process the event
            CalcButton.Enabled = false;
            AnalyticButton.Enabled = false;
            WindButton.Enabled = false;
            WritingLabel.Text = String.Empty;
            //clear what's going to go into the csv
            csvInput.Clear();
            //start total time at 0
            time = 0.0;

            //start the csv with the time and position
            csvInput.AppendLine("Position, Time");

            height = Convert.ToDouble(HeightInput.Text);
            velocity = Convert.ToDouble(VelocityInput.Text);
            deltaT = Convert.ToDouble(DeltaTInput.Text);
            //set the path for the file depending on how small the delta T is
            csvPath = @"..\ex02_euler_" + DeltaTInput.Text.Replace(".", "-") + ".csv";
            InitTimer();
        }


        //produces a csv using the analytics given to us and assumes a 
        private void AnalyticButton_Click(object sender, EventArgs e)
        {
            //make the button unclickable so the computer can process the event
            CalcButton.Enabled = false;
            AnalyticButton.Enabled = false;
            WindButton.Enabled = false;
            WritingLabel.Text = String.Empty;

            //clear what's going to go into the csv
            csvInput.Clear();
            //start total time at 0
            time = 0.0;

            //pull in the vars from the form
            height = Convert.ToDouble(HeightInput.Text);
            velocity = Convert.ToDouble(VelocityInput.Text);
            deltaT = Convert.ToDouble(DeltaTInput.Text);

            //start the csv with the time and position
            csvInput.AppendLine("Position, Time");

            //set file path
            csvPath = @"..\ex02_analytic.csv";

            while (height > 0)
            {
                time += deltaT;

                //x = vi * Δt - 4.9 * (Δt^2)
                height = velocity * time - (4.9 * time * time);
                
                //write this round to the csv
                string temp = String.Format("{0:F2},{1:F2}", height, time);
                csvInput.AppendLine(temp);
            }

            if (height <= 0)
            {
                WriteCSV();
            }
        }

        private void WindButton_Click(object sender, EventArgs e)
        {
            //make the button unclickable so the computer can process the event
            CalcButton.Enabled = false;
            AnalyticButton.Enabled = false;
            WindButton.Enabled = false;
            WritingLabel.Text = String.Empty;

            //clear what's going to go into the csv
            csvInput.Clear();
            //start total time at 0
            time = 0.0;

            //start the csv with the time and position
            csvInput.AppendLine("Position, Time");

            height = Convert.ToDouble(HeightInput.Text);
            velocity = Convert.ToDouble(VelocityInput.Text);
            deltaT = Convert.ToDouble(DeltaTInput.Text);

            wind = true;

            csvPath = @"..\ex02_wind.csv";
            InitTimer();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //stop the times if height has reach zero
            if (height <= 0)
            {
                timer2.Stop();
                WriteCSV();
                WritingLabel.Text = "File Written";
                CalcButton.Enabled = true;
                AnalyticButton.Enabled = true;
                WindButton.Enabled = true;
                wind = false;
            }

            //set what the current time is
            time += deltaT;
            //update position, using old V
            height += velocity * deltaT;
            //update V, using old a
            velocity += acceleration * deltaT;
            //update a
            if(wind)
            {
                acceleration = -9.8 - 0.1 * velocity;
            }

            //write this round to the csv
            string temp = String.Format("{0:F2},{1:F2}", height, time);
            csvInput.AppendLine(temp);
        }
    }
}
