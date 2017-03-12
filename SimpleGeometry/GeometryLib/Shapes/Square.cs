using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    public class Square: Shape
    {
        public double Side { get; }

        public Square(double side)
        {
            Debug.Assert(side > 0, "radius > 0");
            Side = side;
        }

        public override double Area()
        {
            double area = 0;
            var square = (Square)this;
            area = square.Side * square.Side;
            return area;
        }

        public override string Print()
        {
            return ($"Square: side = {this.Side}, area = {this.Area()}");
        }
    }
}
