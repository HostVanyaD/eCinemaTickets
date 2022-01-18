namespace eCinemaTickets.Data
{
    using eCinemaTickets.Models;
    using Microsoft.EntityFrameworkCore;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<ActorMovie> ActorsMovies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorMovie>(entity =>
            {
                entity.HasKey(pk => new
                {
                    pk.ActorId,
                    pk.MovieId
                });

                entity.HasOne(m => m.Movie)
                .WithMany(am => am.ActorsMovies);

                entity.HasOne(a => a.Actor)
                .WithMany(am => am.ActorMovies);
            });
                

            base.OnModelCreating(modelBuilder);
        }
    }
}
