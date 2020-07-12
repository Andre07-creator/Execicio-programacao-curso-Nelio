using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using programa_Vetores_2.Entites;
using System.Globalization;

namespace programa_Vetores_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos jogos deseja cadastrar:");
            int n = int.Parse(Console.ReadLine());

            Jogos[] vect = new Jogos[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome do jogo:");
                string nome = Console.ReadLine();
                Console.Write("Informe o preço do jogo:");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Jogos{ NomeJ = nome, PrecoJ = preco };
            }
            Console.WriteLine();
            Console.WriteLine("Jogos cadastrados com sucesso no sistema!!!");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vect[i]);
            }
        }
    }
}
