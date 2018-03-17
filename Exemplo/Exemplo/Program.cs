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
            AdicionarTelefone(pessoa, "+55 51 4321-8745");
            AdicionarTelefone(pessoa, "+55 51 4321-8745");
            AdicionarTelefone(pessoa, "+55 51 4321-8745");
            AdicionarTelefone(pessoa, "+55 51 4321-8745");

            //emails
            pessoa.Enderecos = new List<Email>();
            AdicionarEmail(pessoa, "teste@teste.com");
            AdicionarEmail(pessoa, "teste@teste.com");
            AdicionarEmail(pessoa, "teste@teste.com");
            AdicionarEmail(pessoa, "teste@teste.com");

            //logradouros
            pessoa.Logradouros = new List<Logradouros>();
            AdicionarLogradouro(pessoa, "Avenida teste", "12");

            EscreveLogradouro(pessoa);
            EscreveNumeros(pessoa);
            EscreveEmail(pessoa);

            Console.WriteLine($"Nome: {pessoa.Nome}\nCPF: {pessoa.Cpf}");
            Console.WriteLine("Nome completo: {0}", Pessoa.NomeCompleto(pessoa.Nome, pessoa.Sobrenome));

            Console.ReadKey();


        }

        public static void AdicionarTelefone(Pessoa pessoa, string telefone)
        {
            var objetoTelefone = new Telefone();
            objetoTelefone.Numero = telefone;
            pessoa.Telefones.Add(objetoTelefone);
        }

        public static void AdicionarEmail(Pessoa pessoa, string endereco)
        {
            var objetoEmail = new Email();
            objetoEmail.Endereco = endereco;
            pessoa.Enderecos.Add(objetoEmail);
        }

        public static void AdicionarLogradouro(Pessoa pessoa, string rua, string numero)
        {
            var objetoLogradouro = new Logradouros();
            objetoLogradouro.numero = numero;
            objetoLogradouro.rua = rua;
            pessoa.Logradouros.Add(objetoLogradouro);
        }



        public static void EscreveEmail(Pessoa pessoa)
        {
            Console.Write("Emails: ");
            foreach (Email item in pessoa.Enderecos)
                
            {
                Console.Write($"{item.Endereco},"); 
            }
        }

        public static void EscreveLogradouro(Pessoa pessoa)
        {
            Console.Write("Logradouro: ");
            foreach (Logradouros item in pessoa.Logradouros)
            {
                Console.Write($"{item.rua},{item.numero},");
            }
        }

        public static void EscreveNumeros(Pessoa pessoa)
        {
            for (int i = 0; i < pessoa.Telefones.Count(); i++)
            {
                Console.WriteLine($"Telefone {i+1} {pessoa.Telefones[i].Numero}");
            }
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
