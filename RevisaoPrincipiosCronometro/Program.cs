using System;
using System.Threading;

namespace RevisaoPrincipiosCronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos segundos devo contar?: ");
            int tempoMaximo = int.Parse(Console.ReadLine());
            Iniciar(tempoMaximo);
        }
        static void Iniciar(int tempoSelecionado)
        {
            int tempoAtual = 0;

            while (tempoAtual != tempoSelecionado)
            {
                Console.Clear();
                tempoAtual++;
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);
            }
        }
    }
}
