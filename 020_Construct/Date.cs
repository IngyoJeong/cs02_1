using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_Construct
{
    internal class Date
    {
        private int year, month, day;

        public Date()
        {
            year = 1; //this 생략
            month = 1; //this 생략
            day = 1; //this 생략
        }

        public Date(int y, int m, int d)
        {
            year = y; //this 생략
            month = m; //this 생략
            day = d; //this 생략
        }

        public void PrintDate()
        {
            Console.WriteLine("{0}/{1}/{2}", year, month, day);
        }
    }
}
