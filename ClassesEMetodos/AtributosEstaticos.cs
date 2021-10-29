namespace CursoCSharp.ClassesEMetodos
{
    public class Produto{
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;


        public Produto(string nome, double preco, double desconto){
            this.Nome = nome;
            this.Preco = preco;
            Desconto = desconto;


        }

        public Produto(){ }

        public double CalculaDesconto(){
            return this.Preco - this.Preco * Desconto;
        }
        

    }
    public class AtributosEstaticos
    {
        public static void Executar(){
            var produto1 = new Produto("Caneta", 3.2, 0.1);
            var produto2 = new Produto(){
                Nome = "Borracha",
                Preco = 5.3,
                //Desconto = 0.1
            };

            Produto.Desconto = 0.5;
            System.Console.WriteLine("Preco com Desconto R${0}", produto1.CalculaDesconto());
            System.Console.WriteLine($"Preco com Desconto R${produto2.CalculaDesconto()}");
            Produto.Desconto = 0.2;
            System.Console.WriteLine("Preco com Desconto R${0}", produto1.CalculaDesconto());
            System.Console.WriteLine($"Preco com Desconto R${produto2.CalculaDesconto()}");
        }
    }
}