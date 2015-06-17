using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public string Tytuł { get; set; }

        [Required(ErrorMessage = "Data Premiery jest wymagana!")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime Premiera { get; set; }

        [Required(ErrorMessage = "Gatunek musi być określony!")]
        public string Gatunek { get; set; }

        [Required(ErrorMessage = "Proszę podać cenę")]
        [Range(1, 200, ErrorMessage = "Cena jest zależna od przedziału <1:200>")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Cena { get; set; }

        [StringLength(5)]
        public string Ocena { get; set; }

        public string Opis { get; set; }

        [StringLength(1024)]
        public string Okladka { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}