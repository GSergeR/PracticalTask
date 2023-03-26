using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public class NotFigureException: Exception
    {
        public NotFigureException() {
            //Console.WriteLine("NotFigureException: A shape cannot have less than three vertices");
        }

        public NotFigureException(int count)
            : base(String.Format("NotFigureException: Figure cannot have {0} vertices", count))
        {

        }
    }

    public class NotTriangleException : Exception
    {
        public NotTriangleException()
        {
            //Console.WriteLine("NotTriangleException: A triangle cannot have more than three vertices");
        }

        public NotTriangleException(int count)
            : base(String.Format("NotTriangleException: Triangle cannot contain {0} vertices", count))
        {

        }
    }
}
