using System;
namespace CursoCSharp.EstruturaDeControle
{
    public class EstruturaDoWhile
    {
        public static void Executar(){
            string entrada;

            do{
                System.Console.WriteLine("Qual o seu nome?");
                entrada = Console.ReadLine();

                System.Console.WriteLine($"Seja bem Vindo {entrada}");
                System.Console.WriteLine("Deseja continuar? (S/N)");
                entrada = Console.ReadLine();
                
            } while(entrada.ToLower() == "s");
        }
    }
}