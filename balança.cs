using System;

namespace Balança
{
    class Program
    {
        public static void calculaPeso(float alt, string sexo)
        {
            float pesoOtimo = 0;
            if (sexo == "feminino" || sexo == "f")
            {
                pesoOtimo = (float)(62.1f * alt) - 44.7f;
            }
            else if (sexo == "masculino" || sexo == "m")
            {

                pesoOtimo = (float)(72.7f * alt) - 58f;
            }
            Console.WriteLine("O peso ótimo é {0}", pesoOtimo);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a altura?\nUse ponto (.) ao invés de vírgula (,)");
            float altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual o sexo?\n'masculino' ou 'm', 'feminino' ou 'f'");
            string sexo = "";

            try
            {
                sexo = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(sexo) || sexo != "feminino" || sexo != "masculino" || sexo != "m" || sexo != "f")
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                System.Console.WriteLine("Digite novamente");
            }
            calculaPeso(altura, sexo);
            Console.ReadKey();
        }
    }
}
