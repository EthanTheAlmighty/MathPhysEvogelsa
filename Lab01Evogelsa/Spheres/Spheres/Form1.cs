using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spheres
{
    public partial class Form1 : Form
    {
        //var declaration
        public double x1, y1, z1; //the x, y, and z coordinates for sphere 1's center
        public double x2, y2, z2; //the x, y, and z coordinates for sphere 1's center

        public double r1, r2;//the input for radius one and radius for the sphere's

        public double d;//calculated distance between the two centers

        private void button1_Click(object sender, EventArgs e)
        {
            //putting the inputs from the form into the variables
            Double.TryParse(x1Input.Text, out x1);
            Double.TryParse(y1Input.Text, out y1);
            Double.TryParse(z1Input.Text, out z1);
            Double.TryParse(x2Input.Text, out x2);
            Double.TryParse(y2Input.Text, out y2);
            Double.TryParse(z2Input.Text, out z2);
            Double.TryParse(r1Input.Text, out r1);
            Double.TryParse(r2Input.Text, out r2);

            //calculate distance
            d = CalcDistance(x1, y1, z1, x2, y2, z2);

            //checks if there is a collision or not and outputs that to a label under the calculate button
            OutputField.Text = ((r1 + r2) >= d) ? "Collision" : "No Collision";
        }

        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        /// <summary>
        /// CalcDistance gets the 2 centers of the spheres and returns the distance between the two
        /// </summary>
        /// <param name="c1">x1</param>
        /// <param name="c2">y1</param>
        /// <param name="c3">z1</param>
        /// <param name="c4">x2</param>
        /// <param name="c5">y2</param>
        /// <param name="c6">z2</param>
        /// <returns>returns the distance between spheres</returns>
        public double CalcDistance(double c1, double c2, double c3, double c4, double c5, double c6)
        {
            return Math.Sqrt(Math.Pow(c4 - c1, 2) + Math.Pow(c5 - c2, 2) + Math.Pow(c6 - c3, 2));
        }
    }
}
