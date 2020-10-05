

namespace Helloworld
{
    class Geometry
    {
        public static double getvector2Dlength(double X, double Y)
        {
            double aux = X * X + Y * Y;
            return System.Math.Sqrt(aux);
        }
        public static double getvector3Dlength(double X, double Y, double Z)
        {
            double aux = X * X + Y * Y + Z * Z;
            return System.Math.Sqrt(aux);

        }
        public static double GetCircleArea(double r)
        {
            double aux = r * r;
            return System.Math.PI * aux;
        }
        public static double GetDistance2D(double X1, double Y1, double X2, double Y2)
        {
            double vx = X2 - X1;
            double vy = Y2 - Y1;
            return Geometry.getvector2Dlength(vx, vy);
        }
        public static bool AreIntersect(double X1, double Y1, double R1, double X2, double Y2, double R2)
        {
            if (Geometry.GetDistance2D(X1, Y1, X2, Y2) <= Geometry.GetCircleArea(R1) + Geometry.GetCircleArea(R2))
                return true;
            else
                return false;
        }
    }
}
