using System;

namespace _022_RectangleClass
{
    internal class Program
    {
        public class Rectangle
        {
            private double width;
            private double height;

            public Rectangle(double w, double h)
            {
                this.width = w;
                this.height = h;
            }

            public double GetArea()
            {
                double area = width * height;
                return area;
            }

            public double GetPerimeter()
            {
                double Perimeter = 2 * (width + height);
                return Perimeter;
            }
        }

        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(8, 5);
            double area = rect.GetArea();
            double perimeter = rect.GetPerimeter();

            Console.WriteLine("넓이 : " + area);
            Console.WriteLine("둘레 : " + perimeter);
        }
    }
}
