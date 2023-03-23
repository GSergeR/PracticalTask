using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
	public class Triangle : IFigure
	{
		CustomVerticesFigure triangle;
		public double Square => triangle.Square;

		public Triangle(Point a, Point b, Point c) : this(new Point[] { a, b, c })
		{
		}

		public Triangle(Point[] vertices)
		{
			if (vertices.Length != 3) throw new Exception("It's not a triangle");
			triangle = new CustomVerticesFigure(vertices);
		}

		/// <summary>
		/// https://www.calc.ru/Formula-Dliny-Otrezka.html
		/// </summary>
		/// <param name="lengthA"></param>
		/// <param name="lengthB"></param>
		/// <param name="lengthC"></param>
		public Triangle(double lengthA, double lengthB, double lengthC)
		{
			//Формулы для поиска вершин расчитал на листочке (если нужно, могу скинуть расчеты)

			Point A = new Point(0, 0);
			Point B = new Point(0, lengthA);

			double Cy = (Math.Pow(lengthC, 2) - Math.Pow(lengthB, 2) + Math.Pow(lengthA, 2)) / (2 * lengthA);
			double Cx = Math.Sqrt(Math.Pow(lengthC, 2) - Math.Pow(Cy, 2));
			Point C = new Point(Cx, Cy);

			triangle = new CustomVerticesFigure(new Point[] { A, B, C });
		}

		public bool isRightTriangle()
		{
			double lengthA = triangle.getSquareLengthSegment(0);
			double lengthB = triangle.getSquareLengthSegment(1);
			double lengthC = triangle.getSquareLengthSegment(2);

			return Math.Max(lengthA,Math.Max(lengthB,lengthC)) * 2 == lengthA + lengthB + lengthC;
		}

	}
}
