using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo
{
    public class Pessoa
    {

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }

        public List<Telefone> Telefones { get; set; }

        public List<Email> Enderecos { get; set; }

        public List<Logradouros> Logradouros { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }

        public static string NomeCompleto(string nome, string sobrenome)
        {
            return nome + " " + sobrenome;
        }      

    }
}
