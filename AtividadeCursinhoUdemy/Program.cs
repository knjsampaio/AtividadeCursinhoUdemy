using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AtividadeCursinhoUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1} cujo o preço é {preco1:F2}");
            Console.WriteLine($"{produto2} cujo o preço é {preco2:F2}");
            Console.WriteLine();
            Console.Write("Regirstro: ");
            Console.WriteLine($"{idade} anos de idade, codigo {codigo} e gênero: {genero}.");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondando (com três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal Invariant Culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

            */

            string nome;
            int quartos;
            double preco;
            

            Console.WriteLine("Entre com o seu nome completo: ");
            nome = Console.ReadLine();
            

            Console.WriteLine("Quantos quartos tem na sua casa?");
            quartos = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Entre com o preço de um produto: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));


            









        }
    }
}
