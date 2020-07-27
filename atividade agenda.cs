using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Atividade02_PF
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta = "y";
            while (resposta.ToLower() == "y")
            {
                Console.Clear();
                int numeroVezes = 0;
                DateTime inicioPeriodo = DateTime.MaxValue;
                DateTime fimPeriodo = DateTime.MinValue;
                Decimal menorValor = Decimal.MaxValue;
                Decimal maiorValor = Decimal.MinValue;
                Decimal TotalRecebido = 0;

                StreamReader file = new StreamReader(@"C:\Temp\DadosPF.txt");

                Console.WriteLine("Digite o nome procurado:");
                var nomeProcurado = Console.ReadLine();

                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] dados = line.Split(';');
                    string idPessoa = dados[0];
                    string nomePessoa = dados[1];
                    string dataPessoa = dados[2];
                    string valorPessoa = dados[3];

                    if (nomeProcurado == nomePessoa)
                    {
                        Console.WriteLine(line);
                        numeroVezes++;

                        if (inicioPeriodo > Convert.ToDateTime(dataPessoa))
                        {
                            inicioPeriodo = Convert.ToDateTime(dataPessoa);
                        }
                        if (fimPeriodo < Convert.ToDateTime(dataPessoa))
                        {
                            fimPeriodo = Convert.ToDateTime(dataPessoa);
                        }

                        if (menorValor > Convert.ToDecimal(valorPessoa))
                        {
                            menorValor = Convert.ToDecimal(valorPessoa);
                        }
                        if (maiorValor < Convert.ToDecimal(valorPessoa))
                        {
                            maiorValor = Convert.ToDecimal(valorPessoa);
                        }

                        TotalRecebido += Convert.ToDecimal(valorPessoa);
                    }

                }
                file.Close();
                Console.WriteLine("");
                Console.WriteLine("Numero de vezes = " + numeroVezes);
                Console.WriteLine("Inicio do periodo = " + inicioPeriodo);
                Console.WriteLine("Fim do periodo = " + fimPeriodo);
                Console.WriteLine("Menor valor = " + menorValor.ToString("N2"));
                Console.WriteLine("Maior valor = " + maiorValor.ToString("N2"));
                Console.WriteLine("Total Recebido = " + TotalRecebido.ToString("N2"));
                Console.WriteLine("");
                Console.WriteLine("Deseja procurar outro nome?(sim - y/nao - n)");
                var respostaFinal = Console.ReadLine();
                while (respostaFinal.ToLower() != "y" && respostaFinal.ToLower() != "n")
                {
                    Console.WriteLine("Deseja procurar outro nome?(sim - y/nao - n)");
                    respostaFinal = Console.ReadLine();
                }
                resposta = respostaFinal;
            }
            Console.WriteLine("Tiau");
            Console.ReadKey();
        }
    }
}
