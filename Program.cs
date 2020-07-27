using System;

namespace Agenda {

	public class Program {
		private static void Main(string[] args) {
			var agenda = new Agenda();
			var loop = 1;
			while (loop != 0) {
				menu();
				loop = validaEntrada(0, 4);
				switch (loop) {
					case 0:
						Environment.Exit(1);
						break;
					case 1:
						var repeteDias = 0;
						var vezes = 0;
						Console.WriteLine("Digite o nome do compromisso");
						string nome = Console.ReadLine();
						Console.WriteLine("Digite a data Ex:21/10/2017");
						string data = Console.ReadLine();
						Console.WriteLine("O compromisso se repete?");
						Console.WriteLine("0 - Não");
						Console.WriteLine("1 - Sim");
						var repete = validaEntrada(0, 1);
						if (repete == 1) {
							repeteDias = readInt("De quanto em quantos dias?");
							vezes = readInt("Quantas vezes o compromisso se repetirá?");
							agenda.adicionaCompromisso(nome, data, repeteDias, vezes);
						}
						else {
							agenda.adicionaCompromisso(nome, data);
						}

						break;
					case 2:
						Console.Write(agenda.listarCompromissos());
						break;
					case 3:
						Console.WriteLine("Digite o nome do compromisso a ser buscado");
						Console.Write(agenda.buscar(Console.ReadLine()));
						break;
					case 4:
						Console.WriteLine("Há {0} compromissos registrados.",agenda.getQntCompromissos());
						break;
					default:
						Console.WriteLine("Opção inválida");
						break;
				}

				Console.WriteLine("Digite algo para prosseguir");
				loop = Console.ReadKey().KeyChar;
			}
		}

		public static void menu() {
			Console.Clear();
			Console.WriteLine("Agenda");
			Console.WriteLine("0 - Sair");
			Console.WriteLine("1 - Adiciona Compromisso");
			Console.WriteLine("2 - Exibir compromissos");
			Console.WriteLine("3 - Buscar compromisso por nome");
			Console.WriteLine("4 - Quantidade de compromissos");
			Console.WriteLine("Digite a opção desejada");
		}

		public static int readInt(string textoSaida) {
			Console.WriteLine(textoSaida);
			string operacao;
			var numero = 0;
			try {
				operacao = Console.ReadLine();
				numero = int.Parse(operacao);
				if (numero < 0) throw new Exception();
			}
			catch (Exception e) {
				Console.WriteLine("Entrada inválida, digite novamente:");
				numero = readInt(textoSaida);
			}

			return numero;
		}

		public static int validaEntrada(int menor, int maior) {
			string operacao;
			var numOperador = 0;
			try {
				operacao = Console.ReadLine();
				numOperador = int.Parse(operacao);
				if (numOperador < menor || numOperador > maior) throw new Exception();
			}
			catch (Exception e) {
				Console.WriteLine("Entrada inválida, digite novamente:");
				numOperador = validaEntrada(menor, maior);
			}

			return numOperador;
		}
	}

}