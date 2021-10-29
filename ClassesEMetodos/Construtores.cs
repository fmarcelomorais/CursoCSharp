namespace CursoCSharp.ClassesEMetodos
{

    class Carro
    {
        
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano){
            this.Modelo = modelo;
            this.Fabricante = fabricante;
            this.Ano = ano;
        }

        public string MostrarCarro(){
            return string.Format
            ($"Modelo: {this.Modelo} - Fabricante: {this.Fabricante} - Ano: {this.Ano}");
        }
        
        public void MostrarDadosConsole(){
            System.Console.WriteLine(this.MostrarCarro());
        }
    }

    public class Construtores
    {
        public static void Executar(){
            var carro1 = new Carro("Corsa Hatch", "Chevrollet", 2006);
            carro1.MostrarDadosConsole();
            var carro2 = new Carro("Corsa Max", "Chevrollet", 2015);
            carro2.MostrarDadosConsole();

        }
    }
}