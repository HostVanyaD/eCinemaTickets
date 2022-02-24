namespace eCinemaTickets.Data.Services
{
    using eCinemaTickets.Models;

    public interface IActorService
    {
        Task<ICollection<Actor>> GetAllAsync();

        Task<Actor> GetByIdAsync(int id);

        Task AddAsync(Actor actor);

        Task<Actor> UpdateAsync(int id, Actor newActor);

        Task DeleteAsync(int id);
    }
}
