namespace Atribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores de atribuição são usados para dar valores a algo.

            int num;
            
            // num recebe 10
            num = 10;
            
            // num recebe num + 2
            num += 2;
            
            // O operador += também funciona para concatenação de strings
            string str = "ABC";
            str += "DEF";

            // num recebe num - 4
            num -= 4;
            
            // num recebe num * 3
            num *= 3;
            
            // num recebe num / 2
            num /= 2;
            
            // num recebe num % 4
            num %= 4;
            
            // O operador ++ adiciona 1 ao número, e o -- subtrai 1.
            num++;
            num--;
            
            // Há diferença entre num++ e ++num, assim como num-- e --num. Iremos ver isso usando variáveis.
            int a = 10;
            int b = a++;
            
            /*
             * Nesse exemplo, você verá no Console que 'a' será 11, mas 'b'. será 10. Por quê?
             * Porque o ++ na frente primeiro deu o valor antigo da variável a para a variável b,
             * e só depois disso somou 1 no valor de a.
             */
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            
            // Agora, vamos usar ainda outras variáveis.
            int c = 20;
            int d = ++c;
            
            /*
             * Nesse caso, as 2 variáveis terão valor 21, pois o ++ atrás primeiro aumenta o valor da variável c,
             * para depois atribuir o valor dela à variável d.
             */

            Console.WriteLine($"c: {c}");
            Console.WriteLine($"d: {d}");
        }
    }
}