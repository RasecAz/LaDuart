using LaDuartProject.Server.Entityes;

namespace LaDuartProjet.Core.Interfaces.Repositories
{
    public interface IAsyncRepository<T> where T : Productos
    {
        Task<List<T>> ListAllAsync();
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
    }
}
