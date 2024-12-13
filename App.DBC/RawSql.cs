using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DBC
{
    public class RawSql
    {
        private readonly IDbContextFactory<AppDbContext> _contextFactory;
        public RawSql(IDbContextFactory<AppDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<int> ExecuteSPNonQuery(string spName, params SqlParameter[] parameters)
        {
            string sqlParams = string.Join(", ", parameters.Select(s => $"@{s.ParameterName}"));
            string sqlCommand = $"EXEC {spName} {sqlParams}";
            using var dbCtx = _contextFactory.CreateDbContext();
            return await dbCtx.Database.ExecuteSqlRawAsync(sqlCommand, parameters);
        }
        public async Task<List<T>> ExecuteSPQuery<T>(string spName, params SqlParameter[] parameters) where T : class
        {
            string sqlParams = string.Join(", ", parameters.Select(s => $"@{s.ParameterName}"));
            string sqlCommand = $"EXEC {spName} {sqlParams}";
            using var dbCtx = _contextFactory.CreateDbContext();
            return await dbCtx.Set<T>().FromSqlRaw(sqlCommand, parameters).ToListAsync();
        }


        //2 Method
    }
}
