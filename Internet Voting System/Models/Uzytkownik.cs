using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Internet_Voting_System.Models
{
    public class Uzytkownik
    {
        [Key, Required, StringLength(6)]
        public double StudentID { get; set; }
        [Required]       
        public string Imie { get; set; }
        [Required]
        public string Nazwisko { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string GrupaD { get; set; }
        [Required]
        public string Wydzial { get; set;}
        public bool Kandydowanie = false;


         public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
         {
             string pat = @"^[a-zA-Z]+@student\.put\.poznan\.com$";
             Regex r = new Regex(pat, RegexOptions.IgnoreCase);
             Match m = r.Match(email);
             if (!m.Success)
             {
                 yield return new ValidationResult ("Twój adres e-mail nie jest w domenie student.put.poznan.pl");
             }
         
         }


    }
}