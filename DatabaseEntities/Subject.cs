namespace DatabaseEntities;
public class Subject
{
    public int Code { get; set; }
    public String FullName { get; set; }
    public int HoursCount { get; set; }
    public int SemestersCount { get; set; }

    public Subject(int code, string fullName, int hoursCount, int semestersCount)
    {
        Code = code;
        FullName = fullName;
        HoursCount = hoursCount;
        SemestersCount = semestersCount;
    }
}
