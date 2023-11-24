namespace DataAccsessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SatilanUruns", "UrunID", "dbo.Uruns");
            DropIndex("dbo.SatilanUruns", new[] { "UrunID" });
            AddColumn("dbo.Uruns", "SatilanUrunID", c => c.Int());
            CreateIndex("dbo.Uruns", "SatilanUrunID");
            AddForeignKey("dbo.Uruns", "SatilanUrunID", "dbo.SatilanUruns", "SatilanUrunID");
            DropColumn("dbo.SatilanUruns", "UrunID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SatilanUruns", "UrunID", c => c.Int());
            DropForeignKey("dbo.Uruns", "SatilanUrunID", "dbo.SatilanUruns");
            DropIndex("dbo.Uruns", new[] { "SatilanUrunID" });
            DropColumn("dbo.Uruns", "SatilanUrunID");
            CreateIndex("dbo.SatilanUruns", "UrunID");
            AddForeignKey("dbo.SatilanUruns", "UrunID", "dbo.Uruns", "UrunID");
        }
    }
}
