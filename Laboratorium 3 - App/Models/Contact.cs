using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Laboratorium_3___App.Models
{
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage ="Musisz wpisać imię!")]
        [StringLength(maximumLength:100, ErrorMessage ="Zbyt długie imię, maksymalnie 100 znaków!")]
        [Display (Name ="Name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Musisz podać e-mail!")]
        [EmailAddress(ErrorMessage ="Niepoprawny adres e-mail, brak znaku @")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Phone(ErrorMessage ="Niepoprawny numer telefonu!")]
        public string Phone { get; set; }
        public DateTime Birth {  get; set; }

        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }
        [HiddenInput]
        public DateTime Created { get; set; }

    }
}
