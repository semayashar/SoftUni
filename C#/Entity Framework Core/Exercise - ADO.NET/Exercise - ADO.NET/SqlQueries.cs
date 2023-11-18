using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise___ADO.NET
{
    public static class SqlQueries
    {
        public const string GetVillainsWithNumberOfMinions = @"SELECT [Name], COUNT(*)[TotalMinions]
                                                        FROM Villains v
                                                        JOIN MinionsVillains mv ON mv.VillainId = v.Id
                                                        GROUP BY [Name]
                                                        HAVING COUNT(*) > 3
                                                        ORDER BY TotalMinions";

        public const string GetVilliansByID = @"SELECT Name FROM Villains WHERE Id = @Id";

        public const string GetOrderednionsByVillianID = @"SELECT ROW_NUMBER() OVER (ORDER BY m.Name) AS RowNum,
                                                            m.Name, 
                                                            m.Age
                                                            FROM MinionsVillains AS mv
                                                            JOIN Minions As m ON mv.MinionId = m.Id
                                                            WHERE mv.VillainId = @Id
                                                            ORDER BY m.Name";

        public const string GetTownByName = @"SELECT Id FROM Towns WHERE Name = @townName";
        public const string GetVillainByName = @"SELECT Id FROM Villains WHERE Name = @villainName";

        public const string InsertTown = @"INSERT INTO Towns ([Name]) OUTPUT inserted.Id VALUES (@townName)";
        public const string InsertVillain = @"INSERT INTO Villains ([Name], EvillnessFactorId) OUTPUT inserted.Id VALUES (@villainName, @evilnessFactorID)";

        public const string InsertMinion = @"INSERT INTO Minions (Name, Age, TownId) OUTPUT inserted.Id VALUES (@name, @age, @townId)";
        public const string InsertIntoMinionsVillains = @"INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (@minionId, @villainId)";
        
    }
}
