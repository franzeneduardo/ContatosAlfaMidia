﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CursoAluno.Models
{
    public class CursoAlunoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CursoAlunoContext() : base("name=CursoAlunoContext")
        {
        }

        public System.Data.Entity.DbSet<CursoAluno.Models.Pessoa> Pessoas { get; set; }

        public System.Data.Entity.DbSet<CursoAluno.Models.Curso> Cursoes { get; set; }

        public System.Data.Entity.DbSet<CursoAluno.Models.Pagamento> Pagamentoes { get; set; }
    }
}
