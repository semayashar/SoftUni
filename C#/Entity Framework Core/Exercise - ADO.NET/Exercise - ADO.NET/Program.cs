using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Exercise___ADO.NET
{
    internal class Program
    {
        //ServerName: DESKTOP-HRCKOHJ
        //DataBase: MinionsDB

        //1. Connection string
          const string _connectionString = "Server=DESKTOP-HRCKOHJ;Database=MinionsDB;Integrated Security=True";


        static void Main(string[] args)
        {
            //2. SQL connection
            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            sqlConnection.Open();


            //EXC: Villians Names:
            //3. Create SQL command
            using SqlCommand getVilliansCommand = new SqlCommand(SqlQueries.GetVillainsWithNumberOfMinions, sqlConnection);
            using SqlDataReader sqlDataReader = getVilliansCommand.ExecuteReader();

            //4. Data Reader
            while (sqlDataReader.Read())
            {
                Console.WriteLine($"{sqlDataReader["Name"]} - {sqlDataReader["TotalMinions"]}");
            }
        }
    }
}