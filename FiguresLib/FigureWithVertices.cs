using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
	public abstract class FigureWithVertices : IFigure
	{
		protected Point[] vertices;
		List<Segment> segments;
		/// <summary>
		/// http://www.bolshoyvopros.ru/questions/2523820-kak-najti-ploschad-geometricheskoj-figury-po-koordinatam.html
		/// </summary>
		public double Square { get {
			double result = 0;
			for (int i = 1; i < vertices.Length; i++)
			{
				result += vertices[i - 1].X * vertices[i].Y;
			}
			result += vertices[vertices.Length - 1].X * vertices[0].Y;
			for (int i = 1; i < vertices.Length; i++)
			{
				result -= vertices[i].X * vertices[i-1].Y;
			}
			result -= vertices[0].X * vertices[vertices.Length - 1].Y;
			return Math.Abs(result) * 0.5; 
		} }

		protected void CheckFigure()
		{
			//CheckOnLessThreeVirtices();
			CheckMatchVertices();
			CheckСrossing();
		}

		void CheckOnLessThreeVirtices()
		{
			if (vertices.Length < 3) throw new NotFigureException(vertices.Length);
		}

		void CheckMatchVertices()
		{
			for (int i = 0; i < vertices.Length; i++)
				for (int j = 0; j < vertices.Length; j++)
				{
					if (i != j)
						if(vertices[i] == vertices[j]) throw new Exception("Figure has matching vertices");
				}
		}

		void initSegments()
		{
			segments = new List<Segment>();
			for (int i = 0; i < vertices.Length - 1; i++)
			{
				segments.Add(new Segment(vertices[i], vertices[i + 1]));
			}
			segments.Add(new Segment(vertices[vertices.Length - 1], vertices[0]));
		}

		void CheckСrossing()
		{
			if (segments == null) initSegments();
			for (int i = 0; i < segments.Count; i++)
				for (int j = 0; j < segments.Count; j++)
				{
					if (i == j) continue;
					if (segments[i].isCross(segments[j])) throw new Exception("The edges of the figure intersect");
				}
		}

		public double getSquareLengthSegment(int index)
		{
			if(index >= segments.Count) throw new Exception("Incorrect edge number");

			return Math.Pow(segments[index].A.Y - segments[index].A.X, 2) + Math.Pow(segments[index].B.Y - segments[index].B.X, 2);
		}

		public double getLengthSegment(int index)
		{
			return Math.Sqrt(getSquareLengthSegment(index));
		}
	}
}
