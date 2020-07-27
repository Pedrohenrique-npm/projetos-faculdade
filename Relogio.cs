using System;

namespace Relogio
{
    public class Relogio
    {
        int hora = 0, minuto = 0, segundo = 0;
        int dia = 1, mes = 1;
        public void ajusteHora(int h, int m, int s)
        {
            this.hora = h;
            this.minuto = m;
            this.segundo = s;

        }
        public void ajusteData(int d, int m)
        {
            while (d > 30)
            {
                d -= 30;
                m++;
            }
            while (m > 12)
            {
                m -= 12;
            }

            this.dia = d;
            this.mes = (m > 12 ? m -= 12 : m);
            System.Console.WriteLine("dia: {0}, mes {1} ", this.dia, this.mes);
        }
        public void reiniciar(int h, int m, int s)
        {

        }
        public void passarTempo(int h, int m, int s)
        {

        }
    }
}
