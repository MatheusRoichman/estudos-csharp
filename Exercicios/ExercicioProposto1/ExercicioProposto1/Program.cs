using System.Globalization;

namespace ExercicioProposto1
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quantidadeQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double precoProduto = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o seu último nome, idade e altura (mesma linha):");
            string[] valores = Console.ReadLine().Split(' ');

            string ultimoNome = valores[0];
            int idade = int.Parse(valores[1]);
            double altura = double.Parse(valores[2]);

            Console.WriteLine(nome);
            Console.WriteLine(quantidadeQuartos);
            Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}