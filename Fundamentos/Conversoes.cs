namespace CursoCSharp.Fundamentos
{
    public class Conversoes
    {
        public static void Executar(){
            int inteiro = 10;
            double quebrado = inteiro;
            System.Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int) nota; // conversão explicita (int)
            System.Console.WriteLine($"nota truncada {notaTruncada}");

            System.Console.WriteLine("Digite sua idade ");
            string idadeString = System.Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);

            System.Console.WriteLine($"Idade Inserida {idadeInteiro}");

            idadeInteiro = System.Convert.ToInt32(idadeString);
            System.Console.WriteLine($"Resultado {idadeInteiro}");

            System.Console.WriteLine("Digite o primeiro numero ");
            string palavra = System.Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            System.Console.WriteLine($"Resultado da conversão: {numero}");

            System.Console.WriteLine("Digite o segundo numero ");
            int.TryParse(System.Console.ReadLine(), out int numero2);
            System.Console.WriteLine($"Resultado da conversão Segundo Numero: {numero2}");

            




        }
    }
}