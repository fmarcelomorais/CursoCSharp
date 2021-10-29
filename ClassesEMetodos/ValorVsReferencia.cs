namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente{
        public string Nome;
        public int Idade;
    }
    public class ValorVsReferencia
    {
        public static void Executar(){
            int numero = 3;
            int copiaNumero = numero;

            System.Console.WriteLine($"{numero} - {copiaNumero}");
            numero++;
            System.Console.WriteLine($"{numero} - {copiaNumero}");

            Dependente dep = new Dependente{ 
                Nome = "Beto",
                Idade = 44
            };

            Dependente copiaDep = dep;
            System.Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            System.Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            copiaDep.Nome = "Renato";
            dep.Idade = 34;
            System.Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            System.Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");
    }
        }
}