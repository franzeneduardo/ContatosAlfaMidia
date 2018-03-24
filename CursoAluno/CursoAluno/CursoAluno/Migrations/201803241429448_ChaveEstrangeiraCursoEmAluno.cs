namespace CursoAluno.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChaveEstrangeiraCursoEmAluno : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Pessoas", "CursoId");
            AddForeignKey("dbo.Pessoas", "CursoId", "dbo.Cursoes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pessoas", "CursoId", "dbo.Cursoes");
            DropIndex("dbo.Pessoas", new[] { "CursoId" });
        }
    }
}
