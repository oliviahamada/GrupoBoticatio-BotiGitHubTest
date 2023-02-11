namespace GrupoBoticatio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RepositoriesItemsDetails",
                c => new
                    {
                        RepositoryId = c.String(nullable: false, maxLength: 128),
                        Id = c.Int(nullable: false),
                        Language = c.String(nullable: false, maxLength: 255),
                        FullName = c.String(nullable: false, maxLength: 255),
                        HtmlUrl = c.String(nullable: false, maxLength: 255),
                        Description = c.String(),
                        IsPrivate = c.Short(nullable: false),
                        StargazersCount = c.Int(nullable: false),
                        Page = c.Int(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RepositoryId)
                .ForeignKey("dbo.RepositoriesLanguages", t => t.Language, cascadeDelete: true)
                .Index(t => t.Language);
            
            CreateTable(
                "dbo.RepositoriesLanguages",
                c => new
                    {
                        Language = c.String(nullable: false, maxLength: 255),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Language);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RepositoriesItemsDetails", "Language", "dbo.RepositoriesLanguages");
            DropIndex("dbo.RepositoriesItemsDetails", new[] { "Language" });
            DropTable("dbo.RepositoriesLanguages");
            DropTable("dbo.RepositoriesItemsDetails");
        }
    }
}
