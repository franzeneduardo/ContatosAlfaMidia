using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CursoAluno.Models
{
    public class Curso
    {
        public int Id { get; set; }

        [Display(Name = "nome")]
        public string Nome { get; set; }

        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }

        public virtual IEnumerable<Pessoa> Pessoas { get; set; }

    }
}