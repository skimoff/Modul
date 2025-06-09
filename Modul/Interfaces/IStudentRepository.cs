namespace Modul;

public interface IStudentRepository
{
    void Save(Student[] students, string filePath);
    Student[] Load(string filePath);
}