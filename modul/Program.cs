using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("name1","lastname1",20);
            var person2 = new Person("name2","lastname2", 21);
            var course1 = new Course[]
            {
                new Course("name1", 20, true, true),
                new Course("name2", 19, true, false)
            };
            var anotherCourse = new Course("name3", 12, false, false);

            var course2 = new Course[]
            {
                new Course("anotherName1", 20, true, true),
                new Course("anotherName2", 19, true, false)
            };
            var student1 = new Student(person1, course1);
            
            var student2 = new Student(person2, course2);

            student1.showInfo();
            if(student1 == student2)
            {
                Console.WriteLine("stu1 == stu 2");
            }
            else 
            {
                Console.WriteLine("stu1 != stu 2");
            }
            var student3 = new Student(person2, course2);
            var student4 = student3;

            if (student3 == student4)
            {
                Console.WriteLine("stu3 == stu 4");
            }
            //student2.showInfo();
            Console.ReadKey();
        }
    }
}
