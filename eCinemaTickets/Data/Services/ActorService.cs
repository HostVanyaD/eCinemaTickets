namespace eCinemaTickets.Data.Services
{
    using eCinemaTickets.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;

    public class ActorService : IActorService
    {
        private readonly AppDbContext _context;

        public ActorService(AppDbContext context)
            => _context = context;

        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var actor = await _context
                .Actors
                .FirstOrDefaultAsync(a => a.Id == id);

            if (actor != null)
            {
                _context.Actors.Remove(actor);

                _context.SaveChanges();
            }
        }

        public async Task<ICollection<Actor>> GetAllAsync()
        {
            var allActors = await _context.Actors.ToListAsync();

            return allActors;
        }

        public async Task<Actor> GetByIdAsync(int id)
            => await _context
                .Actors
                .FirstOrDefaultAsync(a => a.Id == id);

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);

            await _context.SaveChangesAsync();

            return newActor;
        }
    }
}
