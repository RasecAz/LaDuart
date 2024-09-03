using LaDuartProject.Server.Entityes;
using LaDuartProjet.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Management.Automation;

namespace LaDuartProject.Infraestructure.Data
{
    public class EfRepository<T> : IAsyncRepository<T> where T : Productos
    {
        public EfRepository(IConfiguration configuration, IDynamicParameters dynamicParameters ) 
        
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        protected readonly AppDbContext  _dbContext;
        public EfRepository(AppDbContext dbContext) 
        
        {  
            _dbContext = dbContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            entity.Fecha_creacion = DateTime.Now;
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }
        public async Task<List<T>> ListAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }
        public async Task<T> UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public Task<T> DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}       
    


