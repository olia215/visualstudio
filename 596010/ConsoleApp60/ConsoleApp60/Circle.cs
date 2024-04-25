using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp60
{
    internal class Circle : Figure
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override int CompareTo(Figure other)
        {
            return GetArea().CompareTo(other.GetArea());
        }
    }
}
