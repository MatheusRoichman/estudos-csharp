namespace Aritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores aritméticos são usados para fazer operações matemáticas.
            
            // Soma: +
            int soma = 3 + 7;
            
            // Subtração: -
            int subtracao = 10 - 5;
            
            // Multiplicação: *
            int multiplicacao = 4 * 8;
            
            // Divisão: / (retorna o resultado da divisão)
            int divisao = 20 / 4;
            
            // Módulo: % (retorna o resto da divisão)
            int modulo = 10 % 6;
            Console.WriteLine($"Resto de 10 / 6: {modulo}");
            
            /*
             * ORDEM DE PRECEDÊNCIA
             * 1. Parênteses ()
             * 2. Módulo, divisão e multiplicação (%, /, *)
             * 3. Soma e subtração
             */

            int op1 = 3 + 4 * 2; // 11
            int op2 = (3 + 4) * 2; // 12

            Console.WriteLine($"Sem parênteses: {op1}");
            Console.WriteLine($"Com parênteses: {op2}");

            int n1 = 10;
            int n2 = 8;
            double n3 = (double) n1 /n2;

            Console.WriteLine($"{n1} / {n2} = {n3}");
        }
    }
}