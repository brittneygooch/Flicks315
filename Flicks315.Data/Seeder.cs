using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using Flicks315.Data.Models;


namespace Flicks315.Data
{
    public static class Seeder
    {
        public static void Seed(FlicksDbContext db)
        {
            db.Movies.AddOrUpdate(
               m => new { m.MovieId, m.Title, m.Rating, m.Description },
               new Movie() { MovieId = 2, Title = "Are We There Yet?", Rating = "PG", Description = "Family Road Trip or Not?" },
               new Movie() { MovieId = 3, Title = "Life", Rating = "R", Description = "Life in Jail" },
               new Movie() { MovieId = 4, Title = "Due Date", Rating = "PG13", Description = "Road trip plus baby due = classic" }
               );

            db.Actors.AddOrUpdate(
                a => new { a.ActorId, a.Name, a.Awards, a.MovieId },
                new Actor() { ActorId = 1, Name = "Tina Turner", Awards = 5, MovieId = 2 },
                new Actor() { ActorId = 2, Name = "Eddie Murphy", Awards = 8, MovieId = 3 },
                new Actor() { ActorId = 3, Name = "Zach Galifanikis", Awards = 5, MovieId = 4 }


                );
        }
    }
}
