using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Tanvir","13245",2.5f);
            Student s2 = new Student("Sabbir","13246",3.5f);
            Student s3 = new Student("Rahim","13246",3.5f);

            Department d1 = new Department("Computer Science", "CS");
            Department d2 = new Department("Electrical Engineering", "EEE");

            s1.Dept = d1;
            d1.AddStudent(s1,s2,s3);
           
            s2.Dept = d1;
            s3.Dept = d2;
            d2.AddStudent(s3);
            s1.ShowDepartmentDetails();
            s3.ShowDepartmentDetails();
            Console.WriteLine("*********");
            d1.Name = "Computer Science and Engineering";
            d1.Id = "CSE";
            s2.ShowDepartmentDetails();
            Console.WriteLine("*********");
            d2.PrintStudents();
            s3.Name = "Abdur Rahim";
            d2.PrintStudents();


        }
    }
}
