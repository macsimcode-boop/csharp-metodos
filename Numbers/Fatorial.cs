using System;

namespace MyApp
{
    internal class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Digite um fatorial");
            string input = Console.ReadLine();
            input = input.Replace("!", "");
            int numero = int.Parse(input);




            Console.WriteLine($"O Fatorial é igual a {Fatorial(numero)} ");
        }




            static int Fatorial(int numero)
            {

                 int resultado = 1;

                     for (int i = numero; i >= 1; i--)
                     {

                            resultado *= i;


                     }



               return resultado;
  
            
            }

        

    }   
}



