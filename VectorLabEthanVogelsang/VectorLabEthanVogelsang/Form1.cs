using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VectorLabEthanVogelsang
{
    public partial class Form1 : Form
    {
        public Vector3D testVectorRect, testVectorSphere;

        public Form1()
        {
            InitializeComponent();
        }

        private void RectCalc_Click(object sender, EventArgs e)
        {
            if(ThreeCheck.Checked)
                testVectorRect.SetRectGivenRect(Convert.ToDouble(xInput.Text), Convert.ToDouble(yInput.Text), Convert.ToDouble(zInput.Text));
            else
                testVectorRect.SetRectGivenRect(Convert.ToDouble(xInput.Text), Convert.ToDouble(yInput.Text));

            //now print out the results
            RectLabel.Text = Results(testVectorRect);
        }

        private void SphereCalc_Click(object sender, EventArgs e)
        {
            //need to make sure the inputs are converted from degrees into radians for calculations
            testVectorSphere.SetRectGivenMagHeadPitch(Convert.ToDouble(mInput.Text), (Convert.ToDouble(hInput.Text)), (Convert.ToDouble(pInput.Text)));

            SphereLabel.Text = Results(testVectorSphere);
        }

        public string Results(Vector3D vect)
        {
            return String.Format("{0}\n{1:F2}\n{2:F2}", vect.PrintRect(), vect.PrintMagHeadPitch(), vect.PrintAngles());
        }

        private void ThreeCheck_CheckedChanged(object sender, EventArgs e)
        {
            zInput.Enabled = (ThreeCheck.Checked) ? true : false;
        } 

        //constructor to initialize the vector
        private void Form1_Load(object sender, EventArgs e)
        {
            testVectorRect = new Vector3D();
            testVectorSphere = new Vector3D();
        }
    }
}
