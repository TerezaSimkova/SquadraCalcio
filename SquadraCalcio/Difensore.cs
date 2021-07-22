using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadraCalcio
{
    class Difensore : Centrocampista
    {
        public int  NumRecuperiPalla { get; set; }
        public Difensore(string firstName, string lastName, int age, enumRuolo role, int numMaglia, int goalFatti, int numAssist, int numRecuperiPalla)
            : base(firstName, lastName, age, role, numMaglia, goalFatti, numAssist)
        {

            NumRecuperiPalla = numRecuperiPalla;
        }
        public Difensore()
        {

        }
    }
}
