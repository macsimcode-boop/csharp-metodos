namespace CsharpMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma palavra:");
            string texto = Console.ReadLine();
            Console.WriteLine("Quantas vezes deseja repetir?");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Repetir(texto, numero)}");
        }

        static string Repetir(string texto, int numero)
        {
            string repetido = "";
            for (int i = 0; i < numero; i++)
                repetido += texto;
            return repetido;
        }
    }
}
