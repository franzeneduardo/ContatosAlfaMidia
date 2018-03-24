namespace CursoAluno.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChaveEstrangeiraCursoAlunoEmPagamentos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pagamentoes", "Pessoa_Id", c => c.Int());
            CreateIndex("dbo.Pagamentoes", "CursoId");
            CreateIndex("dbo.Pagamentoes", "Pessoa_Id");
            AddForeignKey("dbo.Pagamentoes", "CursoId", "dbo.Cursoes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Pagamentoes", "Pessoa_Id", "dbo.Pessoas", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pagamentoes", "Pessoa_Id", "dbo.Pessoas");
            DropForeignKey("dbo.Pagamentoes", "CursoId", "dbo.Cursoes");
            DropIndex("dbo.Pagamentoes", new[] { "Pessoa_Id" });
            DropIndex("dbo.Pagamentoes", new[] { "CursoId" });
            DropColumn("dbo.Pagamentoes", "Pessoa_Id");
        }
    }
}
