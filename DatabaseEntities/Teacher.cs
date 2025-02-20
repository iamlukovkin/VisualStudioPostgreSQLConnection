namespace DatabaseEntities;

public class Teacher
{
    public int Code { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Surname { get; set; }
    public int Department { get; set; }
    public string Rank { get; set; }
    public string Post { get; set; }

    public Teacher(int code, string firstName, string lastName, string surname, int department, string rank, string post)
    {
        Code = code;
        FirstName = firstName;
        LastName = lastName;
        Surname = surname;
        Department = department;
        Rank = rank;
        Post = post;
    }
}
