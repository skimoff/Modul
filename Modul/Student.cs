using System.Text.Json;

namespace Modul;

public class Student
{
    public string Name { get; } = "Noname";
    public string Surname { get; set; } = "Noname";
    public Course[] Courses { get; private set; } = Array.Empty<Course>();
    
    public Student(string name, string surname, Course[] courses)
    {
        Name = name;
        Surname = surname;
        Courses = courses;
    }
    

    public void AddCourse(Course course)
    {
        foreach (var c in Courses)
        {
            if (c.Equals(course))
            {
                Console.WriteLine($"Курс \"{course.NameOfCourse}\" вже додвн для {Name}.");
                return;
            }
        }
        
        Course[] newCourses = new Course[Courses.Length + 1];
        for (int i = 0; i < Courses.Length; i++)
        {
            newCourses[i] = Courses[i];
        }
        newCourses[Courses.Length] = course;
        Courses = newCourses;
    }
    public void PrintCourseInfo()
    {
        Console.WriteLine($"Студент: {Name}");
        foreach (var course in Courses)
        {
            Console.WriteLine($"- Курс: {course.NameOfCourse}");
            Console.WriteLine($"  Годин: {course.NumberOfHours}");
            Console.WriteLine($"  Сертифікат: {(course.GetCertificate ? "Так" : "Ні")}");
            Console.WriteLine($"  Статус: {course.GetStatus()}");
        }
        Console.WriteLine();
    }
    
    public override bool Equals(object? obj)
    {
        if (obj is Student other)
        {
            return GetHashCode() == other.GetHashCode();
        }
        return false;
    }
    public override int GetHashCode()
    {
        int hash = Name.GetHashCode();
        foreach (var course in Courses)
        {
            hash = HashCode.Combine(hash, course.GetHashCode());
        }
        return hash;
    }

    public override string ToString()
    {
        return $"Ім'я: {Name}\nФамілія: {Surname}\nКурс: {Courses}";
    }
}