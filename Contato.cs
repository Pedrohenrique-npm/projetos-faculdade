using System;
using System.Globalization;
using POO;

namespace Agenda
{
    public class Contato
    {
        protected Data dataNascimento;

        protected string nome;

        public Contato(string nome, Calendar dataNascimento)
        {
            setNome(nome);
            this.dataNascimento
        }

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public virtual string getDados()
        {
            return getNome() + "Nascido em " + dataNascimento.GetDayOfMonth + "/"
                   + dataNascimento.GetMonth + "/" + dataNascimento.GetYear + "\nIdade: " +
                   (dataNascimento - DateTime.Now);
        }
    }
}