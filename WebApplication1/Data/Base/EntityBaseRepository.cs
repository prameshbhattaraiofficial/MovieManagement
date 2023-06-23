using System.Collections;
using System.Threading.Tasks;
using WebApplication1.Data.Base;
using WebApplication1.Models;

namespace WebApplication1.Data.Base
{

    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        public Task DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Actor> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        Task IEntityBaseRepository<T>.AddAsync(T Entity)
        {
            throw new System.NotImplementedException();
        }

        Task<T> IEntityBaseRepository<T>.UpdateAsync(int id, T Entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
