using System;
namespace CursoCSharp.Excessoes
{
    public class Conta {
        double Saldo;

        public Conta(double saldo){
            Saldo = saldo;
        }

        public void Sacar(double valor){
            if( valor > Saldo){
                throw new ArgumentException("Saldo Insuficiente");
            }
            Saldo -= valor;
        }
    }
    public class PrimeiraExcessao
    {
        public static void Executar(){
            var conta = new Conta(1_230.52);

            try {
                conta.Sacar(1600);
                System.Console.WriteLine("Retirada com Sucesso");
            } catch (ArgumentException ex) {
                System.Console.WriteLine(ex.Message);
            } finally{
                System.Console.WriteLine("Obrigado");
            }
        }
    }
}