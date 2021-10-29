using System;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    public class ColecoesStack
    {
        public static void Executar(){
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("A");
            pilha.Push(true);
            pilha.Push(4.6);

            foreach(var item in pilha){
                System.Console.Write($"{item} ");
            }

            System.Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach(var item in pilha){
                System.Console.Write($"{item} ");
            }

            System.Console.WriteLine($"\nPeek: {pilha.Peek()}");

            foreach(var item in pilha){
                System.Console.Write($"{item} ");
            }

        }
    }
}