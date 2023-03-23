using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public class Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static bool operator==(Point A1, Point A2)
        {
            return A1.X == A2.X && A1.Y == A2.Y;
        }

        public static bool operator!=(Point A1, Point A2)
        {
            return !(A1 == A2);
        }
    }
}
