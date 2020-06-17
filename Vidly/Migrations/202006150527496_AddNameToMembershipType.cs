namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            Sql("UPDATE MembershipTypes SET Name='Pagar por pedido' WHERE ID=1");
            Sql("UPDATE MembershipTypes SET Name='Mensual' WHERE ID=2");
            Sql("UPDATE MembershipTypes SET Name='Trimestral' WHERE ID=3");
            Sql("UPDATE MembershipTypes SET Name='Anual' WHERE ID=4");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
