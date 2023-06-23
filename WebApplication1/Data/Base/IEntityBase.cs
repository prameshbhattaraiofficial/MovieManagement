using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data.Base
{
    public interface IEntityBase
    {
        object actors { get; }

        IEnumerable<Actor> GetAll();

        Actor GetByIdAsync(int id);

        void Add(Actor actor);

        Actor Update(int id, Actor actor);

        void Delete(int id);
        Task GetAllAsync();
        object GetByIdAsync(object id);
    }
}
