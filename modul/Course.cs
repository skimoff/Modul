using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul
{
    public class Course
    {
        public string NameOfCourse { get; set; } = "Noname";
        public int NumberOfHours { get; set; }
        public bool GetCertificate { get; set; }
        public bool IsCompleted { get; set; }
        
        public Course(string nameOfCourse, int numberOfHours, bool getCertificate, bool isCompleted) 
        {
            NameOfCourse = nameOfCourse;
            NumberOfHours = numberOfHours;
            GetCertificate = getCertificate;
            IsCompleted = isCompleted;
        }
        public Course()
        {
            //NameOfCourse = "Noname";
            //NumberOfHours = 0;
            //GetCertificate = false;
            //IsCompleted = false;
        }

        public override bool Equals(object obj)
        {
            if(obj is Course other)
            {
                return GetHashCode() == other.GetHashCode();
            }
            return false;
        }
        public override int GetHashCode()
        {
            return NameOfCourse.GetHashCode();
        }
        public override string ToString()
        {
            return $"Name course: {NameOfCourse}\nNumbers of hours: {NumberOfHours}\nGet certificate: {GetCertificate}\nIs complited: {IsCompleted}";
        }
    }
}
