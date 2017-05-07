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
 * 
 * added in matrix operations for translation, raw scaling and
 * scaling about center all using a list of vertices
 * 
 * added in a matrix4x4 class to house matrices and addded in static
 * operations to rotate about all 3 of the main axis
 * 
 * quaternion class added 
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
    /// <summary>
    /// Constructor that can now take in 4 parameters for matrix operations
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="z"></param>
    /// <param name="w"></param>
    public Vector3D(double x, double y, double z, double w)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.w = w;
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

    public void Normalize()
    {
        x /= GetMagnitude();
        y /= GetMagnitude();
        z /= GetMagnitude();
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
    public double GetMagnitude() =>
        //√(vx^2 + vy^2 + vz^2)
        (Math.Sqrt(GetX() * GetX() + GetY() * GetY() + GetZ() * GetZ()));

    /// <summary>
    /// returns the pitch with the arcsine calculation
    /// </summary>
    /// <returns>pitch (radians)</returns>
    public double GetPitch() => (GetMagnitude() == 0) ? 0 : (Math.Asin(GetZ() / GetMagnitude()) * 180 / Math.PI);
    //{
    //    //check is mag is zeero vector
    //    if (GetMagnitude() == 0)
    //        return 0;
    //    //doesn't need corrections, as the only valid Pitch's are in the arcsine's range
    //    //also converted from radians to degrees
    //    return (Math.Asin(GetZ() / GetMagnitude()) * 180 / Math.PI);
    //}

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
    public double GetAlpha() => (GetMagnitude() == 0) ? 0 : (Math.Acos(GetX() / GetMagnitude()) * 180 / Math.PI);
    //{
    //    //a check to see if the magnitude, which is the denominator here, is zero
    //    if (GetMagnitude() == 0)
    //        return 0;
    //    return (Math.Acos(GetX() / GetMagnitude()) * 180 / Math.PI);
    //}

    /// <summary>
    /// Beta is the angle the vector makes with the positive y-axis, β
    /// </summary>
    /// <returns>β<returns>
    public double GetBeta() => (GetMagnitude() == 0) ? 0 : (Math.Acos(GetY() / GetMagnitude()) * 180 / Math.PI);
    //{
    //    //a check to see if the magnitude, which is the denominator here, is zero
    //    if (GetMagnitude() == 0)
    //        return 0;
    //    return (Math.Acos(GetY() / GetMagnitude()) * 180 / Math.PI);
    //}

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
    public double GetX() => (x);

    /// <summary>
    /// Gets the private y coordinate and returns it
    /// </summary>
    /// <returns></returns>
    public double GetY() => (y);

    /// <summary>
    /// Gets the private x coordinate and returns it
    /// </summary>
    /// <returns></returns>
    public double GetZ() => (z);
    /// <summary>
    /// Get the private x coordinate and returns it
    /// </summary>
    /// <returns></returns>
    public double GetW() => (w);
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
    /// <summary>
    /// overloads the ^ operator to be a dot product that also takes the
    /// w component into consideration
    /// </summary>
    /// <param name="u"></param>
    /// <param name="v"></param>
    /// <returns></returns>
    public static double operator ^(Vector3D u, Vector3D v) =>
        (u.GetX() * v.GetX() + u.GetY() * v.GetY() +
        u.GetZ() * v.GetZ() + u.GetW() * v.GetW());
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
        //S = Q - Proj(PQ onto n)
        => (q - ((q - a) > CrossProduct(b - a, c - a)));
    public static Vector3D PlaneDistance(Vector3D a, Vector3D b, Vector3D c, Vector3D q)
        => (q - ClosestPointPlane(a, b, c, q));
    /// <summary>
    /// method takes in two vectors in a plane, AB and AC, and uses then to get a 
    /// crossproduct and then a normal vector of the plane.  This is then used
    /// with the coefficient of restitution, , and the initial velocity, v, 
    /// and returns the new velocity after a collision
    /// </summary>
    /// <param name="v">initial velocity</param>
    /// <param name="ε">coefficient of restitution</param>
    /// <param name="AB">first vector in the plane</param>
    /// <param name="AC">second vector in the plane</param>
    /// <returns></returns>
    public static Vector3D CollisionWithPlane(Vector3D v, double ε, Vector3D AB, Vector3D AC)
        => (v - ((1 + ε) * (v * !CrossProduct(AB, AC)) & !CrossProduct(AB, AC)));
    //{
    //    //find the normal of the plane
    //    Vector3D normal = CrossProduct(AB, AC);
    //    //noramlize the normal vector
    //    normal.Normalize();

    //    Vector3D vFinal = new Vector3D();
    //    vFinal = v - ((1 + ε)*(v * normal) & normal);
    //    return vFinal;
    //}
    #endregion

    #region"Matrix Operations"
    /// <summary>
    /// TranslateVertices takes in a Vector3D, t, which has the delta x,y, and z
    /// that the source Vector, v, will be translated
    /// </summary>
    /// <param name="t">Δx, Δy, and Δz of the translation stored in a vector3D format</param>
    /// <param name="v">the list of vectors being translated and then returned</param>
    /// <returns></returns>
    public static List<Vector3D> TranslateVertices(Vector3D t, List<Vector3D> v)
    {
        List<Vector3D> tempList = new List<Vector3D>();

        //create the transformation "matrix"
        Vector3D t1 = new Vector3D(1, 0, 0, t.GetX());
        Vector3D t2 = new Vector3D(0, 1, 0, t.GetY());
        Vector3D t3 = new Vector3D(0, 0, 1, t.GetZ());
        Vector3D t4 = new Vector3D(0, 0, 0, 1);

        for (int i = 0; i < v.Count; i++)
        {
            tempList.Add(new Vector3D(t1 ^ v[i], t2 ^ v[i], t3 ^ v[i], t4 ^ v[i]));
        }
        return tempList;
    }
    /// <summary>
    /// RawScale Vertices takes in a vector, s, that holds the scale change of
    /// the vertices in x, y, z.  This all changes the list of Vectors, v
    /// </summary>
    /// <param name="s"></param>
    /// <param name="v"></param>
    /// <returns></returns>
    public static List<Vector3D> RawScaleVertices(Vector3D s, List<Vector3D> v)
    {
        List<Vector3D> tempList = new List<Vector3D>();

        //create the transformation "matrix"
        Vector3D t1 = new Vector3D(s.GetX(), 0, 0, 0);
        Vector3D t2 = new Vector3D(0, s.GetY(), 0, 0);
        Vector3D t3 = new Vector3D(0, 0, s.GetZ(), 0);
        Vector3D t4 = new Vector3D(0, 0, 0, 1);

        for (int i = 0; i < v.Count; i++)
        {
            tempList.Add(new Vector3D(t1 ^ v[i], t2 ^ v[i], t3 ^ v[i], t4 ^ v[i]));
        }
        return tempList;
    }
    /// <summary>
    /// ScaleAboutCenterVertices takes in the change of scale, s, and the 
    /// distance to center
    /// </summary>
    /// <param name="s">scale change for the vertices list, stored as x, y, and z conponents of the vector</param>
    /// <param name="c">Δx, Δy, and Δz needed to get to the center</param>
    /// <param name="v"> list of lertices to be scaled</param>
    /// <returns></returns>
    public static List<Vector3D> ScaleAboutCenterVertices(Vector3D s, Vector3D c, List<Vector3D> v)
    {
        List<Vector3D> tempList = new List<Vector3D>();

        //create the transformation "matrix"
        //Vector3D t1 = new Vector3D(s.GetX(), 0, 0, c.GetX() * (1 - s.GetX()));
        //Vector3D t2 = new Vector3D(0, s.GetY(), 0, c.GetY() * (1 - s.GetY()));
        //Vector3D t3 = new Vector3D(0, 0, s.GetZ(), c.GetZ() * (1 - s.GetZ()));
        //Vector3D t4 = new Vector3D(0, 0, 0, 1);

        Matrix4x4 sACMatrix = new Matrix4x4(new Vector3D(s.GetX(), 0, 0, c.GetX() * (1 - s.GetX())),
                                            new Vector3D(0, s.GetY(), 0, c.GetY() * (1 - s.GetY())),
                                            new Vector3D(0, 0, s.GetZ(), c.GetZ() * (1 - s.GetZ())),
                                            new Vector3D(0, 0, 0, 1));

        for (int i = 0; i < v.Count; i++)
        {
            //tempList.Add(new Vector3D(t1 ^ v[i], t2 ^ v[i], t3 ^ v[i], t4 ^ v[i]));
            tempList.Add(sACMatrix * v[i]);
        }
        return tempList;
    }
    #endregion

    #region Matrix Rotations
    /// <summary>
    /// static method that takes in a list of vector3D's, and then rotates
    /// them θ degrees about the X Axis
    /// </summary>
    /// <param name="v">collection of vertices to be transformed</param>
    /// <param name="θ">degrees to rotate</param>
    /// <returns></returns>
    public static List<Vector3D> RotateAboutXAxis(List<Vector3D> v, double θ)
    {
        //convert from degrees to radians so the math namespace can use it
        double tempAngle = θ * Math.PI / 180;
        //initialize the list that will return
        List<Vector3D> tempList = new List<Vector3D>();

        //create the matrix that will allow rotation about the X axis
        Matrix4x4 rotator = new Matrix4x4(new Vector3D(1, 0, 0, 0), new Vector3D(0, Math.Cos(tempAngle), -Math.Sin(tempAngle), 0), new Vector3D(0, Math.Sin(tempAngle), Math.Cos(tempAngle), 0), new Vector3D(0, 0, 0, 1));
        //loop through each vertex and rotate it
        for (int i = 0; i < v.Count; i++)
        {
            //add each to the list
            tempList.Add(rotator * v[i]);
        }
        //return the now full new and rotated list
        return tempList;
    }
    /// <summary>
    /// static method that takes in a list of vector3D's, and then rotates
    /// them θ degrees about the Y Axis
    /// </summary>
    /// <param name="v"></param>
    /// <param name="θ"></param>
    /// <returns></returns>
    public static List<Vector3D> RotateAboutYAxis(List<Vector3D> v, double θ)
    {
        //convert from degrees to radians so the math namespace can use it
        double tempAngle = θ * Math.PI / 180;
        //initialize the list that will return
        List<Vector3D> tempList = new List<Vector3D>();

        //create the matrix that will allow rotation about the Y axis
        Matrix4x4 rotator = new Matrix4x4(new Vector3D(Math.Cos(tempAngle), 0, Math.Sin(tempAngle), 0), new Vector3D(0, 1, 0, 0), new Vector3D(-Math.Sin(tempAngle), 0, Math.Cos(tempAngle), 0), new Vector3D(0, 0, 0, 1));
        //loop through each vertex and rotate it
        for (int i = 0; i < v.Count; i++)
        {
            //add each to the list
            tempList.Add(rotator * v[i]);
        }
        //return the now full new and rotated list
        return tempList;
    }
    /// <summary>
    /// static method that takes in a list of vector3D's, and then rotates
    /// them θ degrees about the Z Axis
    /// </summary>
    /// <param name="v"></param>
    /// <param name="θ"></param>
    /// <returns></returns>
    public static List<Vector3D> RotateAboutZAxis(List<Vector3D> v, double θ)
    {
        //convert from degrees to radians so the math namespace can use it
        double tempAngle = θ * Math.PI / 180;
        //initialize the list that will return
        List<Vector3D> tempList = new List<Vector3D>();

        //create the matrix that will allow rotation about the Z axis
        Matrix4x4 rotator = new Matrix4x4(new Vector3D(Math.Cos(tempAngle), -Math.Sin(tempAngle), 0, 0), new Vector3D(Math.Sin(tempAngle), Math.Cos(tempAngle), 0, 0), new Vector3D(0, 0, 1, 0), new Vector3D(0, 0, 0, 1));
        //loop through each vertex and rotate it
        for (int i = 0; i < v.Count; i++)
        {
            //add each to the list
            tempList.Add(rotator * v[i]);
        }
        //return the now full new and rotated list
        return tempList;
    }
    #endregion

}

