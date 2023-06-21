using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string quantidade;

            Console.WriteLine("Bem-vindo ao sistema de estoque da Keithy");

            Console.WriteLine("Digite o nome do funcionário responsavél:");
            nome = Console.ReadLine();

            Console.WriteLine("O cadastro de estoque será feito no " + nome);

            Console.WriteLine("-- CADASTRO DE PRODUTOS");

            Console.WriteLine("Digite o nome do Produto 1:");
            Console.WriteLine("Calça");
            Console.WriteLine(" Digite a quantidade em estoque de Calça:");
            Console.WriteLine("75");
            Console.WriteLine("Digite o nome do Produto 2:");
            Console.WriteLine("Perfume");
            Console.WriteLine("Digite a quantidade em estoque de Perfume");
            Console.WriteLine(" 23 ");
            Console.WriteLine("Os produtos foram cadastrados com sucesso!");



            Console.ReadKey();
        }
    }
}
