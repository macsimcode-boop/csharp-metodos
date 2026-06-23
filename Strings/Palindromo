namespace CsharpMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma palavra:");
            string texto = Console.ReadLine();
            Console.WriteLine($"A palavra é um palíndromo: {Palindromo(texto)}");
        }

        static bool Palindromo(string texto)
        {
            string repetido = "";
            for (int i = texto.Length - 1; i >= 0; i--)
                repetido += texto[i];
            return texto == repetido;
        }
    }
}
