using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloBD
{
    public class Repositorio : DbContext
    {

        public DbSet<Category> categories { get; set; }
        public DbSet<Film_actor> film_actors { get; set; }
        public DbSet<Actor> actors { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-RLNFUSA;Integrated Security=true; Initial Catalog=ExamenJorgeHerrera");
        }
        protected override void OnModelCreating(ModelBuilder model)
        {
            
            //FILM ACTOR - ACTOR           UNO A  VARIOS
            model.Entity<Film_actor>()
            .HasOne(film_actor => film_actor.Actor)
            .WithMany(actor => actor.Film_actors)
            .OnDelete(DeleteBehavior.NoAction)
            .HasForeignKey(film_actor => film_actor.ActorId);

            //model.Entity<Film_actor>().HasNoKey();
        }
    }
}
