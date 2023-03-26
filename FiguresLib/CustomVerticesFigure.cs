using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
	public class CustomVerticesFigure:FigureWithVertices
	{
		public CustomVerticesFigure(Point[] vertices)
		{
			if (vertices.Length < 3) throw new NotFigureException(vertices.Length);
			this.vertices = vertices;
			CheckFigure();
			/*try
            {
				CheckFigure();
			}
			catch (NotFigureException e)
            {
				Console.WriteLine(e.Message);
            }*/
		}
	}
}
