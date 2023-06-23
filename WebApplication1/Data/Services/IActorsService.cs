using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data.Services
{
   public  interface IActorsService
    {
        object actors { get; }

        IEnumerable<Actor> GetAll();

        Actor GetByIdAsync(int id);

        Task AddAsync(Actor actor);

        Task<Actor> UpdateAsync(int id, Actor actor);

        Task DeleteAsync(int id);

        Task GetAllAsync();

        object GetByIdAsync(object id);

        Task AddAsync(object id);
    }
}
