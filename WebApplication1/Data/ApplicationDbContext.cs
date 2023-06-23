using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;



namespace WebApplication1.Data
{
    public class ApplicationDbContext: DbContext
    {
        internal readonly object Actors;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {


        }
        
        
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Cinema> cinemas { get; set; }

        public DbSet<Producer> Producers { get; set; }

        public DbSet<Actor> actors { get; set; }

        public DbSet<ActorMovies> ActorMovies { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ActorMovies>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId

            });

            modelBuilder.Entity<ActorMovies>().HasOne(m => m.Movie).WithMany(am => am.ActorMovies).HasForeignKey(m => m.MovieId);
            base.OnModelCreating(modelBuilder);

          
           
                            
       
        }


    }
}
