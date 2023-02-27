﻿using System.Globalization;

namespace CursoSeq0402
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CLASSES, OBJETOS E ATRIBUTOS

            Produto p = new Produto();
            
            
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            
            Console.Write("Quantidade em estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);


            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser adicionado ao estoque : ");
            int qte = int .Parse(Console.ReadLine());
            p.AdcionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados : " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removido do estoque : ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados : " + p);
        }
    }
}