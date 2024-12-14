using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace App.DBC
{
    public class RawSql
    {
        private readonly IDbContextFactory<AppDbContext> _contextFactory;
        public RawSql(IDbContextFactory<AppDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        /// <summary>
        /// Use for INSERT, UPDATE, DELETE command
        /// </summary>
        /// <param name="spName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<int> ExecuteSPNonQuery(string spName, params SqlParameter[] parameters)
        {
            string sqlParams = string.Join(", ", parameters.Select(s => $"@{s.ParameterName}"));
            string sqlCommand = $"EXEC {spName} {sqlParams}";
            using var dbCtx = _contextFactory.CreateDbContext();
            return await dbCtx.Database.ExecuteSqlRawAsync(sqlCommand, parameters);
        }

        /// <summary>
        /// Use for SELECT query
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="spName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<List<T>> ExecuteSPQuery<T>(string spName, params SqlParameter[] parameters) where T : class
        {
            string sqlParams = string.Join(", ", parameters.Select(s => $"@{s.ParameterName}"));
            string sqlCommand = $"EXEC {spName} {sqlParams}";
            using var dbCtx = _contextFactory.CreateDbContext();
            return await dbCtx.Set<T>().FromSqlRaw(sqlCommand, parameters).ToListAsync();
        }
    }
}
