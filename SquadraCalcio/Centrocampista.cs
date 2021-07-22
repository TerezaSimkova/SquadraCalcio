using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquadraCalcio
{
    class Centrocampista : Attacante
    {
        public int NumAssist { get; set; }
        public Centrocampista(string firstName, string lastName, int age, enumRuolo role, int numMaglia, int goalFatti, int numAssist)
            : base(firstName, lastName, age, role, numMaglia, goalFatti)
        {
            NumAssist = numAssist;

        }
        public Centrocampista()
        {

        }
    }
}
