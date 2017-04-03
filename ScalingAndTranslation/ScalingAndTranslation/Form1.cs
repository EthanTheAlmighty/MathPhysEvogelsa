using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScalingAndTranslation
{
    public partial class Form1 : Form
    {
        List<Vector3D> Vertices = new List<Vector3D>();
        public Form1()
        {
            InitializeComponent();
            VerticesText.Text = Vertices.Count.ToString();
        }

        private void AddVertexButton_Click(object sender, EventArgs e)
        {
            Vertices.Add(new Vector3D(double.Parse(VertexXInput.Text), 
                double.Parse(VertexYInput.Text), double.Parse(VertexZInput.Text)));
            VerticesText.Text = Vertices.Count.ToString();
            ClearVertexText();
        }

        private void ClearVertexButton_Click(object sender, EventArgs e)
        {
            Vertices.Clear();
            VerticesText.Text = Vertices.Count.ToString();
            ClearVertexText();
        }

        private void ClearVertexText()
        {
            VertexXInput.Text = String.Empty;
            VertexYInput.Text = String.Empty;
            VertexZInput.Text = String.Empty;
        }
    }
}
