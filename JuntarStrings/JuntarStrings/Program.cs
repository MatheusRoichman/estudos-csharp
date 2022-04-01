namespace JuntarStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Matheus";
            int idade = 15;
            char genero = 'M';

            // Quando temos 2 strings ou mais e queremos juntá-las, temos 3 métodos:

            // PLACEHOLDER
            Console.WriteLine("O usuário {0} tem {1} anos e seu gênero é {2}", nome, idade, genero);
            
            // INTERPOLAÇÃO
            Console.WriteLine($"O usuário {nome} tem {idade} anos e seu gênero é {genero}");
            
            // CONCATENAÇÃO
            Console.WriteLine("O usuário " + nome + " tem " + idade + " anos e seu gênero é " + genero);

        }
    }
}