namespace DataAccsessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SatilanUruns", "UrunID", c => c.Int());
            CreateIndex("dbo.SatilanUruns", "UrunID");
            AddForeignKey("dbo.SatilanUruns", "UrunID", "dbo.Uruns", "UrunID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SatilanUruns", "UrunID", "dbo.Uruns");
            DropIndex("dbo.SatilanUruns", new[] { "UrunID" });
            DropColumn("dbo.SatilanUruns", "UrunID");
        }
    }
}
