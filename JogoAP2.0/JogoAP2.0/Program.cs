using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoAP2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int oculto = random.Next(1, 100);

            double palpite;
            double v1 = 1, v2 = 100;
            double nj;
            Console.WriteLine("numero de jogadores: ");
            nj = Convert.ToDouble(Console.ReadLine());

            if (nj < 2 || nj > 5)
            {
                do
                {
                    Console.WriteLine("numero de jogadores: ");
                    nj = Convert.ToDouble(Console.ReadLine());
                }
                while (nj < 2 || nj > 5);
            }

            double i = 0;

            if (i < nj)
                do
                {
                    i++;
                    Console.Write("{0} digite um numero entre {1} e {2}: ", i, v1, v2);
                    palpite = Convert.ToDouble(Console.ReadLine());
                    if (palpite <= v1 || palpite >= v2)
                    {
                        do
                        {
                            Console.Write("{0} digite um numero entre {1} e {2}: ", i, v1, v2);
                            palpite = Convert.ToDouble(Console.ReadLine());
                        } while (palpite <= v1 || palpite >= v2);

                    }
                    if (palpite < oculto)
                    {
                        v1 = palpite;
                    }
                    else
                    {
                        v2 = palpite;
                    }
                    if (palpite == oculto)
                    {
                        Console.WriteLine("Parabens, voce perdeu");
                    }
                    if (i == nj)
                    {
                        i = 0;
                    }
                } while (palpite != oculto);
        }
    }
}
