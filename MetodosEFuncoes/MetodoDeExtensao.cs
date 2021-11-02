namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExtensoesInteiro{
        public static int Soma(this int num, int outroNumero){
            return num + outroNumero;
        }

        public static int Subtrair(this int num, int outroNumero){
            return num - outroNumero;
        }
    }
    public class MetodoDeExtensao
    {
        public static void Executar(){
            int numero = 5;

            System.Console.WriteLine(numero.Soma(3));
            System.Console.WriteLine(numero.Subtrair(10));
        }
    }
}