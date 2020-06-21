using System;

namespace Negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva um número: ");
            decimal numero=Convert.ToDecimal(Console.ReadLine());

            Console.Clear();
            
            if(numero>=0)
            Console.WriteLine("Você digitou um número positivo");
            else
            Console.WriteLine("Você digitou um número negativo");
            
            
        }
    }
}
