// Para utilizar este recurso, precisamos usar o System.Globalization
using System.Globalization;

namespace InvariantCulture
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 23.334221F;
            Console.WriteLine(num1);
            
            // O segundo parâmetro dessa função é o Format Provider.
            // O CultureInfo.InvariantCulture define que nenhuma cultura externa deve afetar o programa
            // Por exemplo, se os números quebrados estão sendo exibidos com ',', eles serão agora exibidos com '.'
            Console.WriteLine(num1.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}