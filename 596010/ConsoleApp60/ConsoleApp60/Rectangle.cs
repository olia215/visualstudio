using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp60
{
    internal class Rectangle : Figure
    {
        private double width;
        private double height;

        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }

        public override double GetArea()
        {
            return width * height;
        }

        public override double GetPerimeter()
        {
            return 2 * (width + height);
        }

        public override int CompareTo(Figure other)
        {
            return GetArea().CompareTo(other.GetArea());
        }
    }
}
