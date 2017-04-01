using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//@author: Ethan Vogelsang
/*
 * class Vector3D takes in info from cartesian, polar, or magHeadPitch,
 * and convert that into the cartesian components of a vector.
 * It can take that and return a string with
 * the cartesian coordinates, the magHeadPitch, and all of the Euler angles
 * can also take in two points to make a Vector (both 2D and 3D)
 * 
 * The class also overloads a number of operators (+,-,8,%,&,<,>, !)
 * to accomplish many of the Vector math operations
 * 
 * Added in cross product, the ability to find the closest point,
 * and the ability to find the distance to that closest point
 */

public class Vector3D
{
    #region "Vars"
    //holds the cartesian coordinates of the vector
    private double x;
    private double y;
    private double z;
    private double w;
    #endregion

    #region "Constructors"
    public Vector3D()
    {
        //constructor to default the coordinates to (0,0,0,1)
        x = 0;
        y = 0;
        z = 0;
        w = 1;
    }

    public Vector3D(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.w = 1;
    }
    #endregion

    #region "Sets"
    /// <summary>
    /// sets the vector using 2D Cartesian coordinates and defaults z to 0
    /// </summary>
    /// <param name="x">X coordinate</param>
    /// <param name="y">Y coordinate</param>
    public void SetRectGivenRect(double X, double Y)
    {
        //sets X and Y, then defaults z to 0 and w to 1
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
        //sets the x,y, and z components of the vector straight from the input
        //and then stores them and defaults w to 1
        this.x = X;
        this.y = Y;
        this.z = Z;
        this.w = 1;
    }

    /// <summary>
    /// SetRectGivenPolar takes in mag and the angle and uses those to make a vector
    /// in cartesian space
    /// </summary>
    /// <param name="m">magnitude of the vector in either polar or spherical coordinates</param>
    /// <param name="θ">The angle the vector makes with the positive x-axis</param>
    public void SetRectGivenPolar(double m, double θ)
    {
        //converts θ from degrees to radians so the computer can use it
        θ = θ * Math.PI / 180;
        this.x = m * Math.Cos(θ);
        this.y = m * Math.Sin(θ);
    }

    /// <summary>
    /// SetRectGivenMagHeadPitch takes is a magnitude, and a heading and pitch in degrees
    /// converts those to radians so they can be used in calculations, and then
    /// uses the standard equations to find the vector cartesian coordinates
    /// </summary>
    /// <param name="m">magnitude of the vector in either polar or spherical coordinates</param>
    /// <param name="h">The angle that the projection of the vector
    /// into the xy-plane makes with the positive x-axis</param>
    /// <param name="p">The angle the vector makes with the xy-plane</param>
    public void SetRectGivenMagHeadPitch(double m, double h, double p)
    {
        //change heading and pitch into radians
        h = h * Math.PI / 180;
        p = p * Math.PI / 180;
        //with radians now calculate
        this.x = m * Math.Cos(p) * Math.Cos(h);
        this.y = m * Math.Cos(p) * Math.Sin(h);
        this.z = m * Math.Sin(p);
    }

    /// <summary>
    /// Given the x,y, and z coordinates of two points, this calculates the vector for that
    /// </summary>
    /// <param name="x1">X Coordinate of the first point</param>
    /// <param name="y1">Y Coordinate of the first point</param>
    /// <param name="z1">Z Coordinate of the first point</param>
    /// <param name="x2">X coordinate of the second point</param>
    /// <param name="y2">Y Coordinate of the second point</param>
    /// <param name="z2">Z Coordinate of the second point</param>
    public void SetRectGivenTwoPoints(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        this.x = x2 - x1;
        this.y = y2 - y1;
        this.z = z2 - z1;
    }

    /// <summary>
    /// Given the x and y coordinates of two points, this calculates the vector for that
    /// </summary>
    /// <param name="x1">X Coordinate of the first point</param>
    /// <param name="y1">Y Coordinate of the first point</param>
    /// <param name="x2">X Coordinate of the second point</param>
    /// <param name="y2">Y Coordinate of the second point</param>
    public void SetRectGivenTwoPoints(double x1, double y1, double x2, double y2)
    {
        this.x = x2 - x1;
        this.y = y2 - y1;
        this.z = 0;
    }

    /// <summary>
    /// Sets a vector for a line given two points in Vector3D form
    /// </summary>
    /// <param name="p1">Vector3D of the start point</param>
    /// <param name="p2">Vector3d of the end point</param>
    public void SetRectGivenTwoPoints(Vector3D p1, Vector3D p2)
    {
        this.x = p2.GetX() - p1.GetX();
        this.y = p2.GetY() - p1.GetY();
        this.z = p2.GetZ() - p1.GetZ();
    }
    #endregion

