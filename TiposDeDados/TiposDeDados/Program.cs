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
            long h = long.MinValue;
            
            // Ponto flutuante
            double i = 23.4;
            float j = float.MaxValue;
            decimal k = decimal.MinValue;
            
            // Boolean: verdadeiro ou falso
            bool l = true;
            bool m = false;
            
            // Caractere Unicode
            char n = 'n';
            
            // Cadeia de caracteres
            string o = "Texto!";

            // REFERÊNCIA: http://www.linhadecodigo.com.br/artigo/12/tipos-de-dados-no-net.aspx
        }
    }
}