using System;

namespace Calc2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            double primeiroNumero = LerNumero("Escolha o primeiro número: ");

            double segundoNumero = LerNumero("Escolha o segundo número: ");
            calc.LerNumeros(primeiroNumero, segundoNumero);
            calc.RealizaOperacao();
            // PENDENTE
            //
            // ENTRAR COM PRIMEIRO NÚMERO, VALIDAR A ENTRADA, EM SEGUIDA VALIDAR O SEGUNDO
            // PARA OPERAÇÕES QUE NÃO PRECISAM DO SEGUNDO 

        }
        private static double LerNumero(string textoRecebido)
        {
            double parse;
            Console.Write(textoRecebido);
            string numero = Console.ReadLine();
            while (!double.TryParse(numero, out parse))
            {
                Console.WriteLine("Entrada inválida");
                Console.Write(textoRecebido);
                numero = Console.ReadLine();
            }
            return double.Parse(numero);
        }
    }
}
