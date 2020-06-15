namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            Sql("UPDATE MembershipTypes SET Name='Pay as You Go' WHERE ID=1");
            Sql("UPDATE MembershipTypes SET Name='Monthly' WHERE ID=2");
            Sql("UPDATE MembershipTypes SET Name='Quarter' WHERE ID=3");
            Sql("UPDATE MembershipTypes SET Name='Yearly' WHERE ID=4");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
