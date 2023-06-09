using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _024_StudentClass
{
    internal class Program
    {
        public class Student
        {
            private string name;
            private double age;
            private string major;


            public Student(string n, double a, string m)
            {
                this.name = n;
                this.age = a;
                this.major = m;
            }

            public void DisplayInfo () { Console.WriteLine("이름 : {0}, 나이 : {1}, 전공 : {2}", name, age, major); }
        }
        
        static void Main(string[] args)
        {
            Student s = new Student("홍길동", 20, "의료IT공학과");
            s.DisplayInfo();
        }
    }
}
