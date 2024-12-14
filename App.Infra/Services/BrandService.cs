using App.DBC;
using App.DMO.Setup;
using App.Infra.IServices;
using Microsoft.Data.SqlClient;
using System.Data;

namespace App.Infra.Services
{
    public class BrandService : IBrandService
    {
        private readonly RawSql _rawSql;
        public BrandService(RawSql rawSql)
        {
            _rawSql = rawSql;
        }
        public async Task Add(BRAND entity)
        {
            await _rawSql.ExecuteSPNonQuery(
               "SP_ManageBrand",
               new SqlParameter("@Action", "CREATE"),
               new SqlParameter("@ID", entity.ID),
               new SqlParameter("@BRAND_NAME", entity.BRAND_NAME),
               new SqlParameter("@BRAND_ORIGIN", entity.BRAND_ORIGIN)
           );
        }

        public async Task Delete(string id)
        {
            await _rawSql.ExecuteSPNonQuery(
                  "SP_ManageBrand",
                  new SqlParameter("@Action", "DELETE"),
                  new SqlParameter("@ID", id),
                  new SqlParameter("@BRAND_NAME", DBNull.Value),
                  new SqlParameter("@BRAND_ORIGIN", DBNull.Value)
              );
        }

        public async Task Edit(BRAND entity)
        {
            await _rawSql.ExecuteSPNonQuery(
                 "SP_ManageBrand",
                 new SqlParameter("@Action", "UPDATE"),
                 new SqlParameter("@ID", entity.ID),
                 new SqlParameter("@BRAND_NAME", entity.BRAND_NAME),
                 new SqlParameter("@BRAND_ORIGIN", entity.BRAND_ORIGIN)
             );
        }

        public async Task<IEnumerable<BRAND>> GetAll()
        {
            var brands = await _rawSql.ExecuteSPQuery<BRAND>(
                   "SP_ManageBrand",
                   new SqlParameter("@Action", "GETALL")
                   );
            return brands;
        }

        public async Task<BRAND> GetById(string id)
        {
            var brand = await _rawSql.ExecuteSPQuery<BRAND>("SP_ManageBrand",
                 new SqlParameter("@Action", "GETBYID") { SqlDbType = SqlDbType.NVarChar },
                 new SqlParameter("@ID", id) { SqlDbType = SqlDbType.NVarChar },
                 new SqlParameter("@BRAND_NAME", DBNull.Value) { SqlDbType = SqlDbType.NVarChar },
                 new SqlParameter("@BRAND_ORIGIN", DBNull.Value) { SqlDbType = SqlDbType.NVarChar }
             );
            return brand.FirstOrDefault();
        }

        public Task<IEnumerable<BRAND>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BRAND>> GetByOriginName(string origin)
        {
            throw new NotImplementedException();
        }
    }
}
