using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Internet_Voting_System.Models
{
    public class Glosowanie
    {
        [Key]
        public int glosid { get; set; }
        
       public ICollection<Kandydat> Kandydaci { get; set; }
        
       public ICollection<Glos> Glosy  { get; set; }
    }
}