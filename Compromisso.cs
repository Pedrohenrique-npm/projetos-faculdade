using System.Globalization;
using System.Text;
using POO;

namespace Agenda {

	/// <summary>
	/// Compromisso
	/// </summary>
	public class Compromisso {
		private Data _data;
		private readonly string _nome;

		public Compromisso(string nome, Data data) {
			_nome = nome;
			_data = data;
		}

		public Compromisso(string nome, string data) {
			_nome = nome;
			int[] datas = getIntData(data);
			init(datas[0], datas[1], datas[2]);
		}

		public int[] getIntData(string data) {
			int[] datas = new int[3];
			for (int i = 0; i < datas.Length; i++) {
				datas[i] = int.Parse(data.Split("/")[i]);
			}

			return datas;
		}

		private void init(int d, int m, int y) {
			_data = new Data(d, m, y);
		}

		public string getNome() {
			return _nome;
		}

		public string getDataString() {
			return _data.ToString();
		}

		public override string ToString() {
			return "Compromisso: " + getNome() + ". Marcado para: " + getDataString();
		}
	}

}