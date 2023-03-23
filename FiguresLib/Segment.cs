using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
	class Segment
	{
		public Point A { get; private set; }
		public Point B { get; private set; }

		public Segment(Point a, Point b)
		{
			A = a;
			B = b;
		}

		/// <summary>
		/// http://algolist.ru/maths/geom/intersect/lineline2d.php
		/// </summary>
		/// <param name="otherSegment"></param>
		/// <returns></returns>
		public bool isCross(Segment otherSegment)
		{
			double	maxx1 = Math.Max(this.A.X, this.B.X), //0
					maxy1 = Math.Max(this.A.Y, this.B.Y),//10
					minx1 = Math.Min(this.A.X, this.B.X), //0
					miny1 = Math.Min(this.A.Y, this.B.Y),//0
					maxx2 = Math.Max(otherSegment.A.X, otherSegment.B.X),//10
					maxy2 = Math.Max(otherSegment.A.Y, otherSegment.B.Y),//10
					minx2 = Math.Min(otherSegment.A.X, otherSegment.B.X), //0
					miny2 = Math.Min(otherSegment.A.Y, otherSegment.B.Y);//0

			if (minx1 >= maxx2 || maxx1 <= minx2 || miny1 >= maxy2 || maxy1 <= miny2)
				return false;  // Момент, когда линии имеют одну общую вершину...


			double dx1 = this.B.X - this.A.X, dy1 = this.B.Y - this.A.Y; // Длина проекций первой линии на ось x и y
			double dx2 = otherSegment.B.X - otherSegment.A.X, dy2 = otherSegment.B.Y - otherSegment.A.Y; // Длина проекций второй линии на ось x и y
			double dxx = this.A.X - otherSegment.A.X, dyy = this.A.Y - otherSegment.A.Y;
			double div, mul;


			if ((div = dy2 * dx1 - dx2 * dy1) == 0)
				return false; // Линии параллельны...
			if (div > 0)
			{
				if ((mul = dx1 * dyy - dy1 * dxx) < 0 || mul > div)
					return false; // Первый отрезок пересекается за своими границами...
				if ((mul = (dx2 * dyy - dy2 * dxx)) < 0 || mul > div)
					return false; // Второй отрезок пересекается за своими границами...
			}

			if ((mul = -(dx1 * dyy - dy1 * dxx)) < 0 || mul > -div)
				return false; // Первый отрезок пересекается за своими границами...
			if ((mul = -(dx2 * dyy - dy2 * dxx)) < 0 || mul > -div)
				return false; // Второй отрезок пересекается за своими границами...
			
			return true;
		}
	}
}
