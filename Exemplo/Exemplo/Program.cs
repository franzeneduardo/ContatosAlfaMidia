﻿using System;
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

            Console.ReadKey();


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