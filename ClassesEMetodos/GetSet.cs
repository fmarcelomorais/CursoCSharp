using System;
namespace CursoCSharp.ClassesEMetodos
{
    public class Moto {
        private string Marca;
        private string Modelo;
        private uint Cilindradas;

        public Moto(string marca, string modelo, uint cilindradas){
            //this.Marca = marca;
           // this.Modelo = modelo;
           // this.Cilindradas = Cilindradas;

           SetMarca(marca);
           SetModelo(modelo);
           SetCilindradas(cilindradas);
        }

        public Moto(){ }

        public string GetMarca(){
            return this.Marca;
        }
        public void SetMarca(string marca){
            this.Marca = marca;
        }

        public string GetModelo(){
            return this.Modelo;
        }
        public void SetModelo(string modelo){
            this.Modelo = modelo;
        }
        public uint GetCilindradas(){
            return this.Cilindradas;
        }
        public void SetCilindradas(uint cilindradas){
            // 1 opção
            /*if(cilindradas <= 0){
                this.Cilindradas = 50;
            }else{
                this.Cilindradas = cilindradas;
            }*/
            // 2 opcao
            //this.Cilindradas = Math.Abs(cilindradas);

            this.Cilindradas = cilindradas;
        }
        
    }
    public class GetSet
    {
        public static void Executar(){
            var moto1 = new Moto("Honda", "CB300R", 300);

            System.Console.WriteLine
            ($"Marca: {moto1.GetMarca()} | Modelo: {moto1.GetModelo()} | Clilindradas: {moto1.GetCilindradas()}cc.");
        
            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("Bros-160");
            moto2.SetCilindradas(160);
        
            System.Console.WriteLine
            ($"Marca: {moto2.GetMarca()} | Modelo: {moto2.GetModelo()} | Clilindradas: {moto2.GetCilindradas()}cc.");
        
            var moto3 = new Moto("Yamaha", "Fazer", 250);

            System.Console.WriteLine
            ($"Marca: {moto3.GetMarca()} | Modelo: {moto3.GetModelo()} | Clilindradas: {moto3.GetCilindradas()}cc.");
        
        }
    }
}