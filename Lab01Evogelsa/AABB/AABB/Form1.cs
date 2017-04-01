using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AABB
{   
    public partial class Form1 : Form
    {
        //variable declaration
        //x, y, z of vertex 1 of box 1
        public double x1, y1, z1;
        //x, y, z of vertex 2 of box 1
        public double x2, y2, z2;
        //x, y, z of vertex 1 of box 2
        public double x3, y3, z3;
        //x, y, z of vertex 2 of box 2
        public double x4, y4, z4;

        //boxes to store all of the coordinate data
        public Box box1, box2;

        //a boolean so my methods can kick out a true or false early
        public bool col;
        

        /// <summary>
        /// The reset button clears all of the fields upon being clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            //clear inputs
            x1Input.Text = String.Empty;
            y1Input.Text = String.Empty;
            z1Input.Text = String.Empty;
            x2Input.Text = String.Empty;
            y2Input.Text = String.Empty;
            z2Input.Text = String.Empty;
            x3Input.Text = String.Empty;
            y3Input.Text = String.Empty;
            z3Input.Text = String.Empty;
            x4Input.Text = String.Empty;
            y4Input.Text = String.Empty;
            z4Input.Text = String.Empty;

            //clear label field declaring a collision
            CollisionLabel.Text = String.Empty;
        }

        /// <summary>
        /// upon being clicked, it pulls the inputs into the correct variables and then calls methods to test if there is collision
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalcButton_Click(object sender, EventArgs e)
        {
            //gather inputs from the form into the vars
            Double.TryParse(x1Input.Text, out x1);
            Double.TryParse(y1Input.Text, out y1);
            Double.TryParse(x2Input.Text, out x2);
            Double.TryParse(y2Input.Text, out y2);
            Double.TryParse(x3Input.Text, out x3);
            Double.TryParse(y3Input.Text, out y3);
            Double.TryParse(x4Input.Text, out x4);
            Double.TryParse(y4Input.Text, out y4);

            //retrieve the z's if it's 3d
            if (threeDimensionCheck.Checked)
            {
                Double.TryParse(z1Input.Text, out z1);
                Double.TryParse(z2Input.Text, out z2);
                Double.TryParse(z3Input.Text, out z3);
                Double.TryParse(z4Input.Text, out z4);

                //creating boxes from the fields
                box1 = new Box(x1, x2, y1, y1, z1, z2);
                box2 = new Box(x3, x4, y3, y4, z3, z4);
            }
            else
            {
                box1 = new Box(x1, x2, y1, y1);
                box2 = new Box(x3, x4, y3, y4);
            }

            //runs one of the two calculate methods depending on if we're in 2D or 3D
            col = threeDimensionCheck.Checked ? ThreeDimensionCollision(box1, box2) : TwoDimensionCollision(box1, box2);

            //setting the text if it's a collision or not
            CollisionLabel.Text = col ? "Collision" : "No Collision";
        }

        /// <summary>
        /// ThreeDimensionCollision checks to see if the two boxes are colliding if it's in 3d and then outputs to a label
        /// whether or not there is collision
        /// </summary>
        public bool ThreeDimensionCollision(Box b1, Box b2)
        {
            //start with the X check
            if (b1.XRadius + b2.XRadius < Math.Sqrt((b1.XCenter - b2.XCenter) * (b1.XCenter - b2.XCenter)))
                return false;
            //since X collides, check Y
            else if (b1.YRadius + b2.YRadius < Math.Sqrt((b1.YCenter - b2.YCenter) * (b1.YCenter - b2.YCenter)))
                return false;
            //since Y collides, check Z
            else if (b1.ZRadius + b2.ZRadius < Math.Sqrt((b1.ZCenter - b2.ZCenter) * (b1.ZCenter - b2.ZCenter)))
                return false;
            //none collide
            else
                return true;
        }

        /// <summary>
        /// TwoDimensionCollision does the same as above however this is the case if it's just in 2D
        /// </summary>
        public bool TwoDimensionCollision(Box b1, Box b2)
        {
            //start with the X check
            if (b1.XRadius + b2.XRadius < Math.Sqrt((b1.XCenter - b2.XCenter) * (b1.XCenter - b2.XCenter)))
                return false;
            //since X collides, check Y
            else if (b1.YRadius + b2.YRadius < Math.Sqrt((b1.YCenter - b2.YCenter) * (b1.YCenter - b2.YCenter)))
                return false;
            else
                return true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void threeDimensionCheck_CheckedChanged(object sender, EventArgs e)
        {
            //if 3d isn't checked disable z
            if(!threeDimensionCheck.Checked)
                ThreeDimSwitcher(false);
            //if 3d is checked enable z
            else if (threeDimensionCheck.Checked)
                ThreeDimSwitcher(true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //starting the form out with Z disabled because it defaults to 2D
            ThreeDimSwitcher(false);
        }

        //method used to either show or hide the Z axis inputs
        public void ThreeDimSwitcher(bool switcheroo)
        {
            z1Label.Enabled = switcheroo;
            z1Input.Enabled = switcheroo;
            z2Label.Enabled = switcheroo;
            z2Input.Enabled = switcheroo;
            z3Input.Enabled = switcheroo;
            z3Label.Enabled = switcheroo;
            z4Input.Enabled = switcheroo;
            z4Label.Enabled = switcheroo;
        }

        
    }
}
