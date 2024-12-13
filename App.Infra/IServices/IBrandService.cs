using App.DMO.Setup;

namespace App.Infra.IServices
{
    public interface IBrandService : IGenericService<BRAND>
    {
        Task<IEnumerable<BRAND>> GetByName(string name);
        Task<IEnumerable<BRAND>> GetByOriginName(string origin);
    }
}
