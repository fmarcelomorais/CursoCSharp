namespace CursoCSharp.ClassesEMetodos
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public string MostrarDados(){
            return string.Format($"Bom dia {this.Nome}, Você tem {this.Idade} anos.");
        }

        public void MostrarNoConsole(){
            System.Console.WriteLine(MostrarDados());
        }
    }
}