using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadraCalcio
{
    class Portiere : Calciatori
    {
        public int GoalSubiti { get; set; }


        public Portiere(string firstName, string lastName, int age, enumRuolo role, int numMaglia, int goalSubiti)
            : base(firstName, lastName, age, role, numMaglia)
        {
            GoalSubiti = goalSubiti;
            numMaglia = 1;

        }
        public Portiere()
        {

        }
    }
}
