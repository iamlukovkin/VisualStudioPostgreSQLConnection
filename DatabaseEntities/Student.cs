namespace DatabaseEntities;

public class Student
{
    public int Code { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Surname { get; set; }
    public DateOnly Birthday { get; set; }
    public float Scholarship { get; set; }

    public Student(int code, string firstName, string lastName, string surname, DateOnly birthday, float scholarship)
    {
        Code = code;
        FirstName = firstName;
        LastName = lastName;
        Surname = surname;
        Birthday = birthday;
        Scholarship = scholarship;
    }
}
