using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul
{
    public class Student
    {
        public Person Person { get; set; }
        private Course[] courses;
        public Course[] Courses { get; set; }

        public Student(Person person, Course[] courses)
        {
            Person = person;
            Courses = courses;
        }
        public Student()
        {
            Person = new Person();
            Courses = new Course[0];
        }
        public void addCourse(params Course[] newCourse)
        {
            if (newCourse == null||newCourse.Length == 0) return;
            int oldLength = Courses.Length;
            Array.Resize(ref courses, oldLength + newCourse.Length);
            Array.Copy(newCourse, 0 ,Courses, oldLength, newCourse.Length+1);
        }
        public void showInfo()
        {
            Console.WriteLine(Person.ToString());
            foreach(var c in Courses)
            {
                Console.WriteLine(c.ToString());
            }
        }
        public override bool Equals(object obj)
        {
            if (obj is Student other)
            {
                return GetHashCode() == other.GetHashCode();
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Person.GetHashCode();
        }
        public override string ToString()
        {
            return $"{Person.ToString()}\n{Courses}";
        }
    }
}
