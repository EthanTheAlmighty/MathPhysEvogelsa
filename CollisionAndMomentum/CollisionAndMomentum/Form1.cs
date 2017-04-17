﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollisionAndMomentum
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void PlaneButton_Click(object sender, EventArgs e)
        {
            Vector3D vFinal = new Vector3D();
            vFinal = Vector3D.CollisionWithPlane(new Vector3D(double.Parse(VelXInput.Text), double.Parse(VelYInput.Text), double.Parse(VelZInput.Text)),
                double.Parse(coeffInput.Text), new Vector3D(double.Parse(p1X.Text), double.Parse(p1Y.Text), double.Parse(p1Z.Text)),
                new Vector3D(double.Parse(p2X.Text), double.Parse(p2Y.Text), double.Parse(p2Z.Text)));
            collisionText.Text = "Vfinal = " + vFinal.PrintRect();
            
        }

        private void momentumButton_Click(object sender, EventArgs e)
        {
            //get the masses
            float m1 = float.Parse(o1m.Text);
            float m2 = float.Parse(o2m.Text);

            //get velocities
            float v1 = float.Parse(o1v.Text);
            float v2 = float.Parse(o2v.Text);

            float ε = float.Parse(coeffInput.Text);

            //calculate v1 final
            float v1f = ((m1 - ε * m2) * v1 + (1 + ε) * (m2 * v2)) / (m1 + m2);
            float v2f = v1f + ε * (v1 - v2);

            o1Text.Text = v1f.ToString("F2");
            o2Text.Text = v2f.ToString("F2");

        }
    }
}
