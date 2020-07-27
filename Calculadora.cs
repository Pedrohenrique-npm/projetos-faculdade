using System;

namespace Calc2019
{

    public class Calculadora
    {
        public double resultado;
        private double primeiroNumero, segundoNumero;
        private readonly string[] operacoes = { "+", "-", "*", "/", "^" };
        private bool EhValido(string tentativa)
        {
            bool elementoExiste = Array.Exists(operacoes, element => element.Contains(tentativa));
            bool naoVazio = (!String.IsNullOrEmpty(tentativa));
            return (elementoExiste && naoVazio);
        }

        private string validaOperador(string textoSaida)
        {
            Console.Write(textoSaida);
            string operacao = Console.ReadLine();
            while (!EhValido(operacao))
            {
                Console.WriteLine("Entrada inválida");
                Console.Write(textoSaida);
                operacao = Console.ReadLine();
            }
            return operacao;
        }
        public void LerNumeros(double valor1, double valor2)
        {
            this.primeiroNumero = valor1;
            this.segundoNumero = valor2;
        }
        public void RealizaOperacao()
        {
            string operador = validaOperador("Entre com a operação + (adição), - (subtração), * (multipicação), / (divisão), ^ (expoente) :");
            switch (operador)
            {
                case "+":
                case "adição":
                    resultado = this.primeiroNumero + this.segundoNumero;
                    break;
                case "-":
                case "subtração":
                    resultado = this.primeiroNumero - this.segundoNumero;
                    break;
                case "*":
                case "multipicação":
                    resultado = this.primeiroNumero * this.segundoNumero;
                    break;
                case "/":
                case "divisão":
                    resultado = this.primeiroNumero / this.segundoNumero;
                    break;
                case "^":
                case "expoente":
                    resultado = Math.Pow(this.primeiroNumero, this.segundoNumero);
                    break;
                default:
                    resultado = 0;
                    break;
            }

            Console.WriteLine("Resultado: {0} {1} {2} = {3}", this.primeiroNumero, operador, this.segundoNumero, resultado);

        }

    }
}