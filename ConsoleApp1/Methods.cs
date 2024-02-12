using Npgsql;
using System.Net.Quic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;

namespace ConsoleApp1
{
    public class Methods
    {
        public static void CreateTable(string table, string column)
        {
            string connetionString = "Host=localhost;Port=5432;Database=connected;username=postgres;Password=psqlDB;";
            
            using (NpgsqlConnection connection = new NpgsqlConnection(connetionString))
            {
                connection.Open();

                string query = @$"CREATE TABLE {table} (id SERIAl, {column} VARCHAR(255));";
                using NpgsqlCommand cmd = new NpgsqlCommand(query,connection);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Succesfully Created !");

                connection.Close();
            }
        }

        public static void GetAll(string table)
        {
            string connectionString = "Host=localhost;Port=5432;Database=connected;username=postgres;Password=psqlDB;";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = @$"SELECT * FROM {table};";
                using NpgsqlCommand cmd = new NpgsqlCommand(query, connection);

                var result = cmd.ExecuteReader();

                Console.WriteLine();

                while (result.Read())
                {
                    Console.WriteLine(result[1
                        ]);
                }

                Console.WriteLine("\nOperation is succesfully ended !");
                connection.Close();
            }
        }
        public static void GetById(string table, int id)
        {
            string connectionString = "Host=localhost;Port=5432;Database=connected;username=postgres;Password=psqlDB;";

            using(NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = @$"SELECT * FROM {table} WHERE id = {id};";

                using NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                
                var result = cmd.ExecuteReader();

                Console.WriteLine();

                while (result.Read())
                {
                    Console.WriteLine(result[1]);
                }

                Console.WriteLine("\nOperation is succesfully ended !");
                connection.Close();
            }
        }
        public static void GetWithLike(string table, string column, string like)
        {
            string connectionString = "Host=localhost;Port=5432;Database=connected;username=postgres;Password=psqlDB;";

            using(NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = @$"SELECT * FROM {table} WHERE {column} LIKE '{like}';";
                using NpgsqlCommand cmd = new NpgsqlCommand(query, connection);

                var result = cmd.ExecuteReader();

                while (result.Read())
                {
                    Console.WriteLine(result);
                }

                Console.WriteLine("Operation is succesfully ended !");

                connection.Close();
            }
        }


        public static void UpdateTable(string oldTableName, string NewTableName)
        {
            string connectionString = "Host=localhost;Port=5432;Database=connected;username=postgres;Password=psqlDB;";
            using( NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = @$"ALTER TABLE {oldTableName} RENAME TO {NewTableName};";
                using NpgsqlCommand cmd = new NpgsqlCommand(query,connection);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Succesfully updated !");

                connection.Close();
            }
        }
        public static void UpdateAll(string table, string columnName, string value)
        {
            string connectionString = "Host=localhost;Port=5432;Database=connected;username=postgres;Password=psqlDB;";

            using(NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = @$"UPDATE {table} SET {columnName} = '{value}';";
                using(NpgsqlCommand cmd =  new NpgsqlCommand(query,connection))

                cmd.ExecuteNonQuery();

                Console.WriteLine("Succesfully updated !");

                connection.Close();
            }
        }
        public static void UpdateOne(string table, string columnName, string value, string columnName2, string value2)
        {
            string connectionString = "Host=localhost;Port=5432;Database=connected;username=postgres;Password=psqlDB;";

            using(NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = @$"UPDATE {table} SET {columnName} = '{value}' WHERE {columnName2} = '{value2}';";
                using NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Succesfully updated !");

                connection.Close();
            }
        }
        public static void UpdateColumn(string table, string oldname, string newname)
        {
            string connectionString = "Host=localhost;Port=5432;Database=connected;username=postgres;Password=psqlDB;";
            using(NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = @$"ALTER TABLE {table} RENAME COLUMN {oldname} TO {newname};";
                using NpgsqlCommand cmd = new NpgsqlCommand(query,connection);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Succesfully Updated !");

                connection.Close();
            }
        }
        public static void DeleteFrom(string table, string columnName, string value)
        {
            string connectionString = "Host=localhost;Port=5432;Database=connected;username=postgres;Password=psqlDB;";

            using(NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = @$"DELETE FROM {table} WHERE {columnName} = '{value}';";

                using(NpgsqlCommand cmd = new NpgsqlCommand(query,connection))

                cmd.ExecuteNonQuery();

                Console.WriteLine("Succesfully deleted !");

                connection.Close();
            }
        }
        public static void TruncateTable(string table)
        {
            string connectionString = "Host=localhost;Port=5432;Database=connected;username=postgres;Password=psqlDB;";

            using(NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = $@"TRUNCATE TABLE {table};";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))

                cmd.ExecuteNonQuery();
                
                Console.WriteLine("Operation is succesfully ended !");
                
                connection.Close();
            }
        }


        public static void InsertOne(string table, string columnName, string value)
        {
            string connectionString = "Host=localhost;Port=5432;Database=connected;username=postgres;Password=psqlDB;";

            using(NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = @$"INSERT INTO {table}({columnName}) VALUES('{value}');";
                using NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                
                cmd.ExecuteNonQuery();

                Console.WriteLine("Succesfully Added!");
                
                connection.Close();
            }
        }


        public static void AddColumn(string table, string column, string type)
        {
            string connectionString = "Host=localhost;Port=5432;Database=connected;username=postgres;Password=psqlDB;";
            using(NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = @$"ALTER TABLE {table} ADD COLUMN {column} {type};";
                using NpgsqlCommand cmd = new NpgsqlCommand(query, connection);

                cmd.ExecuteNonQuery();

                Console.WriteLine("the new column is succesfully Added !");

                connection.Close();
            }
        }
        public static void AddColumnWithDefault(string table, string column, string type)
        {
            string connectionString = "Host=localhost;Port=5432;Database=connected;username=postgres;Password=psqlDB;";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = @$"ALTER TABLE {table} ADD COLUMN {column} {type} DEFAULT 'Example';";
                using NpgsqlCommand cmd = new NpgsqlCommand(query, connection);

                cmd.ExecuteNonQuery();

                Console.WriteLine("the new column is succesfully Added !");

                connection.Close();
            }
        }
        public static void Join(string table, string table2, string join1, string join2)
        {
            string connectionString = "Host=localhost;Port=5432;Database=connected;username=postgres;Password=psqlDB;";
            using(NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = @$"SELECT * FROM {table} INNER JOIN {table2} ON {join1} = {join2};";
                using NpgsqlCommand cmd = new NpgsqlCommand(query, connection);

                var result = cmd.ExecuteReader();

                while (result.Read())
                {
                    Console.Write(result[0]);
                    Console.WriteLine(result[1]);
                }

                Console.WriteLine("Operation is succesfully ended !");

                connection.Close();
            }
        }
        public static void AddIndex(string index, string table, string column)
        {
            string connectionString = "Host=localhost;Port=5432;Database=connected;username=postgres;Password=psqlDB;";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = @$"CREATE INDEX {index} ON {table} ({column});";
                using NpgsqlCommand cmd = new NpgsqlCommand(query, connection);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Succesfully Added !");

                connection.Close();
            }
        }
        public static void InsertMany()
        {

        }

    }
}
