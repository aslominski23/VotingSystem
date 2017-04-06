using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Internet_Voting_System.Models
{
    
    public class Kandydat 
    {

        [Key, Required]
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
        public string Wydzial { get; set; }
        public bool Kandydowanie = false;
        [Required]
        public string Kierunek { get; set; }
        [Required]
        public int rokstudiow { get; set; }
        [Required]
        public int semestr { get; set; }
        [Required]
        public string emailpryw { get; set; }
        [Required]
        public string NumerTel { get; set; }
       
        public bool uprawnienia_ODO { get; set; } 
        public bool zgoda_dane { get; set; }
        

        public Kandydat()
        {
            this.uprawnienia_ODO = false;
            this.zgoda_dane = false;
           
        }
    
    
    }
}