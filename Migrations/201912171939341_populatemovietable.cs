namespace VideoRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatemovietable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT[dbo].[Movies] ON");
            Sql("Insert into Movies(Id, Name, GenreId,DateAdded,ReleaseDate,NumberInStock) VALUES(1,'Hangover',1,'07-17-1996','07-17-1990',5)");
            Sql("Insert into Movies(Id, Name, GenreId,DateAdded,ReleaseDate,NumberInStock) VALUES(2,'Die Hard',2,'07-17-1996','07-17-1990',5)");
            Sql("Insert into Movies(Id, Name, GenreId,DateAdded,ReleaseDate,NumberInStock) VALUES(3,'Terminator',3,'07-17-1996','07-17-1990',5)");
            Sql("Insert into Movies(Id, Name, GenreId,DateAdded,ReleaseDate,NumberInStock) VALUES(4,'Toy-Story',4,'07-17-1996','07-17-1990',5)");
            Sql("Insert into Movies(Id, Name, GenreId,DateAdded,ReleaseDate,NumberInStock) VALUES(5,'Titanic',5,'07-17-1996','07-17-1990',5)");
        }

        public override void Down()
        {
        }
    }
}