public class Matrix4x4
{
    Vector3D[] rows;

    public Matrix4x4()
    {
        rows = new Vector3D[4];
    }

    public Matrix4x4(Vector3D r1, Vector3D r2, Vector3D r3, Vector3D r4)
    {
        rows = new Vector3D[4];
        rows[0] = r1;
        rows[1] = r2;
        rows[2] = r3;
        rows[3] = r4;
    }
    //allows matrix4x4 to multiply next to a vector
    public static Vector3D operator *(Matrix4x4 m, Vector3D v) => new Vector3D(m.rows[0] * v, m.rows[1] * v, m.rows[2] * v, m.rows[3] * v);
}

public class Quaternion
{
    double r;
    Vector3D c;

    public Quaternion(double scalar, Vector3D vect)
    {
        r = scalar;
        c = vect;
    }

    public Quaternion(double r, double x, double y, double z)
    {
        this.r = r;
        this.c = new Vector3D(x, y, z);
    }

    #region Operator Overloads
    public static Quaternion operator +(Quaternion a, Quaternion b) =>
        new Quaternion(a.r + b.r, a.c.GetX() + b.c.GetX(), a.c.GetY() + b.c.GetY(), a.c.GetZ() + b.c.GetZ());
    public static Quaternion operator -(Quaternion a, Quaternion b) =>
        new Quaternion(a.r - b.r, a.c.GetX() - b.c.GetX(), a.c.GetY() - b.c.GetY(), a.c.GetZ() - b.c.GetZ());
    //Scalar multiplication
    public static Quaternion operator &(Quaternion a, double s) =>
        new Quaternion(a.r * s, s & a.c);
    public static Quaternion operator &(double s, Quaternion a) =>
        new Quaternion(a.r * s, s & a.c);
    //multiplication
    public static Quaternion operator *(Quaternion a, Quaternion b) =>
        new Quaternion(a.r*b.r - a.c*b.c, (a.r & b.c) + (b.r & a.c) + (Vector3D.CrossProduct(a.c, b.c)));
    //magnitude
    public static double operator !(Quaternion a) => (Math.Sqrt(a.r*a.r + a.c.GetMagnitude() * a.c.GetMagnitude()));
    //conjugate
    public static Quaternion operator ~(Quaternion a) => new Quaternion(a.r, -1&a.c);
    //inverse
    public static Quaternion operator -(Quaternion a) => (~a & (1/(!a * !a)));

    public static Quaternion Rotate(Vector3D p, Vector3D v, double θ)
    {
        Quaternion rot = new Quaternion(Math.Cos(θ), Math.Sin(θ) & p);
        Quaternion point = new Quaternion(0, p);
        return (rot * (point * +Rot));
    }
    #endregion
}

