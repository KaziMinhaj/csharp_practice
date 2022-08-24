namespace ADO_DOT_NET;

using System.Data.SqlClient;

public class DataHelper
{
    private readonly string _connectionString;
    public DataHelper(string connectionString)
    {
        _connectionString = connectionString;
    }

    private SqlCommand CreateSqlCommand(string sql, Dictionary<string, object> parameters)
    {
        SqlConnection connection = new SqlConnection(_connectionString);
        connection.Open();

        SqlCommand sqlCommand = new SqlCommand(sql, connection);

        foreach (var parameter in parameters)
        {
            sqlCommand.Parameters.Add(new SqlParameter(parameter.Key, parameter.Value));
        }

        return sqlCommand;
    }

    //write operation
    public void WriteOperation(string sql, Dictionary<string, object> parameters)
    {
        using SqlCommand sqlCommand = CreateSqlCommand(sql, parameters);
        sqlCommand.ExecuteNonQuery();
    }

    //delete operation
    public void DeleteOperation(string sql)
    {
        SqlConnection connection = new SqlConnection(_connectionString);

        connection.Open();

        SqlCommand sqlCommand = new SqlCommand(sql, connection);

        sqlCommand.ExecuteNonQuery();
    }

    //update operation
    public void UpdateOperation(string sql)
    {
        SqlConnection connection = new SqlConnection(_connectionString);

        connection.Open();

        SqlCommand sqlCommand = new SqlCommand(sql, connection);

        sqlCommand.ExecuteNonQuery();
    }

    //read operation
    public List<Dictionary<string, object>> ReadOperation(string sql)
    {
        SqlConnection connection = new SqlConnection(_connectionString);

        connection.Open();

        SqlCommand sqlCommand = new SqlCommand(sql, connection);

        using SqlDataReader reader = sqlCommand.ExecuteReader();

        List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();

        while (reader.Read())
        {
            Dictionary<string, object> row = new Dictionary<string, object>();

            for (int i = 0; i < reader.FieldCount; i++)
            {
                row.Add(reader.GetName(i), reader.GetValue(i));
            }
            rows.Add(row);
        }

        return rows;
    }
}