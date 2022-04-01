namespace FormulaBhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            // const impede que o valor da variável seja mudado.
            const double a = 1.0;
            const double b = -3.0;
            const double c = -4.0;

            // var infere o tipo da variável, dando flexibilidade ao programa.
            
            // Math.Pow(b, 2) é o mesmo que b * b. Os argumentos dessa função são (base, expoente).
            var delta = Math.Pow(b, 2) - 4.0 * a * c;
            
            // Math.Sqrt(delta) calcula a raiz quadrada de 'delta'. Sqrt vem de Square Root (Raiz Quadrada).
            var x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            var x2 = (-b + Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("Valores:");
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"c: {c}");
            Console.WriteLine($"O valor de delta é {delta}");
            Console.WriteLine($"O primeiro resultado (x1) é {x1}");
            Console.WriteLine($"O segundo resultado (x2) é {x2}");
        }
    }
}