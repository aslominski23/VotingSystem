using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Internet_Voting_System.Models
{
    
    public class Glos
    {
        public enum Wydzialy { WA, WBiS, WBMiZ, WE, WEiT, WFT, WI, WIZ, WMRiT, WTCh };
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GlosID { get; set; }
        [Required]
        public Wydzialy Wydzial = new Wydzialy();
        [ForeignKey("StudentID")]
       public ICollection<Kandydat> Kandydaci { get; set; }
        
        [Required]
        public int IloscGlosow { get; set;}
           

    }
}