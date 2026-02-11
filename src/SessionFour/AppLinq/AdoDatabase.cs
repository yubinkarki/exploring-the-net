// Using connected architecture (mostly) 

namespace ExploringTheNet.SessionFour.AppLinq;

using System;
using System.Data;

using MySql.Data.MySqlClient; // dotnet add package MySql.Data

public class AdoDatabase {
    private const string User = "root";
    private const string Password = "";
    private const string Database = "kct";
    private const string TableName = "user";
    private const string Server = "localhost";

    private static readonly string ConnectionString = $"Server={Server};Database={Database};Uid={User};Pwd={Password};";

    // Make sure table exists
    public static void AllOperations() {
        EnsureTableExists();
        // CreateUser("Ram Kumar", "ram@gmail.com");
        // UpdateUser(1, "Ram Kumar", "ram@gmail.com");
        // DeleteUser(1);
        ReadUsers();
    }

    private static void EnsureTableExists() {
        MySqlConnection conn = new(ConnectionString);

        const string query = $@"CREATE TABLE IF NOT EXISTS {TableName}(
                        Id INT AUTO_INCREMENT PRIMARY KEY,
                        Name VARCHAR(100),
                        Email VARCHAR(100)
                        );";

        MySqlCommand cmd = new MySqlCommand(query, conn);

        try {
            conn.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Table verified.");
        } catch (MySqlException e) {
            Console.WriteLine("An error occurred while ensuring table exists: " + e.Message);
        }
    }

    private static void CreateUser(string name, string email) {
        MySqlConnection conn = new(ConnectionString);

        const string query = $"INSERT INTO {TableName} (Name, Email) VALUES (@Name, @Email);";

        MySqlCommand cmd = new MySqlCommand(query, conn);

        cmd.Parameters.AddWithValue("@Name", name);
        cmd.Parameters.AddWithValue("@Email", email);

        try {
            conn.Open();
            int result = cmd.ExecuteNonQuery();

            Console.WriteLine(result > 0 ? "User created successfully." : "User creation failed.");
        } catch (MySqlException e) {
            Console.WriteLine("An error occurred while creating user: " + e.Message);
        }
    }

    /* private static void ReadUsers() {
        using MySqlConnection conn = new(ConnectionString);

        const string query = $"SELECT * FROM {TableName};";

        using MySqlCommand cmd = new(query, conn);

        try {
            conn.Open();

            using MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows) {
                Console.WriteLine("\n🆔 Id\t\t👤 Name\t\t📨 Email");
                Console.WriteLine("---------------------------------------------------");

                // Keeps the connection open during reading
                while (reader.Read()) {
                    Console.WriteLine($"{reader["Id"]}\t\t{reader["Name"]}\t{reader["Email"]}");
                }
            }
        } catch (MySqlException e) {
            Console.WriteLine("An error occurred while reading users: " + e.Message);
        }
    } */

    // Disconnected architecture - using data adapter + data table
    private static void ReadUsers() {
        MySqlConnection conn = new(ConnectionString);
        const string query = $"SELECT * FROM {TableName};";

        try {
            conn.Open();

            MySqlDataAdapter adapter = new(query, conn);
            DataTable dataTable = new();
            adapter.Fill(dataTable); // Connection opens and closes internally

            if (dataTable.Rows.Count > 0) {
                Console.WriteLine("\n🆔 Id\t👤 Name\t\t📨 Email");
                Console.WriteLine("---------------------------------------------------");

                foreach (DataRow row in dataTable.Rows) {
                    Console.WriteLine($"{row["Id"]}\t{row["Name"]}\t{row["Email"]}");
                }
            }
        } catch (MySqlException e) {
            Console.WriteLine("An error occurred while reading users: " + e.Message);
        }
    }

    private static void UpdateUser(int id, string name, string email) {
        MySqlConnection conn = new(ConnectionString);
        const string query = $"UPDATE {TableName} SET Name = @Name, Email = @Email WHERE Id = @Id;";

        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Id", id);
        cmd.Parameters.AddWithValue("@Name", name);
        cmd.Parameters.AddWithValue("@Email", email);

        try {
            conn.Open();
            int result = cmd.ExecuteNonQuery();

            Console.WriteLine(result > 0 ? "User updated successfully." : "No user found with the given Id.");
        } catch (MySqlException e) {
            Console.WriteLine("An error occurred while updating user: " + e.Message);
        }
    }

    private static void DeleteUser(int id) {
        MySqlConnection conn = new(ConnectionString);
        const string query = $"DELETE FROM {TableName} WHERE Id = @Id;";

        MySqlCommand cmd = new(query, conn);
        cmd.Parameters.AddWithValue("@Id", id);

        try {
            conn.Open();
            int result = cmd.ExecuteNonQuery();

            Console.WriteLine(result > 0 ? "User deleted successfully." : "No user found with the given Id.");
        } catch (MySqlException e) {
            Console.WriteLine("An error occurred while deleting user: " + e.Message);
        }
    }
}
