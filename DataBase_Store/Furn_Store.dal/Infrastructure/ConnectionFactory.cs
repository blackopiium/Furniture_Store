﻿using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Furnit.Interfaces;

namespace Furnit.Infrastructure
{
    public class ConnectionFactory : IConnectionFactory
    {
        private static string _connectionString;
        //private readonly string sqlConnectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;
        //private readonly string sqlTestConnectionString = ConfigurationManager.ConnectionStrings["SQLTestConnection"].ConnectionString;

        public void SetConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection GetSqlConnection
        {
            get
            {
                SqlConnection connection;

                if (!string.IsNullOrEmpty(_connectionString))
                    connection = new SqlConnection(_connectionString);
                else
                    connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

                connection.Open();

                return connection;
            }
        }
    }
}

