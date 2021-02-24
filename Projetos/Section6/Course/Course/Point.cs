using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    struct Point
    {
        private double x, y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }
    }
}
