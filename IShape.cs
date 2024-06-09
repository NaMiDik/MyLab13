using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLab13_2
{
    public interface IShape
    {
        double GetArea();
    }

    public class Square : IShape
    {
        public double A { get; set; }
        public Square(double a)
        {
            A = a;
        }
        public double GetArea()
        {
            return A*A;
        }
    }

    public class Circle : IShape
    {
        public double R { get; set; }
        public Circle(double r)
        {
            R = r;
        }
        public double GetArea()
        {
            return Math.PI * R * R;
        }
    }
}
