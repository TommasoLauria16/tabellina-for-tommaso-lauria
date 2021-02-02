using System;

namespace tabellina_for_tommaso_lauria
{
    class Program
    {
        public static void Main(string[] args)
        {
            int A;

            Console.WriteLine("Tabellina");
            Console.WriteLine("inserisci un numero a tua scelta");
            A = int.Parse(Console.ReadLine());
        }



        static void tabellina(int M)
        {
            int l, prodotto = M;
            for (l = 1; l <= M; l++);
            {
                prodotto = l;
                 
                Console.Write("prodotto");

            }

        }
    }
}
