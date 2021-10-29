using System;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional{
        double desconto = 0.1;
        string nome;
        public string Nome {
            get{
                return "Opcional " + nome;
            }
            set {
                nome = value;
            }
        }

        //Propriedades AutoImplementadas
        public double Preco{ get; set; }

        // Propriedade Somente Leitura
        public double PrecoComDesconto{
            get => Preco - (desconto * Preco); // Lambda
        }

        public CarroOpcional(){}

        public CarroOpcional(string nome, double preco){
            Nome = nome;
            Preco = preco;
        }
    }
    public class Props
    {
        public static void Executar(){
            var opc1 = new CarroOpcional("Ar Condicionado", 3499.9);
            System.Console.WriteLine(opc1.PrecoComDesconto);

            var opc2 = new CarroOpcional(){
                Nome = "Direção Hidraulica",
                Preco = 2349.9
            };
            System.Console.WriteLine(opc2.PrecoComDesconto);
        }
    }
}