namespace DatabaseEntities;

public class SessionResult
{
    public int Student { get; set; }
    public int Subject { get; set; }
    public int Teacher { get; set; }
    public DateOnly DateOfExam { get; set; }
    public int Mark { get; set; }

    public SessionResult(int student, int subject, int teacher, DateOnly dateOfExam, int mark)
    {
        Student = student;
        Subject = subject;
        Teacher = teacher;
        DateOfExam = dateOfExam;
        Mark = mark;
    }
}
