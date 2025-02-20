namespace DatabaseEntities;

public class Department
{
    public int? Code { get; set; }
    public string? FullName { get; set; }
    public int? Manager { get; set; }

    public Department(int? code, string? fullName, int? manager)
    {
        Code = code;
        FullName = fullName;
        Manager = manager;
    }

    public Department()
    {
        FullName = "";
    }

    public override string ToString()
    {
        return $"Department(Code='{Code}'; FullName='{FullName}'; Manager='{Manager}';";
    }
}

