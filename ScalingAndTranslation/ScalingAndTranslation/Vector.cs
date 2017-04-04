using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Vector{
    #region "Vars"
    private double x, y, z, w;
    #endregion
    #region "Constructors"
    public Vector(){
        x = 0; y = 0; z = 0; w = 1;}
    public Vector(double x, double y, double z){
        this.x = x; this.y = y; this.z = z; this.w = 1;}

    public Vector(double x, double y, double z, double w){
        this.x = x; this.y = y; this.z = z; this.w = w;}
    #endregion
    #region "Sets"
    public void SetRectGivenRect(double X, double Y){
        this.x = X; this.y = Y; this.z = 0; this.w = 1;}
    public void SetRectGivenRect(double X, double Y, double Z){
        this.x = X; this.y = Y; this.z = Z; this.w = 1;}
    public void SetRectGivenPolar(double m, double θ){
        θ = θ * Math.PI / 180;
        this.x = m * Math.Cos(θ);
        this.y = m * Math.Sin(θ);}
    public void SetRectGivenMagHeadPitch(double m, double h, double p){
        h = h * Math.PI / 180;
        p = p * Math.PI / 180;
        this.x = m * Math.Cos(p) * Math.Cos(h);
        this.y = m * Math.Cos(p) * Math.Sin(h);
        this.z = m * Math.Sin(p);}
    public void SetRectGivenTwoPoints(double x1, double y1, double z1, double x2, double y2, double z2){
        this.x = x2 - x1;
        this.y = y2 - y1;
        this.z = z2 - z1;}
    public void SetRectGivenTwoPoints(double x1, double y1, double x2, double y2){
        this.x = x2 - x1;
        this.y = y2 - y1;
        this.z = 0;}
    public void SetRectGivenTwoPoints(Vector p1, Vector p2){
        this.x = p2.GetX() - p1.GetX();
        this.y = p2.GetY() - p1.GetY();
        this.z = p2.GetZ() - p1.GetZ();}
    #endregion
    #region "Print"
    public string PrintRect() => (String.Format("<{0:F2}, {1:F2}, {2:F2}>", GetX(), GetY(), GetZ()));
    public string PrintMagHeadPitch() => (String.Format("M: {0:F2}  θ: {1:F2}°  ρ: {2:F2}°", GetMagnitude(), GetHeading(), GetPitch()));
    public string PrintAngles() => (String.Format("Alpha: {0:F2}° Beta: {1:F2}° Gamma: {2:F2}°",GetAlpha(), GetBeta(), GetGamma()));
    #endregion
    #region "Gets"
    public double GetMagnitude() =>(Math.Sqrt(GetX() * GetX() + GetY() * GetY() + GetZ() * GetZ()));
    public double GetPitch() => (GetMagnitude() == 0) ? 0 : (Math.Asin(GetZ() / GetMagnitude()) * 180 / Math.PI);
    public double GetHeading() => (Math.Sqrt(GetX() * GetX() + GetY() * GetY()) == 0) ? 0 : ((GetY() >= 0) ? Math.Acos(GetX() / Math.Sqrt(GetX() * GetX() + GetY() * GetY())) : 2 * Math.PI - Math.Acos(GetX() / Math.Sqrt(GetX() * GetX() + GetY() * GetY())));
    public double GetAlpha() => (GetMagnitude() == 0) ? 0 : (Math.Acos(GetX() / GetMagnitude()) * 180 / Math.PI);
    public double GetBeta() => (GetMagnitude() == 0) ? 0 : (Math.Acos(GetY() / GetMagnitude()) * 180 / Math.PI);
    public double GetGamma() => (GetMagnitude() == 0) ? 0 : (Math.Acos(GetZ() / GetMagnitude()) * 180 / Math.PI);
    public double GetX() => (x);
    public double GetY() => (y);
    public double GetZ() => (z);
    public double GetW() => (w);
    #endregion
    #region "Operator Overloads"
    public static Vector operator +(Vector u, Vector v) =>
        new Vector(u.GetX() + v.GetX(), u.GetY() + v.GetY(), u.GetZ() + v.GetZ());
    public static Vector operator -(Vector u, Vector v) =>
        new Vector(u.GetX() - v.GetX(), u.GetY() - v.GetY(), u.GetZ() - v.GetZ());
    public static Vector operator &(double s, Vector u) =>
        new Vector(u.GetX() * s, u.GetY() * s, u.GetZ() * s);
    public static Vector operator &(Vector u, double s) =>
        new Vector(u.GetX() * s, u.GetY() * s, u.GetZ() * s);
    public static double operator *(Vector v1, Vector v2) =>
        (v1.GetX() * v2.GetX() + v1.GetY() * v2.GetY() + v1.GetZ() * v2.GetZ());
    public static Vector operator !(Vector u) =>
        new Vector(u.GetX() / u.GetMagnitude(), u.GetY() / u.GetMagnitude(), u.GetZ() / u.GetMagnitude());
    public static Vector operator >(Vector u, Vector v) =>
       (((u * v) / (v.GetMagnitude() * v.GetMagnitude())) & v);
    public static Vector operator <(Vector u, Vector v) => (u - (u > v));
    public static double operator %(Vector u, Vector v) =>
        (Math.Acos((u * v) / (u.GetMagnitude() * v.GetMagnitude())));
    public static double operator ^(Vector u, Vector v) =>
        (u.GetX() * v.GetX() + u.GetY() * v.GetY() +
        u.GetZ() * v.GetZ() + u.GetW() * v.GetW());
    #endregion
    #region"Static Operations"
    public static Vector CrossProduct(Vector u, Vector v) => new Vector(u.GetY() * v.GetZ() - v.GetY() * u.GetZ(), -(u.GetX() * v.GetZ() - v.GetX() * u.GetZ()), u.GetX() * v.GetY() - v.GetX() * u.GetY());
    public static Vector ClosestPointLine(Vector q, Vector p, Vector d)
        => (p + ((q - p) > d));
    public static Vector LineDistance(Vector q, Vector p, Vector d) =>
        (q - ClosestPointLine(q, p, d));
    public static Vector ClosestPointPlane(Vector a, Vector b, Vector c, Vector q)
        => (q - ((q - a) > CrossProduct(b - a, c - a)));
    public static Vector PlaneDistance(Vector a, Vector b, Vector c, Vector q)
        => (q - ClosestPointPlane(a, b, c, q));
    public static List<Vector> TranslateVertices(Vector t, List<Vector> v){
        List<Vector> tempList = new List<Vector>();
        Vector[] T = { new Vector(1, 0, 0, t.GetX()), new Vector(0, 1, 0, t.GetY()), new Vector(0, 0, 1, t.GetZ()), new Vector(0, 0, 0, 1) };
        for (int i = 0; i < v.Count; i++){
            tempList.Add(new Vector(T[0] ^ v[i], T[1] ^ v[i], T[2] ^ v[i], T[3] ^ v[i]));}
        return tempList;}
    public static List<Vector> RawScaleVertices(Vector s, List<Vector> v){
        List<Vector> tempList = new List<Vector>();
        Vector[] T = { new Vector(s.GetX(), 0, 0, 0), new Vector(0, s.GetY(), 0, 0), new Vector(0, 0, s.GetZ(), 0), new Vector(0, 0, 0, 1), new Vector(0, 0, 0, 1) };
        for (int i = 0; i < v.Count; i++){
            tempList.Add(new Vector(T[0] ^ v[i], T[1] ^ v[i], T[2] ^ v[i], T[3] ^ v[i]));}
        return tempList;}
    public static List<Vector> ScaleAboutCenterVertices(Vector s, Vector c, List<Vector> v){
        List<Vector> tempList = new List<Vector>();
        Vector[] T = { new Vector(s.GetX(), 0, 0, c.GetX() * (1 - s.GetX())), new Vector(0, s.GetY(), 0, c.GetY() * (1 - s.GetY())), new Vector(0, 0, s.GetZ(), c.GetZ() * (1 - s.GetZ())), new Vector(0, 0, 0, 1)};
        for (int i = 0; i < v.Count; i++){
            tempList.Add(new Vector(T[0] ^ v[i], T[1] ^ v[i], T[2]^v[i], T[3] ^ v[i]));}
        return tempList;
    }
    #endregion
}