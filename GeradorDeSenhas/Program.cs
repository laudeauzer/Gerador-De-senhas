using System;
using System.Text;
using System.Linq;

namespace GeradorDeSenhas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de caracteres que você quer para a sua senha:");
            int qtd = int.Parse(Console.ReadLine());

            string letrasMinusculas = "abcdefghijklmnopqrstuvwxyz";
            string letrasMaiusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string simbolos = "!@#$%";
            string numeros = "0123456789";

            Random sorteio = new Random();
            StringBuilder password = new StringBuilder();

            // Garantir 2 números
            for (int i = 0; i < 2; i++)
            {
                password.Append(numeros[sorteio.Next(0, numeros.Length)]);
            }

            // Calcular quantidades restantes para maiúsculas, minúsculas e símbolos
            int qtdMaiusculas = qtd / 4; // Definindo um quarto como maiúsculas
            int qtdSimbolos = qtd / 6; // Definindo um sexto como símbolos
            int qtdMinusculas = qtd - qtdMaiusculas - qtdSimbolos - 2; // Resto em minúsculas, excluindo números

            // Adicionar letras maiúsculas
            for (int i = 0; i < qtdMaiusculas; i++)
            {
                password.Append(letrasMaiusculas[sorteio.Next(0, letrasMaiusculas.Length)]);
            }

            // Adicionar letras minúsculas
            for (int i = 0; i < qtdMinusculas; i++)
            {
                password.Append(letrasMinusculas[sorteio.Next(0, letrasMinusculas.Length)]);
            }

            // Adicionar símbolos
            for (int i = 0; i < qtdSimbolos; i++)
            {
                password.Append(simbolos[sorteio.Next(0, simbolos.Length)]);
            }

            // Embaralhar os caracteres para uma ordem aleatória
            var senhaArray = password.ToString().ToCharArray();
            senhaArray = senhaArray.OrderBy(x => sorteio.Next()).ToArray();
            string senhaFinal = new string(senhaArray);

            Console.WriteLine("\nSenha gerada:\n");
            Console.WriteLine(senhaFinal);
            Console.WriteLine("\n");
        }
    }
}
