using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDbInitializer
    {

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();


                //cinema
                if (!context.cinemas.Any())
                {
                    context.cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Prem Geet 3",
                           CinemaLogo= "https://upload.wikimedia.org/wikipedia/en/3/3f/Prem_Geet_3.jpg",
                           Description= "Prem Geet 3"


                        },

                        new Cinema()
                        {
                            Name = "Cinema 2",
                            CinemaLogo = "https://upload.wikimedia.org/wikipedia/en/1/13/A_Mero_Hajur_4_film_poster.jpg",
                            Description = " This is cinemas 2"
                        },

                        new Cinema()
                        {
                            Name = "Cinema 3",
                            CinemaLogo = "https://upload.wikimedia.org/wikipedia/en/7/7c/Premgeetposter.jpg",
                            Description = " This is Cinemas 3"
                        },

                        new Cinema()
                        {
                            Name = "Cinema 4",
                            CinemaLogo = "https://upload.wikimedia.org/wikipedia/en/a/ac/Prem_Geet_2_movie_poster_2017.jpg",
                            Description = " This is Cinema 4"
                        }
                    }) ;
                    context.SaveChanges();
                }

                //Actors
                if (!context.actors.Any())
                {
                    context.actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Rajesh Hamal",
                            Bio = " shanker ho Shanker",
                            profilepictureUrl ="https://upload.wikimedia.org/wikipedia/en/3/3f/Prem_Geet_3.jpg"
                        },

                        new Actor()
                        {
                            FullName = " Paul shah",
                            Bio = "Jonny Gentleman",
                            profilepictureUrl = "https://upload.wikimedia.org/wikipedia/en/3/3f/Prem_Geet_3.jpg"
                        },

                        new Actor()
                        {
                            FullName = "Pradip Khadka",
                            Bio = "Prem Geet",
                            profilepictureUrl = "https://upload.wikimedia.org/wikipedia/en/3/3f/Prem_Geet_3.jpg",
                            }

                    }
                        );
                    context.SaveChanges();

                }
                //Producers


                if (!context.Producers.Any())
                {

                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/3/3e/Deepak_Raj_Giri.jpg",
                            FullName = "Dipak Raj Giri",
                            Bio = "Chhakka Panja ",
                            

                        },

                        new Producer()
                        {
                            ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/7/7f/Milan_Chams_on_Budha_Subba_Digital.jpg",
                            FullName = "Milan Chams",
                             Bio = "Aanchal sharma best actress producer "

                        }, 
                        new Producer()
                        {
                            ProfilePicture = "https://upload.wikimedia.org/wikipedia/commons/b/bf/Bhuwan_KC.png",
                            FullName = "Bhuwan KC ",
                             Bio = "Anmol Kc Dad"

                        }

                    }
                    );
                    context.SaveChanges();

                }
                //Movies

                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {

                        new Movie()
                        {
                            Name ="Prem Geet 2",
                            Price = 85 ,
                            Description ="This is first Movie",
                            Imageurl = "https://upload.wikimedia.org/wikipedia/en/a/ac/Prem_Geet_2_movie_poster_2017.jpg",
                            StartDate = DateTime.Now.AddDays(-9),
                            EndDate = DateTime.Now.AddDays(-3),
                            CinemaId =1,
                            ProducerId =3,
                            MovieCategory = Enum.MovieCategory.Action
                        },

                          new Movie()
                        {
                            Name ="A Mero Hajur 4",
                            Price = 23.5 ,
                            Description ="This is SECOND mOVIE",
                            Imageurl = "https://upload.wikimedia.org/wikipedia/en/1/13/A_Mero_Hajur_4_film_poster.jpg",
                            StartDate = DateTime.Now.AddDays(-5),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId =1,
                            ProducerId =3,
                            MovieCategory = Enum.MovieCategory.Camedy
                        },

                            new Movie()
                        {
                            Name ="Prem Geet 3",
                            Price = 23.5 ,
                            Description ="This is THIRD Movie",
                            Imageurl = "https://upload.wikimedia.org/wikipedia/en/3/3f/Prem_Geet_3.jpg",
                            StartDate = DateTime.Now.AddDays(-16),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId =1,
                            ProducerId =3,
                            MovieCategory = Enum.MovieCategory.Documentary
                        },

                        new Movie()
                        {
                            Name ="prem geet",
                            Price = 23.5 ,
                            Description ="This is FOURTH Movie",
                            Imageurl = "https://upload.wikimedia.org/wikipedia/en/7/7c/Premgeetposter.jpg",
                            StartDate = DateTime.Now.AddDays(-19),
                            EndDate = DateTime.Now.AddDays(-7),
                            CinemaId =1,
                            ProducerId =3,
                            MovieCategory = Enum.MovieCategory.Drama
                        }

                    }
                        ) ; ;
                    context.SaveChanges();
                }

                // Actors & Movies

                if (!context.ActorMovies.Any())
                {
                    context.ActorMovies.AddRange(new List<ActorMovies>()
                    {
                        new ActorMovies()
                        {
                            ActorId = 1,
                            MovieId =3
                        },

                        new ActorMovies()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        
                        new ActorMovies()
                        {
                            ActorId = 3,
                            MovieId =1
                        },

                        new ActorMovies()
                        {
                            ActorId = 2,
                            MovieId = 1
                        }
                    }
                    );
                    context.SaveChanges();

                }

            }
        }
    }
}
