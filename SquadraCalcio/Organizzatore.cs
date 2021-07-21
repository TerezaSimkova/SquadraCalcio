using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadraCalcio
{
    class Organizzatore
    {

        internal static void ChooseTeam1()
        {
            Dictionary<int, Calciatori> SqItalia = new Dictionary<int, Calciatori>()
            {
                { 0, new Portiere{ FirstName = "Alex", LastName = "Giallo", Age = 22, Role = enumRuolo.portiere, NumMaglia = 1, GoalSubiti = 0} },

                { 1, new Difensore{ FirstName = "Mike", LastName = "Harold", Age = 22, Role = enumRuolo.portiere, NumMaglia = 22, GoalFatti =0, NumAssist =0, NumRecuperiPalla =0} },
                { 2, new Difensore{ FirstName = "John", LastName = "Old", Age = 23, Role = enumRuolo.portiere, NumMaglia = 23, GoalFatti =0, NumAssist =0, NumRecuperiPalla =0} },
                { 2, new Difensore{ FirstName = "Rian", LastName = "Blake", Age = 20, Role = enumRuolo.portiere, NumMaglia = 24, GoalFatti =0, NumAssist =0, NumRecuperiPalla =0} },
                { 4, new Difensore{ FirstName = "Liam", LastName = "Gold", Age = 21, Role = enumRuolo.portiere, NumMaglia = 25, GoalFatti =0, NumAssist =0, NumRecuperiPalla =0} },

            };

         

        }


        //crea team ,sceglie tra una lista generica List di giocattori ,sceglie al base di numero / lettera
        //crea un altro team
        //aggiunge un arbitro
        //non si possono inserirre giocattori due volte 
    }
}
