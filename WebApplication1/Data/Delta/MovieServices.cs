using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data.Delta
{
    public class MovieServices : ImoviesServices
    {
        public void Add(Actor actor)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ImoviesServices> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Actor GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Actor Update(int id, Actor actor)
        {
            throw new System.NotImplementedException();
        }

        Task ImoviesServices.Add(Actor actor)
        {
            throw new System.NotImplementedException();
        }

        Task ImoviesServices.Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        Task ImoviesServices.Update(int id, Actor actor)
        {
            throw new System.NotImplementedException();
        }
    }
}
