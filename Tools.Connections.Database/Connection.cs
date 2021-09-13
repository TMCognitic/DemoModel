using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Tools.Connections.Database
{
    public class Connection : IConnection
    {
        private readonly string _connectionString;
        private readonly DbProviderFactory _providerFactory;

        public Connection(string connectionString, DbProviderFactory providerFactory)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException(nameof(connectionString));

            if (providerFactory is null)
                throw new ArgumentNullException(nameof(providerFactory));

            _connectionString = connectionString;
            _providerFactory = providerFactory;

            using (DbConnection dbConnection = CreateConnection(_providerFactory, _connectionString))
            {
                dbConnection.Open();
            }
        }

        public int ExecuteNonQuery(Command command)
        {
            using (DbConnection dbConnection = CreateConnection(_providerFactory, _connectionString))
            {
                using (DbCommand dbCommand = CreateCommand(dbConnection, command))
                {
                    dbConnection.Open();
                    return dbCommand.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<TResult> ExecuteReader<TResult>(Command command, Func<IDataRecord, TResult> selector)
        {
            if (selector is null)
                throw new ArgumentNullException(nameof(selector));

            using (DbConnection dbConnection = CreateConnection(_providerFactory, _connectionString))
            {
                using (DbCommand dbCommand = CreateCommand(dbConnection, command))
                {
                    dbConnection.Open();
                    using (IDataReader reader = dbCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return selector(reader);
                        }
                    }
                }
            }
        }

        public object ExecuteScalar(Command command)
        {
            using (DbConnection dbConnection = CreateConnection(_providerFactory, _connectionString))
            {
                using (DbCommand dbCommand = CreateCommand(dbConnection, command))
                {
                    dbConnection.Open();
                    object o = dbCommand.ExecuteScalar();
                    return o is DBNull ? null : o;
                }
            }
        }

        private static DbConnection CreateConnection(DbProviderFactory providerFactory, string connectionString)
        {
            DbConnection dbConnection = providerFactory.CreateConnection();
            dbConnection.ConnectionString = connectionString;

            return dbConnection;
        }

        private static DbCommand CreateCommand(DbConnection dbConnection, Command command)
        {
            DbCommand dbCommand = dbConnection.CreateCommand();
            dbCommand.CommandText = command.Query;

            if (command.IsStoredProcedure)
                dbCommand.CommandType = CommandType.StoredProcedure;

            foreach (KeyValuePair<string, object> parameter in command.Parameters)
            {
                DbParameter dbParameter = dbCommand.CreateParameter();
                dbParameter.ParameterName = parameter.Key;
                dbParameter.Value = parameter.Value;
                dbCommand.Parameters.Add(dbParameter);
            }

            return dbCommand;
        }
    }
}
