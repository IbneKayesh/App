namespace App.Infra.IServices
{
    public interface IGenericService<T>
    {
        Task Add(T entity);
        Task Edit(T entity);
        Task Delete(string id);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(string id);
    }
}
