using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace CRUDFilmDbProject.Models
{
    public class FilmForm

    {
        [Key]
        public int FilmID { get; set; }

        public string FilmTitle { get; set; }

        public string FilmCertificate { get; set; }

        public string FilmDescription { get; set; }

        public string FilmImage {  get; set;}
        public decimal FilmPrice { get; set; }

        public int Stars { get; set; }

        public DateTime ReleaseDate { get; set; }

    }

}