using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterfaces
{
    public interface IShape
    {
        void Area();
    }
    class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public void Area()
        {
            Console.WriteLine("Area of Circle: "+ Math.PI*radius*radius);
        }
        public void GetShape()
        {
            Console.WriteLine("it's a Circle");
        }
    }
    class Square : IShape
    {
        private double length;

        public Square(double length)
        {
            this.length = length;
        }

        public void Area()
        {
           Console.WriteLine("Area of Square: "+ length*length);
        }
        
        public void GetShape()
        { 
            Console.WriteLine("it's a square"); 
        }
        
    }
    internal class Demo1
    {
        static void Main()
        {
            Circle c=new Circle(23);
            c.Area();
            c.GetShape();
            Square s=new Square(13);
            s.Area();
            s.GetShape();
            IShape circle=new Circle(10);
            circle.Area();
            IShape square=new Square(10);
            square.Area();
        }
    }
}
