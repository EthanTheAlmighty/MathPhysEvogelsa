using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClosestPointsLab
{
    public partial class Form1 : Form
    {
        //variable declaration
        Vector3D shipPos;
        Vector3D meteorPos, meteorDir; //pos and direction of the line
        Vector3D pointA, pointB, pointC; // points on the plane
        // vector3D objects to store the closest point and distance
        //to be able to print them out
        Vector3D closestPoint, closestDistance;
        //same storage as above but for the second part with the plane  
        Vector3D moonClose, moonDistance; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initialize the Vectors so they aren't null objects
            shipPos = new Vector3D();
            meteorPos = new Vector3D();
            meteorDir = new Vector3D();
            pointA = new Vector3D();
            pointB = new Vector3D();
            pointC = new Vector3D();
            closestPoint = new Vector3D();
            closestDistance = new Vector3D();
            moonClose = new Vector3D();
            moonDistance = new Vector3D();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //read in x,y,z for the ship position
            shipPos.SetRectGivenRect(double.Parse(ShipXInput.Text),
                double.Parse(ShipYInput.Text), double.Parse(ShipZInput.Text));
            //x,y,z for the meteor's starting position
            meteorPos.SetRectGivenRect(double.Parse(MeteorStartX.Text),
             double.Parse(MeteorStartY.Text), double.Parse(MeteorStartZ.Text));
            //x,y,z for meteor's direction
            meteorDir.SetRectGivenRect(double.Parse(MeteorDirX.Text),
                double.Parse(MeteorDirY.Text), double.Parse(MeteorDirZ.Text));
            //x,y,z for point A
            pointA.SetRectGivenRect(double.Parse(AXInput.Text), 
                double.Parse(AYInput.Text), double.Parse(AZInput.Text));
            //x,y,z for point B
            pointB.SetRectGivenRect(double.Parse(BXInput.Text),
                double.Parse(BYInput.Text), double.Parse(BZInput.Text));
            //x,y,z for point C
            pointC.SetRectGivenRect(double.Parse(CXInput.Text),
                double.Parse(CYInput.Text), double.Parse(CZInput.Text));

            //get closest point and distance for the ship and meteor
            closestPoint = 
                Vector3D.ClosestPointLine(shipPos, meteorPos, meteorDir);
            closestDistance = 
                Vector3D.LineDistance(shipPos, meteorPos, meteorDir);
            //display point and distance
            ClosestPointMeteorText.Text = closestPoint.PrintRect() + " km";
            DistanceMeteorText.Text = 
                closestDistance.GetMagnitude().ToString("F2") + " km";

            //get closest point and distance for the ship and plane
            moonClose = 
                Vector3D.ClosestPointPlane(pointA, pointB, pointC, shipPos);
            moonDistance = 
                Vector3D.PlaneDistance(pointA, pointB, pointC, shipPos);
            //print closest point and distance
            PlanePointText.Text = moonClose.PrintRect() + " km";
            PlaneDistanceText.Text = 
                moonDistance.GetMagnitude().ToString("F2") + " km";
        }
    }
}
