using System;

namespace SquadraCalcio
{
    internal class Menu
    {
        internal static void Start()
        {
            Console.WriteLine("***Benvenuto***");
            

            bool calcio = true;

            while (calcio)
            {
                Console.WriteLine("*Scegli la tua squadra*");
                char scelta = char.Parse(Console.ReadLine());

                switch (scelta)
                {
                    case '1':
                        Organizzatore.FetchTeam();

                        break;
                    case '2':
                        Organizzatore.FetchTeam2();

                        break;
                    default:
                        Console.Write("Scelta non valida");
                        break;
                }
                Console.WriteLine("\nOra Scegli chi vuoi che gioca nella tua squadra:");
                bool scelta1 = true;
                while (scelta1)
                {

                    for (int i = 0; i < 7; i++)
                    {
                        int choice = GetByKey();
                        Organizzatore.ShowCalciatore(choice);
                    }
                    scelta1 = false;


                }

                Organizzatore.FetchTeam2();
                Console.WriteLine("\nOra Scegli chi vuoi che gioca nella seconda squadra:");
                bool scelta2 = true;
                while (scelta2)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        int choice2 = GetByKey2();
                        Organizzatore.ShowCalciatore2(choice2);
                    }
                    scelta2 = false;

                }
                Console.WriteLine("\nL'arbitro della partita é:");
                Console.WriteLine("\n Michael Neri, 31 anni con 8 anni di esperienza.\n");
                Console.WriteLine("\n La partita puó iniziare.\n");

                calcio = false;
            }

        }
        private static int GetByKey2()
        {
            int key;
            do
            {
                Console.Write("Inserisci il numero del calciatore: ");
            }
            while (!(int.TryParse(Console.ReadLine(), out key)) || !(Organizzatore.IsInList2(key)));
            return key;
        }

        private static int GetByKey()
        {
            int key=0;
           
                do
                {
                    Console.Write("Inserisci il numero del calciatore: ");

                }
                while (!(int.TryParse(Console.ReadLine(), out key)) || !(Organizzatore.IsInList(key) || key < 0 || key > 7));
                 return key;
        }
    }
}