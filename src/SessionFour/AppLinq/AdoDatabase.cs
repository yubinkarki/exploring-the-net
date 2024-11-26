namespace ExploringTheNet.SessionFour.AppLinq;

using System;

using MySql.Data.MySqlClient;

public class AdoDatabase {
    private static readonly string connectionString = "Server=localhost;Database=TestDB;Uid=root;Pwd=your_password;";

    public static void RunDatabase() {
        EnsureTableExists();

        // CreateUser("Hari Om", "hariom@gmail.com");
        // ReadUsers();
        UpdateUser(1, "Radhe Krishna", "radhekrishna@gmail.com");
        // DeleteUser(1);

        Console.WriteLine("Done.");
    }

    private static void EnsureTableExists() {
        using MySqlConnection conn = new MySqlConnection(connectionString);

        string query = @"CREATE TABLE IF NOT EXISTS Users (
                        Id INT AUTO_INCREMENT PRIMARY KEY,
                        Name VARCHAR(100),
                        Email VARCHAR(100));";

        using MySqlCommand cmd = new MySqlCommand(query, conn);

        try {
            conn.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Checked for table existence and created if not existing.");
        } catch (MySqlException ex) {
            Console.WriteLine("An error occurred while ensuring table exists: " + ex.Message);
        }
    }

    private static void CreateUser(string name, string email) {
        using MySqlConnection conn = new MySqlConnection(connectionString);

        string query = "INSERT INTO Users (Name, Email) VALUES (@Name, @Email);";

        using MySqlCommand cmd = new MySqlCommand(query, conn);

        cmd.Parameters.AddWithValue("@Name", name);
        cmd.Parameters.AddWithValue("@Email", email);

        try {
            conn.Open();
            int result = cmd.ExecuteNonQuery();

            if (result > 0) {
                Console.WriteLine("User created successfully.");
            } else {
                Console.WriteLine("Error occurred while creating user.");
            }
        } catch (MySqlException ex) {
            Console.WriteLine("An error occurred while creating user: " + ex.Message);
        }
    }

    // Read (Select) Operation
    private static void ReadUsers() {
        using MySqlConnection conn = new MySqlConnection(connectionString);

        string query = "SELECT * FROM Users;";

        using MySqlCommand cmd = new MySqlCommand(query, conn);
        try {
            conn.Open();

            using MySqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("Id\tName\t\tEmail");
            Console.WriteLine("-----------------------------------------");

            while (reader.Read()) {
                Console.WriteLine($"{reader["Id"]}\t{reader["Name"]}\t{reader["Email"]}");
            }
        } catch (MySqlException ex) {
            Console.WriteLine("An error occurred while reading users: " + ex.Message);
        }
    }

    // Update Operation
    private static void UpdateUser(int id, string name, string email) {
        using MySqlConnection conn = new MySqlConnection(connectionString);
        string query = "UPDATE Users SET Name = @Name, Email = @Email WHERE Id = @Id;";

        using MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Id", id);
        cmd.Parameters.AddWithValue("@Name", name);
        cmd.Parameters.AddWithValue("@Email", email);

        try {
            conn.Open();
            int result = cmd.ExecuteNonQuery();

            if (result > 0) {
                Console.WriteLine("User updated successfully.");
            } else {
                Console.WriteLine("No user found with the given Id.");
            }
        } catch (MySqlException ex) {
            Console.WriteLine("An error occurred while updating user: " + ex.Message);
        }
    }

    // Delete Operation
    private static void DeleteUser(int id) {
        using MySqlConnection conn = new MySqlConnection(connectionString);
        string query = "DELETE FROM Users WHERE Id = @Id;";

        using MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Id", id);

        try {
            conn.Open();
            int result = cmd.ExecuteNonQuery();

            if (result > 0) {
                Console.WriteLine("User deleted successfully.");
            } else {
                Console.WriteLine("No user found with the given Id.");
            }
        } catch (MySqlException ex) {
            Console.WriteLine("An error occurred while deleting user: " + ex.Message);
        }
    }
}
