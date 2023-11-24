namespace DataAccsessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Musteris", "SatilanUrunID", c => c.Int(nullable: false));
            DropColumn("dbo.Uruns", "UrunCategory");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Uruns", "UrunCategory", c => c.String(maxLength: 50));
            AlterColumn("dbo.Musteris", "SatilanUrunID", c => c.Int());
        }
    }
}
