using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CursoAluno.Models
{
    public class Pagamento
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CursoId { get; set; }

        [Required]
        public int AlunoId { get; set; }

        [Required]
        public decimal Valor { get; set; }

        public virtual Curso Curso { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}