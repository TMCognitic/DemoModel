using System;
using System.Collections.Generic;

namespace Tools.Connections.Database
{
    public class Command
    {
        internal string Query { get; init; }
        internal bool IsStoredProcedure { get; init; }
        internal IDictionary<string, object> Parameters { get; init; }

        public Command(string query, bool isStoredProcedure)
        {
            Query = query;
            IsStoredProcedure = isStoredProcedure;
            Parameters = new Dictionary<string, object>();
        }

        public void AddParameter(string parameterName, object value)
        {
            if (string.IsNullOrWhiteSpace(parameterName))
                throw new ArgumentException(nameof(parameterName));

            Parameters.Add(parameterName, value ?? DBNull.Value);
        }
    }
}
