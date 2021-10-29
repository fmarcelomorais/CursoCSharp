using System;
namespace CursoCSharp.EstruturaDeControle
{
    public class EstruturaSwitch
    {
        public static void Executar(){
            System.Console.WriteLine("Avalie o atendimento com nota de 1 a 5");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota) {
                case 0: 
                    System.Console.WriteLine("Pessimo :(");
                    break;
                case 1:
                case 2:
                    System.Console.WriteLine("Ruim :/");   
                    break;
                case 3: 
                    System.Console.WriteLine("Boa :|");
                    break;
                case 4:
                    System.Console.WriteLine("Otima :)");
                    break;
                case 5:
                    System.Console.WriteLine("Excelente! :D");
                    break;
            }
            System.Console.WriteLine("Fim!");
        }
    }
}