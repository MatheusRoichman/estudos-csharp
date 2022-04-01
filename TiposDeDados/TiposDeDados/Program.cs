namespace TiposDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inteiros
            byte   a = 255;   // Vai de 0 a 255
            sbyte  b = 127;   // Vai de -127 a 127
            ushort c = 65535; // Vai de 0 a 65.535
            short  d = 32767; // Vai de -32.768 a 32.767
            
            // Podemos pegar o valor máximo e mínimo desses tipos. Veja com o restante dos tipos:
            uint e = uint.MaxValue;
            int f = int.MinValue;
            ulong g = ulong.MaxValue;
            long h = 43894774L; // é recomendado que números long tenham o L no final, para identificar que são desse tipo
            
            // Ponto flutuante
            double i = 23.4;
            float j = 12343.67f; // números float precisam ter 'f' no final
            decimal k = decimal.MinValue;
            
            // Boolean: verdadeiro ou falso
            bool l = true;
            bool m = false;
            
            // Caractere Unicode
            char n = 'n'; // caracteres devem ser definidos entre aspas simples
            char o = '\u00DF'; // char pode receber tanto o caractere quanto o código Unicode do caractere. Veja a tabela: https://unicode-table.com
            Console.WriteLine(o);
            
            // Cadeia de caracteres
            string p = "Texto!"; // cadeias de caracteres devem ser definidas entre aspas duplas.
            
            /* OBSERVAÇÃO: O string não é reconhecido como um tipo básico do C#.
            Ele é imutável. Uma vez que você cria uma variável do tipo string,
            você não pode usar o valor dela,
            aumentando a segurança e reduzindo a chance de erros no programa.
            Quando você modifica o valor de uma variável string, você não modifica a string,
            e sim cria uma nova. */
            
            // Objeto genérico, Tudo no C# é uma subclasse de object, logo, ele pode ser qualquer coisa.
            object q = 4.5;
            object r = "Sou uma string e me encaixo no object!";

            // REFERÊNCIA: http://www.linhadecodigo.com.br/artigo/12/tipos-de-dados-no-net.aspx
        }
    }
}