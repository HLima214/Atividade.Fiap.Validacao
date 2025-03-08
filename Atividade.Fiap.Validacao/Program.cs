using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Fiap.Validacao
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Digite seu e-mail: ");
                string email = Console.ReadLine();
                Console.Write("Digite sua senha: ");
                string senha = Console.ReadLine();

                if (email == "rm551528@fiap.com.br" && senha == "551528")
                {
                    Console.WriteLine("Acesso Válido");
                }
                else
                {
                    Environment.Exit(0);
                }

                Console.Write("Digite seu gênero (M/F): ");
                char genero = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                Console.Write("Digite seu tempo total de contribuição (em anos): ");
                if (!int.TryParse(Console.ReadLine(), out int tempodecontribuicao))
                {
                    Console.WriteLine("Valor inválido. Digite um número inteiro.");
                    return;
                }
                else
                {
                    Console.WriteLine("Valor válido");
                }

                if (tempodecontribuicao == 15)
                {
                    Console.WriteLine("Você pode se aposentar com 62 anos !");
                }
                else
                {
                    Console.WriteLine("Você ainda não pode se aposentar");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}