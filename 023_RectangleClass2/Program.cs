using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _023_RectangleClass2
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

        public double GetArea () { return width * height; }

        public double GetPerimeter () { return 2 * ( width + height); }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 3);
            double area = rect.GetArea();
            double perimeter = rect.GetPerimeter();

            Console.WriteLine("넓이 : " + area);
            Console.WriteLine("둘레 : " + perimeter);
        }
    }
}
