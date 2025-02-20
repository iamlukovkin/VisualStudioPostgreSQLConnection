using Npgsql;
using DatabaseConnector;
using DatabaseEntities;
using EntityRepositories;

public class Program
{
    public static void Main()
    {
        // Here's enter your credentials for connection to database
        ConnectionFactory.Host = "";
        ConnectionFactory.Port = ""; 
        ConnectionFactory.DatabaseName = ""; 
        ConnectionFactory.Username = ""; 
        ConnectionFactory.Password = ""; 

        List<Department> departments = DepartmentRepository.GetDepartments();

        foreach (Department department in departments)
        {
            Console.WriteLine(department);
        }
    }
}