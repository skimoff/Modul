namespace Modul;

public class Course:ICourseStatus
{
    public string NameOfCourse { get; set; } = "Noname";
    public int NumberOfHours { get; set; }
    public bool GetCertificate { get; set; }
    public int DelayInDays { get; set; }
    
    public Course(string nameOfCourse, int numberOfHours, bool getCertificate, int  delayInDays) 
    {
        NameOfCourse = nameOfCourse;
        NumberOfHours = numberOfHours;
        GetCertificate = getCertificate;
        DelayInDays = delayInDays;
    }

    public string GetStatus()
    {
        return DelayInDays > 0 ? $"Розпочнеться через {DelayInDays} днів" : "В процесі/Пройден";
    }
    public override bool Equals(object? obj)
    {
        if (obj is not Course other)
            return false;

        return NameOfCourse == other.NameOfCourse &&
               NumberOfHours == other.NumberOfHours &&
               GetCertificate == other.GetCertificate &&
               DelayInDays == other.DelayInDays;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(NameOfCourse, NumberOfHours, GetCertificate, DelayInDays);
    }
}