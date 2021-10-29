using System;
namespace CursoCSharp.EstruturaDeControle
{
    public class EstruturaIfElse
    {
        public static void Executar(){
            double nota = 0;
            //string aprovado;
            System.Console.WriteLine("Difgite a nota ");
                     
            
            if(nota >= 7.0){
                System.Console.WriteLine("Aprovadpo!");
            }else{
                System.Console.WriteLine("Reprovado!");
            }

            //aprovado = nota >= 7 ? System.Console.WriteLine("Aprovado") : System.Console.WriteLine("Reprovado");

        }
    }
}