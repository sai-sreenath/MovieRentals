namespace VideoRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNameOfMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MemberShipName = 'Pay as You Go' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET MemberShipName = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET MemberShipName = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET MemberShipName = 'Annual' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
