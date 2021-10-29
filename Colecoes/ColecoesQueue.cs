using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{
    public class ColecoesQueue
    {
        public static void Executar(){
            var fila = new Queue<string>();

            fila.Enqueue("Maria");
            fila.Enqueue("Marcelo");
            fila.Enqueue("Elisa");

            System.Console.WriteLine(fila.Peek());
            System.Console.WriteLine(fila.Count);

            System.Console.WriteLine(fila.Dequeue());
            System.Console.WriteLine(fila.Count);

            foreach(var pessoa in fila){
                System.Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.5);

            System.Console.WriteLine(salada.Contains("Item"));


        }
    }
}