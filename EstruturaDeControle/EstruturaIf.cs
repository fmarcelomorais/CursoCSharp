using System;
namespace CursoCSharp.EstruturaDeControle
{
    public class EstruturaIf
    {
        public static void Executar(){
            bool bomComportamento = false;
            string entrada;

            System.Console.Write("Digite a nota do Aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            System.Console.WriteLine("Possui Bom Comportamento (S//N): ");
            entrada = Console.ReadLine();
            //if( entrada == "S" || entrada == "s")
            //bomComportamento = entrada == "S" || entrada == "s";
            bomComportamento  = entrada.ToLower() == "s";
           
           if( nota >= 9.0 && bomComportamento) {
               System.Console.WriteLine("Quandro de Honra!");
           }

        }
    }
}