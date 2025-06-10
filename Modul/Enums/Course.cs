namespace Modul;

public class Course:ICourseStatus
{
    public string NameOfCourse { get; set; } = "Noname";
    public int NumberOfHours { get; set; }
    public bool GetCertificate { get; set; }
    public int DelayInDays { get; set; }
    public CourseStatus Status { get; set; }
    
    public Course(string nameOfCourse, int numberOfHours, bool getCertificate, int  delayInDays, CourseStatus status) 
    {
        NameOfCourse = nameOfCourse;
        NumberOfHours = numberOfHours;
        GetCertificate = getCertificate;
        DelayInDays = delayInDays;
        Status = delayInDays > 0 ? CourseStatus.Delayed : CourseStatus.NotStarted;
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

    public CourseStatus GetStatus()
    {
        return Status;
    }
}