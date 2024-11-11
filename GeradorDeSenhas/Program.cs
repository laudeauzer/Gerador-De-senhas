using System.Text;
namespace GeradorDeSenhas { 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de caracteres que você quer para a sua senha");
            int qtd = int.Parse(Console.ReadLine());
            string caracteresPossiveis = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%0123456789";


            Random sorteio = new Random();
            int numeroSorteado = 0;
            StringBuilder password = new StringBuilder();


            for (int t = 0; t < qtd; t++) {
                numeroSorteado = sorteio.Next(0, caracteresPossiveis.Length - 1);
                password.Append(caracteresPossiveis[numeroSorteado]);
            }


            Console.WriteLine("\n \n");           
            Console.Write(password);           
            Console.WriteLine("\n \n" );
            
        }
    }
}
