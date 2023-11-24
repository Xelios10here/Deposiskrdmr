namespace DataAccsessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Depoes", "SatilanUrunID", "dbo.SatilanUruns");
            DropIndex("dbo.Depoes", new[] { "SatilanUrunID" });
            AlterColumn("dbo.Depoes", "SatilanUrunID", c => c.Int());
            AlterColumn("dbo.Musteris", "SatilanUrunID", c => c.Int());
            CreateIndex("dbo.Depoes", "SatilanUrunID");
            AddForeignKey("dbo.Depoes", "SatilanUrunID", "dbo.SatilanUruns", "SatilanUrunID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Depoes", "SatilanUrunID", "dbo.SatilanUruns");
            DropIndex("dbo.Depoes", new[] { "SatilanUrunID" });
            AlterColumn("dbo.Musteris", "SatilanUrunID", c => c.Int(nullable: false));
            AlterColumn("dbo.Depoes", "SatilanUrunID", c => c.Int(nullable: false));
            CreateIndex("dbo.Depoes", "SatilanUrunID");
            AddForeignKey("dbo.Depoes", "SatilanUrunID", "dbo.SatilanUruns", "SatilanUrunID", cascadeDelete: true);
        }
    }
}
