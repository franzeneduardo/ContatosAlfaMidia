namespace CursoAluno.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriarTabelaPagamentos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pagamentoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CursoId = c.Int(nullable: false),
                        AlunoId = c.Int(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pagamentoes");
        }
    }
}
