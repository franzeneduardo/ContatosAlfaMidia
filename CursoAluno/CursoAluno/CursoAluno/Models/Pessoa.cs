using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CursoAluno.Models
{
    public class Pessoa
    {
        public int Id { get; set;}

        [Display(Prompt = "Nome completo")]
        [Required]
        [MaxLength(150)]
        public string Nome { get; set; }

        [Display(Prompt = "Data de nascimento"), Required]
        public DateTime Nascimento { get; set; }

        public int CursoId { get; set; }

        public virtual Curso Curso { get; set; }


    }
}