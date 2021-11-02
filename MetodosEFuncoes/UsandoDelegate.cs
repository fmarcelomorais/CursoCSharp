namespace CursoCSharp.MetodosEFuncoes
{
    public class UsandoDelegate
    {
        delegate double Soma(double a, double b);
        delegate void Imprimir(double a, double b);

        static double MinhaSoma(double x, double y){
            return x + y;
        }

        static void ImprimirSoma(double a, double b){
            System.Console.WriteLine(a + b);
        }
        
        public static void Executar(){
            Soma op1 = MinhaSoma;
            System.Console.WriteLine(op1(5,5));

            Imprimir op2 = ImprimirSoma;
            op2(5,5);
        }
    }
}