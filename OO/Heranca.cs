namespace CursoCSharp.OO
{

    public class Carro{
        protected readonly int VelociadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima){
            VelociadeMaxima = velocidadeMaxima;
        }

        //public Carro(){}

        protected int AlterarVelocidade(int delta){
            int novaVelocidade = VelocidadeAtual + delta;
            if(novaVelocidade < 0){
                VelocidadeAtual = 0;
            }else if( novaVelocidade > VelociadeMaxima){
                VelocidadeAtual = VelociadeMaxima;
            }else{
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }

        public virtual int Acelerar(){ //virtual -> pode ser sobescrito <- override
            return AlterarVelocidade(5);
        }

        public int Frear(){
            return AlterarVelocidade(-5);
        }
    }

    public class Uno: Carro{
        public Uno() : base(200){

        }
    } 

    public class Ferrari: Carro{
        public Ferrari(): base(350){

        }

        public override int Acelerar(){
            return AlterarVelocidade(15);
        }

        // Oculta o metodo da classe pai

        public new int Frear(){  
            return AlterarVelocidade(-15);
        }
    }
    public class Heranca
    {
        public static void Executar(){
            System.Console.WriteLine("Uno...");
            Uno carro1 = new Uno();

            System.Console.WriteLine(carro1.Acelerar());
            System.Console.WriteLine(carro1.Acelerar());
            System.Console.WriteLine(carro1.Frear());
            System.Console.WriteLine(carro1.Frear());
            System.Console.WriteLine(carro1.Frear());

            System.Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();

            System.Console.WriteLine(carro2.Acelerar());
            System.Console.WriteLine(carro2.Acelerar());
            System.Console.WriteLine(carro2.Acelerar());
            System.Console.WriteLine(carro2.Acelerar());

            System.Console.WriteLine(carro2.Frear());
            System.Console.WriteLine(carro2.Frear());
            System.Console.WriteLine(carro2.Frear());

            System.Console.WriteLine("Ferrari do tipo Carro...");
            Carro carro3 = new Ferrari(); 
            System.Console.WriteLine(carro3.Acelerar());
            System.Console.WriteLine(carro3.Acelerar());
            System.Console.WriteLine(carro3.Frear());
            System.Console.WriteLine(carro3.Frear());
            System.Console.WriteLine(carro3.Frear());

            System.Console.WriteLine("Uno do tipo Carro...");
            carro3 = new Uno(); // Polimorfismo
            System.Console.WriteLine(carro3.Acelerar());
            System.Console.WriteLine(carro3.Acelerar());
            System.Console.WriteLine(carro3.Frear());
            System.Console.WriteLine(carro3.Frear());
            System.Console.WriteLine(carro3.Frear());
        }
    }
}