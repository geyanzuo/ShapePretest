using System;
using System.Collections.Generic;
using System.Text;

namespace ShapePretest
{
    public class Cricle: Shape
    {
        public readonly double PI;
        public double Radius;

        public Cricle (double pradius, double pcolor): base(pcolor)
        {
            PI = 3.142;
            Radius = pradius;
        }

        public void cricle()
        {
            return;
        }
    }
}
