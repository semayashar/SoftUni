using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Exercise___ADO.NET
{
    internal class Program
    {
        // ServerName: DESKTOP-HRCKOHJ
        // DataBase: MinionsDB

        // 1. Connection string
        const string connectionString = "Server=DESKTOP-HRCKOHJ;Database=MinionsDB;Integrated Security=True";
        static SqlConnection connection;

        static async Task Main(string[] args)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                // await GetOrderedMinionsByVillainId(9);
                // await GetOrderedMinionsByVillainId(2);

                string minionInfoRow = Console.ReadLine();
                string villainInfoRow = Console.ReadLine();

                string minionInfo = minionInfoRow.Substring(minionInfoRow.IndexOf(":") + 1).Trim();
                string villainName = villainInfoRow.Substring(villainInfoRow.IndexOf(":") + 1).Trim();

                await AddMinions(minionInfo, villainName);
            }
            finally
            {
                connection?.Close();
            }
        }

        static async Task GetOrderedMinionsByVillainId(int id)
        {
            using SqlCommand command = new SqlCommand(SqlQueries.GetVilliansByID, connection);
            command.Parameters.AddWithValue("@Id", id);
            var result = await command.ExecuteScalarAsync();
            if (result is null)
            {
                await Console.Out.WriteLineAsync($"No villain with ID {id} exists in the database.");
            }
            else
            {
                await Console.Out.WriteLineAsync($"Villain: {result}");

                using SqlCommand commandGetMinionData = new SqlCommand(SqlQueries.GetOrderednionsByVillianID, connection);
                commandGetMinionData.Parameters.AddWithValue("@Id", id);

                var minionsReader = await commandGetMinionData.ExecuteReaderAsync();

                while (await minionsReader.ReadAsync())
                {
                    await Console.Out.WriteLineAsync($"{minionsReader["RowNum"]}. " +
                        $"{minionsReader["Name"]} {minionsReader["Age"]}");
                }
            }
        }

        static async Task AddMinions(string minionInfo, string villainName)
        {
            string[] minionData = minionInfo.Split(' ');
            string m_name = minionData[0];
            int m_age = int.Parse(minionData[1]);
            string m_town = minionData[2];

            #region Town
            using SqlCommand cmdGetTownId = new SqlCommand(SqlQueries.GetTownByName, connection);
            cmdGetTownId.Parameters.AddWithValue("@townName", m_town);

            var townResult = await cmdGetTownId.ExecuteScalarAsync();

            int townId = -1;
            if (townResult is null)
            {
                using SqlCommand createTown = new SqlCommand(SqlQueries.InsertTown, connection);
                createTown.Parameters.AddWithValue("@townName", m_town);
                townId = Convert.ToInt32(await createTown.ExecuteScalarAsync());
                Console.WriteLine($"Town {m_town} was added to the database");
            }
            else
            {
                townId = (int)townResult;
            }
            #endregion

            #region Villain
            using SqlCommand cmdGetVillain = new SqlCommand(SqlQueries.GetVillainByName, connection);
            cmdGetVillain.Parameters.AddWithValue("@villainName", villainName);
            var villainResult = await cmdGetVillain.ExecuteScalarAsync();

            int villainId = -1;
            if (villainResult is null)
            {
                using SqlCommand cmdInsertNewVillain = new SqlCommand(SqlQueries.InsertVillain, connection);
                cmdInsertNewVillain.Parameters.AddWithValue("@villainName", villainName);
                cmdInsertNewVillain.Parameters.AddWithValue("@evilnessFactorId", 4);
                villainId = Convert.ToInt32(await cmdInsertNewVillain.ExecuteScalarAsync());
                await Console.Out.WriteLineAsync($"Villain {villainName} was added to the database");
            }
            else
            {
                villainId = (int)villainResult;
            }
            #endregion

            #region Minion
            using SqlCommand cmdInsertMinion = new SqlCommand(SqlQueries.InsertMinion, connection);
            cmdInsertMinion.Parameters.AddWithValue("@name", m_name);
            cmdInsertMinion.Parameters.AddWithValue("@age", m_age);
            cmdInsertMinion.Parameters.AddWithValue("@townId", townId);
            await cmdInsertMinion.ExecuteNonQueryAsync();
            Console.WriteLine($"Minion {m_name} was added to the database");

            int minionId = Convert.ToInt32(await cmdInsertMinion.ExecuteScalarAsync());

            using SqlCommand cmdInsertMinionsVillains = new SqlCommand(SqlQueries.InsertIntoMinionsVillains, connection);
            cmdInsertMinionsVillains.Parameters.AddWithValue("@minionId", minionId);
            cmdInsertMinionsVillains.Parameters.AddWithValue("@villainId", villainId);
            await cmdInsertMinionsVillains.ExecuteNonQueryAsync();
            Console.WriteLine($"Successfully added {m_name} to be a minion of {villainName}.");
            #endregion
        }
    }
}
