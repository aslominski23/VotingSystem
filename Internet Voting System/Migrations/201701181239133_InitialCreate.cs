namespace Internet_Voting_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Glos",
                c => new
                    {
                        GlosID = c.Int(nullable: false, identity: true),
                        IloscGlosow = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GlosID);
            
            CreateTable(
                "dbo.Glosowanies",
                c => new
                    {
                        glosid = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.glosid);
            
            CreateTable(
                "dbo.Kandydats",
                c => new
                    {
                        StudentID = c.Double(nullable: false),
                        Imie = c.String(nullable: false),
                        Nazwisko = c.String(nullable: false),
                        email = c.String(nullable: false),
                        GrupaD = c.String(nullable: false),
                        Wydzial = c.String(nullable: false),
                        Kierunek = c.String(nullable: false),
                        rokstudiow = c.Int(nullable: false),
                        semestr = c.Int(nullable: false),
                        emailpryw = c.String(nullable: false),
                        NumerTel = c.String(nullable: false),
                        uprawnienia_ODO = c.Boolean(nullable: false),
                        zgoda_dane = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID);
            
            CreateTable(
                "dbo.Verifies",
                c => new
                    {
                        VerifyID = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.VerifyID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Verifies");
            DropTable("dbo.Kandydats");
            DropTable("dbo.Glosowanies");
            DropTable("dbo.Glos");
        }
    }
}
