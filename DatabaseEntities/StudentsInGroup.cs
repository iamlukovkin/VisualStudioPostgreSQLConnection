namespace DatabaseEntities;

public class StudentsInGroup
{
    public int Student { get; set; }
    public string GroupName { get; set; }
    public DateOnly DateStart { get; set; }
    public DateOnly DateEnd { get; set; }
    public StudentsInGroup(int student, string groupName, DateOnly dateStart, DateOnly dateEnd)
    {
        Student = student;
        GroupName = groupName;
        DateStart = dateStart;
        DateEnd = dateEnd;
    }
}
