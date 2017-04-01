using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorClassBuilder
{
    class Vector3D
    {
        private double x;
        private double y;
        private double z;
        private double w;

        public Vector3D()
        {
            x = 0;
            y = 0;
            z = 0;
            w = 1;
        }

        /// <summary>
        /// sets the vector using 2D Cartesian coordinates and defaults z to 0
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        public void SetRectGivenRect(double X, double Y)
        {
            this.x = X;
            this.y = Y;
            this.z = 0;
            this.w = 1;
        }

        /// <summary>
        /// sets the vector using 3D Cartesian coordinates
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="z">Z coordinate</param>
        public void SetRectGivenRect(double X, double Y, double Z)
        {
            this.x = X;
            this.y = Y;
            this.z = Z;
            this.w = 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="m">magnitude of the vector in either polar or spherical coordinates</param>
        /// <param name="θ">The angle the vector makes with the positive x-axis</param>
        public void SetRectGivenPolar(double m, double θ)
        {
            this.x = m * Math.Cos(θ);
            this.y = m * Math.Sin(θ);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="m">magnitude of the vector in either polar or spherical coordinates</param>
        /// <param name="h">The angle that the projection of the vector into the xy-plane makes with the positive x-axis</param>
        /// <param name="p">The angle the vector makes with the xy-plane</param>
        public void SetRectGivenMagHeadPitch(double m, double h, double p)
        {
            this.x = m * Math.Cos(p) * Math.Cos(h);
            this.y = m * Math.Cos(p) * Math.Sin(h);
            this.z = m * Math.Sin(p);
        }

        /// <summary>
        /// PrintRect returns out the Cartesian coordinates of the particular object
        /// </summary>
        public string PrintRect()
        {
            return String.Format("Coordinates: x: {0} y: {1} z: {2}", x, y, z);
        }

        /// <summary>
        /// converts the Cartesian coordinates and returns the magnitude, the heading, and the pitch as a string
        /// </summary>
        public string PrintMagHeadPitch()
        {
            return String.Format("magnitude {0} Heading: {1} Pitch {2}", GetMagnitude(), GetHeading(), GetPitch());
        }

        /// <summary>
        /// converts the Cartesian coordinates and returns the Euler angles in a string
        /// </summary>
        public string PrintAngles()
        {
            //each angle is just the inverse cosine of the 3 components of the unit vector
            return String.Format("Alpha: {0] Beta: {1} Gamma: {2}", GetAlpha(), GetBeta(), GetGamma());
        }

        /// <summary>
        /// Calculates the magnitude of the given vector
        /// </summary>
        /// <returns>magnitude</returns>
        public double GetMagnitude()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        /// <summary>
        /// returns the pitch with the arcsine calculation
        /// </summary>
        /// <returns>pitch (radians)</returns>
        public double GetPitch()
        {
            return Math.Asin(z / GetMagnitude());
        }

        /// <summary>
        /// GetHeading 
        /// </summary>
        /// <returns>Heading (radians)</returns>
        public double GetHeading()
        {
            //needs the restrictions given to arctan
            return (x / Math.Sqrt(Math.Atan(y / x)));
        }

        /// <summary>
        /// Alpha is the angle the vector makes with the positive x-axis, α    
        /// </summary>
        /// <returns>α</returns>
        public double GetAlpha()
        {
            //needs restrictions for arccos
            return Math.Acos(x / GetMagnitude());
        }

        /// <summary>
        /// Beta is the angle the vector makes with the positive y-axis, β
        /// </summary>
        /// <returns>β/returns>
        public double GetBeta()
        {
            return Math.Acos(y / GetMagnitude());
        }

        /// <summary>
        /// Gamma is the angle the vector makes with the positive z-axis, γ
        /// </summary>
        /// <returns>γ</returns>
        public double GetGamma()
        {
            return Math.Acos(z / GetMagnitude());
        }

        /// <summary>
        /// Gets the private x coordinate and returns it
        /// </summary>
        /// <returns></returns>
        public double GetX()
        {
            return x;
        }

        /// <summary>
        /// Gets the private y coordinate and returns it
        /// </summary>
        /// <returns></returns>
        public double GetY()
        {
            return y;
        }

        /// <summary>
        /// Gets the private x coordinate and returns it
        /// </summary>
        /// <returns></returns>
        public double GetZ()
        {
            return z;
        }

        /// <summary>
        /// A static method that takes two vectors as input and returns their dot product scalar
        /// </summary>
        /// <param name="v1">First vector</param>
        /// <param name="v2">Second vector</param>
        /// <returns>scalar; the dot product</returns>
        public static double DotProduct(Vector3D v1, Vector3D v2)
        {
            return (v1.GetX()*v2.GetX() + v1.GetY() * v2.GetY() + v1.GetZ() * v2.GetZ());
        }


        public static Vector3D CrossProduct(Vector3D v1, Vector3D v2)
        {
            Vector3D temp = new Vector3D();
            temp.SetRectGivenRect(v1.GetY() * v2.GetZ() - v2.GetY() * v1.GetZ(),       //X
                                    -(v1.GetX() * v2.GetZ() - v2.GetX() * v1.GetZ()),  //Y
                                    v1.GetX() * v2.GetY() - v2.GetX() * v1.GetY());    //Z
            return temp;
        }
    }
}
