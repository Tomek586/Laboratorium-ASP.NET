using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3___Post_App.Models
{
    public class Post
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Musisz wpisać zawartość")]
        [StringLength(maximumLength: 200, ErrorMessage = "Za dużo znaków!")]
        [Display(Name = "Zawartość")]
        public string Content {  get; set; }
        [Display(Name = "Autor")]
        [Required(ErrorMessage = "Musisz wpisać Autora!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Za dużo znaków!")]
        public string Author { get; set; }
        [Display(Name = "Data publikacji")]
        [Required(ErrorMessage = "Musisz uzupełnić datę!")]
        public DateTime Date { get; set; }
        [Display(Name = "Tagi")]
        [Required(ErrorMessage = "Musisz wpisać Tagi!")]
        [StringLength(maximumLength: 100, ErrorMessage = "Za dużo znaków!")]
        public string Tags { get; set; }
        [Display(Name = "Komentarz")]
        [Required(ErrorMessage = "Musisz wpisać Komentarz!")]
        [StringLength(maximumLength: 200, ErrorMessage = "Za dużo znaków!")]
        public string Comment { get; set; }

        public DateTime Created { get; set; }

    }
}
