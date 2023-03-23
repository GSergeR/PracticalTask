using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
	public class Circle : IFigure
	{
		Point center;
		double radius;

		public Circle(Point center, double radius)
		{
			this.center = center;
			this.radius = radius;
		}

		public Circle(double radius):this(new Point(0,0),radius)
		{

		}
		public double Square => Math.PI * Math.Pow(radius, 2);
	}
}
