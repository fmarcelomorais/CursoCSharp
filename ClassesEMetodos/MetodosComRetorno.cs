namespace CursoCSharp.ClassesEMetodos
{

    class CalculadoraComum
    {
        public int Somar(int a, int b){
            return a + b;
        }
        public int Subtrair(int a, int b){
            return a - b;
        }

        public int Multiplicar(int a, int b){
            return a * b;
        }
        public double Dividir(int a, int b){
            return a / b;
        }

    }

    class CalculadoraCadeia{
        int memoria;

        public CalculadoraCadeia Somar(int a){
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Subtrair(int a){
            memoria -= a;
            return this;
        }
        public CalculadoraCadeia Multiplicar(int a){
            memoria *= a;
            return this;
        }
        public CalculadoraCadeia Dividir(int a){
            memoria /= a;
            return this;
        }
        public CalculadoraCadeia Limpar(){
            memoria = 0;
            return this;
        }
        public CalculadoraCadeia Imprimir(){
            System.Console.WriteLine(memoria);
            return this;
        }
        public int Resultado(){
            return memoria;
        }

    }


    public class MetodosComRetorno
    {
        public static void Executar(){
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(2,3);
            System.Console.WriteLine($"Resultado: {resultado}");
            
            System.Console.WriteLine(calculadoraComum.Subtrair(10,5));
            System.Console.WriteLine(calculadoraComum.Multiplicar(10,5));
            System.Console.WriteLine(calculadoraComum.Dividir(10,5));

            System.Console.WriteLine("--------------------------------");

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(30).Multiplicar(2).Dividir(10)
                .Imprimir().Limpar().Imprimir();    

            resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
            System.Console.WriteLine(resultado);

        }
    }
}