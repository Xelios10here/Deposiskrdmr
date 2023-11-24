namespace DataAccsessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Depoes", "UrunID", "dbo.Uruns");
            DropForeignKey("dbo.Musteris", "SatilanUrunID", "dbo.SatilanUruns");
            DropIndex("dbo.Depoes", new[] { "UrunID" });
            DropIndex("dbo.Musteris", new[] { "SatilanUrunID" });
            DropPrimaryKey("dbo.Depoes");
            AddColumn("dbo.Depoes", "Urun_UrunID", c => c.Int());
            AddColumn("dbo.SatilanUruns", "CategoryID", c => c.Int(nullable: false));
            AddColumn("dbo.SatilanUruns", "MusteriID", c => c.Int(nullable: false));
            AddColumn("dbo.SatilanUruns", "Musteri_MusteriID", c => c.Int());
            AddColumn("dbo.Musteris", "SatilanUrun_SatilanUrunID", c => c.Int());
            AddColumn("dbo.Musteris", "SatilanUrun_SatilanUrunID1", c => c.Int());
            AlterColumn("dbo.Depoes", "UrunID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Depoes", "UrunID");
            CreateIndex("dbo.Depoes", "Urun_UrunID");
            CreateIndex("dbo.SatilanUruns", "CategoryID");
            CreateIndex("dbo.SatilanUruns", "Musteri_MusteriID");
            CreateIndex("dbo.Musteris", "SatilanUrun_SatilanUrunID");
            CreateIndex("dbo.Musteris", "SatilanUrun_SatilanUrunID1");
            AddForeignKey("dbo.SatilanUruns", "CategoryID", "dbo.Categories", "CategoryID", cascadeDelete: true);
            AddForeignKey("dbo.SatilanUruns", "Musteri_MusteriID", "dbo.Musteris", "MusteriID");
            AddForeignKey("dbo.Depoes", "Urun_UrunID", "dbo.Uruns", "UrunID");
            AddForeignKey("dbo.Musteris", "SatilanUrun_SatilanUrunID1", "dbo.SatilanUruns", "SatilanUrunID");
            AddForeignKey("dbo.Musteris", "SatilanUrun_SatilanUrunID", "dbo.SatilanUruns", "SatilanUrunID");
            DropColumn("dbo.Depoes", "CategoryID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Depoes", "CategoryID", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Musteris", "SatilanUrun_SatilanUrunID", "dbo.SatilanUruns");
            DropForeignKey("dbo.Musteris", "SatilanUrun_SatilanUrunID1", "dbo.SatilanUruns");
            DropForeignKey("dbo.Depoes", "Urun_UrunID", "dbo.Uruns");
            DropForeignKey("dbo.SatilanUruns", "Musteri_MusteriID", "dbo.Musteris");
            DropForeignKey("dbo.SatilanUruns", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Musteris", new[] { "SatilanUrun_SatilanUrunID1" });
            DropIndex("dbo.Musteris", new[] { "SatilanUrun_SatilanUrunID" });
            DropIndex("dbo.SatilanUruns", new[] { "Musteri_MusteriID" });
            DropIndex("dbo.SatilanUruns", new[] { "CategoryID" });
            DropIndex("dbo.Depoes", new[] { "Urun_UrunID" });
            DropPrimaryKey("dbo.Depoes");
            AlterColumn("dbo.Depoes", "UrunID", c => c.Int(nullable: false));
            DropColumn("dbo.Musteris", "SatilanUrun_SatilanUrunID1");
            DropColumn("dbo.Musteris", "SatilanUrun_SatilanUrunID");
            DropColumn("dbo.SatilanUruns", "Musteri_MusteriID");
            DropColumn("dbo.SatilanUruns", "MusteriID");
            DropColumn("dbo.SatilanUruns", "CategoryID");
            DropColumn("dbo.Depoes", "Urun_UrunID");
            AddPrimaryKey("dbo.Depoes", "CategoryID");
            CreateIndex("dbo.Musteris", "SatilanUrunID");
            CreateIndex("dbo.Depoes", "UrunID");
            AddForeignKey("dbo.Musteris", "SatilanUrunID", "dbo.SatilanUruns", "SatilanUrunID", cascadeDelete: true);
            AddForeignKey("dbo.Depoes", "UrunID", "dbo.Uruns", "UrunID", cascadeDelete: true);
        }
    }
}
