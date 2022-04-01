using System.Globalization;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados é quando o programa recebe um dado do usuário ou de uma fonte externa.
            
            // O método Console.ReadLine() lê os dados em formato de string até a quebra de linha.
            Console.WriteLine("Digite algo:");
            
            string dadoUser = Console.ReadLine();
            
            Console.WriteLine($"Você digitou: {dadoUser}");
            
            // O método Console.Clear() limpa a tela do console, apagando os textos nele
            Console.Clear();
            
            // EXERCÍCIO DE FIXAÇÃO 1
            string frase = Console.ReadLine();
            
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            
            // Agora temos que receber 3 palavras em uma única linha e armazenar cada uma em uma variável.
            // Vamos primeiro pegar a linha toda
            string s = Console.ReadLine();
            
            // string[] é um vetor de strings, ou seja, guarda mais de 1 valor em uma única variável.
            // O método s.Split(' ') separa a string em pedaços a cada vez que o separador definido aparecer.
            // Cada pedaço será transformado em um item do vetor.
            // Os parâmetros dessa função são (separador).
            string[] vetor = s.Split(' ');

            // A contagem de posições nos vetores começa do 0.
            // Ou seja, 0 será a primeira posição, 1 será a segunda etc.
            // Para acessar uma posição de um vetor, a sintaxe é: nomeDoVetor[posicao]. Veja:
            string a = vetor[0];
            string b = vetor[1];
            string c = vetor[2];
            
            // EXERCÍCIO DE FIXAÇÃO 2
            Console.Clear();
            
            // Os métodos [tipo].Parse() convertem um dado para o tipo de onde a função Parse vem.
            // Exemplo: int.Parse() converte para int.
            
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] valores = Console.ReadLine().Split(' ');

            string nome = valores[0];
            char genero = char.Parse(valores[1]);
            int idade = int.Parse(valores[2]);
            double altura = double.Parse(valores[3]);

            Console.WriteLine($"Nome: {nome}, gênero: {genero}, idade: {idade}, altura: {altura}");
        }
    }
}