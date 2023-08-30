using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatorStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students();
            students.Add(new Student("김윤서", 4.5));
            students.Add(new Student("나미림", 4.4));
            students.Add(new Student("마이콜", 1.5));

            students.Print();
            students.Print((student) =>
            {
                Console.WriteLine("*****************");
                Console.WriteLine("이름: "+student.Name);
                Console.WriteLine("학점: " + student.Score);
            });

            Console.WriteLine("<students>");
            students.Print((s) =>
            {
                Console.WriteLine("  <student>");
                Console.WriteLine("    <name>" + s.Name+ "</name>");
                Console.WriteLine("    <score>" + s.Score + "</score>");
                Console.WriteLine("  </student>");
            });
            Console.WriteLine("/<students>");
        }
    }
}
