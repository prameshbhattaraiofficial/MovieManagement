using System.Collections;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {

        Task<IEnumerable> GetAllAsync();

        Task<Actor> GetByIdAsync(int id);

        Task AddAsync (T Entity);

        Task<T>  UpdateAsync ( int id ,T Entity);

        Task DeleteAsync (int id);

    }
}