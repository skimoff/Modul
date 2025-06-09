namespace Modul;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        var csharp = new Course("C# Основи", 40, true, 0);
        var algorithms = new Course("Алгоритмы", 60, true, 5);
        var design = new Course("UI/UX Дизайн", 30, false, 2);
        var c = new Course("С++ Основи",60, true, 1);
        var course = new Course[]
        {
            csharp, algorithms, design
        };
        var student1 = new Student("John", "Doe", course);
        student1.AddCourse(c);
        student1.PrintCourseInfo();
        
        var student2 = new Student("Doe", "John", new Course[]{});
        student2.AddCourse(csharp);
        student2.AddCourse(algorithms);

        Console.WriteLine("Після додавання курсів");
        student1.PrintCourseInfo();
        student2.PrintCourseInfo();

        var students = new Student[] {student1, student2 };
        
        student1.Save(students,"Save.json");

        Console.WriteLine($"Однакові? {student1.Equals(student2)}");
        Console.ReadKey();
    }
}