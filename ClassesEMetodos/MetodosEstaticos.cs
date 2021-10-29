namespace CursoCSharp.ClassesEMetodos
{

    public class CalculadoraEstatica{

        public static int Multiplicar( int a, int b){
            return a * b;
        }
        public int Somar(int a, int b){
            return a + b;
        }
    }

    public class MetodosEstaticos
    {
        public static void Executar(){
            var resultado = CalculadoraEstatica.Multiplicar(2,2);
            System.Console.WriteLine("Resultado {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            System.Console.WriteLine(calc.Somar(10, 5));
        }
    }
}