    #region "Print"
    /// <summary>
    /// PrintRect returns out the Cartesian coordinates of the particular object
    /// </summary>
    public string PrintRect()
    {
        return String.Format("<{0:F2}, {1:F2}, {2:F2}>", GetX(), GetY(), GetZ());
    }

    /// <summary>
    /// converts the Cartesian coordinates and returns the magnitude, the heading, and the pitch as a string
    /// </summary>
    public string PrintMagHeadPitch()
    {
        return String.Format("M: {0:F2}  θ: {1:F2}°  ρ: {2:F2}°",
            GetMagnitude(), GetHeading(), GetPitch());
    }

    /// <summary>
    /// converts the Cartesian coordinates and returns the Euler angles in a string
    /// </summary>
    public string PrintAngles()
    {
        //each angle is just the inverse cosine of the 3 components
        //divided by the magnitude of the vector
        return String.Format("Alpha: {0:F2}° Beta: {1:F2}° Gamma: {2:F2}°",
            GetAlpha(), GetBeta(), GetGamma());
    }
    #endregion

    #region "Gets"
    /// <summary>
    /// Calculates the magnitude of the given vector
    /// </summary>
    /// <returns>magnitude</returns>
    public double GetMagnitude()
    {
        //√(vx^2 + vy^2 + vz^2)
        return Math.Sqrt(GetX() * GetX() + GetY() * GetY() + GetZ() * GetZ());
    }

    /// <summary>
    /// returns the pitch with the arcsine calculation
    /// </summary>
    /// <returns>pitch (radians)</returns>
    public double GetPitch()
    {
        //check is mag is zeero vector
        if (GetMagnitude() == 0)
            return 0;
        //doesn't need corrections, as the only valid Pitch's are in the arcsine's range
        //also converted from radians to degrees
        return (Math.Asin(GetZ() / GetMagnitude()) * 180 / Math.PI);
    }

    /// <summary>
    /// GetHeading 
    /// </summary>
    /// <returns>Heading (radians)</returns>
    public double GetHeading()
    {
        //checked for a denominator of zero
        if (Math.Sqrt(GetX() * GetX() + GetY() * GetY()) == 0)
            return 0;
        //needs the restrictions given to arctan
        double temp;
        //checks if y is greater than zero, and then either returns theta or 2*PI - theta
        temp = (GetY() >= 0) ? Math.Acos(GetX() / Math.Sqrt(GetX() * GetX() + GetY() * GetY())) :
            2 * Math.PI - Math.Acos(GetX() / Math.Sqrt(GetX() * GetX() + GetY() * GetY()));
        //convert temp to degrees for readability
        temp = temp * 180 / Math.PI;
        return temp;
    }

    /// <summary>
    /// Alpha is the angle the vector makes with the positive x-axis, α    
    /// </summary>
    /// <returns>α</returns>
    public double GetAlpha()
    {
        //a check to see if the magnitude, which is the denominator here, is zero
        if (GetMagnitude() == 0)
            return 0;
        return (Math.Acos(GetX() / GetMagnitude()) * 180 / Math.PI);
    }

    /// <summary>
    /// Beta is the angle the vector makes with the positive y-axis, β
    /// </summary>
    /// <returns>β/returns>
    public double GetBeta()
    {
        //a check to see if the magnitude, which is the denominator here, is zero
        if (GetMagnitude() == 0)
            return 0;
        return (Math.Acos(GetY() / GetMagnitude()) * 180 / Math.PI);
    }

