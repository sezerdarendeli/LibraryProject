using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryProject.Repositories.Interfaces
{
    public interface IRepositoryBase<TEntity>
         where TEntity : class
    {
        List<TEntity> GetAll();

        Task<TEntity> GetById(int id);

        Task Create(TEntity entity);

        Task Update(int id, TEntity entity);

        Task Delete(int id);
    }
}
