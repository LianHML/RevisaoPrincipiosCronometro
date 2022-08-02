using System;
using System.Threading;

namespace RevisaoPrincipiosCronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Cronômetro");
            Console.WriteLine("");
            Console.WriteLine("Devo contar em?: ");
            Console.WriteLine("");
            Console.WriteLine("1 - Segundos");
            Console.WriteLine("2 - Minutos");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("");
            int tipoTempo = int.Parse(Console.ReadLine());
            if (tipoTempo == 3)
                Sair();
            else
            {
                Console.Clear();
                Console.WriteLine("Cronômetro");
                Console.WriteLine("");
                Console.WriteLine("Quanto devo contar?: ");
                Console.WriteLine("");
            }
            int tempoMaximo = int.Parse(Console.ReadLine());

            switch (tipoTempo)
            {
                case 1: Iniciar(tempoMaximo); break;
                case 2: Iniciar(tempoMaximo * 60); break;
                default: Menu(); break;
            }
        }

        static void Iniciar(int tempoSelecionado)
        {
            int tempoAtual = 0;

            while (tempoAtual != tempoSelecionado)
            {
                Console.Clear();
                Console.WriteLine("Cronômetro");
                Console.WriteLine("");
                tempoAtual++;
                Console.WriteLine($"Contagem: {tempoAtual}");
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Contagem Finalizada!");

            Thread.Sleep(2000);
            Menu();
        }
        static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Obrigado! Até a próxima.");
            Thread.Sleep(2500);
            Environment.Exit(1);
        }

    }
}
