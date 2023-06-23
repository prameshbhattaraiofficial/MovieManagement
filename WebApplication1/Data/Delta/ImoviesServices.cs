using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data.Delta
{
    public interface ImoviesServices
    {

        IEnumerable<ImoviesServices> GetAll();

        Actor GetById(int id);

        Task  Add(Actor actor);

        Task Update(int id , Actor actor);

        Task Delete(int id);
    }
}
