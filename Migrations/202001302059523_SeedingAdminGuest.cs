namespace VideoRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingAdminGuest : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'76753343-44ad-485b-b673-195f51a88f9f', N'admin@video.com', 0, N'AMexbkOx70lTls3qU705kyi7LKCnjnmPX9X7JDXiGer6z2KbK2+StwbtckuyGl8iWg==', N'cca2f333-4fdd-4cf5-9bed-27ac86adc9b6', NULL, 0, 0, NULL, 1, 0, N'admin@video.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e52ec05c-dd04-4404-80a9-ab5072e178fd', N'guest@video.com', 0, N'AGVxyjl4E/WA/hmwbK6Ww9z24MMX1NJOAwwTdea/K1ggJWk72u9ql+uwkyL/Wgx/DA==', N'b0c3f79d-8cb1-4611-ad08-45d0b1f101d3', NULL, 0, 0, NULL, 1, 0, N'guest@video.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a91df9cd-0e53-43e6-9753-af8935aad2d8', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'76753343-44ad-485b-b673-195f51a88f9f', N'a91df9cd-0e53-43e6-9753-af8935aad2d8')

");
        }
        
        public override void Down()
        {
        }
    }
}
