using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data.Services
{
    public class ActorsService : IActorsService
    {

        private readonly ApplicationDbContext _context;

        public ActorsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public object actors => throw new NotImplementedException();

       

        public Task AddAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(Actor actor)
        {
            _context.actors.Add(actor);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var actordetails = await _context.actors.FirstOrDefaultAsync(n => n.ID == id);
            _context.actors.Remove(actordetails);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Actor> GetAll()
        {
            var data = _context.actors.ToList();
            return data;
        }

        public Task GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Actor GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public object GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<Actor> UpdateAsync(int id, Actor actor)
        {
            _context.Update(actor);
            await _context.SaveChangesAsync();
            return actor;
        }
    }
}
