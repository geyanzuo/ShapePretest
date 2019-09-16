using System;
using System.Collections.Generic;
using System.Text;

namespace ShapePretest
{
    public class Triangle: Shape
    {
        public double Side1;
        public double Side2;
        public double Side3;

        public Triangle(double pside1, double pside2, double pside3, double pcolor ): base(pcolor)
        {
            Side1 = pside1;
            Side2 = pside2;
            Side3 = pside3;
        }
    }
}
