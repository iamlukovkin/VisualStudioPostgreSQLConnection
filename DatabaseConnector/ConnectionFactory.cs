using Npgsql;
namespace DatabaseConnector;

public static class ConnectionFactory
{
    public static string Host { get; set; }
    public static string Port { get; set; }
    public static string DatabaseName { get; set; }
    public static string Username { get; set; }
    public static string Password { get;  set; }

    public static NpgsqlConnection Create()
    {
        if (Host == null
            || Port == null
            || DatabaseName == null
            || Username == null
            || Password == null)
        {
            throw new Exception("Some one of required argument is null!");
        }
        string connectionString = $"Host={Host};Port={Port};Database={DatabaseName};User Id={Username};Password={Password};";
        return new NpgsqlConnection(connectionString);
    }
}
