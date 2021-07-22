using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadraCalcio
{
    class Organizzatore
    {


        private static Dictionary<int, Calciatori> CalciatoriItalia = TuttiCalciatoriIT();

        private static Dictionary<int, Calciatori> TuttiCalciatoriIT()
        {
            Dictionary<int, Calciatori> SqItalia = new Dictionary<int, Calciatori>()
            {
                { 0, new Portiere{ FirstName = "Alex", LastName = "Giallo", Age = 22, Role = enumRuolo.portiere, NumMaglia = 1, GoalSubiti = 0} },

                { 1, new Difensore{ FirstName = "Mike", LastName = "Harold", Age = 22, Role = enumRuolo.portiere, NumMaglia = 22, GoalFatti =0, NumAssist =0, NumRecuperiPalla =0} },
                { 2, new Difensore{ FirstName = "John", LastName = "Old", Age = 23, Role = enumRuolo.portiere, NumMaglia = 23, GoalFatti =0, NumAssist =0, NumRecuperiPalla =0} },
                { 3, new Difensore{ FirstName = "Rian", LastName = "Blake", Age = 20, Role = enumRuolo.portiere, NumMaglia = 24, GoalFatti =0, NumAssist =0, NumRecuperiPalla =0} },
                { 4, new Difensore{ FirstName = "Liam", LastName = "Gold", Age = 21, Role = enumRuolo.portiere, NumMaglia = 25, GoalFatti =0, NumAssist =0, NumRecuperiPalla =0} },

                { 5, new Centrocampista {FirstName = "Tommy", LastName= "Code", Age = 25, Role = enumRuolo.centrocampista, NumMaglia = 31, GoalFatti= 0,NumAssist= 0 } },
                { 6, new Centrocampista {FirstName = "Gianni", LastName= "Blur", Age = 26, Role = enumRuolo.centrocampista, NumMaglia = 32, GoalFatti= 0,NumAssist= 0 } },
                { 7, new Centrocampista {FirstName = "Oleg", LastName= "Stone", Age = 24, Role = enumRuolo.centrocampista, NumMaglia = 33, GoalFatti= 0,NumAssist= 0 } },

                { 8, new Attacante {FirstName = "Mark", LastName= "Host", Age = 21, Role = enumRuolo.centrocampista, NumMaglia = 41, GoalFatti= 0} },
                { 9, new Attacante {FirstName = "Harold", LastName= "Main", Age = 20, Role = enumRuolo.centrocampista, NumMaglia = 42, GoalFatti= 0} },
                { 10, new Attacante {FirstName = "Omar", LastName= "Cold", Age = 19, Role = enumRuolo.centrocampista, NumMaglia = 43, GoalFatti= 0} },

               // { 11, new Arbitro {FirstName = "Michael", LastName = "Strike", Age = 31, NumAnniCarriera = 15} }
            };
            return SqItalia;


        }

  
        internal static void ShowCalciatore2(int key)
        {
            var SceltaCalciatore = CalciatoriEngland[key];
            Console.WriteLine($"{SceltaCalciatore.FirstName} {SceltaCalciatore.LastName}");
        }

        internal static bool IsInList2(int key)
        {
            return CalciatoriEngland.ContainsKey(key);
        }

        internal static void ShowCalciatore(int key)
        {

                var SceltaCalciatore = CalciatoriItalia[key];
                Console.WriteLine($"{SceltaCalciatore.FirstName} {SceltaCalciatore.LastName}");
            
        }

        internal static bool IsInList(int key)
        {
            return CalciatoriItalia.ContainsKey(key);
        }


        private static Dictionary<int, Calciatori> CalciatoriEngland = TuttiCalciatoriEN();

        private static Dictionary<int, Calciatori> TuttiCalciatoriEN()
        {
            Dictionary<int, Calciatori> SqEngland = new Dictionary<int, Calciatori>()
            {
                { 0, new Portiere{ FirstName = "Thomas", LastName = "White", Age = 22, Role = enumRuolo.portiere, NumMaglia = 1, GoalSubiti = 0} },

                { 1, new Difensore{ FirstName = "Mick", LastName = "Hardy", Age = 22, Role = enumRuolo.portiere, NumMaglia = 22, GoalFatti =0, NumAssist =0, NumRecuperiPalla =0} },
                { 2, new Difensore{ FirstName = "John", LastName = "Sea", Age = 23, Role = enumRuolo.portiere, NumMaglia = 23, GoalFatti =0, NumAssist =0, NumRecuperiPalla =0} },
                { 3, new Difensore{ FirstName = "Richard", LastName = "Bloom", Age = 20, Role = enumRuolo.portiere, NumMaglia = 24, GoalFatti =0, NumAssist =0, NumRecuperiPalla =0} },
                { 4, new Difensore{ FirstName = "Liam", LastName = "Gordon", Age = 21, Role = enumRuolo.portiere, NumMaglia = 25, GoalFatti =0, NumAssist =0, NumRecuperiPalla =0} },

                { 5, new Centrocampista {FirstName = "Tom", LastName= "Class", Age = 25, Role = enumRuolo.centrocampista, NumMaglia = 31, GoalFatti= 0,NumAssist= 0 } },
                { 6, new Centrocampista {FirstName = "Johs", LastName= "Beam", Age = 26, Role = enumRuolo.centrocampista, NumMaglia = 32, GoalFatti= 0,NumAssist= 0 } },
                { 7, new Centrocampista {FirstName = "Oliver", LastName= "Steam", Age = 24, Role = enumRuolo.centrocampista, NumMaglia = 33, GoalFatti= 0,NumAssist= 0 } },

                { 8, new Attacante {FirstName = "Mark", LastName= "Bright", Age = 21, Role = enumRuolo.centrocampista, NumMaglia = 41, GoalFatti= 0} },
                { 9, new Attacante {FirstName = "Harold", LastName= "Match", Age = 20, Role = enumRuolo.centrocampista, NumMaglia = 42, GoalFatti= 0} },
                { 10, new Attacante {FirstName = "Kevin", LastName= "Moon", Age = 19, Role = enumRuolo.centrocampista, NumMaglia = 43, GoalFatti= 0} },


            };
            return SqEngland;



        }


        Dictionary<int, Arbitro> ArbitroO = new Dictionary<int, Arbitro>()
            {
                { 11, new Arbitro {FirstName = "Michael", LastName = "Strike", Age = 31, NumAnniCarriera = 15} }
            };


        Dictionary<int, Arbitro> SqEnglandArbitro = new Dictionary<int, Arbitro>()
        {
            { 11, new Arbitro {FirstName = "Giordan", LastName = "Lake", Age = 41, NumAnniCarriera = 22} }
        };

        internal static void FetchTeam2()
        {
            Console.WriteLine("Lista calciatori Team 2: ");
            foreach (var item in CalciatoriEngland)
            {
               
                Console.WriteLine($"{item.Key} - {item.Value.FirstName} - {item.Value.LastName} - {item.Value.Age} Anni - {item.Value.Role} - Numero maglia {item.Value.NumMaglia} .");

            }

        }

        internal static void FetchTeam()
        {
            Console.WriteLine("Lista calciatori Team 1: ");
            foreach (var item in CalciatoriItalia)
            {
                Console.WriteLine($"{item.Key} - {item.Value.FirstName} - {item.Value.LastName} - {item.Value.Age} Anni - {item.Value.Role} - Numero maglia {item.Value.NumMaglia} .");
            }
        }
    }


    //crea team ,sceglie tra una lista generica List di giocattori ,sceglie al base di numero / lettera
    //crea un altro team
    //aggiunge un arbitro
    //non si possono inserirre giocattori due volte 
}

