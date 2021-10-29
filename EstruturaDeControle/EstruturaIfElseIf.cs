using System;
namespace CursoCSharp.EstruturaDeControle
{
    public class EstruturaIfElseIf
    {
        public static void Executar(){
            System.Console.WriteLine("Digite a nota do Aluno: ");
            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);
            
            if(nota >= 9.0){
                System.Console.WriteLine("Quadro de Honra");
            } else if(nota <= 7.0 ){
                System.Console.WriteLine("Aluno na Media");
            }else{
                System.Console.WriteLine("Aluno Reprovado");
            }

        }
    }
}