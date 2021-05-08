using System;

namespace checkTriangle
{
    public static class CheckTriangle
    {
        public static string CheckTriangleType(double a, double b, double c)
        {
            double maxside, side1, side2;
            if (a + b > c && a + c > b && b + c > a &&
                a > 0 && b > 0 && c > 0)
            {
                if (a >= b)
                {
                    if (a >= c)
                    {
                        maxside = a;
                        side1 = b;
                        side2 = c;
                    }
                    else
                    {
                        maxside = c;
                        side1 = a;
                        side2 = b;
                    }
                }
                else
                {
                    if (b >= c)
                    {
                        maxside = b;
                        side1 = a;
                        side2 = c;
                    }
                    else
                    {
                        maxside = c;
                        side1 = a;
                        side2 = b;
                    }
                }

                if (Math.Pow(maxside, 2.0) == Math.Pow(side1, 2.0) + Math.Pow(side2, 2.0))
                    return "Right triangle";
                else if (Math.Pow(maxside, 2.0) > Math.Pow(side1, 2.0) + Math.Pow(side2, 2.0))
                    return "Obtuse triangle";
                else
                    return "Acute triangle";
            }
            else
                return "This is not a triangle.";
        }
    }
}
