using System.Text.Json;

namespace Modul;

public class JsonStudentRepository: IStudentRepository
{
    public void Save(Student[] students, string filePath)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string json = JsonSerializer.Serialize(students, options);
        File.WriteAllText(filePath, json);

    }

    public Student[] Load(string filePath)
    {
        if (!File.Exists(filePath)) return Array.Empty<Student>();

        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<Student[]>(json) ?? Array.Empty<Student>();
    }
}