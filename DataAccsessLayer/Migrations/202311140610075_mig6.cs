namespace DataAccsessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig6 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Uruns", name: "SatilanUrunID", newName: "SatilanUrun_SatilanUrunID");
            RenameIndex(table: "dbo.Uruns", name: "IX_SatilanUrunID", newName: "IX_SatilanUrun_SatilanUrunID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Uruns", name: "IX_SatilanUrun_SatilanUrunID", newName: "IX_SatilanUrunID");
            RenameColumn(table: "dbo.Uruns", name: "SatilanUrun_SatilanUrunID", newName: "SatilanUrunID");
        }
    }
}
