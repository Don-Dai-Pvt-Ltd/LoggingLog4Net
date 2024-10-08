﻿using log4net;
using MySql.Data.MySqlClient;

namespace LoggingLog4Net
{
    public class Bar
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Bar));
        private string _connectionString = "Server=127.0.0.1;Database=logdb;User ID=root;Password=DonDaii;";

        public void DoIt()
        {
            log.Debug("Did it again!");
        }

        public void ConnectionCheck()
        {
            using (var conn = new MySqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    log.Info("Connection Successful");
                }
                catch (Exception ex)
                {
                    //Console.WriteLine($"Connection failed : {ex.Message}");
                    log.Error($"Connection failed : {ex.Message}");
                }
            }
        }
    }
}
