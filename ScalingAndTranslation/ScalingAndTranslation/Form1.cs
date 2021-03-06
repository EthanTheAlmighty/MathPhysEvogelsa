﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScalingAndTranslation
{
    public partial class Form1 : Form
    {
        List<Vector3D> vertices = new List<Vector3D>();
        List<Vector3D> newVertices = new List<Vector3D>();
        int userSelection;
        double userDegrees;
        public Form1()
        {
            InitializeComponent();
            VerticesText.Text = vertices.Count.ToString();
        }

        private void AddVertexButton_Click(object sender, EventArgs e)
        {
            vertices.Add(new Vector3D(double.Parse(VertexXInput.Text), 
                double.Parse(VertexYInput.Text), double.Parse(VertexZInput.Text)));
            VerticesText.Text = vertices.Count.ToString();
            OldVerticesOutput.Items.Add(vertices[vertices.Count - 1].PrintRect());
            ClearVertexText();
        }

        private void ClearVertexButton_Click(object sender, EventArgs e)
        {
            vertices.Clear();
            OldVerticesOutput.Items.Clear();
            VerticesText.Text = vertices.Count.ToString();
            ClearVertexText();
        }

        private void ClearVertexText()
        {
            VertexXInput.Text = String.Empty;
            VertexYInput.Text = String.Empty;
            VertexZInput.Text = String.Empty;
        }

        //the three checks
        private void TranslationRadio_CheckedChanged(object sender, EventArgs e)
        {
            //fades stuff
        }
        private void RawScaleRadio_CheckedChanged(object sender, EventArgs e)
        {
            //fades stuff
        }
        private void ScaleAboutCenterRadio_CheckedChanged(object sender, EventArgs e)
        {
            //fades stuff
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clears the lists upon each iteration of code so there are no
            //duplicate entries
            newVertices.Clear();
            FinalResultsOutput.Items.Clear();

            //reads in the degrees of rotation from the form
            userDegrees = double.Parse(degreesBox.Text);

            //switch for which modification is selected
            //switch(userSelection)
            //{
            //    //translation
            //    case 0:
            //        newVertices.AddRange(Vector3D.TranslateVertices(
            //            new Vector3D(double.Parse(TranslateXInput.Text),    //X
            //            double.Parse(TranslateYInput.Text),                 //Y
            //            double.Parse(TranslateZInput.Text))                 //Z
            //            , vertices));       //the list to be converted
            //        break;
            //    //raw scale
            //    case 1:
            //        newVertices.AddRange(Vector3D.RawScaleVertices(new Vector3D(double.Parse(ScaleXInput.Text), double.Parse(ScaleYInput.Text), double.Parse(ScaleZInput.Text)), vertices));
            //        break;
            //    //scale about center
            //    case 2:
            //        newVertices.AddRange(Vector3D.ScaleAboutCenterVertices(new Vector3D(double.Parse(ScaleXInput.Text), double.Parse(ScaleYInput.Text), double.Parse(ScaleZInput.Text)),   //scale stored as vector
            //            new Vector3D(double.Parse(CenterXInput.Text), double.Parse(CenterYInput.Text), double.Parse(CenterZInput.Text)),    //center in vector form
            //            vertices));     //list of vertices to be changed
            //        break;
            //}

            switch(userSelection)
            {
                case 0:
                    //takes the list vectors in the object and rotates them
                    //around the x axis
                    newVertices.AddRange(Vector3D.RotateAboutXAxis(vertices, userDegrees));
                    break;
                case 1:
                    //takes the list vectors in the object and rotates them
                    //around the y axis
                    newVertices.AddRange(Vector3D.RotateAboutYAxis(vertices, userDegrees));
                    break;
                case 2:
                    //takes the list vectors in the object and rotates them
                    //around the z axis
                    newVertices.AddRange(Vector3D.RotateAboutZAxis(vertices, userDegrees));
                    break;
            }

            foreach (Vector3D vertex in newVertices)
            {
                FinalResultsOutput.Items.Add(vertex.PrintRect());
            }
        }

        //this gives an int value to which of the 3 axis options the user can select
        //so it can be filtered through a switch statement to call the
        //right method
        private void XradioButton_CheckedChanged(object sender, EventArgs e)
        {
            userSelection = 0;
        }
        private void YRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            userSelection = 1;
        }
        private void ZRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            userSelection = 2;
        }
    }
}
