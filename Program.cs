using System;
using System.Globalization;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Digite Dados do Produto! , Nome , Preço e Quantidade");
            string[] v = Console.ReadLine().Split(',');
            string nome = v[0];
            double preco = double.Parse(v[1], CultureInfo.InvariantCulture);
            int quantidade = int.Parse(v[2], CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco, quantidade);//Parâmetros do Construtor

            /*p.Nome = nome; // Properties mais Intuitivo e Didatico . // Possibilidades de Atrinuição Não está sendo Ultilizado pois o Construtor
            p.Preco = preco; // Ja está recebendo os Parâmetros!
            p.Quantidade = quantidade;*/

            Console.WriteLine();
            Console.WriteLine("Dados do Estoque : " + p);
            Console.WriteLine();

            Console.Write("Digite Quantos Produtos Devem Ser Adicionados ao Estoque :");
            quantidade = int.Parse(Console.ReadLine());
            p.AdicionarProduto(quantidade);

            Console.WriteLine();
            Console.WriteLine("Estoque Atualizado!");

            Console.WriteLine();
            Console.Write(p);
            Console.WriteLine();

            Console.Write("Digite Quantos Produtos Irão Sair do Estoque :");
            quantidade = int.Parse(Console.ReadLine());
            p.RemoverProduto(quantidade);

            Console.WriteLine();
            Console.WriteLine("Estoque Atualizado!");

            Console.WriteLine();
            Console.WriteLine(p);
            Console.WriteLine();

            Console.WriteLine("Digitou Algo Errado ? Qual deseja Corrigir :");
            Console.Write("Digite 1 - Nome, 2 - Quantidade  ou 0 - Para Sair :");
            Console.WriteLine();
            int concertar = int.Parse(Console.ReadLine());

            while (concertar != 0)
            {
                switch (concertar)
                {
                    case 1:
                        Console.Write("Corrigir Nome :");
                        nome = Console.ReadLine();
                        p.Nome = nome;
                        break;
                    case 2:
                        Console.WriteLine("Corrigir Quantidade :");
                        quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        p.Quantidade = quantidade;
                        break;
                    default:
                        Console.WriteLine("Opção Invalida !");
                        break;

                }
                Console.WriteLine();
                Console.WriteLine("Novos Dados:" + p);

                Console.WriteLine();
                Console.Write("Digite 1 - Nome, 2 - Quantidade  ou 0 - Para Sair :");
                Console.WriteLine();
                concertar = int.Parse(Console.ReadLine());
            }




        }
    }
}
