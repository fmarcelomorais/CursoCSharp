using System;
namespace CursoCSharp.EstruturaDeControle
{
    public class UsandoBreack
    {
        public static void Executar(){
            Random random = new Random();

            int numero = random.Next(1,51);

            System.Console.WriteLine($"O numero que queremos é {numero}.");

            for(int i = 1; i <= 50; i++){
                System.Console.Write($"{i} é o numeor que queremos?");
                if(i == numero){
                    System.Console.WriteLine("Sim");
                    break;
                }else{ 
                    System.Console.WriteLine("Não");
                }
            }
            
            System.Console.WriteLine("Fim");
        }
    }
}