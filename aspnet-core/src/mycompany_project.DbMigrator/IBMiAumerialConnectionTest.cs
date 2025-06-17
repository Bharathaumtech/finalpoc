using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aumerial.Data.Nti;

namespace mycompany_project.DbMigrator
{
    internal class IBMiAumerialConnectionTest
    {
        static void Main(string[] args)
        {
            string connectionString = "DataSource=10.150.0.59; UserID=AUM_TECH04;Password=AUMTTec";

            try
            {
                using var connection = new NTiConnection(connectionString);
                connection.Open();

                Console.WriteLine("✅ Connected to IBM i server using Aumerial.Data.Nti");

                using var command = connection.CreateCommand();
                command.CommandText = "SELECT CURRENT_DATE FROM SYSIBM.SYSDUMMY1";

                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("📅 IBM i Current Date: " + reader.GetValue(0));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Connection failed: " + ex.Message);
            }
        }
    }
}
