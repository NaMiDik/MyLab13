using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLab13_1
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }
    public class Square : Shape
    {
        public double A {  get; set; }
        public Square(double a)
        {
            A = a;
        }
        public override double GetArea()
        {
            return A * A;
        }
    }
    public class Circle : Shape
    {
        public double R {  get; set; }
        public Circle(double r)
        {
            R = r;
        }
        public override double GetArea()
        {
            return Math.PI * R * R;
        }
    }
}
