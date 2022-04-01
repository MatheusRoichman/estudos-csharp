namespace ConversaoImplicitaECasting
{
    class Program
    {
        static void Main(string[] args) {
            // Conversão implícita é quando um dado de um tipo pode ser naturalmente atribuído a uma variável de outro tipo.
            // REFERÊNCIA: https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/numeric-conversions
            
            // Float tem 4 bytes e double tem 8 bytes, logo, float pode ser atribuído a um double.
            // A operação inversa é impossível.
            float num1 = 4.5F;
            double num2 = num1;
            
            // Casting é a conversão explícita entre tipos compatíveis. Pode haver perda de informação.
            double num3 = 9.423;
            float num4 = (float) num3;
            Console.WriteLine(num4);

            double num5 = 646.34;
            int num6 = (int) num5;
            
            // Nesse caso, houve perda de informação. As casas decimais foram perdidas, pois o tipo int não as aceita.
            Console.WriteLine(num6);

            int num7 = 5;
            int num8 = 2;
            double resultado = num7 / num8;
            
            /*
             * O resultado esperado era 2.5, mas o resultado obtido foi 2. Por quê?
             * Como os 2 números utilizados na operação foram do tipo int,
             * o compilador entende que seria uma divisão inteira, e por isso o retorno não é um número quebrado.
             */
            Console.WriteLine($"Divisão 1: {resultado}");
            
            // Podemos fazer casting para contornar essa situação.
            resultado = (double) num7 / num8;
            Console.WriteLine($"Divisão 1: {resultado}");
        }
    }
}