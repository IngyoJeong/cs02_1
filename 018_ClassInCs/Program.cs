using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_ClassInCs
{
    class product
    {
        public string name;
        public int price;
    }

    class MyMath
    {
        public static double PI = 3.14; //static 정적 변수(클래스 변수)
    }

    class MyCalendar
    {
        public const int months = 12;
        public const int weeks = 52;
        public const int days = 365;

        public const double daysPerWeek = (double)days / (double)weeks;
        public const double daysPerMonth = (double)days / (double)months;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            product p = new product();
            p.name = "시계";
            p.price = 100000;

            Console.WriteLine("{0} : {1:C}", p.name, p.price); //객체.값
            Console.WriteLine("원주율 : {0}", MyMath.PI); //static.값 객체를 안만들고 클래스 이름으로 써도됨
            Console.WriteLine("한 달은 평균 {0:F3}일", MyCalendar.daysPerMonth);
        }
    }
}
