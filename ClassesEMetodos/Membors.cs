using System;

namespace CursoCSharp.ClassesEMetodos
{
    public class Membors
    {
        public static void Executar(){
            Pessoa p1 = new Pessoa();
            p1.Nome = "Marcelo";
            p1.Idade = 34;

           p1.MostrarNoConsole();

           var p2 = new Pessoa();
            p2.Nome = "Maria";
            p2.Idade = 35;

            string ApresentacoMaiuscula = p2.MostrarDados();
            System.Console.WriteLine(ApresentacoMaiuscula.ToUpper());
            p2.MostrarNoConsole();
            
        }
    }
}