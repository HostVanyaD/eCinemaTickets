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

        public void Add(Actor actor)
        {
            throw new NotImplementedException();
        }

        public Actor Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Actor>> GetAll()
        {
            var allActors = await _context.Actors.ToListAsync();

            return allActors;
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
