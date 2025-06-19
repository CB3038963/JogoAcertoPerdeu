using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo4._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nj;
            Console.WriteLine("Numero de jogadores (2 a 5): ");
            nj = Convert.ToDouble(Console.ReadLine());

            if (nj < 2 || nj > 5)
            {
                do
                {
                    Console.WriteLine("Numero de jogadores (2 a 5): ");
                    nj = Convert.ToDouble(Console.ReadLine());
                }
                while (nj < 2 || nj > 5);
            }


            string[] nome = new string[5];

            for (int i = 0; i < nj; i++)
            {
                Console.WriteLine("Nome do jogador {0}: ",i+1);
                nome[i] = Console.ReadLine();
            }

            double v1 = 1;
            double v2 = 100;
            double palpite;
            Random r = new Random();
            int oculto = r.Next(2, 100);

            Console.WriteLine("{0}  ", oculto);


            int t = 0;

            if (t < nj)
            {
                do
                {
                    Console.Write("{0}, Digite um valor entre {1} e {2}: ", nome[t], v1, v2);
                    palpite = Double.Parse(Console.ReadLine());

                    if (palpite <= v1 || palpite >= v2)
                    {
                        do
                        {
                            Console.Write("{0}, Digite um valor entre {1} e {2}: ", nome[t], v1, v2);
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
                        Console.WriteLine("Parabéns {0}, você PERDEU!!!", nome[t]);
                    }
                    t++;
                    if(t==nj)
                    {
                        t = 0;
                    }

                } while (palpite != oculto);

            }
            
        }
    }
}
