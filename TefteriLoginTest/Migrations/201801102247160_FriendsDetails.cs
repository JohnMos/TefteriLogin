namespace TefteriLoginTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FriendsDetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FriendDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FriendDetails");
        }
    }
}
