namespace eCinemaTickets.Data.Services
{
    using eCinemaTickets.Models;

    public interface IActorService
    {
        Task<ICollection<Actor>> GetAll();

        Actor GetById(int id);

        void Add(Actor actor);

        Actor Update(int id, Actor newActor);

        Actor Delete(int id);
    }
}
