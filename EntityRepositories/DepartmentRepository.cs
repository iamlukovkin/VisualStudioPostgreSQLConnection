using Npgsql;
using DatabaseEntities;
using DatabaseConnector;

namespace EntityRepositories;
public static class DepartmentRepository
{
    public static List<Department> GetDepartments()
    {
        List<Department> departments = new List<Department>();
        try
        {
            NpgsqlConnection connection = ConnectionFactory.Create();
            connection.Open();
            using NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM department", connection);
            using NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                departments.Add(
                    new Department(
                        int.Parse(reader["code"].ToString()),
                        reader["full_name"].ToString(),
                        int.Parse(reader["manager"].ToString()
                        )
                    )
                );
            }
            connection.Close();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            return departments;
        }
        return departments;
    }
}

