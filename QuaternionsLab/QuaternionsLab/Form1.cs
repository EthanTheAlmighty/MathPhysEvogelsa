using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuaternionsLab
{
    public partial class Form1 : Form
    {
        //the two quaternions
        Quaternion p, q;
        //vectors: a is the point to rotate, b is what axis
        //a will be rotated about
        Vector3D a, b;
        //degrees of rotation
        double θ;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// all of the button methods bellow here, styart by clearing out the
        /// answer form, initializing the two quaternions, and then 
        /// doing their assigned quaternion math and outputing it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //called for addition
        private void AddButton_Click(object sender, EventArgs e)
        {
            ReadQuaternions();
            answers.Items.Add(p + q);
        }
        //quaternion subtraction
        private void subButton_Click(object sender, EventArgs e)
        {
            ReadQuaternions();
            answers.Items.Add(p - q);
        }
        //quaternion scalar multiplication
        private void ScalarButton_Click(object sender, EventArgs e)
        {
            ReadQuaternions();
            double temp = double.Parse(scalar.Text);
            answers.Items.Add(temp & p);
            answers.Items.Add(temp & q);
        }
        //quaternion multiplication
        private void MultButton_Click(object sender, EventArgs e)
        {
            ReadQuaternions();
            answers.Items.Add(p * q);
        }
        //quat modulus
        private void ModulusButton_Click(object sender, EventArgs e)
        {
            ReadQuaternions();
            answers.Items.Add(!p);
            answers.Items.Add(!q);
        }
        //quaternion conjugate
        private void ConButton_Click(object sender, EventArgs e)
        {
            ReadQuaternions();
            answers.Items.Add(~p);
            answers.Items.Add(~q);
        }
        //quiaternion inverse
        private void InverseButton_Click(object sender, EventArgs e)
        {
            ReadQuaternions();
            answers.Items.Add(-p);
            answers.Items.Add(-q);
        }
        //calls quaternions rotate method to get the new point
        private void RotateButton_Click(object sender, EventArgs e)
        {
            answers.Items.Clear();
            a = new Vector3D(double.Parse(ax.Text), double.Parse(ay.Text), double.Parse(az.Text));
            b = new Vector3D(double.Parse(bx.Text), double.Parse(by.Text), double.Parse(bz.Text));
            θ = double.Parse(degrees.Text);
            rotateAnswer.Items.Add(Quaternion.Rotate(a, b, θ));
        }
        //initializes the quaternion objects after clearing the answer field
        void ReadQuaternions()
        {
            answers.Items.Clear();
            p = new Quaternion(double.Parse(ps.Text), double.Parse(px.Text), double.Parse(py.Text), double.Parse(pz.Text));
            q = new Quaternion(double.Parse(qs.Text), double.Parse(qx.Text), double.Parse(qy.Text), double.Parse(qz.Text));
        }
    }
}
