namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id,Name) VALUES (1,'Comedia')");
            Sql("INSERT INTO Genres(Id,Name) VALUES (2,'Accion')");
            Sql("INSERT INTO Genres(Id,Name) VALUES (3,'Familiar')");
            Sql("INSERT INTO Genres(Id,Name) VALUES (4,'Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
