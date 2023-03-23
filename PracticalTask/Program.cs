using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguresLib;

namespace PracticalTask
{
	class Program
	{
		static void Main(string[] args)
		{
			Circle circle = new Circle(10);
			Console.WriteLine($"Площадь круга с радиусом 10 равен - {circle.Square}");

			Triangle triangleLength = new Triangle(5, 5, 5);
			Console.WriteLine($"Площадь треугольника со сторонами 5х5х5 равен - {triangleLength.Square}, и он " + (triangleLength.isRightTriangle()?"":"НЕ ") + "прямоугольный");

			Console.WriteLine("\nДополнительно");
			Triangle triangle = new Triangle(new Point(0, 0), new Point(0, 10), new Point(10, 0));
			Console.WriteLine($"Площадь треугольника с вершинами (0, 0) (0, 10) (10, 0) равен - {triangle.Square}, и он " + (triangle.isRightTriangle() ? "" : "НЕ ") + "прямоугольный");
			
			CustomVerticesFigure customFigure = new CustomVerticesFigure(new Point[] { new Point(0, 0), new Point(0, 10), new Point(10, 0), new Point(10,-10), new Point(-10, -10) });
			Console.WriteLine($"Площадь произвольной фигуры равна - {customFigure.Square}");


			Console.ReadKey();
		}
	}
}
