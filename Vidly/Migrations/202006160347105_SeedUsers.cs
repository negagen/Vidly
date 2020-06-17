namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'31de0ae5-77d3-47ec-8d16-3521547d59c4', N'admin@vidly.com', 0, N'AASniek/XfOWE3pc8x9jMsS9LjWEmehbvQbFGkyL3eA5t8LdPti6Akx8hngl1Hlxng==', N'418956db-0178-43ef-bc17-1bca68d297ea', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6afdda24-83d8-4577-af29-01b985c72d38', N'guest@vidly.com', 0, N'AL9EZXIHdXtHlfSx8IqRbrIn+ZK0p+t5mRPVQtbr+vLjnKek47Visvb7rojDs6qUDQ==', N'8f7a1f28-573e-4425-8953-5bd88c2ecaad', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'99aa60e7-129a-4782-a1b5-dae35450c334', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'31de0ae5-77d3-47ec-8d16-3521547d59c4', N'99aa60e7-129a-4782-a1b5-dae35450c334')                
");


        }
        
        public override void Down()
        {
        }
    }
}
