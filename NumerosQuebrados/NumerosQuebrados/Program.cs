namespace NumerosQuebrados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Podemos limitar as casas decimais de números quebrados. Veja:
            double num1 = 34.4663255;
            Console.WriteLine("Número: {0}", num1);
            
            // o F2 limita as casas decimais para 2. Se fosse F3, por exemplo, seriam 3 casas decimais.
            Console.WriteLine("Número com 2 casas decimais: " + num1.ToString("F2"));

            Console.WriteLine($"Número com 4 casas decimais: {num1:F4}");
        }
    }
}