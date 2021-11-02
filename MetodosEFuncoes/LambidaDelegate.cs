namespace CursoCSharp.MetodosEFuncoes{

    delegate double Operacao( double x, double y);

    public class LambidaDelegate
    {
        public static void Executar(){
            Operacao somar = (x, y) => x + y;
            Operacao multiplicar = (x, y) => x * y;
            Operacao dividir = (x, y) => x / y;

            System.Console.WriteLine(somar(10, 5));
            System.Console.WriteLine(multiplicar(10, 5));
            System.Console.WriteLine(dividir(10, 5));

        }
    }
}