    /// <summary>
    /// Gamma is the angle the vector makes with the positive z-axis, γ
    /// </summary>
    /// <returns>γ</returns>
    public double GetGamma()
    {
        //a check to see if the magnitude, which is the denominator here, is zero
        if (GetMagnitude() == 0)
            return 0;
        return (Math.Acos(GetZ() / GetMagnitude()) * 180 / Math.PI);
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
    #endregion

    #region "Operator Overloads"
    /// <summary>
    /// overlaods the + operator to add two vectors
    /// </summary>
    /// <param name="u"></param>
    /// <param name="v"></param>
    /// <returns></returns>
    public static Vector3D operator +(Vector3D u, Vector3D v) =>
        new Vector3D(u.GetX() + v.GetX(), u.GetY() + v.GetY(), u.GetZ() + v.GetZ());

    /// <summary>
    /// overloads the - operator to subtract two vectors
    /// </summary>
    /// <param name="u"></param>
    /// <param name="v"></param>
    /// <returns></returns>
    public static Vector3D operator -(Vector3D u, Vector3D v) =>
        new Vector3D(u.GetX() - v.GetX(), u.GetY() - v.GetY(), u.GetZ() - v.GetZ());

    /// <summary>
    /// two methods that do the same thing, which is take a scalar and multiply it
    /// into the vector, both methods exist so that the scalar can be the first or
    /// the last paramter and it will still work
    /// </summary>
    /// <param name="s"></param>
    /// <param name="u"></param>
    /// <returns></returns>
    public static Vector3D operator &(double s, Vector3D u) =>
        new Vector3D(u.GetX() * s, u.GetY() * s, u.GetZ() * s);
    public static Vector3D operator &(Vector3D u, double s) =>
        new Vector3D(u.GetX() * s, u.GetY() * s, u.GetZ() * s);


    /// <summary>
    /// A static method that takes overloads the * operator for a dot product
    /// returning a scalar
    /// </summary>
    /// <param name="v1">First vector</param>
    /// <param name="v2">Second vector</param>
    /// <returns>scalar; the dot product</returns>
    public static double operator *(Vector3D v1, Vector3D v2) =>
        (v1.GetX() * v2.GetX() + v1.GetY() * v2.GetY() + v1.GetZ() * v2.GetZ());

    /// <summary>
    /// overlaods the ! operator to normalize the vector providing it the 
    /// same direction as before but the magnitude is now one
    /// </summary>
    /// <param name="u"></param>
    /// <returns></returns>
    public static Vector3D operator !(Vector3D u) =>
        new Vector3D(u.GetX() / u.GetMagnitude(),
                     u.GetY() / u.GetMagnitude(),
                     u.GetZ() / u.GetMagnitude());

    /// <summary>
    /// operator >> is being used for parralel projection of u onto v
    /// </summary>
    /// <param name="u">the vector you're projecting</param>
    /// <param name="v">the vector that u is projecting onto</param>
    /// <returns></returns>
    public static Vector3D operator >(Vector3D u, Vector3D v) =>
       (((u * v) / (v.GetMagnitude() * v.GetMagnitude())) & v);

    /// <summary>
    /// this operator is being used for perpendicular projection
    /// </summary>
    /// <param name="u"></param>
    /// <param name="v"></param>
    /// <returns></returns>
    public static Vector3D operator <(Vector3D u, Vector3D v) => (u - (u > v));

    /// <summary>
    /// % operator is being used to find the angle between two vectors
    /// </summary>
    /// <param name="u"></param>
    /// <param name="v"></param>
    /// <returns></returns>
    public static double operator %(Vector3D u, Vector3D v) =>
        (Math.Acos((u * v) / (u.GetMagnitude() * v.GetMagnitude())));
    #endregion

    #region"Static Operations"
    /// <summary>
    /// Method to make it so you can take the crossproduct
    /// of two vectors
    /// </summary>
    /// <param name="u">first vector</param>
    /// <param name="v">second vector</param>
    /// <returns>the cross product of the two inputed vectors</returns>
    public static Vector3D CrossProduct(Vector3D u, Vector3D v) =>
        new Vector3D(u.GetY() * v.GetZ() - v.GetY() * u.GetZ(),   //X
                   -(u.GetX() * v.GetZ() - v.GetX() * u.GetZ()),  //Y
                     u.GetX() * v.GetY() - v.GetX() * u.GetY());  //Z
    /// <summary>
    /// ClosestPointLine takes in three vectors: q(point), p(point on the line)
    /// and d(the direction the line goes) and returns what the closest point 
    /// on the line relative to the point Q is
    /// 
    /// LineDistance takes the closest point and the reference point, Q, and
    /// finds the distance between the two
    /// </summary>
    /// <param name="q">Point you're finding a point from</param>
    /// <param name="p">Point on the line</param>
    /// <param name="d">direction of the line</param>
    /// <returns></returns>
    public static Vector3D ClosestPointLine(Vector3D q, Vector3D p, Vector3D d)
        => (p + ((q - p) > d));
    public static Vector3D LineDistance(Vector3D q, Vector3D p, Vector3D d) =>
        (q - ClosestPointLine(q, p, d));

    /// <summary>
    /// ClosestPointPlane takes in the 3 points on a plane: A,B, and C and 
    /// the point of comparison Q, it returns the closest point
    /// 
    /// PlaneDistance takes the ClosestPointPlane and gives the distance from
    /// the point Q to the closest point
    /// </summary>
    /// <param name="a">First Point on the plane</param>
    /// <param name="b">Second Point on the plane</param>
    /// <param name="c">Third Point on the plane</param>
    /// <param name="q">Point of reference for the closest point</param>
    /// <returns></returns>
    public static Vector3D ClosestPointPlane(Vector3D a, Vector3D b, Vector3D c, Vector3D q)
    {
        return (q - ((q - a) > CrossProduct(b - a, c - a)));
    }
    public static Vector3D PlaneDistance(Vector3D a, Vector3D b, Vector3D c, Vector3D q)
        => (q - ClosestPointPlane(a,b,c,q));
    /*
        //check that a,b, and c are different
        if(a != b && a != c)
        {
            return (q - a) > CrossProduct(b - a, c - a);
        }
    }*/
    #endregion
}

