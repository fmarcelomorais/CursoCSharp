using System;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    public class ColecoesArrayList
    {
        public static void Executar(){
            var arrayList = new ArrayList{
                "palavra",
                3,
                true                
            };

            arrayList.Add(4.5);

            foreach(var item in arrayList){
                System.Console.WriteLine("{0} => {1}", item, item.GetType());
            }

        }
    }

}
