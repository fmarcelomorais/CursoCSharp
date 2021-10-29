using System;
namespace CursoCSharp.ClassesEMetodos
{

    public class Cliente{
        public string Nome;
        readonly DateTime Nascimento; // somente leitura

        public Cliente(string nome, DateTime nascimento){
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento(){
            return string.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }

    public class ReadOnly
    {
        public static void Executar(){
            var novoCliente = new Cliente("Marcelo", new DateTime(1987, 9, 4));
            System.Console.WriteLine(novoCliente.Nome);
            System.Console.WriteLine(novoCliente.GetDataDeNascimento());
        }
    }
}