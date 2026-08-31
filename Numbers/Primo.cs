namespace MyApp
{
    internal class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Digite um numero");
            int numero = int.Parse(Console.ReadLine());
            

            Console.WriteLine($"O numero é primo: {Primo(numero)} ");
        }




            static bool Primo(int numero)
            {
               for (int i = 2; i < numero; i++)

               {
                   
                 if(numero % i  == 0)
                 {

                    return false;
                 }
                 



               }

               return true;
  
            
            }

        

    }   
}
