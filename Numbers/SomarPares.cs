using System;

namespace MyApp
{
    internal class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Quantos numeros deseja mandar?");
            int quantidade = int.Parse(Console.ReadLine());

            int[] array = new int[quantidade];
            
            
            for (int i = 0; i < array.Length; i++) 
            { 
               
                Console.WriteLine($"Digite o {i + 1}º numero");
                array[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine($"A soma dos numeros é {ContarPares(array)}");
        
        }

            static int ContarPares(int[] array)
            {

               int Pares = 0;
               
               for(int i = 0; i < array.Length; i++)
               {

                if (array[i] % 2 == 0) 
                {
                    Pares += array[i];
                }

               }

              return Pares;

            }
    }   
}



