using System;

namespace Relogio
{
    class Program
    {
        static void Main(string[] args)
        {
            Relogio r = new Relogio();
            r.ajusteData(19, 11);
            r.ajusteData(31, 13);
            r.ajusteData(90, 24);
            r.ajusteData(30, 11);
            r.ajusteData(30, 11);
        }
    }
}
