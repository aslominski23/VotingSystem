using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace Internet_Voting_System.Models
{
    public class VotingContext : DbContext
    {
        public VotingContext() : base("VoteDB") {
            Database.SetInitializer<VotingContext>(new DropCreateDatabaseIfModelChanges<VotingContext>());
            
        
        
        }

   /*     protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }*/

        public virtual DbSet<Glos> Glos { get; set; }
        public virtual DbSet<Glosowanie> Glosowanie {get; set;}
        public virtual DbSet<Kandydat> Kandydat { get; set; }
      //  public virtual DbSet<Uzytkownik> Uzytkownik { get; set; }
        public virtual DbSet<Verify> Verify { get; set; }
    }
}