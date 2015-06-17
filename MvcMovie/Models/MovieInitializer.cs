using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MvcMovie.Models
{
    public class MovieInitializer : DropCreateDatabaseIfModelChanges<MovieDBContext>
    {
        protected override void Seed(MovieDBContext context)
        {
            var movies = new List<Movie> {  
  
                 new Movie { Tytuł = "Prison Break",   
                             Premiera=DateTime.Parse("2005-08-08 00:00:00"),   
                             Gatunek="Action",  
                             Ocena="R",  
                             Cena=23.00M},  

                     new Movie { Tytuł = "Scary Movie ",   
                             Premiera=DateTime.Parse("2008-07-19 00:00:00"),   
                             Gatunek="Comedy",  
                              Ocena="R",  
                             Cena=9.00M},   
  
                 new Movie { Tytuł = "MVC Tutorials",   
                             Premiera=DateTime.Parse("2010-09-21 00:00:00"),   
                             Gatunek="Sience",  
                             Ocena="R",  
                             Cena=30.00M}
            };

            movies.ForEach(d => context.Movies.Add(d));
        }
    }

}