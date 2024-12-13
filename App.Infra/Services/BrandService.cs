using App.DBC;
using App.DMO.Setup;
using App.Infra.IServices;
using Microsoft.Data.SqlClient;

namespace App.Infra.Services
{
    public class BrandService : IBrandService
    {
        private readonly RawSql _rawSql;
        public BrandService(RawSql rawSql)
        {
            _rawSql = rawSql;
        }
        public Task Add(BRAND entity)
        {

            List<object> parameterList = new List<object>();
            parameterList.Add(new SqlParameter("@ID", "123"))
                ;
            throw new NotImplementedException();
        }

        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task Edit(BRAND entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BRAND>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<BRAND> GetById(string id)
        {
            throw new NotImplementedException();
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
