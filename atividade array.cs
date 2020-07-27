using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01_Array
{
    class Program
    {
        static string VerificarSequencia(int[] vetor1)
        {
            Console.WriteLine("Digite o valor:");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 0; i < vetor1.Length; i++)
            {
                if (valor < vetor1[i])
                {
                    string retorno = "Esse valor digitado ficaria na posição " + i + " do Array";
                    return retorno;
                }
                else if (valor == vetor1[i])
                {
                    string retorno = "Esse valor fica na posição " + i + " do Array";
                    return retorno;
                }

            }
            string retornoDefault = "Esse valor digitado ficaria na posição " + vetor1.Length + " do Array";
            return retornoDefault;
        }

        static bool isMonotonic(int[] vetor)
        {
            if (vetor.Length == 1 && vetor.Length == 2)
            {
                return true;
            }
            for (int i = 0; i < (vetor.Length - 2); i++)
            {
                int valorA = vetor[i] - vetor[i + 1];
                int valorB = vetor[i + 1] - vetor[i + 2];

                if (Math.Abs(valorA) != Math.Abs(valorB) && valorA != 0 && valorB != 0)
                {
                    return false;
                }

            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Digite o número de posições");
            int n = int.Parse(Console.ReadLine());

            int[] vetor1 = new int[n];

            Console.WriteLine($"Array de {n} posições");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o valor de posição " + i + " do array");
                vetor1[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();

            int opcao = 0;
            while (opcao != 3)
            {
                Console.WriteLine($@"Array digitado [" + String.Join(",", vetor1) + "]");

                Console.WriteLine("Selecione:");
                Console.WriteLine("1- Verificar um valor na sequencia do array;");
                Console.WriteLine("2- Verificar se o array é 'monotonic';");
                Console.WriteLine("3- Sair do Programa.");
                opcao = int.Parse(Console.ReadLine());


                if (opcao == 1)
                {
                    string texto = VerificarSequencia(vetor1);
                    Console.WriteLine(texto);
                    Console.WriteLine("Aperte um botao para voltar para o menu");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opcao == 2)
                {
                    bool resultado = isMonotonic(vetor1);
                    if (resultado)
                    {
                        Console.WriteLine("O Array é monotonic");
                    }
                    else
                    {
                        Console.WriteLine("O Array não é monotonic");
                    }

                    Console.WriteLine("Aperte um botao para voltar para o menu");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Até mais...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("opção não identificada.");
                }

            }


        }


    }
}
