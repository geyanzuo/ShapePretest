using System;
using System.Collections.Generic;
using System.Text;

namespace ShapePretest
{
    public class Rectangle: Quadrilateral
    {
        public Rectangle(double pside1, double pside2, double pcolor): base(pside1, pside2, pside1, pside2, pcolor)
        {
        }
    }
}
