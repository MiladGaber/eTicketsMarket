using eTicketsMarket.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eTicketsMarket.Data
{
    public static class ApplicationDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                //cinema 
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Description = "some desc 1",
                            Logo = "https://picsum.photos/300/300"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Description = "some desc 2",
                            Logo = "https://picsum.photos/300/300"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Description = "some desc 3",
                            Logo = "https://picsum.photos/300/300"
                        }
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "Actor 1 Bio",
                            ProfileUrl = "~/Images/actor1.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "Actor 2 Bio",
                            ProfileUrl = "~/Images/actor2.jpg",
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "Actor 3 Bio",
                            ProfileUrl = "~/Images/actor3.jpg",
                        }
                    });
                    context.SaveChanges();
                }

                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "Producer 1 Bio",
                            ProfileUrl = "~/Images/producer1.png"
                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "Producer 2 Bio",
                            ProfileUrl = "~/Images/producer2.png",
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "Producer 3 Bio",
                            ProfileUrl = "~/Images/producer3.png",
                        }
                    });
                    context.SaveChanges();
                }

                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Movie 1",
                            Description = " Movie 1 Description",
                            Price = 22.50,
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(10),
                            ImgUrl = "https://picsum.photos/400/600",
                            MovieCategory = MovieCategory.Comedy,
                            CinemaId=3,
                            ProducerId=1
                        },
                        new Movie()
                        {
                            Name = "Movie 2",
                            Description = " Movie 2 Description",
                            Price = 22.50,
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(22),
                            ImgUrl = "https://picsum.photos/400/600",
                            MovieCategory = MovieCategory.Drama,
                            CinemaId=1,
                            ProducerId=1
                        },
                        new Movie()
                        {
                            Name = "Movie 3",
                            Description = " Movie 3 Description",
                            Price = 22.50,
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(8),
                            ImgUrl = "https://picsum.photos/400/600",
                            MovieCategory = MovieCategory.Action,
                            CinemaId=3,
                            ProducerId=3
                        },
                        new Movie()
                        {
                            Name = "Movie 4",
                            Description = " Movie 4 Description",
                            Price = 22.50,
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(17),
                            ImgUrl = "https://picsum.photos/400/600",
                            MovieCategory = MovieCategory.History,
                            CinemaId=2,
                            ProducerId=1
                        }
                    });
                    context.SaveChanges();
                }

                //Actors And Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 4,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 2,
                        },

                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
