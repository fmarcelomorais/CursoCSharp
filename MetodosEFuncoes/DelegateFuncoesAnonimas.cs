using System;
namespace CursoCSharp.MetodosEFuncoes
{
    public class DelegateFuncoesAnonimas
    {
        delegate string StringOperacao(string s);

        public static void Executar(){
            StringOperacao inverter = delegate (string s) {
                char[] charArray = s.ToCharArray(); 
                Array.Reverse(charArray);
                return new string(charArray);
            };  

            System.Console.WriteLine(inverter("Marcelo"));

        }
    }
}