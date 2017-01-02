using System;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Movie
    {
        //public int id { get; set; }

        //[stringlength(60, minimumlength = 3)]
        //public string title { get; set; }

        //[display(name = "release date")]
        //[datatype(datatype.date)]
        //[displayformat(dataformatstring = "{0:yyyy-mm-dd}", applyformatineditmode = true)]
        //public datetime releasedate { get; set; }

        //[regularexpression(@"^[a-z]+[a-za-z''-'\s]*$")]
        //[required]
        //[stringlength(30)]
        //public string genre { get; set; }

        //[range(1, 100)]
        //[datatype(datatype.currency)]
        //public decimal price { get; set; }

        //[regularexpression(@"^[a-z]+[a-za-z''-'\s]*$")]
        //[stringlength(5)]
        //public string rating { get; set; }

        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string Rating { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        //public MovieDBContext()
        //{
        //    Database.SetInitializer<MovieDBContext>
        //        (new MigrateDatabaseToLatestVersion<MovieDBContext,
        //            MvcMovie.Migrations.Configuration>());
        //}
        public DbSet<Movie> Movies { get; set; }
    }
}
