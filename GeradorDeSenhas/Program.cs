using System.Text;
namespace GeradorDeSenhas { 
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = int.Parse(args[0]);
            string caracteresPossiveis = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%0123456789";


            Random sorteio = new Random();
            int numeroSorteado = 0;
            StringBuilder password = new StringBuilder();


            for (int t = 0; t < qtd; t++) {
                numeroSorteado = sorteio.Next(0, caracteresPossiveis.Length - 1);
                password.Append(caracteresPossiveis[numeroSorteado]);
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.Write(password);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
