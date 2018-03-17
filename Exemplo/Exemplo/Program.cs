using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meu aplicativo\n\n");

            var idade = 18;
            var nomePessoa = "João";
            string nomeDaMae;
            nomeDaMae = "Joana";
            int idadeDaMae;
            idadeDaMae = 40;


            Console.WriteLine("Nome: "+ nomePessoa);
            Console.WriteLine("Idade: "+ idade);
            Console.WriteLine("Nome da mãe: " + nomeDaMae);
            Console.WriteLine("Idade da mãe: " + idadeDaMae);

            //funções

            var sobrenome = "Silva";



            Console.WriteLine("Nome completo: "+NomeCompleto(nomePessoa,sobrenome));

            EscreveDiferencaIdade(idadeDaMae, idade);

            Console.WriteLine("\n------------\n");

            var pessoa = new Pessoa();
            pessoa.Nome = "Pedro";
            pessoa.Sobrenome = "Santana";
            pessoa.Cpf = "12345678900";

            pessoa.Telefones = new List<Telefone>();
            //telefones
            AdicionarTelefone(pessoa, "+55 51 9999-9999");
            AdicionarTelefone(pessoa, "+55 51 1234-5678");


            Console.WriteLine($"Telefone 1 {pessoa.Telefones[0].Numero}");
            Console.WriteLine($"Telefone 2 {pessoa.Telefones[1].Numero}");




            Console.WriteLine($"Nome: {pessoa.Nome}\nCPF: {pessoa.Cpf}");

            Console.ReadKey();


        }

        public static void AdicionarTelefone(Pessoa pessoa, string telefone)
        {
            var objetoTelefone = new Telefone();
            objetoTelefone.Numero = telefone;
            pessoa.Telefones.Add(objetoTelefone);
        }

        static string NomeCompleto (string primeiro, string sobrenome)
        {
            return primeiro + " " + sobrenome; 
        }

        static void EscreveDiferencaIdade(int idadeMaisVelho, int idadeMaisNovo)
        {
            Console.WriteLine("Diferença de idade: " + (idadeMaisVelho - idadeMaisNovo).ToString());
        }
    }
}
