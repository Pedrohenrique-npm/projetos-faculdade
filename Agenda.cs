using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using POO;

namespace Agenda {

	public class Agenda {
		private List<Compromisso> compromissos;

		public Agenda() {
			compromissos = new List<Compromisso>();
		}

		/// <summary>
		/// Adiciona um novo compromisso
		/// </summary>
		/// <param name="nome">Nome do compromisso</param>
		/// <param name="data">Data do compromisso</param>
		/// <param name="repeticaoDias">De quanto em quanto tempo o compromisso repetirá</param>
		/// <param name="vezes">Quantidade de vezes que repetirá</param>
		public void adicionaCompromisso(string nome, string data, int repeticaoDias, int vezes) {
			Compromisso compromisso = new Compromisso(nome, data);
			int[] datas = compromisso.getIntData(data);
			compromissos.Add(compromisso);
			for (int i = 1; i <= vezes; i++) {
				Data dataRepeticao = new Data(datas[0], datas[1], datas[2]);
				dataRepeticao.acrescentaDias(i * repeticaoDias);
				adicionaCompromisso(nome, dataRepeticao);
			}
		}

		/// <summary>
		/// Adiciona um compromisso
		/// </summary>
		/// <param name="nome">Nome do compromisso</param>
		/// <param name="data">Data do compromisso</param>
		public void adicionaCompromisso(string nome, string data) {
			var compromisso = new Compromisso(nome, data);
			compromissos.Add(compromisso);
		}

		public void adicionaCompromisso(string nome, Data data) {
			compromissos.Add(new Compromisso(nome, data));
		}

		/// <summary>
		/// Busca um compromisso pelo nome
		/// </summary>
		/// <param name="nome">Nome a ser buscado</param>
		/// <returns>Compromissos que contêm o nome</returns>
		public string buscar(string nome) {
			StringBuilder aux = new StringBuilder();
			foreach (Compromisso c in compromissos) {
				if (c.getNome().Contains(nome)) aux.AppendLine(c.ToString());
			}

			return aux.ToString();
		}

		/// <summary>
		/// Lista todos compromissos
		/// </summary>
		/// <returns>Todos compromissos registrados</returns>
		public string listarCompromissos() {
			StringBuilder aux = new StringBuilder();
			foreach (Compromisso compromisso in compromissos) {
				aux.AppendLine(compromisso.ToString());
			}

			return aux.ToString();
		}

		public int getQntCompromissos() {
			return compromissos.Count;
		}
	}

}