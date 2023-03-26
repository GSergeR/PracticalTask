using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguresLib;

namespace FigureTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(NotFigureException))]
        public void Create_figure_less_tree_vertices()
        {
            CustomVerticesFigure line = new CustomVerticesFigure(new Point[] { new Point(0, 0), new Point(1, 1) });
        }

        [TestMethod]
        [ExpectedException(typeof(NotTriangleException))]
        public void Triangle_is_not_a_triangle()
        {
            Triangle triangle = new Triangle(new Point[] { new Point(0, 0), new Point(1, 1) });
        }

        [TestMethod]
        public void Square_circle()
        {
            double radius = 10;
            double expected = Math.PI * Math.Pow(radius, 2);
            Circle circle = new Circle(radius);

            Assert.AreEqual(expected, circle.Square);
        }

        [TestMethod]
        public void Square_triangle()
        {
            Triangle triangle = new Triangle(new Point(0, 0), new Point(0, 10), new Point(10, 0));
            double expected = 50;

            Assert.AreEqual(expected, triangle.Square);
        }

        [TestMethod]
        public void Right_triangle()
        {
            Triangle rightTriangle = new Triangle(new Point(0, 0), new Point(0, 10), new Point(10, 0));

            Assert.AreEqual(true, rightTriangle.isRightTriangle());
        }
    }
}
