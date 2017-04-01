using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LineSegments
{
    public partial class Form1 : Form
    {

        //two line segments
        public LineSegment line1, line2;
        //array of vars to represent the letters in standard form
        public double[] letters;

        //constructor
        private void Form1_Load(object sender, EventArgs e)
        {
            //set the size of the letters array
            letters = new double[6];
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            line1 = new LineSegment(Convert.ToDouble(Input0.Text),   //x1 
                                    Convert.ToDouble(Input1.Text),   //y1
                                    Convert.ToDouble(Input2.Text),   //x2
                                    Convert.ToDouble(Input3.Text));  //y2
            line2 = new LineSegment(Convert.ToDouble(Input4.Text),   //x1 
                                    Convert.ToDouble(Input5.Text),   //y1
                                    Convert.ToDouble(Input6.Text),   //x2
                                    Convert.ToDouble(Input7.Text));  //y2
            CollisionLabel.Text = String.Empty;

            //take the coordinates and turn then into standard form lines
            letters = Standardize(line1, line2);
            
            //use the cross product to determine if there's a possible intersection
            if (Vector2.CrossProduct(line1.Vector, line2.Vector) == 0)
            {
                //need to determine if collinear(zero) or parallel(not zero)
                //checking X numerator with BF-CE
                if (letters[1] * letters[5] - letters[2] * letters[4] != 0)
                {
                    CollisionLabel.Text = "Lines are parallel.";
                }
                else
                {
                    //a quick check with min and maxes to prove if the identical lines
                    //have intersecting segments
                    //if line 2 is to the right
                    if (Math.Max(line1.X1, line1.X2) < Math.Max(line2.X1, line2.X2))
                        CollisionLabel.Text = (Math.Max(line1.X1, line1.X2) > Math.Min(line2.X1, line2.X2)) ? "The lines are identical and collide." : "The lines are identical and do not collide.";
                    //line 1 is to the right
                    else
                        CollisionLabel.Text = (Math.Max(line2.X1, line2.X2) > Math.Min(line1.X1, line1.X2)) ? "The lines are identical and collide." : "The lines are identical and do not collide.";
                }
            }
            //this means the lines are not collinear or parallel
            else
            {
                //get the x and y intercept values
                double tempX, tempY;
                tempX = CalcX();
                tempY = CalcY();
                //check the X and Y intersect if it's on the segments
                if (Math.Min(line1.X1, line1.X2) <= tempX && Math.Max(line1.X1, line1.X2) >= tempX && //in between X's for line 1
                   Math.Min(line1.Y1, line1.Y2) <= tempY && Math.Max(line1.Y1, line1.Y2) >= tempY &&  //in between Y's for line 1
                   Math.Min(line2.X1, line2.X2) <= tempX && Math.Max(line2.X1, line2.X2) >= tempX &&  //in between X's for line 2
                   Math.Min(line2.Y1, line2.Y2) <= tempY && Math.Max(line2.Y1, line2.Y2) >= tempY)    //in between Y's for line 2
                {
                    CollisionLabel.Text = String.Format("Segments intersect at [{0:F2},{1:F2}]", tempX, tempY);
                }
                else
                    CollisionLabel.Text = "Segments do not Intersect.";
            }
            
        }

        //gets the x intercept for the two segments
        public double CalcX()
        {
            return (letters[1] * letters[5] - letters[2] * letters[4]) / (letters[1] * letters[3] - letters[0] * letters[4]);       
        }

        //gets the y intercept for the two segments
        public double CalcY()
        {
            return (letters[2] * letters[3] - letters[0] * letters[5]) / (letters[1] * letters[3] - letters[0] * letters[4]);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                string temp;
                temp = "Input" + i;
                TextBox tbx = this.Controls.Find(temp, true).FirstOrDefault() as TextBox;
                tbx.Text = string.Empty;
            }
            CollisionLabel.Text = string.Empty;
        }

        /// <summary>
        /// takes the coordinates from the two line segments and returns the Constants A through F
        /// of the standard form of the two line segments
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public double[] Standardize(LineSegment l1, LineSegment l2)
        {
            double[] returnTemp = new double[6] {(l1.Y1 - l1.Y2),                                    //A
                                               (l1.X2 - l1.X1),                                      //B
                                               ((l1.X2 - l1.X1) * l1.Y1) - ((l1.Y2 - l1.Y1) * l1.X1),//C
                                               (l2.Y1 - l2.Y2),                                      //D
                                               (l2.X2 - l2.X1),                                      //E
                                               ((l2.X2 - l2.X1) * l2.Y1) - ((l2.Y2 - l2.Y1) * l2.X1) //F
                                               };
            return returnTemp;
        }


    }
}
