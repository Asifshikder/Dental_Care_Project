using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.DataAccess
{
    public class SqlService : ISqlService
    {
        private readonly SqlProperties sqlProperties;
        public SqlService(SqlProperties sqlProperties)
        {
            this.sqlProperties = sqlProperties;
        }
        public async Task<IEnumerable<T>> QueryAsync<T, U>(string storedProcedure, U parameter)
        {
            using IDbConnection connection = new SqlConnection(sqlProperties.ConnectionString);
            return await connection.QueryAsync<T>(storedProcedure, parameter, commandType: CommandType.StoredProcedure);
        }
        public async Task CommandAsync<T>(string storedProcedure, T parameter)
        {
            using IDbConnection connection = new SqlConnection(sqlProperties.ConnectionString);
            await connection.ExecuteAsync(storedProcedure, parameter, commandType: CommandType.StoredProcedure);
        }
    }
}
