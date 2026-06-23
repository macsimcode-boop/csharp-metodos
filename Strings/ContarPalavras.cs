namespace CsharpMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um conjunto de palavras:");
            string texto = Console.ReadLine();
            Console.WriteLine($"Número de palavras: {ContarPalavras(texto)}");
        }

        static int ContarPalavras(string texto)
        {
            int palavras = 1;
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == ' ')
                    palavras++;
            }
            return palavras;
        }
    }
}
