using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadraCalcio
{
    class Attacante : Calciatori
    {
        public int GoalFatti { get; set; }
        public Attacante(string firstName, string lastName, int age, enumRuolo role, int numMaglia, int goallFatti)
            : base(firstName, lastName, age, role, numMaglia)
        {
            GoalFatti = goallFatti;

        }
        public Attacante()
        {

        }
    }
}
