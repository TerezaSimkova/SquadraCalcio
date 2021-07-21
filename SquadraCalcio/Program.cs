using System;

namespace SquadraCalcio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Benvenuto***");
            Console.WriteLine("*Scegli la tua squadra*");
            //stampa tutti i giocattori

            int scelta = int.Parse(Console.ReadLine());
            Organizzatore.ChooseTeam1();





            //Portiere p1 = new Portiere("Aless", "Giallo", 22, enumRuolo.portiere, 5, 1);

            //Difensore d1 = new Difensore("Mike", "Gold", 24, enumRuolo.difensore, 6, 2, 1, 4);
            //Difensore d2 = new Difensore("John", "Harm", 22, enumRuolo.difensore, 2, 3, 1, 1);
            //Difensore d3 = new Difensore("Rian", "Old", 21, enumRuolo.difensore, 1, 1, 1, 2);
            //Difensore d4 = new Difensore("Liam", "Blake", 20, enumRuolo.difensore, 2, 0, 1, 3);

            //Centrocampista c1 = new Centrocampista("Mark", "Red", 25, enumRuolo.centrocampista, 3, 1, 4);
            //Centrocampista c2 = new Centrocampista("Lil", "Black", 20, enumRuolo.centrocampista, 3, 1, 4);
            //Centrocampista c3 = new Centrocampista("Tommy", "White", 21, enumRuolo.centrocampista, 3, 1, 4);

            //Attacante a1 = new Attacante("Alex", "Dark", 23, enumRuolo.attacante, 2, 3);
            //Attacante a2 = new Attacante("Alex", "Arow", 22, enumRuolo.attacante, 2, 3);
            //Attacante a3 = new Attacante("Alex", "White", 20, enumRuolo.attacante, 2, 3);

            //Arbitro arb1 = new Arbitro("Gianni", "Rosso", 35, 15);

        }
    }
}
