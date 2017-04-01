using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projections_Lab
{
    public partial class Form1 : Form
    {
        //storing the utility pole
        public Vector3D utilityPole = new Vector3D();
        //tallies up the total trip in one vector
        public Vector3D totalTravel = new Vector3D();
        //pulls input from the form to add to the total travel
        public Vector3D currentTravel = new Vector3D();
        //holds vector displaying how to get to the end of the utility pole
        public Vector3D endTrip = new Vector3D();
        //vector to store where the closest point
        public Vector3D closestPoint = new Vector3D();

        public int legOfJourney = 0;
        public Form1()
        {
            InitializeComponent();
        }

        //utility pole button
        private void button1_Click(object sender, EventArgs e)
        {
            utilityPole.SetRectGivenMagHeadPitch(Convert.ToDouble(utilityMagInput.Text),
                                                    Convert.ToDouble(utilityHeadInput.Text),
                                                    Convert.ToDouble(utilityPitchInput.Text));
            SetUtility(false);
            legOfJourney = 1;
            JourneyText.Text = "Leg " + legOfJourney + " of Journey";

            TravelButton.Enabled = true;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            //re initialize the utility buttons
            SetUtility(true);

            //reset all of the vectors
            utilityPole = new Vector3D();
            totalTravel = new Vector3D();
            currentTravel = new Vector3D();
            endTrip = new Vector3D();
            closestPoint = new Vector3D();

            legOfJourney = 0;

            TravelButton.Enabled = false;

            totalTripText.Text = String.Empty;
            ShortestDistText.Text = String.Empty;
            EndTripText.Text = String.Empty;
        }

        void SetUtility(bool util)
        {
            UtilityButton.Enabled = util;
            utilityMagInput.Enabled = util;
            utilityHeadInput.Enabled = util;
            utilityPitchInput.Enabled = util;
        }

        /// <summary>
        /// this is the button for traveling legs of the journey
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            legOfJourney++;
            JourneyText.Text = "Leg " + legOfJourney + " of Journey";
            currentTravel.SetRectGivenMagHeadPitch(Convert.ToDouble(JourneyMagInput.Text),
                                                   Convert.ToDouble(JourneyHeadInput.Text),
                                                   Convert.ToDouble(JourneyPitchInput.Text));
            totalTravel = totalTravel + currentTravel;
            totalTripText.Text = "Current Location: " + totalTravel.PrintMagHeadPitch();
            //calc shortest distance
            closestPoint = totalTravel > utilityPole;
            ShortestDistText.Text = String.Format("Closest Point: ( {0:F2}, {1:F2}, {2:F2})", closestPoint.GetX(), closestPoint.GetY(), closestPoint.GetZ());
            //calc the travel to the end of the utility pole
            endTrip = utilityPole - totalTravel;
            EndTripText.Text = "To tip of Utility Pole: " + endTrip.PrintMagHeadPitch();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            totalTripText.Text = String.Empty;
            ShortestDistText.Text = String.Empty;
            EndTripText.Text = String.Empty;

            TravelButton.Enabled = false;
        }
    }
}
