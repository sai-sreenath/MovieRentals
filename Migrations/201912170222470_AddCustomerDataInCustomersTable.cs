namespace VideoRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerDataInCustomersTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT[dbo].[Customers] ON");
            Sql("Insert into Customers(Id, Name, IsSubscribedToNewsletter,MemberShipTypeId,Birthdate) VALUES(1,'John Smith',0,1,'07-17-1996')");
            Sql("Insert into Customers(Id, Name, IsSubscribedToNewsletter,MemberShipTypeId,Birthdate) VALUES(2,'Mary Williams',1,2,null)");
        }

        public override void Down()
        {
        }
    }
}
