using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Student
{
    class CreateStudents
    {
        static void Main(string[] args)
        {
            Student first = new Student();
            Student second = new Student();
            first.IdNumber = 123;
            first.LastName = "Burton";
            first.GradePointAverage = 3.5;

            Write("Enter students lastName");
            second.LastName = ReadLine();
            Write("Enter student ID number >>> ");
            second.IdNumber = con
        }
        static void Display(Student stu)
        {
            WriteLine("{0} {1} {2}", stu.IdNumber,
                stu.LastName, stu.GradePointAverage);
        }
       
    }
}
