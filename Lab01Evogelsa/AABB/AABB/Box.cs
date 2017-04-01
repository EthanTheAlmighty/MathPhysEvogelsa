using System;

/// <summary>
/// class Box creates a Box from two points in the form Box(xMin, xMax, yMin, yMax, zMin, zMax)
/// </summary>
public class Box
{
    //properties to store all of the x, y, z values
    public double XMin { get; set; }
    public double XMax { get; set; }
    public double YMin { get; set; }
    public double YMax { get; set; }
    public double ZMin { get; set; }
    public double ZMax { get; set; }

    //constructor to populate the properties(3D)
    public Box(double x1, double x2, double y1, double y2, double z1, double z2)
    {
        XMin = x1;
        XMax = x2;
        YMin = y1;
        YMax = y2;
        ZMin = z1;
        ZMax = z2;
    }

    //constructor to populate the properties(2D)
    public Box(double x1, double x2, double y1, double y2)
    {
        XMin = x1;
        XMax = x2;
        YMin = y1;
        YMax = y2;
    }

    //allows the object to return what it's 3 centers are
    public double XCenter { get { return ((XMin + XMax) * .5); } }
    public double YCenter { get { return ((YMin + YMax) * .5); } }
    public double ZCenter { get { return ((ZMin + ZMax) * .5); } }

    //allows the object to return it's 3 radii
    public double XRadius { get { return (.5 * Math.Sqrt((XMax - XMin) * (XMax - XMin))); } }
    public double YRadius { get { return (.5 * Math.Sqrt((YMax - YMin) * (YMax - YMin))); } }
    public double ZRadius { get { return (.5 * Math.Sqrt((ZMax - ZMin) * (ZMax - ZMin))); } }

} // end class
